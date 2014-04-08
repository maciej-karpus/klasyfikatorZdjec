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

        [XmlAttribute("rozmiar")]
        public int size;
        [XmlAttribute("format")]
        public string format;
        [XmlAttribute("urzadzenie")]
        public string cameraModel;
        [XmlAttribute("dataWykonania")]
        public string dateTaken;
        [XmlAttribute("ISO")]
        public int iso;

        [XmlAttribute("szerokoscGeoRef")]
        public string latitudeRef;
        [XmlAttribute("szerokoscGeoStopnie")]
        public double latitudeDegrees;
        [XmlAttribute("szerokoscGeoMinuty")]
        public double latitudeMinutes;
        [XmlAttribute("szerokoscGeoSekundy")]
        public double latitudeSeconds;
        [XmlAttribute("dlugoscGeoRef")]
        public string longitudeRef;
        [XmlAttribute("dlugoscGeoStopnie")]
        public double longitudeDegrees;
        [XmlAttribute("dlugoscGeoMinutes")]
        public double longitudeMinutes;
        [XmlAttribute("dlugoscGeoSeconds")]
        public double longitudeSeconds;
        [XmlAttribute("wysokoscNadPozMorza")]
        public double altitude;

        public UnclassifiedImage(string path, int faces, double redVal, double greenVal, double blueVal,
            int resolutionX, int resolutionY, string format, string cameraModel, string dateTaken, int iso,
            string latitudeRef, double latitudeDegrees, double latitudeMinutes, double latitudeSeconds,
            string longitudeRef, double longitudeDegrees, double longitudeMinutes, double longitudeSeconds,
            double altitude)
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
            this.latitudeRef = latitudeRef;
            this.latitudeDegrees = latitudeDegrees;
            this.latitudeMinutes = latitudeMinutes;
            this.latitudeSeconds = latitudeSeconds;

            this.longitudeRef = longitudeRef; 
            this.longitudeDegrees = longitudeDegrees;
            this.longitudeMinutes = longitudeMinutes;
            this.longitudeSeconds = longitudeSeconds;


            this.altitude = altitude;
        }

        public UnclassifiedImage()
        {
            new UnclassifiedImage("", 0, 0.0, 0.0, 0.0, 0, 0, "", "", "", 0, "",  0.0, 0.0, 0.0, "", 0.0, 0.0, 0.0, 0.0);
        }
    }
}
