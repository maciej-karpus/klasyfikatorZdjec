using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyfikatorZdjec
{
     public enum SettingKey { SMALL_IMG_KEY, MEDIUM_IMG_KEY, LARGE_IMG_KEY, DOMINATING_RED_KEY,
     DOMINATING_GREEN_KEY, DOMINATING_BLUE_KEY, LOW_ISO_KEY, MEDIUM_ISO_KEY, HIGH_ISO_KEY};

     static class Settings
     {
          //Opisy poszczególnych parametrów
          public static readonly Dictionary<SettingKey, string> settingsDescriptions =
               new Dictionary<SettingKey, string>
               {
                    {SettingKey.SMALL_IMG_KEY, "Mały rozmiar (megapiksele)"},
                    {SettingKey.MEDIUM_IMG_KEY,"Średni rozmiar (megapiksele)"},
                    {SettingKey.LARGE_IMG_KEY, "Duży rozmiar (megapiksele)"},
                    {SettingKey.DOMINATING_RED_KEY, "Dominujący czerwony"},
                    {SettingKey.DOMINATING_GREEN_KEY, "Dominujący zielony"},
                    {SettingKey.DOMINATING_BLUE_KEY, "Dominujący niebieski"},
                    {SettingKey.LOW_ISO_KEY, "Niska wartość ISO"},
                    {SettingKey.MEDIUM_ISO_KEY, "Średnia wartość ISO"},
                    {SettingKey.HIGH_ISO_KEY, "Wysoka wartość ISO"}
               };
       
          static List<Setting> settingList;

          public static List<Setting> getSettingList()
          {
               return settingList;
          }


          static Settings() 
          {
               //Stworzenie domyślnego zestawu parametrów
               settingList = new List<Setting>();
               settingList.Add(new Setting(SettingKey.SMALL_IMG_KEY, 0, 2f, true, false));
               settingList.Add(new Setting(SettingKey.MEDIUM_IMG_KEY, 2f, 4f));
               settingList.Add(new Setting(SettingKey.LARGE_IMG_KEY, 4f, 0f, false, true));
               settingList.Add(new Setting(SettingKey.DOMINATING_RED_KEY, 0.75f, 0f, false, true));
               settingList.Add(new Setting(SettingKey.DOMINATING_GREEN_KEY, 0.75f, 0f, false, true));
               settingList.Add(new Setting(SettingKey.DOMINATING_BLUE_KEY, 0.75f, 0f, false, true));
               //TODO - Dopisać reguły do ISO
          }

          public static Setting findSettingByKey(SettingKey key) 
          {
               return settingList.Find(s => s.getKey() == key);
          }

          public static void editSettingByKey(SettingKey key, Double lower, Double upper)
          {
               var tmp = settingList.Find(s => s.getKey() == key);
               tmp.lowerBound = lower;
               tmp.upperBound = upper;
               var tmp2 = settingList.Find(s => s.getKey() == key);
          }
     }

     public class Setting : IEquatable<SettingKey>
     {
          SettingKey settingKey;
          string description;
          public Double upperBound;
          public Double lowerBound;
          Boolean upperBoundLocked;
          Boolean lowerBoundLocked;
     
          public Setting(SettingKey key, Double l, Double u, Boolean f = false, Boolean f2 = false) {
               this.settingKey = key;
               this.upperBound = u;
               this.lowerBound = l;
               this.lowerBoundLocked = f;
               this.upperBoundLocked = f2;
               this.description = (Settings.settingsDescriptions.ContainsKey(key)) ? Settings.settingsDescriptions[key] : "";
          }

          #region Gettery/Settery
          public SettingKey getKey() 
          {
               return settingKey;
          }
          public Double getUpperBound()
          {
               return upperBound;
          }
          public void setUpperBound(Double b)
          {
               this.upperBound = b;
          }
          public Double getLowerBound()
          {
               return lowerBound;
          }
          public void setLowerBound(Double b)
          {
               this.lowerBound = b;
          }
          public Boolean isUpperBoundLocked()
          {
               return upperBoundLocked;
          }
          public Boolean isLowerBoundLocked()
          {
               return lowerBoundLocked;
          }
          public string getDescription()
          {
               return description;
          }
          #endregion

          //IEquatable
          public bool Equals(SettingKey key)
          {
               if (key == settingKey) return true;
               else return false;
          }
     }
          
}
