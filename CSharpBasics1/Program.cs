﻿using System;
using System.Threading;
using System.ComponentModel.DataAnnotations;

namespace CSharpBasics1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyString();

            Console.WriteLine();
        }

        static void MyString()
        {
            Console.Write("What year were born?");
            int yearBorn = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is your age?");
            string myName = Console.ReadLine();

            Console.WriteLine($"Your age is: {myName}, and you were born in {yearBorn}");
            
            string myString1 = "This is my first string";
            string theTruth = "The last thing a ninja would do is amdit to being a ninja.";
            string theLie = "I am not a ninja.";
            Console.WriteLine("This is my String. " + myString1);
            Console.WriteLine($"Here are two truths and a lie. {theTruth}, {theLie}");
            Console.WriteLine($"This is a commit. {theTruth}, {theLie}");

        }
    }
}
