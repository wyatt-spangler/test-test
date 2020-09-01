using System;
using System.Threading;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Runtime.InteropServices;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            CastingTypes();
        }

        static void MyString()
        {
            Console.Write("What year were you born?");
            int yearBorn = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is your age?");
            string myName = Console.ReadLine();

            Console.WriteLine($"Your age is: {myName}, and you were born in {yearBorn}");

            string myString1 = "This is my first string";
            string theTruth = "The last thing a ninja would do is admit to being a ninja.";
            string theLie = "I am not a ninja.";
            Console.WriteLine("This is my String. " + myString1);
            Console.WriteLine($"Here are two truths and a lie. {theTruth}, {theLie}");

        }

        static void DataTypes()
        {
            int myAge = 99;
            string name = "Bob the Builder";
            bool awesome = true;
            char grade = 'F'; // Chars are single characters with single quotes
            float altitude = 90.2638493f; // float requires 'f' at the end.
            double bankBalance = -400000000;
            decimal pi = 3.14159265359M; // decimal requires an 'M' at the end.



            /// Output
            /// 
            Console.WriteLine($"int = {myAge}.");
            Console.WriteLine($"string = {name}.");
            Console.WriteLine($"bool = {awesome}.");
            Console.WriteLine($"char = {grade}.");
            Console.WriteLine($"float = {altitude}.");
            Console.WriteLine($"double = {bankBalance}.");
            Console.WriteLine($"decimal = {pi}.");
            Console.WriteLine($"myAge = {myAge}.");
        }



        static void InputTypes()
        {
            ///*DataTypes();*/
            Console.WriteLine("Enter Number One.");
            ///*string myName = Console.ReadLine();*/
            decimal numberOne = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine($"You entered: {numberOne}");

            Console.WriteLine("Enter Number Two.");
            decimal numberTwo = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"You entered {numberOne} & {numberTwo}");


        //Addition
        Console.WriteLine($"Addition:{numberOne} + {numberTwo} = {numberOne + numberTwo}");
        Console.WriteLine($"Subtraction:{numberOne} - {numberTwo} = {numberOne - numberTwo}");
        Console.WriteLine($"Multiplication:{numberOne} * {numberTwo} = {numberOne * numberTwo}");
        Console.WriteLine($"Division:{numberOne} / {numberTwo} = {numberOne / numberTwo}");
        Console.WriteLine($"Modulus:{numberOne} % {numberTwo} = {numberOne % numberTwo}");
            
            //increment
            Console.WriteLine($"Increment: The increment of {numberOne++} is {numberOne}");
            Console.WriteLine($"Increment: The increment of {numberOne++} is {numberOne}");
            Console.WriteLine($"numberOne++ is the same as numberOne = numberOne + 1. See here: {numberOne} is {numberOne = numberOne + 1}.");
            //decrement
            Console.WriteLine($"Decrement: The decrement of {numberTwo++} is {numberTwo}");
            Console.WriteLine($"Decrement: The decrement of {numberTwo++} is {numberTwo}");

            decimal centeredPolygonal = ((((numberOne * numberTwo) / 2) * (numberTwo - 1)) + 1);
            Console.WriteLine($"The centered polygonal of {numberOne} & {numberTwo} is: + {centeredPolygonal}");
        }

        static void CastingTypes()
        {
            double myDouble = 10.5;
            int myInteger = 2;

            myDouble = myDouble + myInteger;
            Console.WriteLine($"Implicit cast: {myDouble}");

            myDouble = (double)7 / myInteger; //Implicit Cast: C# Automatically Converts int to double
            Console.WriteLine($"Explicit cast: {myDouble}"); //Explicit Cast: C# If forced to Convert int to double //Without (double) answer is 3

            myDouble = 7 / myInteger;
            Console.WriteLine($"Without explicit cast: {myDouble}");

            char myLetter = (char)65;
            Console.WriteLine($"Cast integer: {myLetter}");

            int myAscii = (int)']';
            Console.WriteLine($"Cast letter: {myAscii}");

            Console.ReadKey();
        }
    }
}
