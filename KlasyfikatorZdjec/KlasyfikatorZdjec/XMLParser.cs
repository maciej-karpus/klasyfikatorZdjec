﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace KlasyfikatorZdjec
{
     class XMLParser
     {
          public const string defaultPath = @"out.xml";

          public XMLParser() {}

          public static void serialize(List<classifiedImage> imgList, String pathToXML = defaultPath)
          {
               classifiedImage[] imgArray = imgList.ToArray();
               //Utworzenie/nadpisanie pliku
               var file = File.Create(defaultPath);
               file.Close();
               //Utworzenie serializatora XML
               var serializer = new XmlSerializer(typeof(classifiedImage[]));            
               //Puste xmlns:xsi i xmlns:xsd
               var xsn = new XmlSerializerNamespaces();
               xsn.Add(String.Empty, String.Empty);
               
               //Utworzenie strumienia zapisu XML bez deklaracji <?xml>
               var settings = new XmlWriterSettings();
               settings.Indent = true;
               settings.OmitXmlDeclaration = true;
               var writer = XmlWriter.Create(defaultPath, settings);              
               //Serializacja tablicy obiektów
               serializer.Serialize(writer, imgArray, xsn);

               writer.Close();
          }

          public static List<classifiedImage> deserialize()
          {
               classifiedImage[] imgArray;
               StreamReader reader = new StreamReader(defaultPath);
               var serializer = new XmlSerializer(typeof(classifiedImage[]));

               imgArray = (classifiedImage[]) serializer.Deserialize(reader);
               return new List<classifiedImage>(imgArray);
          }
     }
}