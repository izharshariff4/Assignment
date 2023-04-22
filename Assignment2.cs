using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Assignment2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Display ODD and Even Numbers");
            int[] array = {4,7,9,12,77 };
            Console.WriteLine("odd are");

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i]%2!=0)
                {
                    Console.WriteLine(array[i]+" ");
                }
                
            }
            Console.WriteLine("EVEN are");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine(array[i] + " ");
                }

            }


        }
    }
}
