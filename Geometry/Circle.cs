using System;

namespace Geometry
{
    abstract public class Circle
    {
        /// <summary>
        /// Вычисление площади круга
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <returns>Площадь круга</returns>
        public static double Square(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Радиус не может быть отрицательным числом");
            return Math.PI * radius * radius;
        }
    }
}
