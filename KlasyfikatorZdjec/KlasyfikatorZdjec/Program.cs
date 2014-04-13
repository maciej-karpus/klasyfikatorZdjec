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
            //TestSettings();
        }

        static void TestSettings() {
             //Przykład użycia klasy Settings - wyszukiwanie konkretnego ustawienia
             var setting = Settings.findSettingByKey(SettingKey.DOMINATING_BLUE_KEY);
             //Dolne ograniczenie danego ustawienia
             setting.getLowerBound();
             setting.getUpperBound();
        }

    }
}
