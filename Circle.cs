using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Circle:Tekning
    {
        double Radius;
        public float Pi = 3.141f;
        public Circle(double Radius)
        {
            
           this.Radius = Radius;
        }
        public override void Area()
        {
            double circumarea = Radius * Radius * Pi;
            Console.WriteLine("Circelns area är "+ circumarea);
        }
        
        
       

    }

}


