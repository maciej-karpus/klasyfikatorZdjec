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
            List<ClassifiedImage> imagesCopy = new List<ClassifiedImage>(images);
            foreach (ClassifiedImage ci in images)
            {
                if (!resolution.Equals(ci.resolution))
                {
                    imagesCopy.Remove(ci);
                }
            }
            images = imagesCopy;
        }

        public void filterByFormat(string format)
        {
            List<ClassifiedImage> imagesCopy = new List<ClassifiedImage>(images);
            foreach (ClassifiedImage ci in images)
            {
                if (!format.Equals(ci.format))
                {
                    imagesCopy.Remove(ci);
                }
            }
            images = imagesCopy;
        }

        public void filterByCameraModel(string cameraModel)
        {
            List<ClassifiedImage> imagesCopy = new List<ClassifiedImage>(images);
            foreach (ClassifiedImage ci in images)
            {
                if (!cameraModel.Equals(ci.cameraModel))
                {
                    imagesCopy.Remove(ci);
                }
            }
            images = imagesCopy;
        }

        public void filterByIso(string iso)
        {
            List<ClassifiedImage> imagesCopy = new List<ClassifiedImage>(images);
            foreach (ClassifiedImage ci in images)
            {
                if (!iso.Equals(ci.iso))
                {
                    imagesCopy.Remove(ci);
                }
            }
            images = imagesCopy;
        }

        public void filterByIsInPoland(bool isInPoland)
        {
            List<ClassifiedImage> imagesCopy = new List<ClassifiedImage>(images);
            foreach (ClassifiedImage ci in images)
            {
                if (ci.isInPoland != isInPoland)
                {
                    imagesCopy.Remove(ci);
                }
            }
            images = imagesCopy;
        }

        public void filterByIsBelowSeaLevel(bool isBelowSeaLevel)
        {
            List<ClassifiedImage> imagesCopy = new List<ClassifiedImage>(images);
            foreach (ClassifiedImage ci in images)
            {
                if ((isBelowSeaLevel && ci.isAboveSeaLevel != "niziny") || (!isBelowSeaLevel && ci.isAboveSeaLevel != "wyżyny"))
                {
                    imagesCopy.Remove(ci);
                }
            }
            images = imagesCopy;
        }

        public void filterByIsPeople(bool isPeople)
        {
            List<ClassifiedImage> imagesCopy = new List<ClassifiedImage>(images);
            foreach (ClassifiedImage ci in images)
            {
                if (ci.isPeople != isPeople)
                {
                    imagesCopy.Remove(ci);
                }
            }
            images = imagesCopy;
        }

        public void filterByIsPortrait(bool isPortrait)
        {
            List<ClassifiedImage> imagesCopy = new List<ClassifiedImage>(images);
            foreach (ClassifiedImage ci in images)
            {
                if (ci.isPortrait != isPortrait)
                {
                    imagesCopy.Remove(ci);
                }
            }
            images = imagesCopy;
        }

        public void filterByIsGroupOfPeople(bool isGroupOfPeople)
        {
            List<ClassifiedImage> imagesCopy = new List<ClassifiedImage>(images);
            foreach (ClassifiedImage ci in images)
            {
                if (ci.isGroupOfPeople != isGroupOfPeople)
                {
                    imagesCopy.Remove(ci);
                }
            }
            images = imagesCopy;
        }

        public void filterByMainColor(string mainColor)
        {
            List<ClassifiedImage> imagesCopy = new List<ClassifiedImage>(images);
            foreach (ClassifiedImage ci in images)
            {
                if (!mainColor.Equals(ci.mainColor))
                {
                    imagesCopy.Remove(ci);
                }
            }
            images = imagesCopy;
        }
    }
}
