using System;
using System.Collections.Generic;

namespace Lab2Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberOne = new List<int>();
            List<int> numberTwo = new List<int>();
            List<int> result = new List<int>();
            List<int> reminder = new List<int>();
            List<int> reminderfordiff = new List<int>();
            int a, b, w, n = 0, m = 0;
            Console.WriteLine("Enter divisor number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter dividand number:");
            b = Convert.ToInt32(Console.ReadLine());
            numberOne = Todouble(a);
            numberTwo = Todouble(b);
            Console.WriteLine("The divisor number in (2):");
            foreach (int i in numberOne)
            {
                Console.Write(i);
            }
            Console.WriteLine("\nThe dividand number in (2):");
            foreach (int i in numberTwo)
            {
                Console.Write(i);
            }
            Console.WriteLine("\n");
            w = numberTwo.Count;
            for (int u = 0; u < w * 2; u++)
            {
                if (u < numberTwo.Count) reminder.Add(0); else reminder.Add(numberTwo[u - numberTwo.Count]);
            }
            Console.WriteLine("reg:");
            foreach (int i in reminder)//register
            {
                Console.Write(i);
            }
            Console.WriteLine("");
            for (int y = 0; y < reminder.Count / 2; y++)
            {
                reminderfordiff.Clear();
                for (int o = 0; o < reminder.Count; o++)
                {
                    if (o < reminder.Count - 1)
                        reminder[o] = reminder[o + 1];
                    else reminder[o] = 2;
                }
                Console.WriteLine("shift:");
                foreach (int i in reminder)//shift
                {
                    Console.Write(i);
                }
                Console.WriteLine("");
                for (int p = 0; p < reminder.Count / 2; p++)
                {
                    reminderfordiff.Add(reminder[p]);
                }
                n = 0;
                m = 0;
                for (int t = 0; t < reminderfordiff.Count; t++)
                {
                    if (reminderfordiff[t] > 0)
                    {
                        n += (int)Math.Pow(2, (reminderfordiff.Count - 1 - t));
                    }
                    if (t < numberOne.Count - 1)
                    {
                        if (numberOne[t] > 0)
                        {
                            m += (int)Math.Pow(2, (numberOne.Count - 1 - t));
                        }
                    }

                }
                if ((n - m) == m) { result.Add(0); break; }
                else
                {
                    if ((n - m) >= 0)
                    {
                        result.Add(1);
                        reminder[reminder.Count - 1] = 1;
                    }
                    else { result.Add(0); reminder[reminder.Count - 1] = 0; }
                }
            }
           
            Console.WriteLine("Resault:");
            foreach (int i in result)
            {
                Console.Write(i);
            }
	    Console.ReadLine();

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
                while (number.Count < 4)
                {
                    number.Add(0);
                }
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
