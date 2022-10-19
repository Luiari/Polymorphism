using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(2.33);
            Rektangel rektangel = new Rektangel(1.3,1.5);
            Fyrkant fyrkant = new Fyrkant(1.4,1.4);

            circle.Area();
            rektangel.Area();
            fyrkant.Area();
            
        }
    }
}
