﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {12.5, 10.5, 18.9};
            var grades = new List<double>() {12.5, 10.5, 18.9};
            var gradesCount = grades.Count;
            grades.Add(56.1);
            
            var result = 0.0;
            foreach(double number in grades)
            {
                result += number;
            }
            var average = 0.0;
            average = result/average;
            Console.WriteLine(result/average);



            
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
