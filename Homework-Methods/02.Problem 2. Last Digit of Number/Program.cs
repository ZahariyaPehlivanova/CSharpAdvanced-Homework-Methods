﻿using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        GetLastDigitAsWord(num);
    }
    static void GetLastDigitAsWord(int number)
    {
        int lastDigit = number % 10;
        switch (lastDigit)
        {
            case 1: Console.WriteLine("one"); break;
            case 2: Console.WriteLine("two"); break;
            case 3: Console.WriteLine("three"); break;
            case 4: Console.WriteLine("four"); break;
            case 5: Console.WriteLine("five"); break;
            case 6: Console.WriteLine("six"); break;
            case 7: Console.WriteLine("seven"); break;
            case 8: Console.WriteLine("eight"); break;
            case 9: Console.WriteLine("nine"); break;

        }
    }
}
