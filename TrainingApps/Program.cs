using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApps
{
    class Program
    {
        static void Main(string[] args)
        {
            //program to write all first numbers from the given interval

            int loverNumber=0, higherNumber=0, counter = 0;
            Console.WriteLine("Please give me the lover numer: ");
            loverNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please give me the higher number: ");
            higherNumber = Convert.ToInt32(Console.ReadLine());

            for(int i = loverNumber; i<=higherNumber; i++)
            {
                for(int j = 1; j <=i; j++)
                {
                    if(i%j == 0)
                    {
                        counter++;
                    }
                    
                }
                if(counter <=2)
                {
                    Console.WriteLine(i + " ");
                }
                counter = 0;
            }

            Console.ReadKey();
        }
    }
}
