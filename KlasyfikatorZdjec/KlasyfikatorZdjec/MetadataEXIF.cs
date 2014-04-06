using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;

namespace KlasyfikatorZdjec
{

    public enum Tags : int
    {
        PropertyTagGpsLatitudeRef = 0x0001,
        PropertyTagGpsLatitude = 0x0002,
        PropertyTagGpsLongitudeRef = 0x0003,
        PropertyTagGpsLongitude = 0x0004,
        PropertyTagGpsAltitudeRef = 0x0005,
        PropertyTagGpsAltitude = 0x0006,
        PropertyTagImageWidth = 0x0100,
        PropertyTagImageHeight = 0x0101,
        PropertyTagEquipMake = 0x010F,
        PropertyTagEquipModel = 0x0110,
        PropertyTagExifISOSpeed = 0x8827,
        PropertyTagExifDTOrig = 0x9003,
    }

    class MetadataEXIF
    {
        string path;
        PropertyItem[] propItems;
        string Manufacturer = null;
        string Model = null;
        int Width = 0;
        int Height = 0;
        short ISOSpeed = 0;
        string DateTimeTaken = null;
        int ImageSize = 0;
        ImageFormat ImageFormat = null;
        double LatitudeDegrees = 0.0; //Szerokosc geo
        double LatitudeMinutes = 0.0;
        double LatitudeSeconds = 0.0;
        string LatitudeRef = null; //W czy E
        double LongitudeDegrees = 0.0; //Dlugosc geo
        double LongitudeMinutes = 0.0;
        double LongitudeSeconds = 0.0;
        string LongitudeRef = null; //N czy S
        double Altitude = 0.0; //Wysokosc geo
        bool BelowSeaLevel = false; //0 Above Sea Level, 1 Below

        public MetadataEXIF(string path)
        {
            this.path = path;
            Image img = new Bitmap(path);
            ImageSize = (int)new System.IO.FileInfo(path).Length;
            ImageFormat = img.RawFormat;
            Height = img.Height;
            Width = img.Width;
            propItems = img.PropertyItems;
            SetCamera();
            SetISOSpeed();
            SetDateTimeTaken();
            SetGeoTags();
        }


        #region Getters
        public string GetManufacturer()
        {
            return this.Manufacturer;
        }

        public string GetModel()
        {
            return this.Model;
        }

        public int GetWidth()
        {
            return this.Width;
        }

        public int GetHeight()
        {
            return this.Height;
        }

        public short GetISOSpeed()
        {
            return this.ISOSpeed;
        }

        public string GetDateTimeTaken()
        {
            return this.DateTimeTaken;
        }

        public int GetImageSize()
        {
            return this.ImageSize;
        }

        public ImageFormat GetImageFormat()
        {
            return this.ImageFormat;
        }

        public double GetLatitudeDegrees()
        {
            return this.LatitudeDegrees;
        }

        public double GetLatitudeMinutes()
        {
            return this.LatitudeMinutes;
        }

        public double GetLatitudeSeconds()
        {
            return this.LatitudeSeconds;
        }

        public string GetLatitudeRef()
        {
            return this.LatitudeRef.Substring(0,1);
        }

        public double GetLongitudeDegrees()
        {
            return this.LongitudeDegrees;
        }

        public double GetLongitudeMinutes()
        {
            return this.LongitudeMinutes;
        }

        public double GetLongitudeSeconds()
        {
            return this.LongitudeSeconds;
        }

        public string GetLongitudeRef()
        {
            return this.LongitudeRef.Substring(0,1);
        }

        public double GetAltitude()
        {
            return this.Altitude;
        }

        public bool IsBelowSeaLevel()
        {
            return this.BelowSeaLevel;
        }

        public string GetPath()
        {
            return this.path;
        }

        #endregion



        #region Setters

        void SetCamera()
        {
            PropertyItem manuf = propItems.Where(s => s.Id == (int)Tags.PropertyTagEquipMake).DefaultIfEmpty(null).First();
            if (manuf != null)
                Manufacturer = GetEncodedValue<string>(manuf);
            PropertyItem model = propItems.Where(s => s.Id == (int)Tags.PropertyTagEquipModel).DefaultIfEmpty(null).First();
            if (model != null)
                Model = GetEncodedValue<string>(model);
        }


        void SetISOSpeed()
        {
            PropertyItem iso = propItems.Where(s => s.Id == (int)Tags.PropertyTagExifISOSpeed).DefaultIfEmpty(null).First();
            if (iso != null)
                ISOSpeed = GetEncodedValue<short>(iso);
        }

        void SetDateTimeTaken()
        {
            PropertyItem dateTimeTaken = propItems.Where(s => s.Id == (int)Tags.PropertyTagExifDTOrig).DefaultIfEmpty(null).First();
            if (dateTimeTaken != null)
                DateTimeTaken = GetEncodedValue<string>(dateTimeTaken);
        }

        public void SetGeoTags()
        {
            PropertyItem latitude = propItems.Where(s => s.Id == (int)Tags.PropertyTagGpsLatitude).DefaultIfEmpty(null).First();
            if (latitude != null) 
            {
                int A = BitConverter.ToInt32(latitude.Value, 0);
                int B = BitConverter.ToInt32(latitude.Value, 4);
                LatitudeDegrees = (double)A / B; ;
                A = BitConverter.ToInt32(latitude.Value, 8);
                B = BitConverter.ToInt32(latitude.Value, 12);
                LatitudeMinutes = (double)A / B; ;
                A = BitConverter.ToInt32(latitude.Value, 16);
                B = BitConverter.ToInt32(latitude.Value, 20);
                LatitudeSeconds = (double)A / B; ;

            }
                

            PropertyItem latitudeRef = propItems.Where(s => s.Id == (int)Tags.PropertyTagGpsLatitudeRef).DefaultIfEmpty(null).First();
            if (latitudeRef != null)
                LatitudeRef = GetEncodedValue<string>(latitudeRef);

            PropertyItem longitude = propItems.Where(s => s.Id == (int)Tags.PropertyTagGpsLongitude).DefaultIfEmpty(null).First();
            if (longitude != null)
            {
                int A = BitConverter.ToInt32(longitude.Value, 0);
                int B = BitConverter.ToInt32(longitude.Value, 4);
                LongitudeDegrees = (double)A / B; ;
                A = BitConverter.ToInt32(longitude.Value, 8);
                B = BitConverter.ToInt32(longitude.Value, 12);
                LongitudeMinutes = (double)A / B; ;
                A = BitConverter.ToInt32(longitude.Value, 16);
                B = BitConverter.ToInt32(longitude.Value, 20);
                LongitudeSeconds = (double)A / B; ;
            }

            PropertyItem longitudeRef = propItems.Where(s => s.Id == (int)Tags.PropertyTagGpsLongitudeRef).DefaultIfEmpty(null).First();
            if (longitudeRef != null)
                LongitudeRef = GetEncodedValue<string>(longitudeRef);

            PropertyItem altitude = propItems.Where(s => s.Id == (int)Tags.PropertyTagGpsAltitude).DefaultIfEmpty(null).First();
            if (altitude != null)
                Altitude = GetEncodedValue<double>(altitude);

            PropertyItem altitudeRef = propItems.Where(s => s.Id == (int)Tags.PropertyTagGpsAltitudeRef).DefaultIfEmpty(null).First();
            if (altitudeRef != null)
                BelowSeaLevel = GetEncodedValue<bool>(altitudeRef);
        }

        #endregion

        T GetEncodedValue<T>(PropertyItem prop)
        {
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            string s = encoding.GetString(prop.Value);
            double rational = 0.0;

            if (prop.Type == 5)
            {
                int A = BitConverter.ToInt32(prop.Value, 0);
                int B = BitConverter.ToInt32(prop.Value, 4);
                rational = (double)A / B;
            }

            T item = default(T);
            var @switch = new Dictionary<Type, Action> {
                { typeof(string), () => item = (T)Convert.ChangeType(s,typeof(T)) },
                { typeof(int), () => item = (T)Convert.ChangeType(BitConverter.ToInt32(prop.Value,0),typeof(T)) },
                { typeof(short), () => item = (T)Convert.ChangeType(BitConverter.ToInt16(prop.Value,0),typeof(T)) },
                { typeof(double), () => item = (T)Convert.ChangeType(rational,typeof(T)) },
                { typeof(bool), () => item = (T)Convert.ChangeType(BitConverter.ToBoolean(prop.Value,0),typeof(T)) },
            };

            @switch[typeof(T)]();

            return item;

        }
    }
}
