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
            //int[] mass = new int[15];
            //Random rnd =new Random();
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    mass[i] = rnd.Next(-50,50); 
            //    Console.WriteLine($"mass[{i}]={mass[i]}");
            //}
            //int a = 0;
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    if (mass[i]%3==0)
            //    {
            //        a++;
            //    }
            //}
            //Console.WriteLine($"Кол-во чисел, кратное трем, равно {a}");
            //Console.ReadLine();
            //2
            double[]mass=new double[31];
            Random rnd = new Random();
            double sum = 0;
            int i;
            for (i=0;i<mass.Length;i++)
            {
                mass[i] = 60+5*rnd.NextDouble();
                Console.WriteLine($"mass[{i+1}]={mass[i]:f2}");
                sum += mass[i];
            }
            int IndexMax=0;
            int IndexMin=0;
            double max = mass[0];
            for (i = 1; i < mass.Length; i++)
            {
                if (mass[i] > max)
                {
                    max = mass[i];
                    IndexMax = i;
                }
            }
            double min = mass[0];
            for (i = 1; i < mass.Length; i++)
            {
                if (mass[i] < min)
                {
                    min = mass[i];
                    IndexMin = i;
                }
            }
            Console.WriteLine($"Ср. знач ={sum/mass.Length:f2}; max={max:f2} в день {IndexMax+1};min={min:f2} в день {IndexMin+1}");
            Console.ReadLine();
        }
    }
}
