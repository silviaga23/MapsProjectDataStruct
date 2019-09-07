using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd
{
    public class Place
    {
        private string Name;
        private double Lon;
        private double Lati;
        public Place()
        {
            this.Name = "";
            this.Lati = 0;
            this.Lon = 0;
        }
        public Place(string pName, double pLati, double pLongi)
        {
            this.Name = pName;
            this.Lati = pLati;
            this.Lon = pLongi;
        }
        public string GetName()
        {
            return this.Name;
        }
        public double GetLati()
        {
            return this.Lati;
        }
        public double GetLongit()
        {
            return this.Lon;
        }
        public void SetName(string pName)
        {
            this.Name = pName;
        }
        public void SetLati(double pLati)
        {
            this.Lati = pLati;
        }
        public void SetLongi(double pLongi)
        {
            this.Lon = pLongi;
        }
    }
}

