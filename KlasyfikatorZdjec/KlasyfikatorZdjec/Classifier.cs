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

        public static void classifyByMetadata()
        {
            foreach (MetadataEXIF photo in PHOTOS_METADATA)
            {
                ClassifiedImage cImg = PHOTOS_CLASSIFIED.Find(s => s.path == photo.GetPath());
                if (cImg != null) 
                {
                    //Rozdzielczosc
                    cImg.resolution = photo.GetHeight() + "*" + photo.GetWidth();

                    //Rozmiar w MB
                    double s = (double) photo.GetImageSize() / (1024*1024);
                    cImg.size = s <= 0.5 ? "< 0.5" : s <= 1 ? "0.5 - 1" : s <= 2 ? "1 - 2" : s <= 5 ? "2 - 5" : "> 5";

                    //Marka i model
                    cImg.cameraModel = photo.GetModel();

                    //Data wykonania
                    cImg.dateTaken = photo.GetDateTimeTaken();

                    //Format
                    ImageFormat imgForm = photo.GetImageFormat();
                    cImg.format = ImageFormat.Bmp.Equals(imgForm) ? "BMP" :
                        ImageFormat.Gif.Equals(imgForm)  ? "GIF" :
                        ImageFormat.Jpeg.Equals(imgForm) ? "JPEG" :
                        ImageFormat.Png.Equals(imgForm)  ? "PNG" :
                        imgForm.ToString();

                    //ISO
                    cImg.iso = photo.GetISOSpeed() <= 200 ? "100 - 200" : photo.GetISOSpeed() <= 800 ? "200 - 800" : "> 800";

                    //Czy w Polsce
                    double latD = photo.GetLatitudeDegrees(), latM = photo.GetLatitudeMinutes(), lonD = photo.GetLongitudeDegrees(), lonM = photo.GetLongitudeMinutes();
                    if (photo.GetLatitudeRef() == "N" && photo.GetLongitudeRef() == "E" &&
                        (latD >= 49 ) &&
                        (lonD > 14 || (lonD == 14 && lonM >= 7)) &&
                        (latD < 54 || (latD == 54 && latM <= 50)) &&
                        (lonD < 24 || (lonD == 24 && lonM <= 9))
                    )
                        cImg.isInPoland = true;
                    else
                        cImg.isInPoland = false;

                    //Wysokosc n.p.m.
                    cImg.isBelowSeaLevel = photo.IsBelowSeaLevel();

                }
            }

        }

        public static void classifyByFaces()
        {
            bool isPortrait = false;
            foreach (ClassifiedImage cImg in PHOTOS_CLASSIFIED)
            {
                cImg.faces = DetectFace.Run(cImg.path, ref isPortrait);
                cImg.isPortrait = isPortrait;
                cImg.isGroup = cImg.faces > 1 ? true : false;
            }
        }
    }
}
