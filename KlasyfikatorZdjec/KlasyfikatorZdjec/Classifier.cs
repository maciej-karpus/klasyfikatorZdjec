using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyfikatorZdjec
{
    static class Classifier
    {
        public static List<MetadataEXIF> PHOTOS_METADATA = new List<MetadataEXIF>();
        public static List<ClassifiedImage> PHOTOS_CLASSIFIED = new List<ClassifiedImage>();
        public static List<UnclassifiedImage> UNCLASSIFIED_PHOTOS = new List<UnclassifiedImage>();
        
        // TODO: majac liste UNCLASSIFIED_PHOTOS (nie musi byc statyczna, moze byc podawana jako parametr
        // albo ew. umiescimy ja jako statyczna np. w Program.cs) uzupelniamy liste PHOTOS_CLASSIFIED
        // a wiec proces usupelniania listy UNCLASSIFIED_PHOTOS musimy wyrzucic gdzie indziej, np. do metody loadImages()
        // tutaj niech bedzie tylko sama klasyfikacja

        public static void classifyByMetadata()
        {
            foreach (UnclassifiedImage unCImg in UNCLASSIFIED_PHOTOS)
            {

                ClassifiedImage cImg = PHOTOS_CLASSIFIED.Find(s => s.path == unCImg.path);
                if (cImg != null) 
                {
                    //Rozdzielczosc
                    cImg.resolution = unCImg.resolutionX < 1024 && unCImg.resolutionY < 768 ? "małe" : unCImg.resolutionX < 2000 && unCImg.resolutionY < 1000 ? "średnie" : "duże";

                    //Rozmiar w MB
                    double s = (double) unCImg.size / (1024*1024);
                    cImg.size = s <= 0.5 ? "< 0.5" : s <= 1 ? "0.5 - 1" : s <= 2 ? "1 - 2" : s <= 5 ? "2 - 5" : "> 5";

                    //Marka i model
                    cImg.cameraModel = unCImg.cameraModel;

                    //Data wykonania
                    cImg.dateTaken = unCImg.dateTaken;

                    //Format
                    cImg.format = unCImg.format;
                    

                    //ISO
                    cImg.iso = unCImg.iso <= 200 ? "100 - 200" : unCImg.iso <= 800 ? "200 - 800" : "> 800";

                    //Czy w Polsce
                    double latD = unCImg.latitudeDegrees, latM = unCImg.latitudeMinutes, lonD = unCImg.longitudeDegrees, lonM = unCImg.longitudeMinutes;
                    if (unCImg.latitudeRef == "N" && unCImg.longitudeRef == "E" &&
                        (latD >= 49 ) &&
                        (lonD > 14 || (lonD == 14 && lonM >= 7)) &&
                        (latD < 54 || (latD == 54 && latM <= 50)) &&
                        (lonD < 24 || (lonD == 24 && lonM <= 9))
                    )
                        cImg.isInPoland = true;
                    else
                        cImg.isInPoland = false;

                    //Wysokosc n.p.m.
                    cImg.isAboveSeaLevel = unCImg.altitude > 0 ? "wyżyny" : "niziny";
                }
            }

        }

        // TODO
        public static void classifyByFaces()
        {
            bool isPortrait = false;
            foreach (ClassifiedImage cImg in PHOTOS_CLASSIFIED)
            {
                int faces = DetectFace.Run(cImg.path, ref isPortrait);
                cImg.isPortrait = faces == 1 ? true : false;
                cImg.isGroupOfPeople = faces > 1 ? true : false;
            }
        }

        public static void classifyByColors()
        {
            foreach (UnclassifiedImage unCImg in UNCLASSIFIED_PHOTOS)
            {
                ClassifiedImage cImg = PHOTOS_CLASSIFIED.Find(s => s.path == unCImg.path);
                if (cImg != null)
                {
                    Histograms hist = new Histograms(unCImg.path);
                    hist.setHistograms();
                    long tmpBlue = 0;
                    long tmpGreen = 0;
                    long tmpRed = 0;

                    for (int i = 175; i < hist.histogramBlue.Length; i++)
                    {
                        tmpBlue += hist.histogramBlue[i];
                        tmpGreen += hist.histogramGreen[i];
                        tmpRed += hist.histogramRed[i];
                    }

                    unCImg.blueVal = (double)tmpBlue / (double)hist.pixels;
                    unCImg.redVal = (double)tmpRed / (double)hist.pixels;
                    unCImg.greenVal = (double)tmpGreen / (double)hist.pixels;

                    if (unCImg.blueVal > unCImg.redVal && unCImg.blueVal > unCImg.greenVal)
                        cImg.mainColor = "Blue";
                    else if (unCImg.redVal > unCImg.blueVal && unCImg.redVal > unCImg.greenVal)
                        cImg.mainColor = "Red";
                    else if (unCImg.greenVal > unCImg.redVal && unCImg.greenVal > unCImg.blueVal)
                        cImg.mainColor = "Green";
                    else
                        cImg.mainColor = "N/D";
                }
            }
        }
    }
}
