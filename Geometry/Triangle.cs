using System;

namespace Geometry
{
    abstract public class Triangle
    {
        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        /// <param name="a">Первая сторона</param>
        /// <param name="b">Вторая сторона</param>
        /// <param name="c">Третья сторона</param>
        /// <returns>Площадь треугольника</returns>
        public static double Square(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentException("Сторона не может быть отрицательным числом");
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Такой треугольник не существует");
            double semiPerimeter = (a + b + c) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
        }

        /// <summary>
        /// Проверка на то, является ли треугольник прямоугольным
        /// </summary>
        /// <param name="a">Первая сторона</param>
        /// <param name="c">Вторая сторона</param>
        /// <param name="b">Третья сторона</param>
        /// <returns><strong>true</strong> - является, <strong>false</strong> - не является</returns>
        public static bool isRightAngled(double a, double c, double b)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentException("Сторона не может быть отрицательным числом");
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Такой треугольник не существует");
            return a * a + c * c == b * b || a * a + b * b == c * c || b * b + c * c == a * a;
        }
    }
}
