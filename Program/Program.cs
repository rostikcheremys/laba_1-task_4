using System;

namespace Program
{
    internal abstract class Program
    {
        private delegate double Calculate(double number);
        
        public static void Main()
        {
            while (true)
            {
                try
                {
                    string[] input = Console.ReadLine()?.Trim().Split();

                    int command = Convert.ToInt32(input[0]);
                    double number = Convert.ToDouble(input[1]);
                    
                    Calculate[] calculations = {
                        x => Math.Sqrt(Math.Abs(number)),         
                        x => Math.Pow(number, 3),         
                        x => number - 1.25
                    };
                    
                    Console.WriteLine($"Result: {calculations[command](number)}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e}");
                    break;
                }
            }
        }
    }
}