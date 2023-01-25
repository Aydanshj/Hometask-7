using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Xml.Schema;

namespace HomeTask7
{
    internal class Laptop
    {
        public string Brand;
        public string Model;
        public int Price;

        public Laptop(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public Laptop(string brand, string model, int price = 0)
        {
            Price = price;
            Brand = brand;
            Model = model;
        }

        public string showInfo()
        {
            return $"Brand {Brand}, Model {Model}, Price {Price}";
        }
    }
}
