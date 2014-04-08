using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyfikatorZdjec
{
    public class Filter
    {
        public List<ClassifiedImage> images { get; set; }

        public Filter(List<ClassifiedImage> images)
        {
            this.images = images;
        }

        public void filterByResolution(string resolution)
        {
            foreach (ClassifiedImage ci in images)
            {
                if (!resolution.Equals(ci.resolution))
                {
                    images.Remove(ci);
                }
            }
        }

        public void filterByFormat(string format)
        {
            foreach (ClassifiedImage ci in images)
            {
                if (!format.Equals(ci.format))
                {
                    images.Remove(ci);
                }
            }
        }

        public void filterByCameraModel(string cameraModel)
        {
            foreach (ClassifiedImage ci in images)
            {
                if (!cameraModel.Equals(ci.cameraModel))
                {
                    images.Remove(ci);
                }
            }
        }

        public void filterByIso(string iso)
        {
            foreach (ClassifiedImage ci in images)
            {
                if (!iso.Equals(ci.iso))
                {
                    images.Remove(ci);
                }
            }
        }

        public void filterByIsInPoland(bool isInPoland)
        {
            foreach (ClassifiedImage ci in images)
            {
                if (ci.isInPoland != isInPoland)
                {
                    images.Remove(ci);
                }
            }
        }

        public void filterByIsBelowSeaLevel(bool isBelowSeaLevel)
        {
            foreach (ClassifiedImage ci in images)
            {
                if (ci.isBelowSeaLevel != isBelowSeaLevel)
                {
                    images.Remove(ci);
                }
            }
        }

        public void filterByIsPeople(bool isPeople)
        {
            foreach (ClassifiedImage ci in images)
            {
                if (ci.isPeople != isPeople)
                {
                    images.Remove(ci);
                }
            }
        }

        public void filterByIsPortrait(bool isPortrait)
        {
            foreach (ClassifiedImage ci in images)
            {
                if (ci.isPortrait != isPortrait)
                {
                    images.Remove(ci);
                }
            }
        }

        public void filterByIsGroupOfPeople(bool isGroupOfPeople)
        {
            foreach (ClassifiedImage ci in images)
            {
                if (ci.isGroupOfPeople != isGroupOfPeople)
                {
                    images.Remove(ci);
                }
            }
        }

        public void filterByMainColor(string mainColor)
        {
            foreach (ClassifiedImage ci in images)
            {
                if (mainColor.Equals(ci.mainColor))
                {
                    images.Remove(ci);
                }
            }
        }
    }
}
