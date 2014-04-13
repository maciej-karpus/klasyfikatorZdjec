using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlasyfikatorZdjec
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //TestXMLParser();
        }

        static void TestXMLParser()
        {
            var mList = new List<UnclassifiedImage>();
            //mList.Add(new ClassifiedImage(false, @"C:/test", 3, 0.94f));
            //mList.Add(new ClassifiedImage(true, @"C:/test2", 2, 0.1f));
            //mList.Add(new ClassifiedImage(true, @"C:/test3", 42, 0.22f));
            //XMLParser.serialize(mList);
            //var deserializedList = XMLParser.deserialize();
        }
    }
}
