using System.Runtime.InteropServices;

namespace second
{
    class Test
    {
        public static void Main()
        {
            Console.WriteLine("please enter x & y: ");
            Console.Write("x = ");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            int Y = Convert.ToInt32(Console.ReadLine());
            calc(X, Y);
        }

        private static void calc(int x, int y)
        {
            double result = Math.Sqrt(Math.Abs(x) + Math.Pow(y, 2));
            Console.WriteLine("√|x|+y2 = {0}", result);
        }
    }
}