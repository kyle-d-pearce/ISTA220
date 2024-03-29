﻿using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            int myInt = 1;
            Console.WriteLine(myInt);

            float myFloat = 0.42f;
            bool myBoolean = true;
            string myName = "John";
            char myChar = 'a';

            StringBuilder address = new StringBuilder();
            address.Append("8150");
            address.Append(", Marne Road");
            address.Append(", Ft Benning, GA 31905");
            string concatenatedAddress = address.ToString();
            Console.WriteLine(concatenatedAddress);
            // Concatenating multiple strings in Visual C# is simple to achieve by using the + operator. 
            // However, this is considered bad coding practice because strings are immutable. 
            // This means that every time you concatenate a string, you create a new string in memory 
            // and the old string is discarded. It is best to use StringBuilder

            Regex rx = new Regex(@"\b(?<word>\w+)\s+(\k<word>)\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            string smtText = "The Cloud Apps Developer Program is a great great opportunity to start a new career career";
            //Find match of duplicate words
            MatchCollection matches = rx.Matches(smtText);
            //Report the number of matches found
            Console.WriteLine("{0} matches found in: \n {1}", matches.Count, smtText);
            // When acquiring input from the user interface of an application, 
            // data is often provided as strings that you need to validate and then convert 
            // into a format that your application logic expects. 
            // Regular expressions provide a mechanism that enables you to validate input. 

            double d = 5673.74;
            int i;
            // cast double to int
            i = (int)d;
            Console.WriteLine(i);

            string userEnteredValue = "542.12";
            //error: int flightCost = Convert.ToInt32(userEnteredValue);
            double flightCost = Convert.ToDouble(userEnteredValue);
            //error: long flightCost = Convert.ToUInt32(userEnteredValue);
            Console.WriteLine(flightCost);
        }
    }
}
