using System;
using System.Collections.Generic;

namespace PyramidMaxSumChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = InputData.CreatePyramid();
            Console.WriteLine($"Input: {Environment.NewLine}");
            PrintInputData(input);
            var calculator = new PyramidMaxSum();
            var max = calculator.GetMaxSum(input);
            Console.WriteLine($"{Environment.NewLine}The maximum sum is: {max}.");
            Console.ReadLine();
        }

        static void PrintInputData(int[,] input)
        {
            var length = input.GetLength(0);
            for (int i = 0; i < length; i++)
            {
                var line = new List<int>();
                for (int j = 0; j <= i; j++) line.Add(input[i, j]);
                Console.WriteLine(string.Join(" ", line.ToArray()));
            }
        }
    }
}
