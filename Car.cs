using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Car
{
    internal class Car
    {

        public string model;
        public string colour;
        public int year;

        //constructor

        public Car(string aModel, string aColour, int aYear)
        {
            model = aModel;
            colour = aColour;
            year = aYear;
        }
    }
}
