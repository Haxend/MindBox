using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox
{
    public class Class
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle("Circle", 4);
            Console.WriteLine(circle.CSquare());

            Triangle triangle = new Triangle("Triangle", 10, 8, 6);
            Console.WriteLine(triangle.CSquare());
        }
    }
}
