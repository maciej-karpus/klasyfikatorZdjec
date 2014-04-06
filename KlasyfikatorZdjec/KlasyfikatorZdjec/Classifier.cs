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
                    cImg.format = photo.GetImageFormat() == ImageFormat.Bmp ? "BMP" :
                        photo.GetImageFormat() == ImageFormat.Gif  ? "GIF" :
                        photo.GetImageFormat() == ImageFormat.Jpeg ? "JPEG" :
                        photo.GetImageFormat() == ImageFormat.Png  ? "PNG" :
                        photo.GetImageFormat().ToString();

                    //ISO
                    cImg.iso = photo.GetISOSpeed() <= 200 ? "100 - 200" : photo.GetISOSpeed() <= 800 ? "200 - 800" : "> 800";

                    //Szerokosc geo
                    cImg.latitude = photo.GetLatitudeRef() + ": " + photo.GetLatitudeDegrees() + "° " + photo.GetLatitudeMinutes() + "' " + photo.GetLatitudeSeconds() + "\"";
                    
                    //Dlugosc geo
                    cImg.longitude = photo.GetLongitudeRef() + ": " + photo.GetLongitudeDegrees() + "° " + photo.GetLongitudeMinutes() + "' " + photo.GetLongitudeSeconds() + "\"";
                    
                    //Wysokosc n.p.m.
                    double seaLevel = photo.GetAltitude();
                    if(photo.IsBelowSeaLevel() == true)
                        seaLevel *= -1;
                    cImg.altitude = seaLevel;
                }
            }

        }

    }
}
