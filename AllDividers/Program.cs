using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllDividers
{
    class Program
    {
        static List<int> Dividers(int num)
        {
            List<int> dividers = new List<int>();
            for (int i = -(int)Math.Sqrt(Math.Abs(num)); i <= (int)Math.Sqrt(Math.Abs(num)); i++)
                if (i != 0 && num % i == 0)
                {
                    dividers.Add(i);
                    dividers.Add(num / i);
                }
            dividers = dividers.Distinct().ToList<int>();
            dividers.Sort();
            return dividers;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please, enter any number: ");
                string s = Console.ReadLine();
                int num = 0;
                try
                {
                    num = Int32.Parse(s);
                }
                catch(OverflowException)
                {
                    Console.WriteLine("Sorry, this number is too big to calculate all dividers. Try again.\n");
                    continue;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please, enter your number correct. Try again.\n");
                    continue;
                }
                List<int> dividers = Dividers(num);
                s = "The dividers of this number is: ";
                foreach (var divider in dividers)
                    s += divider + ", ";
                if (num == 0)
                    s = "Zero has no dividers.";
                Console.WriteLine(s + "\n");
            }
        }
    }
}
