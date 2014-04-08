using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KlasyfikatorZdjec
{
    // przechowuje atrybuty, na podstawie ktorych przeprowadzona zostanie klasyfikacja
    public class UnclassifiedImage
    {
        [XmlAttribute("ścieżka")]
        public String path;
        [XmlAttribute("twarze")]
        public int faces;

        [XmlAttribute("czerwony")]
        public double redVal;
        [XmlAttribute("niebieski")]
        public double blueVal;
        [XmlAttribute("zielony")]
        public double greenVal;

        [XmlAttribute("rozdzielczoscX")]
        public int resolutionX;
        [XmlAttribute("rozdzielczoscY")]
        public int resolutionY;
        
        [XmlAttribute("format")]
        public string format;
        [XmlAttribute("urzadzenie")]
        public string cameraModel;
        [XmlAttribute("dataWykonania")]
        public string dateTaken;
        [XmlAttribute("ISO")]
        public int iso;
        
        [XmlAttribute("szerokoscGeo")]
        public double latitude;
        [XmlAttribute("dlugoscGeo")]
        public double longitude;
        [XmlAttribute("wysokoscNadPozMorza")]
        public double altitude;

        public UnclassifiedImage(string path, int faces, double redVal, double greenVal, double blueVal,
            int resolutionX, int resolutionY, string format, string cameraModel, string dateTaken, int iso,
            double latitude, double longitude, double altitude)
        {
            this.path = path;
            this.faces = faces;
            this.redVal = redVal;
            this.greenVal = greenVal;
            this.blueVal = blueVal;
            this.resolutionX = resolutionX;
            this.resolutionY = resolutionY;
            this.format = format;
            this.cameraModel = cameraModel;
            this.dateTaken = dateTaken;
            this.iso = iso;
            this.latitude = latitude;
            this.longitude = longitude;
            this.altitude = altitude;
        }

        public UnclassifiedImage()
        {
            new UnclassifiedImage("", 0, 0.0, 0.0, 0.0, 0, 0, "", "", "", 0, 0.0, 0.0, 0.0);
        }
    }
}
