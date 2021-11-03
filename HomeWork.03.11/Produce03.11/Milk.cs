using System;
using System.Collections.Generic;
using System.Text;

namespace Produce03._11_
{
    class Milk:Produce
    {
        public Milk(double volume, double fatrate, string name, double price, int count, double totalincome) : base(name, price, count, totalincome)
        {
            this.Volume = volume;
            this.FatRate = fatrate;
        }

        public double Volume;
        public double FatRate;
    }
}
