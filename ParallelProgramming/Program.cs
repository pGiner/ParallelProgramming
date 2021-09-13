﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = new List<string>();
            numbers.Add("1");
            numbers.Add("2");
            numbers.Add("3");
            numbers.Add("4");
            numbers.Add("5");
            numbers.Add("6");
            numbers.Add("7");
            numbers.Add("8");
            numbers.Add("9");
            numbers.Add("10");
            numbers.Add("11");
            numbers.Add("12");
            numbers.Add("13");
            numbers.Add("14");
            numbers.Add("15");
            numbers.Add("16");
            numbers.Add("17");
            numbers.Add("18");

            Parallel.ForEach(numbers, number =>
            {
                Console.WriteLine(number);
            });

        }
    }
}
