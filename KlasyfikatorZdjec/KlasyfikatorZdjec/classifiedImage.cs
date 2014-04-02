using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KlasyfikatorZdjec
{
     public class classifiedImage
     {
          [XmlAttribute("natura")]
          public Boolean isNature;
          [XmlAttribute("ścieżka")]
          public String path;
          [XmlAttribute("twarze")]
          public int faces;
          [XmlAttribute("niebieski")]
          public float blueVal;

          //Konstruktor bez argumentów wymagany do serializacji
          public classifiedImage()
          {
               new classifiedImage(false, "", 0, 0f);
          }

          public classifiedImage(Boolean isNature, String path, int faces, float blueVal)
          {
               this.isNature = isNature;
               this.path = path;
               this.faces = faces;
               this.blueVal = blueVal;
          }
     }
}
