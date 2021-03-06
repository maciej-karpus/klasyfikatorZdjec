﻿using System;
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
                    var resolutionSetting = Settings.findSettingByKey(SettingKey.MEDIUM_IMG_KEY);
                    var resolution = (unCImg.resolutionX * unCImg.resolutionY) / 1000000; 
                    var lowerBound = resolutionSetting.getLowerBound();
                    var upperBound = resolutionSetting.getUpperBound();
                    cImg.resolution = resolution < lowerBound  ? "małe" : resolution >= lowerBound && resolution <= upperBound ? "średnie" : "duże";

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
                    var altitudeSetting = Settings.findSettingByKey(SettingKey.ALTITUDE_KEY);
                    var highGroundBound = altitudeSetting.getLowerBound();
                    cImg.isAboveSeaLevel = unCImg.altitude > highGroundBound ? "wyżyny" : "niziny";
                }
            }

        }

        // TODO
        public static void classifyByFaces()
        {
            foreach (UnclassifiedImage unCImg in UNCLASSIFIED_PHOTOS)
            {
                ClassifiedImage cImg = PHOTOS_CLASSIFIED.Find(s => s.path == unCImg.path);
                if (cImg != null)
                {
                    cImg.isPortrait = unCImg.faceOccupancy >= Settings.findSettingByKey(SettingKey.PORTRAIT_KEY).lowerBound/100 ? true : false;
                    cImg.isGroupOfPeople = unCImg.faces >= Settings.findSettingByKey(SettingKey.GROUP_OF_PEOPLE_KEY).lowerBound ? true : false;
                }
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

                    long startBlue = (long) (255 * Settings.findSettingByKey(SettingKey.DOMINATING_BLUE_KEY).lowerBound);
                    long startGreen = (long)(255 * Settings.findSettingByKey(SettingKey.DOMINATING_GREEN_KEY).lowerBound);
                    long startRed = (long)(255 * Settings.findSettingByKey(SettingKey.DOMINATING_RED_KEY).lowerBound);

                    for (; startBlue < hist.histogramBlue.Length; startBlue++)
                        tmpBlue += hist.histogramBlue[startBlue];

                    for (; startGreen < hist.histogramGreen.Length; startGreen++)
                        tmpGreen += hist.histogramGreen[startGreen];

                    for (; startRed < hist.histogramRed.Length; startRed++)
                        tmpRed += hist.histogramRed[startRed];

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
