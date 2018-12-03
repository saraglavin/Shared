using System;
using System.Collections.Generic;
using System.Text;

namespace ClasserCars
{
    class Car
    {

        public int Weight { get; set; }
        public string Color { get; set; }

        //private string color;
        //private int weight;

        public Car(string c, int w)
        {
            Color = c;
            Weight = w;
        }

        public Car()
        {
            Color = "Default Blue";
            Weight = 1200;

        }

        //public void SetWeight(int yy)
        //{
        //    weight = yy;
        //}
        //public int Getweight()
        //{
        //    return weight;
        //}

        //public void SetColor(string xx)
        //{
        //    color = xx;
        //}
        //public string GetColor()
        //{
        //    return color;
        //}

    }
}
