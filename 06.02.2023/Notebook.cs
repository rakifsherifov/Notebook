using System;
using System.Collections.Generic;
using System.Text;

namespace _06._02._2023
{
    internal class Notebook
    {     
        public Notebook( string model, int price)
        {
            Model= model;
            Price= price;

        }
        
        public string Brand;
        public string Model;
        public int Price;

        public string ShowInfo()
        {
            return Brand + " " + Model+ " "+ Price;
        }


    }
}
