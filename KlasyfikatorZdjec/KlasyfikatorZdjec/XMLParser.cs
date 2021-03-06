﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace KlasyfikatorZdjec
{
     class XMLParser
     {
          public const string defaultPath = @"out.xml";

          public XMLParser() {}

          public static void serialize(List<UnclassifiedImage> imgList, String pathToXML)
          {
               UnclassifiedImage[] imgArray = imgList.ToArray();
               //Utworzenie/nadpisanie pliku
              
               var file = File.Create(pathToXML+"\\"+defaultPath);
               file.Close();
               //Utworzenie serializatora XML
               var serializer = new XmlSerializer(typeof(UnclassifiedImage[]));            
               //Puste xmlns:xsi i xmlns:xsd
               var xsn = new XmlSerializerNamespaces();
               xsn.Add(String.Empty, String.Empty);
               
               //Utworzenie strumienia zapisu XML bez deklaracji <?xml>
               var settings = new XmlWriterSettings();
               settings.Indent = true;
               settings.OmitXmlDeclaration = true;
               var writer = XmlWriter.Create(pathToXML + "\\" + defaultPath, settings);              
               //Serializacja tablicy obiektów
               serializer.Serialize(writer, imgArray, xsn);

               writer.Close();
          }

          public static List<UnclassifiedImage> deserialize(String directory)
          {
               UnclassifiedImage[] imgArray;
               StreamReader reader = new StreamReader(directory+"\\"+defaultPath);
               var serializer = new XmlSerializer(typeof(UnclassifiedImage[]));

               imgArray = (UnclassifiedImage[])serializer.Deserialize(reader);
               return new List<UnclassifiedImage>(imgArray);
          }
     }
}
