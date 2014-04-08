using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KlasyfikatorZdjec
{
    // przechowuje atrybuty, na podstawie ktorych przeprowadzimy filtrowanie
     public class ClassifiedImage
     {
         public string path { get; set; }
         public string mainColor { get; set; }
         public bool isNature { get; set; }
         public string resolution { get; set; }
         public string size { get; set; }
         public string format { get; set; }
         public string cameraModel { get; set; }
         public string dateTaken { get; set; }
         public string iso { get; set; }
         public bool isInPoland { get; set; }
         public bool isBelowSeaLevel { get; set; }
         public bool isPeople { get; set; }
         public bool isPortrait { get; set; }
         public bool isGroupOfPeople { get; set; }
     }
}
