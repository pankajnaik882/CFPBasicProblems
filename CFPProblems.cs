using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CFPbasicProblems
{
    public class CFPProblems
    {
        public static void PrintNames()
        {
            Console.WriteLine("-------FRIENDS' NAMES-------");
            Console.WriteLine("Guruprasad");
            Console.WriteLine("Kush");
            Console.WriteLine("Siddhart");
            Console.WriteLine("Sagar");
            Console.WriteLine("Krishna");
        }

        public static void Prompt2Numbers()
        {
            Console.WriteLine("Input 2 Numbers To Perform Arithematic Task");
            Console.WriteLine("Enter First Number (either Decimal)");
            decimal dec1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number (either Decimal)");
            decimal dec2 = decimal.Parse(Console.ReadLine());

            decimal sum = dec1+ dec2;
            decimal squaresum = sum * sum;
            Console.WriteLine($"Square of Sum of both the Numbers is {squaresum}");

            decimal diff = dec1 - dec2;
            decimal squarediff = diff * diff; 
            Console.WriteLine($"Square of Difference of both the Numbers is {squarediff}");
        }

        public static void PlaceName()
        {
            Console.WriteLine("Enter your Favourite Placename");
            string PlaceName = Console.ReadLine();

            if (Regex.IsMatch(PlaceName, @"^[a-z A-Z]+$"))
            {
                Console.WriteLine("-------------------------------------------");
                string upperstr = PlaceName.ToUpper();
                Console.WriteLine($"String converted in Uppercase : {upperstr}");
                string lowerstr = PlaceName.ToLower();
                Console.WriteLine($"String converted in Lowercase : {lowerstr}");
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }     
        }

        public static void PrintTenTimes()
        {
            Console.WriteLine("Enter A Number");
            string MyNum = Console.ReadLine();

            if (Regex.IsMatch(MyNum, @"^[0-9]+$"))
            {
                for (int i=1; i <=10; i++)
                {
                    Console.WriteLine($"{i}.{MyNum}");
                }
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }
        }

        public static void PersonFullName()
        {
            Console.WriteLine("ENTER YOUR FULL NAME CREDENTIALS");

            Console.WriteLine("Do you have Middle Name? (yes/no)");
            string ques1 = Console.ReadLine();
            string ans1 = ques1.ToLower();

            if (ans1 == "yes")
            {
                Console.WriteLine("Enter your First Name");
                string firstname = Console.ReadLine();
                Console.WriteLine("Enter Your Middle Name");
                string middlename = Console.ReadLine();
                Console.WriteLine("Enter your Last Name");
                string Lastname = Console.ReadLine();

                Console.WriteLine($"There are 3 Parts in your Full Name");
                Console.WriteLine($"Your Full Name : {firstname} {middlename} {Lastname}");
            }
            else if (ans1== "no")
            {
                Console.WriteLine("Enter your First Name");
                string firstname = Console.ReadLine();
                Console.WriteLine("Enter your Last Name");
                string Lastname = Console.ReadLine();

                Console.WriteLine($"There are 2 Parts in your Full Name");
                Console.WriteLine($"Your Full Name : {firstname} {Lastname}");
            }

            else
            {
                Console.WriteLine("Wrong Input");
            }
        } 


        public static void RandomNumbers()
        {
            Random rand = new Random();
            int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                numbers[i] = rand.Next(10, 50);
            }

            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += numbers[i];
            }

            double average = sum / 5;
            Console.WriteLine("Random Generated numbers: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{numbers[i]}");
            }
            Console.WriteLine("Average of the numbers is : " + average);
        }

        public static void Circle() 
        {
            Console.Write("Enter the diameter of the circle: ");
            double diameter = double.Parse(Console.ReadLine());

            double radius = diameter / 2;
            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;

            Console.WriteLine("Perimeter of circle: " + perimeter);
            Console.WriteLine("Area of circle: " + area);
        }

        public static void YearAddition()
        {
            Console.Write("Input a year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Input a month [1-12]: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Input a day [1-31]: ");
            int day = int.Parse(Console.ReadLine());

            if (day < 31)
            {
                day++;
            }
            else if (month == 2 && day == 28 && DateTime.IsLeapYear(year))
            {
                day = 29;
            }
            else if (month == 2 && day == 28)
            {
                day = 1;
                month = 3;
            }
            else if ((month == 4 || month == 6 || month == 9 || month == 11) && day == 30)
            {
                day = 1;
                month++;
            }
            else if (day == 31 && month == 12)
            {
                day = 1;
                month = 1;
                year++;
            }
            else
            {
                day = 1;
                month++;
            }

            Console.WriteLine("The next date is [yyyy-mm-dd] " + year + "-" + month + "-" + day);
        }

        public static void TimeElapsed() 
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int sum = 0;
            for (int i = 1; i <= 1000000; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum of numbers from 1 to 1000000: " + sum);

            stopwatch.Stop();
            Console.WriteLine("Execution time: " + stopwatch.Elapsed);
        }

        public static void DivisibleSeven()
        {
            for (int i = 2000; i <= 3200; i++)
            {
                if (i % 7 == 0 && i % 5 != 0)
                {
                    Console.Write(i + ",");
                }
            }
        }

        public static int ComputeFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * ComputeFactorial(n - 1);
            }
        }

        public static void PrintNumber(int n)
        {
            if (n <= 100)
            {
                Console.WriteLine(n);
                PrintNumber(n + 1);
            }
        }

        public static void PlingPlangPlong()
        {
            int number = 11;
            string result = "";

            if (number % 3 == 0)
            {
                result += "Pling";
            }
            if (number % 5 == 0)
            {
                result += "Plang";
            }
            if (number % 7 == 0)
            {
                result += "Plong";
            }
            if (result == "")
            {
                result = number.ToString();
            }
            Console.WriteLine(result);
        }

        public static void AndOrOperators()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            bool hasA = false, hasE = false, hasP = false;

            foreach (char c in input)
            {
                if (c == 'a')
                {
                    hasA = true;
                }
                if (c == 'e')
                {
                    hasE = true;
                }
                if (c == 'p')
                {
                    hasP = true;
                }
            }

            if (hasA && hasE && hasP)
            {
                Console.WriteLine("All Present");
            }
            else if (hasA || hasE || hasP)
            {
                Console.WriteLine("One or more - Present");
            }
            else
            {
                Console.WriteLine("None Present");
            }
        }

        public static void FloatArray()
        {
            float[] numbers = { 3.14f, 2.5f, 1.6f, 5.0f, 0.5f };

            float sum = 0;
            foreach (float number in numbers)
            {
                sum += number;
            }

            float average = sum / numbers.Length;

            Console.WriteLine("The average of the numbers is: " + average);
        }

        public static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
             for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static void ArraySwap()
        {
            int[] arr = { 12, 0, 42, 0, 4 };
            Console.Write("Present Array is : ");
            foreach (int number in arr)
            {   
                Console.Write(number + " ");
            }
            int n = arr.Length;

            int j = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] != 0)
                {
                    int temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                    j++;
                }
            }

            for (int i = j; i < n; i++)
            {
                arr[i] = 0;
            }

            Console.Write("\n Array After Swapping : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        public static void FirstRepeatedarray()
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] myarr = {20,30,40,30,40,10,60};
            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < n; i++)
            {
                myarr[i] = int.Parse(Console.ReadLine());
            }

            int repeated = 0;
            for(int i =0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (myarr[i] == myarr[j])
                    {
                        repeated =  myarr[i];
                        break;
                    }
                }
            }

            if (repeated == 0)
            {
                Console.WriteLine("There are no repeated elements in the array.");
            }
            else
            {
                Console.WriteLine($"The first repeated element in the array is {repeated}.");
            }
        }

        public static void QuadExpression()
        {
            Console.Write("Enter the value of a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the value of b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the value of c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("The roots are real and distinct.");
                Console.WriteLine("Root 1: " + root1);
                Console.WriteLine("Root 2: " + root2);
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine("The roots are real and equal.");
                Console.WriteLine("Root: " + root);
            }
            else
            { 
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
                Console.WriteLine("The roots are complex and conjugate.");
                Console.WriteLine("Root 1: " + realPart + " + " + imaginaryPart + "i");
                Console.WriteLine("Root 2: " + realPart + " - " + imaginaryPart + "i");
            }
        }

        public static void LongestSubstring()
        {
            string name = "ABDEFGABEF";
            char[] ch = name.ToCharArray();
            int i = 0;
            int j = 0;
            int temp = 0;
            for (i = 0; i < ch.Length - 1; i++)
            {
                char c = ch[i];
                int count = 0;
                for (j = i + 1; j < ch.Length; j++)
                {
                    if (c != ch[j] || c == ch[j])
                    {
                        Console.Write($"{ch[j]}");
                        count++;
                        temp = count;
                    }
                    if (c == ch[j])
                    {
                        break;
                    }
                }
                Console.WriteLine($": {count}");
            }
        }


        public static void ArrayDelete() 
        {
            Console.Write("Input the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            Console.WriteLine("Input " + size + " elements in the array in ascending order:");
            for (int i = 0; i < size; i++)
            {
                Console.Write("element - " + (i+1) + " : ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Input the position where to delete: ");
            int position = int.Parse(Console.ReadLine());
 
            if (position >= 1 && position <= size)
            {
                for (int i = position - 1; i < size - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                Array.Resize(ref arr, size - 1);

                Console.Write("The new list is : ");
                foreach (int element in arr)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid position!");
            }
        }

        public static void SecondLargestArray()
        {
            Console.Write("Input the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            Console.WriteLine("Input " + size + " elements in the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write("element - " + (i+1) + " : ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int max = arr[0];
            int secondMax = arr[0];
            for (int i = 1; i < size; i++)
            {
                if (arr[i] > max)
                {
                    secondMax = max;
                    max = arr[i];
                }
                else if (arr[i] > secondMax && arr[i] < max)
                {
                    secondMax = arr[i];
                }
            }

            Console.WriteLine("The Second largest element in the array is: " + secondMax);

        }

        public static void ArrayDupRemove() 
        {
            Console.WriteLine("Original array elements:");
            object[] arr = { 25, "Anna", false, 25, 112.22, "Anna", false };
            foreach (object element in arr)
            {
                Console.WriteLine(element);
            }

            
            int len = arr.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (arr[i].Equals(arr[j]))
                    {
                        for (int k = j; k < len - 1; k++)
                        {
                            arr[k] = arr[k + 1];
                        }
                        len--;
                        j--;
                    }
                }
            }

            object[] newArr = new object[len];
            Array.Copy(arr, newArr, len);

            Console.WriteLine("\nAfter removing duplicate elements from the said array:");
            foreach (object element in newArr)
            {
                Console.WriteLine(element);
            }
        }

        public static void SmallestGapArray()
        {
            int[] numbers = { 70, 50, 20, 30, 11, 23, 18 };

            Array.Sort(numbers);
            int smallestGap = int.MaxValue; 
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int gap = numbers[i + 1] - numbers[i];
                if (gap < smallestGap)
                {
                    smallestGap = gap;
                }
            }

            Console.WriteLine("The smallest gap between numbers is {0}", smallestGap);
        }

        public static void DaysTOYMW()
        {
            Console.Write("Enter the number of days: ");
            int totalDays = int.Parse(Console.ReadLine());

            int years = totalDays / 365;
            int remainingDays = totalDays % 365;
            int months = remainingDays / 30;
            remainingDays %= 30;
            int weeks = remainingDays / 7;

            Console.WriteLine($"Years: {years}");
            Console.WriteLine($"Months: {months}");
            Console.WriteLine($"Weeks: {weeks}");
        }

        public static void Sqrt() 
        {
            Console.Write("Enter the Perfect Square : ");
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = number; i >= 0; i--)
            {
                if (i*i == number)
                {
                    Console.WriteLine($"Square Root of {number} is {i} ");
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Entered number is not a perfect square");
            }
            
        }


        public static void PrimeInRange()
        {
            Console.WriteLine("Prime numbers between 1 and 100 are:");
            for (int i = 2; i <= 100; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }
        }

        

    }
}
