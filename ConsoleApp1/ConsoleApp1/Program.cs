using System.ComponentModel;
using System.Numerics;
using System.Reflection;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loop1 = true;
            int count = 0;
            while (loop1)
            {
                int num = 0;
                bool tryLock = true;
                Console.Write("Enter number: ");
                string numInt = Console.ReadLine();

                try
                {
                    num = Int32.Parse(numInt);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter a number");
                    tryLock = false;
                    count = count + 1;
                }
                Console.WriteLine(count);
                if (tryLock == true)
                {
                    num = Int32.Parse(numInt);
                    float total = num / count;
                    Console.WriteLine("Your final number is " + total.ToString("n2"));
                    loop1 = false;
                }
            }
        }
    }
}
