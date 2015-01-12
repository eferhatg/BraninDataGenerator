using System;
namespace BraninDataGenerator
{
    class Program
    {
        static Random r = new Random();
        static void Main(string[] args)
        {
            const int iterCount = 2000;
            using (var file = new System.IO.StreamWriter(@"branin_data.txt"))
            {
                for (int i = 0; i < iterCount; i++)
                {
                    var x1 = GetRandomNumber(-5.0, 10.0);
                    var x2 = GetRandomNumber(0.0, 15.0);
                    var result = ((-1.275 * (Math.Pow(x1, 2) / Math.Pow(Math.PI, 2))) 
                        + (5 * (x1 / Math.PI)) + x2 - 6) 
                        + ((10 - (5 / (4 * Math.PI))) * Math.Cos(x1)) + 10;
                    file.WriteLine(Normilize(x1, 10, -5, 1, -1) + " " + Normilize(x2, 15, 0, 1, -1) + " " + result);
                }
            }
            Console.ReadLine();
        }
        public static double GetRandomNumber(double minimum, double maximum)
        {
            return r.NextDouble() * (maximum - minimum) + minimum;
        }
        public static double Normilize(double x, double max, double min, double new_max, double new_min)
        {
            x = (x - min)/(max - min);
            return x;
        }
    }
}
