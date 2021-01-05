using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new double[3];
            numbers[0] = 12.7;
            numbers[1] = 15.5;
            numbers[3] = 20.3;

            var sum = (numbers[0] + numbers[1] + numbers[2]);
            System.Console.WriteLine(sum);



            
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
