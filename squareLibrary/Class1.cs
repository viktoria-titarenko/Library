using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace squareLibrary
{
    public class Triangle
    {
        public double SideOne { get; set; }
        public double SideTwo { get; set; }
        public double SideThree { get; set; }
        public Triangle(double sideOne, double sideTwo, double sideThree)
        {
            SideOne = sideOne;
            SideTwo = sideTwo;
            SideThree = sideThree;
            if ((SideOne < 0) || (SideTwo < 0) || (SideThree < 0))
            {
                throw new ArgumentException("В треугольнике не может быть отрицателььных сторон");
            }
            if (!IsTriangle())
            {
                throw new ArgumentException("Такого треугольника не существует");
            }
        }


        private bool IsTriangle()
        {
            return ((SideOne < (SideTwo + SideThree)) && (SideTwo < (SideOne + SideThree)) && (SideThree < (SideOne + SideTwo)));
        }
    }
    public class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
            if (Radius < 0)
            {
                throw new ArgumentException("Отрицательный радиус");
            }
        }
    }
    public class SquareCalculator
    {

        public static double Square(Triangle triang)
        {
            if (PythagoreanTheorem.IsTheorem(triang))
                //Нахождениие площади прямоугольного треугольника
            {
                if ((triang.SideThree > triang.SideTwo) && (triang.SideThree > triang.SideOne))
                {
                    return triang.SideTwo * triang.SideOne / 2;
                }
                else if ((triang.SideTwo > triang.SideThree) && (triang.SideTwo > triang.SideOne))
                {
                    return triang.SideOne * triang.SideThree / 2;
                }
                else
                {
                    return triang.SideTwo * triang.SideThree / 2;
                }
            }
            else
            {
                double semi_perimeter = (triang.SideOne + triang.SideTwo + triang.SideThree) / 2;
                return Math.Sqrt(semi_perimeter * (semi_perimeter - triang.SideOne) * (semi_perimeter - triang.SideTwo) * (semi_perimeter - triang.SideThree));
            }
        }

        public static double Square(Circle circle)
        {
            return Math.Pow(circle.Radius, 2) * Math.PI;
        }

    }

    public static class PythagoreanTheorem
    {
        public static Boolean IsTheorem(Triangle triang)
        {
            return ((Theorem(triang.SideOne, triang.SideTwo, triang.SideThree) || (Theorem(triang.SideTwo, triang.SideThree, triang.SideOne)) || (Theorem(triang.SideThree, triang.SideTwo, triang.SideOne))));
            
              
        }
        public static bool Theorem(double first, double second, double third)
        {
            return (Math.Pow(first, 2) == (Math.Pow(second, 2) + Math.Pow(third, 2)));
        }


    }
}