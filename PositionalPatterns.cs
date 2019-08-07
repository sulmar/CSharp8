using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8
{
    static class PositionalPatterns
    {
        public static void Test()
        {
            GpsLocation location = new GpsLocation(52.04f, 28.4f, 0f);

            float lat;
            float lng;
            float alt;

            location.Deconstruct(out lat, out lng, out alt);

            
        }
    }

    public class GpsLocation
    {
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public float Altitude { get; set; }

        // C# <8.0
        //public GpsLocation(float lat, float lng, float alt)
        //{
        //    this.Latitude = lat;
        //    this.Longitude = lng;
        //    this.Altitude = alt;
        //}

        // C# 8.0
        public GpsLocation(float lat, float lng, float alt) => (Latitude, Longitude, Altitude) = (lat, lng, alt);

        // C# <8.0
        //public void Deconstruct(out float lat, out float lng, out float alt)
        //{
        //    lat = Latitude;
        //    lng = Longitude;
        //    alt = Altitude;
        //}
          
        // C# 8.0
        public void Deconstruct(out float lat, out float lng, out float alt) => (lat, lng, alt) = (Latitude, Longitude, Altitude);
        

    }


}
