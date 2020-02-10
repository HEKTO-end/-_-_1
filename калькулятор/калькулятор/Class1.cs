using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace калькулятор
{
    class Class1
    {
        public int Perimeter(int a, int b, int c) => a + b + c;//Считает периметр
        /// <summary>
        /// нахоидит площадь
        /// </summary>
        /// <param name="a">Сторона треугольника</param>
        /// <param name="b">Сторона треугольника</param>
        /// <param name="c">Сторона треугольника</param>
        /// <returns></returns>
        
        public double Area(int a, int b, int c)
        {
            var P = (a + b + c) / 2;
            double S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            return S;
        }

        /// <summary>
        /// находит радиус вписанной окружности
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public double Area_of_inner_circle(int a, int b, int c)
        {
            var P = (a + b + c) / 2;
            double R = Area(a, b, c) / P;
            double area_of_inner_circle = 3.14 * Math.Pow(R, 2);
            return area_of_inner_circle;
        }

        /// <summary>
        /// проверяет корректность введённых данных
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public int Check(int a, int b, int c)
        {
            if (a > 0 & b > 0 & c > 0)
            {
                if ((b + c) > a & (a + c) > b & (a + b) > c)
                {
                    return Perimeter(a, b, c);
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// не реализованный метод по нахождению углов
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public double the_Angles_Of_A_Triangle(int a, int b, int c)
        {
            //Угол A
            double pi = 3;
            double A1 = ((b * b + c * c - a * a) / (2d * b * c));
            double A2 = (double)Math.Acos(A1);
            double A3 = (double)b * (double)Math.Sin(A2) / c;
            double B1 = (double)Math.Asin(A3) * 180d / pi;
            double B2 = A2 * 180d / pi;
            double C1 = 180d - A2 - B1;
            return B2;
            //double alfa, beta;
            //double alfa1, beta1, gamma;
            //alfa = ((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c));
            //alfa1 = Math.Acos(alfa);
            //beta = Math.Abs((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c));
            //beta1 = Math.Acos(beta);
            //gamma = 180 - (alfa1 + beta1);
            //Console.WriteLine($"Угол Аlfa = {alfa1} \n Угол Вeta = {beta1} \n Угол Gamma = {gamma}");         
            //return alfa1;            
        } //Метод для нахождение углов треугольника по сторона. НЕ РЕАЛИЗОВАН!
    }
}
