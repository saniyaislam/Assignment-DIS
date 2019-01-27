using System;

namespace Assignment1_S19
{
    class Program
    {
        public static void Main()
        {
            int a = 5, b = 15;
            printPrimeNumbers(a, b);

            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("The sum of the series is: " + r1);


            long n2 = 15;
            long r2 = decimalToBinary(n2);
            Console.WriteLine("Binary conversion of the decimal number " + n2 + " is: " + r2);


            long n3 = 1111;
            long r3 = binaryToDecimal(n3);
            Console.WriteLine("Decimal conversion of the binary number " + n3 + " is: " + r3);


            int n4 = 5;
            printTriangle(n4);

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);
            Console.ReadLine();

            // write your self-reflection here as a comment
            //This was a good excercise for brushing up our basics. 
            //These programs helped us to understand the logic which will help us in future understanding of the course.

        }

        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                int i;
                Console.WriteLine("Prime nos between" + x + " and " + y + " are:");
                for (i = x; i <= y; i++)    //iterating through the loop
                {
                    isPrime(i);   //calling the isPrime function
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
        }
        public static void isPrime(int n)
        {
            int k;
            k = 0;
            for (int i = 1; i <= n; i++)            //iterating through the loop
            {
                if (n % i == 0)            //checking if no is divisible by any other no.
                {
                    k++;                  //increasing the counter
                }
            }

            if (k == 2)
            {
                Console.WriteLine("{0}", n);
            }

        }

        public static double getSeriesResult(int n)
        {
            double sum = (double)1 / (double)2;
            double fact = 1;
            try
            {
                for (double i = 2; i <= n; i++)        //iterating through the loop
                {
                    fact = (factorial(i));
                    if (i % 2 == 0)
                    {
                        sum -= (fact / (i + 1));         //calculating series in odd and even places
                    }
                    else
                    {
                        sum += fact / (i + 1);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return sum;
        }
        static double factorial(double i)
        {
            double fact = 1;
            for (double j = 1; j <= i; j++)        //iterating through the loop
            {
                fact = fact * j;                   //calculating factorial
            }
            return fact;

        }

        public static long decimalToBinary(long n)
        {
            string binary = "";
            long rem = 0;
            try
            {
                while (n != 0)
                {
                    rem = n % 2;                        //calculating the rem
                    binary = rem + binary;              //adding remainder to binary
                    n = n / 2;                         //dividing the no by 2
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            }
            return Convert.ToInt64(binary);
        }

        public static long binaryToDecimal(long n)
        {
            long decValue = 0, baseVal = 1, rem;
            try
            {
                while (n > 0)
                {
                    rem = n % 10;                         //taking  the value in unit digit place
                    decValue = decValue + rem * baseVal;  //calculating the decimal value
                    n = n / 10;
                    baseVal = baseVal * 2;               //multiplying basevalue by 2
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }

            return decValue;
        }

        public static void printTriangle(int n)
        {
            try
            {
                int i, j, k;
                for (i = 1; i <= n; i++)
                {

                    int numberOfStars = (i * 2) - 1;
                    int numberOfSpaces = n - i;

                    for (j = 1; j <= n - i; j++)        //iterating through the loop
                    {
                        Console.Write(" ");             //printing spaces one less than the no of rows
                    }

                    for (k = 1; k <= numberOfStars; k++)        //iterating through the loop
                    {
                        Console.Write("*");         //printing stars as no of rows
                    }

                    Console.WriteLine("");
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static void computeFrequency(int[] a)
        {
            try
            {
                int n = a.Length;

                Boolean[] b = new Boolean[n];
                Console.WriteLine("Computed Frequency is:");
                for (int i = 0; i < n; i++)
                {
                    if (b[i] == true)
                        continue;
                    int counter = 1;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (a[i] == a[j])   //if array value matches other value
                        {
                            b[j] = true;     //make boolean value true
                            counter++;     //increase the counter
                        }

                    }
                    Console.WriteLine(a[i] + "  :  " + counter);
                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");

            }
        }
    }
}

