using System;

namespace CSharp.LabExercise1
{
    internal class Program
    {
        static void Number1()
        {
            Console.WriteLine("Welcome to the Area and Perimeter Calculator");

            Console.Write("Enter Length: ");
            decimal length = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter Width: ");
            decimal width = Convert.ToDecimal(Console.ReadLine());

            decimal Area = length * width;
            Console.WriteLine("Area: " + Area);

            decimal Perimeter = (2 * length) + (2 * width);
            Console.WriteLine("Perimeter: " + Perimeter);

            Console.Write("Continue? y/n: ");
            string choice = Console.ReadLine();
            if (choice == "y" || choice == "Y")
            {
                Number1();
            }
            else if (choice == "n" || choice == "N")
            {
                Console.Clear();
                Main();
            }

        }

        static void Number2()
        {
            Console.WriteLine("Welcome to the Letter Grade Calculator");
            Console.Write("Enter numerical grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade >= 88 && grade <= 100)
            {
                Console.WriteLine("Letter Grade: A");
            }

            else if (grade >= 80 && grade <= 87)
            {
                Console.WriteLine("Letter Grade: B");
            }

            else if (grade >= 67 && grade <= 79)
            {
                Console.WriteLine("Letter Grade: C");
            }

            else if (grade >= 60 && grade <= 67)
            {
                Console.WriteLine("Letter Grade: D");
            }

            else if (grade < 60)
            {
                Console.WriteLine("Letter Grade: F");
            }

            Console.Write("Continue? y/n: ");
            string choice = Console.ReadLine();
            if (choice == "y" || choice == "Y")
            {
                Number2();
            }
            else if (choice == "n" || choice == "N")
            {
                Console.Clear();
                Main();
            }
        }

        static void Number3()
        {
            Console.WriteLine("Welcome to the Download Time Estimator");
            Console.WriteLine("This Program calculates how long it will take to download a file with a 56k analog modem");
            Console.Write("Enter a file size (MB): ");
            decimal fileSizeInMB = Convert.ToDecimal(Console.ReadLine());

            decimal fileSizeInKB = fileSizeInMB * 1024;
            decimal totalSeconds = fileSizeInKB / Convert.ToDecimal(5.2);
            decimal hoursValue = (totalSeconds / 3600);
            decimal minutesValue = (hoursValue - (Math.Floor(hoursValue))) * 60;
            decimal secondsValue = (minutesValue - (Math.Floor(minutesValue))) * 60;

            decimal secondsValueInt = Math.Floor(secondsValue);
            decimal minutesValueInt = Math.Floor(minutesValue);
            decimal hoursValueInt = Math.Floor(hoursValue);

            Console.WriteLine("A \"56k\" modem will take " + hoursValueInt + " hours " + minutesValueInt + " minutes " + secondsValueInt + " seconds.");

            Console.Write("Continue? y/n: ");
            string choice = Console.ReadLine();
            if (choice == "y" || choice == "Y")
            {
                Number3();
            }
            else if (choice == "n" || choice == "N")
            {
                Console.Clear();
                Main();
            }
        }

        static void Number4()
        {

            Console.Write("Enter square size: ");
            int squareSize = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < squareSize; i++)
            {
                Console.Write("*");
                for (int j = 1; j < squareSize; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.Write("Continue? y/n: ");
            string choice = Console.ReadLine();
            if (choice == "y" || choice == "Y")
            {
                Number4();
            }
            else if (choice == "n" || choice == "N")
            {
                Console.Clear();
                Main();
            }


        }
        static void Main()
        {
            Console.WriteLine("LAB EXERCISE #1 BY MIKKO ANGELO DACASIN");
            Console.WriteLine("[1] NUMBER 1 PROBLEM");
            Console.WriteLine("[2] NUMBER 2 PROBLEM");
            Console.WriteLine("[3] NUMBER 3 PROBLEM");
            Console.WriteLine("[4] NUMBER 4 PROBLEM");
            Console.WriteLine("[5] EXIT");
            Console.Write("Enter Problem Number: ");
            int problemNumber = Convert.ToInt32(Console.ReadLine());

            if (problemNumber == 1)
            {
                Console.Clear();
                Number1();
            }
            else if (problemNumber == 2)
            {
                Console.Clear();
                Number2();
            }
            else if (problemNumber == 3)
            {
                Console.Clear();
                Number3();
            }
            else if (problemNumber == 4)
            {
                Console.Clear();
                Number4();
            }
            else if (problemNumber == 5)
            {
                Environment.Exit(-1);
            }

            //Number1();
            //Number2();
            //Number3();
            //Number4();
        }
    }
}
