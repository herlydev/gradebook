namespace Gradebook
{
    class Statistics
    {
        public Statistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach(double number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N1}");
            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"The lowest grade is {lowGrade}");
        }
    }
}