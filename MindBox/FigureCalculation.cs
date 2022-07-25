using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox
{
    public abstract class Figure
    {
        public string FigureName { get; set; }

        public Figure(string FigureName)
        {
            this.FigureName = FigureName;
        }

        public abstract double CSquare();
    }

    public static class FigureShape
    {
        public static double CSquare(Figure figure) => figure.CSquare();
    }

    public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(string FigureName, double Radius) : base(FigureName)
        {
            this.Radius = Radius;
        }

        public override double CSquare()
        {
            if (this.Radius <= 0)
                throw new ArgumentException($"Ошибка: Радиус не может быть меньше или равен 0");
            else
                return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }
    }

    public class Triangle : Figure
    {
        public double ab { get; set; }
        public double ac { get; set; }
        public double bc { get; set; }

        public Triangle(string FigureName, double ab, double bc, double ac) : base(FigureName)
        {
            if (ab <= 0 || ac <= 0 || bc <= 0)
                throw new ArgumentException($"Ошибка: Сторона треугольника не может быть меньше или равен 0");
            else if (ab > (bc + ac) || bc > (ab + ac) || ac > (ab + bc))
                throw new ArgumentException($"Ошибка: Одна из сторон больше суммы двух других");
            else
            {
                this.ab = ab;
                this.ac = ac;
                this.bc = bc;                
            }
        }

        public override double CSquare()
        {
            double p = (ab + ac + bc) / 2;
            double result = Math.Round(Math.Sqrt(p * (p - ab) * (p - ac) * (p - bc)), 2);
            return result;
        }

        public bool IsRectangular()
        {
            bool check = (Math.Pow(ab, 2) == Math.Pow(ac, 2) + Math.Pow(bc, 2)
                        || Math.Pow(ac, 2) == Math.Pow(ab, 2) + Math.Pow(bc, 2)
                        || Math.Pow(bc, 2) == Math.Pow(ac, 2) + Math.Pow(ab, 2));
            return check;
        }
    }
}
