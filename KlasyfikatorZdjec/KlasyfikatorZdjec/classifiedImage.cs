using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KlasyfikatorZdjec
{
     public class ClassifiedImage
     {
          [XmlAttribute("natura")]
          public Boolean isNature;
          [XmlAttribute("ścieżka")]
          public String path;
          [XmlAttribute("twarze")]
          public int faces;
          [XmlAttribute("niebieski")]
          public float blueVal;

          [XmlAttribute("rozdzielczosc")]
          public string resolution;
          [XmlAttribute("rozmiar")]
          public string size;
          [XmlAttribute("format")]
          public string format;
          [XmlAttribute("urzadzenie")]
          public string cameraModel;
          [XmlAttribute("dataWykonania")]
          public string dateTaken;
          [XmlAttribute("ISO")]
          public string iso;
          [XmlAttribute("szerokoscGeo")]
          public string latitude;
          [XmlAttribute("dlugoscGeo")]
          public string longitude;
          [XmlAttribute("poziomMorza")]
          public double altitude;

          [XmlAttribute("portret")]
          public bool isPortrait;
          [XmlAttribute("grupa")]
          public bool isGroup;

          //Konstruktor bez argumentów wymagany do serializacji
          public ClassifiedImage()
          {
               new ClassifiedImage(false, "", 0, 0f);
          }

          public ClassifiedImage(Boolean isNature, String path, int faces, float blueVal)
          {
               this.isNature = isNature;
               this.path = path;
               this.faces = faces;
               this.blueVal = blueVal;
          }

          public object getProp(int i)
          {
              switch (i)
              {
                  case 0:
                      return isNature;
                  case 1:
                      return path;
                  case 2:
                      return faces;
                  case 3:
                      return blueVal;
                  default:
                      return null;
              }
          }
     }
}
