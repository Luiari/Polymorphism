using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    internal class Tekning
    {
        protected double Radius;
        protected double Heigth;
        protected double Base;

      
        public virtual void Area()
        {
            double Area = Heigth * Base;
            

            Console.WriteLine("Formens area är "+Area);
        }
    }

//Kolla på circle uppgiften och gör liknande sätt för att räkna ut arean på de olika figurerna
}

