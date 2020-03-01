using System;

namespace Lab2_Pairs2
{
    class Multiply
    {
        private static double res;
        public static double Multiplication(double value1,double value2)
        {
            return res = value1*value2;
        }
        public static void Print(){
            Console.WriteLine(res);
        }
    }
}