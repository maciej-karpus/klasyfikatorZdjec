using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyfikatorZdjec
{
    public static class Filter
    {
        public static string[] filter(bool[] filters, object[] values, List<classifiedImage> images)
        {
            for (int i = 0; i < filters.Length; i++)
            {
                if (filters[i])
                {
                    foreach (classifiedImage ci in images)
                    {
                        if(ci.getProp(i) != values[i])
                        {
                            images.Remove(ci);
                        }
                    }
                }
            }
            string[] files = new string[images.Count];
            int j = 0;
            foreach (classifiedImage ci in images)
            {
                files[j] = ci.path;
            }
            return files;
        }
    }
}
