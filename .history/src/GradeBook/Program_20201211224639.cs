using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {12.5, 10.5, 18.9};
            
            var result = 0.0;
            foreach(double number in numbers)
            {
                result += number;
            }
            Console.WriteLine(result);



            
            // if(args.Length > 0)
            // {
            //     Console.WriteLine($"Hello {args[0]}!");
            // }
            // else {
            // System.Console.WriteLine("Hello!");
            // }
        }
    }
}
