using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Fyrkant : Tekning
    {
        
        public double Heigth1
        {
            get { return Heigth; }

            set { Heigth = value; }
        }
        public double Base1
        {
            get
            { return Base; }
            set
            { Base = value; }
        }



        public Fyrkant(double Heigth, double Base)
        {
        

            this.Heigth1 = Heigth;
            this.Base1 = Base;
        }
        public override void Area()
        {
            double Area = Heigth1 * Base1;

            Console.WriteLine("Fyrkantens area är " + Area);
        }
    }
}
