using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    internal class Rektangel:Tekning
    {
        public double Heigth1
        {
            get { return Heigth; }

            set { Heigth = value; }
        }
        public double Base1
        {
            get { return Base; }
            set { Base = value; }
        }
        
        public Rektangel(double Heigth, double Base)
        {
            this.Heigth1 = Heigth;
            this.Base1 = Base;
           
        }
        public override void Area()
        {
            double Area = Heigth * Base;

            Console.WriteLine("Rektangels area är " + Area);
        }




    }
}

