﻿using System;

namespace Months
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.Write("Please enter the number of the month in which you were born: ");
            string monthNumber = Console.ReadLine();

            string monthName = "";

            if (monthNumber == "1")
                monthName = "gennaio";
            else if (monthNumber == "2")
                monthName = "febbraio";
            else if (monthNumber == "3")
                monthName = "marzo";
            else if (monthNumber == "4")
                monthName = "aprile";
            else if (monthNumber == "5")
                monthName = "maggio";
            else if (monthNumber == "6")
                monthName = "giungo";
            else if (monthNumber == "7")
                monthName = "luglio";
            else if (monthNumber == "8")
                monthName = "agosto";
            else if (monthNumber == "9")
                monthName = "settembre";
            else if (monthNumber == "10")
                monthName = "ottobre";
            else if (monthNumber == "11")
                monthName = "novembre";
            else if (monthNumber == "12")
                monthName = "dicembre";
            else
            {
                monthName = "Sorry, we didn't understand. Please enter a number 1 through 12.";

            }

            Console.WriteLine("The Italian name for your birth month is : {0}.", monthName);
            Console.ReadLine();








        }
    }
}
