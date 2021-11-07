using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {

            //Logical operators: && (and), || (or), ! (not)
            //Relation operators: ==, !=, >=, <=, <, >
            //Arithmetic operators: +, -, *, /, %
            //Assignment operator: =

            var number = 10;
            if (number == 10)
            {
                Console.WriteLine("Number is 10");

            }
            else // number!=10 // !(number == 10)
            {
                Console.WriteLine("Number is not 10");
            }

            number = 11;
            Console.WriteLine( number == 10 ? "Number is 10" : "Number is not 10"); //ternary operator

            number = 20;

            if (number == 10) 
            { 
                Console.WriteLine("On");
            }
            else if (number == 20)
            {
                Console.WriteLine("Yirmi");
            }
            else
                Console.WriteLine("On veya 20 değil");

            switch (number)
            {
                case 10: Console.WriteLine("On");
                    break;
                case 20: Console.WriteLine("Yirmi");
                    break;
                default:
                    Console.WriteLine("On veya yirmi değil");
                    break;
            }
            Console.ReadLine();           
        }
    }
}
