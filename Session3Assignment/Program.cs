using System.ComponentModel;

namespace Session3Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1-Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            int num = int.Parse(Console.ReadLine());
            if (num % 3 == 0 && num % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
                Console.WriteLine("No");
            #endregion
            
            #region Q2-Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            int number = int.Parse(Console.ReadLine());
            if (number >= 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }

            #endregion
            
            #region Q3- Write a program that takes 3 integers from the user then prints the max element and the min element.
            int x = int.Parse(Console.ReadLine()), y = int.Parse(Console.ReadLine())
            , z = int.Parse(Console.ReadLine());

            #region Max
            if (x >= y && x >= z)
            {
                Console.WriteLine($"Max Num = {x}");
            }
            else if (y >= z && y >= z)
            {
                Console.WriteLine($"Max Num =  {y}");
            }
            else
            {
                Console.WriteLine($"Max Num = {z} ");
            }
            //using max function
            int MaxNum = Math.Max(x, Math.Max(y, z));
            Console.WriteLine($"Max Num = {MaxNum}");
            #endregion
            #region Min
            if (x <= y && x <= z)
            {
                Console.WriteLine($"Min Number = {x}");
            }
            else if (y <= z && y <= z)
            {
                Console.WriteLine($"Min Number ={y}");
            }
            else
            {
                Console.WriteLine($"Min Number = {z}");
            }
            //using min function
            int MinNum = Math.Min(x, Math.Min(y, z));
            Console.WriteLine($"Min Number = {MinNum}");
            #endregion

            #endregion
            
            #region Q4 - Write a program that allows the user to insert an integer number then check If a number is even or odd.
            int EvenOrOdd = int.Parse(Console.ReadLine());
            if (EvenOrOdd % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            #endregion
            
            #region Q5-Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            char Vowel = char.Parse(Console.ReadLine());
            if (Vowel == 'e' || Vowel == 'o' || Vowel == 'I' || Vowel == 'a' || Vowel == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("consonant");
            }
            #endregion
            
            #region Q6-- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i);
            }

            #endregion

            #region Q7-Write a program that allows the user to insert an integer then  print a multiplication table up to 12.
            int M = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(M * i);

            }
            #endregion

            #region Q8-Write a program that allows to user to insert number then print all even numbers between 1 to this number
            int Evens = int.Parse(Console.ReadLine());
            for (int i = 1; i <= Evens; i++)
            {
                if (i % 2 == 0)
                { Console.WriteLine(i); }
            }
            #endregion

            #region Q9-Write a program that takes two integers then prints the power.
            int Fnum = int.Parse(Console.ReadLine()), Lnum = int.Parse(Console.ReadLine());
            int Count = 1, result = 1;
            while (Count <= Lnum)
            {
                result *= Fnum;

                Count++;
            }
            Console.WriteLine(result);
            #endregion

            #region Q10-- Write a program to enter marks of five subjects and calculate total, average and percentage.
            int s1 = int.Parse(Console.ReadLine()), s2 = int.Parse(Console.ReadLine()),
                s3 = int.Parse(Console.ReadLine()), s4 = int.Parse(Console.ReadLine()), s5 = int.Parse(Console.ReadLine());
            int Sum = s1 + s2 + s3 + s4 + s5;
            int Average = Sum / 5;
            int percentage = Average;
            Console.WriteLine($"Total marks = {Sum}");
            Console.WriteLine($"Average Marks =  {Average}");
            Console.WriteLine($"Pecentage =  {percentage}");
            #endregion

            #region Q11- Write a program to input the month number and print the number of days in that month.
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine($"Days in Month : {DateTime.DaysInMonth(2024, month)}");
            #endregion

            #region Q12-Write a program to create a Simple Calculator.

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} % {num2} = {num1 % num2}");

            #endregion

            #region Q13-Write a program to allow the user to enter a string and print the REVERSE of it.
            string str = Console.ReadLine();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            #endregion

            #region Q14 - Write a program to allow the user to enter int and print the REVERSED of it.

            int NumberToReverse = int.Parse(Console.ReadLine());
            string ReversedString = Convert.ToString(NumberToReverse);
            for (int i = ReversedString.Length - 1; i >= 0; i--)
            {
                Console.Write(ReversedString[i]);
            }

             #endregion

            //Q15 => is not founded
            #region Q16-Write a program in C# Sharp to convert a decimal number into binary without using an array.

            int BinaryNum = int.Parse(Console.ReadLine());
            string BinaryStr = "";
            int OriginalNum = BinaryNum;
            while (BinaryNum > 0)
            {
                if (BinaryNum % 2 == 0)
                    BinaryStr += "0";
                else
                    BinaryStr += "1";
                BinaryNum /= 2;


            }
            Console.Write($"The Binary of {OriginalNum} is ");
            for (int i = BinaryStr.Length - 1; i >= 0; i--)
            {
                Console.Write(BinaryStr[i]);
            }

            #endregion


            #region Q17-Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            int x1 = int.Parse(Console.ReadLine()),
             y1 = int.Parse(Console.ReadLine()),
             x2 = int.Parse(Console.ReadLine()),
             y2 = int.Parse(Console.ReadLine()),
             x3 = int.Parse(Console.ReadLine()),
             y3 = int.Parse(Console.ReadLine());

            int res = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);
            if (res == 0)
            {
                Console.WriteLine("Straight line Points");
            }
            else

            {
                Console.WriteLine("Not Straight line Points");
            }



            #endregion

            #region Q18
            int Hours = int.Parse(Console.ReadLine());
            if (Hours <= 3)
                Console.WriteLine("highly efficient");
            else if (Hours >= 3 && Hours <= 4)
                Console.WriteLine("are instructed to increase speed. ");
            else if (Hours >= 4 && Hours <= 5)
                Console.WriteLine("provided with training to enhance speed.");
            else
                Console.WriteLine("required to leave the company.");
            #endregion

        }

    }
}

