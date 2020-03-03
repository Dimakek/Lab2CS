using System;
using System.Collections.Generic;

namespace Lab2Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0, n = 0;
            Console.WriteLine("Number:155,625 -X");
            List<int> x = new List<int>() { 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 1, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Console.WriteLine("Number:20,5 -Y");
            List<int> y = new List<int>() { 0, 1, 0, 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Console.WriteLine("X number:");
            foreach (int p in x)
            {
                Console.Write(p);
            }
            Console.WriteLine("");
            Console.WriteLine("Y number");
            foreach (int p in y)
            {
                Console.Write(p);
            }
            Console.WriteLine("");
            int Sx = x[0];
            Console.WriteLine("Sign of x = " + x[0]);
            int Sy = y[0];
            Console.WriteLine("Sign of y = " + y[0]);
            List<int> expX = new List<int>() { x[1], x[2], x[3], x[4], x[5], x[6], x[7], x[8] };
            Console.WriteLine("exp of x:");
            foreach (int p in expX)
            {
                Console.Write(p);
            }
            Console.WriteLine("");
            Console.WriteLine("exp of y:");
            List<int> expY = new List<int>() { y[1], y[2], y[3], y[4], y[5], y[6], y[7], y[8] };
            foreach (int p in expY)
            {
                Console.Write(p);
            }
            Console.WriteLine("");
            List<int> mantisaX = new List<int>() { 1 };
            List<int> mantisaY = new List<int>() { 1 };
            List<int> resault = new List<int>();
            for (int q = 9; q < x.Count; q++)
            {
                mantisaX.Add(x[q]);
            }
            for (int q = 9; q < y.Count; q++)
            {
                mantisaY.Add(y[q]);
            }
            for (int t = 0; t < expX.Count; t++)
            {
                if (expX[t] > 0)
                {
                    n += (int)Math.Pow(2, (expX.Count - 1 - t));
                }

                if (expY[t] > 0)
                {
                    m += (int)Math.Pow(2, (expY.Count - 1 - t));
                }
            }
            n = n - 127;
            m = m - 127;
            int z = 0;
            if (n > m)
            {
                z = n - m;
                m = n;
                for (int l = 0; l < z; l++)
                {
                    for (int k = 0; k < mantisaY.Count ; k++)
                    {
                        if (k == mantisaY.Count - 1) mantisaY[mantisaY.Count - 1 - k] = 0;
                        else mantisaY[mantisaY.Count - 1 - k] = mantisaY[mantisaY.Count - 2 - k];
                    }
                }


            }
            if (n < m)
            {
                z = m - n;
                n = m;
                for (int l = 0; l < z; l++)
                {
                    for (int k = 0; k < mantisaX.Count; k++)
                    {
                        mantisaX[mantisaX.Count - 1 - k] = mantisaX[mantisaX.Count - 2 - k];
                    }
                }

            }
            Console.WriteLine("Aligned:");
            foreach (int p in mantisaX)
            {
                Console.Write(p);
            }
            Console.WriteLine("");
            foreach (int p in mantisaY)
            {
                Console.Write(p);
            }
            Console.WriteLine("");
            List<int> plussum = new List<int>();
            int c = 0;
            for (int r = 0; r < mantisaY.Count; r++)
            {

                int k;
                k = mantisaX[mantisaX.Count - 1 - r] + mantisaY[mantisaY.Count - 1 - r] + c;
                if (k == 0) plussum.Add(0);
                if (k == 1) { plussum.Add(1); c = 0; }
                if (k == 2) { plussum.Add(0); c = 1; }
                if (k == 3) { plussum.Add(1); c = 1; }

            }
            if (c == 1) plussum.Add(1);
            List<int> result = new List<int>();
            for (int i = 0; i < plussum.Count; i++)
            {
                result.Add(plussum[plussum.Count - 1 - i]);
            }
            Console.WriteLine("---------------------------------------------------------------------------------------");
            foreach (int p in result)
            {
                Console.Write(p);
            }
            Console.WriteLine("");
            List<int> exp = new List<int>();
            exp = Todouble(n + 127);
            if (Sx == Sy) resault.Add(0);
            foreach(int p in exp)
            {
                resault.Add(p);
            }
            for(int u =1;u<result.Count;u++)
            {
                resault.Add(result[u]);
            }
            Console.WriteLine("final resault:");
            for (int p= 0;p < resault.Count;p++)
            {
                if (p == 1 | p == 9) Console.Write(" ");
                Console.Write(resault[p]);
                
            }
            Console.WriteLine("\nS Exponent       Masntisa");
            Console.WriteLine("Resault = 176,125");
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
