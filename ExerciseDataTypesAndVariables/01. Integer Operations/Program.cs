﻿namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber=int.Parse(Console.ReadLine());
            int secondNumber=int.Parse(Console.ReadLine());
            int thirdNumber=int.Parse(Console.ReadLine());
            int forthNumber=int.Parse(Console.ReadLine());
            int result = 0;
            result = ((firstNumber + secondNumber)/thirdNumber)*forthNumber ;
            Console.WriteLine((int)result);
        }
    }
}