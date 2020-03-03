using System;
using System.Collections.Generic;


namespace Lab2
{
    class Program
    {
        public static void Main()
        {
            List<int> numberOne = new List<int>();
            List<int> numberTwo = new List<int>();
            List<int> sum = new List<int>();
            List<int> numberOdin = new List<int>();
            List<int> numberDva = new List<int>();
            List<int> plussum = new List<int>();

            int a, b,j,n,m=0;
            Console.WriteLine("Enter first number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            b = Convert.ToInt32(Console.ReadLine());
            numberOne = Todouble(a);
            numberTwo = Todouble(b);
            Console.WriteLine("The first number in (2):");
            foreach (int i in numberOne)
            {
                Console.Write(i);
            }
            Console.WriteLine("\nThe second number in (2):");
            foreach (int i in numberTwo)
            {
                Console.Write(i);
            }
            Console.WriteLine("\n");
            for (int i = 0; i < numberTwo.Count; i++)
            {
                for (int z = 10; i < z; z--) { Console.Write(" "); }
                if (numberTwo[numberTwo.Count -1- i] == 1)
                {
                    if (i == 0)
                    {
                        foreach (int x in numberOne)
                        {
                            sum.Add(x);
                        }
                    }
                    else
                    {
                        j = i;
                        numberDva.Clear();
                        numberOdin.Clear();
                        plussum.Clear();
                        foreach (int x in sum)
                        {
                            numberOdin.Add(x);
                        }
                        foreach (int x in numberOne)
                        {
                            numberDva.Add(x);
                        }
                        while (j > 0)
                        {
                            numberDva.Add(0);
                            j--;
                        }
                        for (j = 0; j < numberDva.Count; j++)
                        {
                            if ((numberOdin.Count - 1 - j) >= 0)
                            {
                                n = numberOdin[numberOdin.Count - 1 - j] + numberDva[numberDva.Count - 1 - j] + m;
                                if (n == 0) plussum.Add(0);
                                if (n == 1) { plussum.Add(1); m = 0; }
                                if (n == 2) { plussum.Add(0); m = 1; }
                                if (n == 3) { plussum.Add(1); m = 1; }
                            }
                            else
                            {
                                if (m == 1)
                                {
                                    n = numberDva[numberDva.Count - 1 - j] + m;
                                    if (n == 2) { plussum.Add(0); m = 1; }
                                    if (n == 1) { plussum.Add(1); m = 0; }

                                }
                                else
                                {
                                    plussum.Add(numberDva[numberDva.Count - 1 - j]);
                                }
                            }

                        }
                        if (m == 1) {plussum.Add(1); m = 0; }
                        sum.Clear();
                        for (int g = 0; g < plussum.Count; g++)
                        {
                            sum.Add(plussum[plussum.Count - g - 1]);
                        }

                    }
                    foreach (int number in numberOne)
                    {
                        Console.Write(number);
                    }
                    Console.Write("    Sum = ");
                    foreach (int p in sum)
                    {
                        Console.Write(p);
                    }
                }
                else
                {

                    sum.Insert(0, 0);
                    foreach (int k in numberOne)
                    {
                        Console.Write("0");
                    }
                    Console.Write("    Sum = ");
                    foreach (int p in sum)
                    {
                        Console.Write(p);
                    }
                }
                Console.WriteLine("");

            }
        }
        public static List<int> Todouble(int a)
        {
            List<int> number = new List<int>();
            List<int> numberPos = new List<int>();
            int k;
            if (a > 0)
            {
                for (int i = 0; a > 1; i++)
                {
                    k = a % 2;
                    a = a / 2;
                    number.Add(k);
                }
                if (a == 1) number.Add(1);
                if (a == 0) number.Add(0);
                for (int i = 0; i < number.Count; i++)
                {
                    numberPos.Add(number[number.Count - i - 1]);
                }
                return numberPos;
            }
            else
            {
                return number;
            }
        }
    }
}
