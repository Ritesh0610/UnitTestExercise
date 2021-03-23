using System;

namespace Calc
{
    internal class Number
    {
        public Number()
        {
        }

        internal int Square(int num)
        {
            int res = 0;
            try
            {
                res =( num * num );
            }
            catch (Exception ex)
            {
                Console.WriteLine("Square Error !!! " + ex.Message);
            }
            return res;
        }

        internal int SquareRoot(int num)
        {
            int res = 0;
            try
            {
                res = (int)Math.Sqrt(num);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Square root Error !!! " + ex.Message);
            }
            return res;

        }

        internal int Cube(int num)
        {
            int res = 0;
            try
            {
                res = (num * num * num);
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Cube Error !!! " + ex.Message);
            }
            return res;
        }
    }
}