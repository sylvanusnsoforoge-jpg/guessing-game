using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Guess_game1._0
{
    internal class Class1
    {
        static void Main(string[]args)
        {
            Random Numbers = new Random();

            int num = Numbers.Next(1,100);

            Console.WriteLine(num);
            {
                for(int Num =0; num <=3; num +=1)
                {
                    Console.WriteLine(Num);

                }
                if (num <=100)
                {
                    Console.WriteLine("too low");
                }else if (num >= 100)
                {
                    Console.WriteLine("too high");
                }
            }
            Console.ReadLine();
            
        }
    }
}


            