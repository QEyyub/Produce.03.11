using System;
using System.Collections.Generic;
using System.Text;

namespace Produce03._11_
{
    class Produce
    {
        public Produce(string name , double price , int count , double totalincome)
        {
            _name = name;
            _price = price;
            Count = count;
            TotalInCome = totalincome;
        }


        private string _name;
        private double _price;
        public int Count { get; private set; }
        public double TotalInCome { get; private set; }

        public string Name {
            get
            {
                return _name;
            }
            set
            {
                if(value.Length>3 && value.Length < 25)
                {
                    _name = value;
                }
            }
        }

        public double Price {
            get
            {
                return _price;
            }
            set
            {
                if (value > 9)
                {
                    _price = value;
                }
            }
        }
    }
}
