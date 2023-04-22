using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Hybrid
    {
        Monday, Tuesday, Wednesday, Thursday, Friday
    }
    class To_do_Hybrid
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working Days List are");
            Array weeks = Enum.GetValues(typeof(Hybrid));
            for (int i = 0; i < weeks.Length; i++)
            {
                Console.WriteLine(weeks.GetValue(i));
            }

            Hybrid select = (Hybrid)Enum.Parse(typeof(Hybrid), Console.ReadLine(), true);
            Console.WriteLine("the Selected day is " + select);
        }
    }
}