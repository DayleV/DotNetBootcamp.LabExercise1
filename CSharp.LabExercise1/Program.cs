using System;

namespace CSharp.LabExercise1
{
    internal class Program
    {
        static void Number1()
        {
            while (true)
            {
                Console.WriteLine("\nWelcome to the Area and Perimeter Calculator");

                Console.Write("\nEnter Length: ");
                float length = (float)Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter Width: ");
                float width = (float)Convert.ToDecimal(Console.ReadLine());

                float area = length * width;
                float perimeter = (2 * width) + (2 * length);

                Console.WriteLine("Area: {0}", area);
                Console.WriteLine("Perimeter: {0}", perimeter);

                Console.Write("\nContinue? (y/n) ");
                string willContinue = Console.ReadLine();

                if (willContinue == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            
        }
        static void Number2()
        {
            while (true)
            {
                Console.WriteLine("\nWelcome to the Letter Grade Calculator");

                Console.Write("\nEnter Numerical Grade: ");
                int grade = Convert.ToInt32(Console.ReadLine());

                char gradeInLetter = 'F';
                if(grade >= 88 && grade <= 100)
                {
                    gradeInLetter = 'A';
                }
                else if (grade >= 80 && grade <= 87)
                {
                    gradeInLetter = 'B';
                }
                else if(grade >= 67 && grade <= 79)
                {
                    gradeInLetter = 'C';
                }
                else if(grade >= 60 && grade <= 66)
                {
                    gradeInLetter = 'D';
                }
                else if (grade < 60)
                {
                    gradeInLetter = 'F';
                }
                Console.WriteLine("Letter grade: {0}", gradeInLetter);

                Console.Write("\nContinue? (y/n) ");
                string willContinue = Console.ReadLine();
                if (willContinue == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            
        }

        static void Number3()
        {
            while (true)
            {
                Console.WriteLine("\nWelcome to the Download Time Estimator");
                Console.WriteLine("\nThis program calculates how long it will take to download a file with a 56k analog modem.");
          
                Console.Write("\nEnter a file size (MB): ");
                int fileSize = Convert.ToInt32(Console.ReadLine());

                int toSeconds = (int)((fileSize*1024)/5.2);
                float hours = (float)(toSeconds/3600.00);
                float minutes = (float)((toSeconds/3600.00)-Math.Truncate(hours)) *60;
                float seconds = (float)(minutes - Math.Truncate(minutes))*60;


                Console.WriteLine("\nA \"56k\" modem will take {0} hours {1} minutes {2} seconds", 
                    Math.Truncate(hours),
                    Math.Truncate(minutes),
                    Math.Truncate(seconds)
                    );

                Console.Write("\nContinue? (y/n) ");
                string willContinue = Console.ReadLine();
                if (willContinue == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }

        static void Number4()
        {
            Console.Write("Enter square size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
            static void Main(string[] args)
        {
            //Number1();
            Number2();
            //Number3();
            //Number4();
        }
    }
}
