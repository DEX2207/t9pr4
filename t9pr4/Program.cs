using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t9pr4
{
    internal class Program
    {
        static void Main(string[] args)
        {//1
            int[] mass = new int[15];
            Random rnd =new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(-50,50); 
                Console.WriteLine($"mass[{i}]={mass[i]}");
            }
            int a = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i]%3==0)
                {
                    a++;
                }
            }
            Console.WriteLine($"Кол-во чисел, кратное трем, равно {a}");
            Console.ReadLine();
            //2

        }
    }
}
