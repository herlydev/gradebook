﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {12.7, 10.3, 6.11, 4.1};
            var grades = new List<double>() {12.7, 10.3, 6.11, 4.1};
            var gradesCount = grades.Count;
            grades.Add(56.1);
            
            var result = 0.0;
            foreach(double number in grades)
            {
                result += number;
            }
            var average = 0.0;
            average = result/gradesCount;
            Console.WriteLine(average);



            
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
