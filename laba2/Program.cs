using System;

namespace Laba2
{
    public class Program
    {
        static void Main()
        {
            Program p = new Program();
            string task;
            do
            {
                Console.WriteLine("\nWhat task do you need?\nPrint '0' to exit.");
                task = Console.ReadLine();
                switch (task)
                {
                    case "0": break;
                    case "1": p.first(); break;
                    case "2": p.second(); break;
                    case "3": p.third(); break;
                    case "5": p.fifth(); break;
                    default: Console.WriteLine("Try again. (tasks '1', '2', '3', '5' are available and '0' to exit)"); break;
                }
            } while (task != "0");

        }
        public void first()
        {
            Console.WriteLine("\n\t\t1\n\n");
            bool ok;
            Console.WriteLine("Enter the number in students list:");
            do
            {
                ok = true;
                string index = Console.ReadLine();
                switch (index)
                {
                    case "1": Console.WriteLine("Oleksyuk"); break;
                    case "2": Console.WriteLine("Kolysnyuk"); break;
                    case "3": Console.WriteLine("Dudych"); break;
                    case "4": Console.WriteLine("Dub"); break;
                    case "5": Console.WriteLine("Kvas"); break;
                    case "6": Console.WriteLine("Ivanyk"); break;
                    case "7": Console.WriteLine("Tarasiv"); break;
                    case "8": Console.WriteLine("Dzurba"); break;
                    case "9": Console.WriteLine("Stadnyk"); break;
                    case "10": Console.WriteLine("Romanko"); break;
                    default: ok = false; break;

                }
                if (ok == false) Console.WriteLine("Try another number. (1-10)");
            } while (ok == false);
            Console.WriteLine("_____________________________________________________\n");
        }
        public void second()
        {
            Console.WriteLine("\n\n\n\t\t2\n\n");

            double a = 1, b = 6, dx = 0.2, y;
            double x = a;
            Console.WriteLine("_____________________________________________________");
            Console.WriteLine("\tx \t\t|\t\t y = f(x)");
            Console.WriteLine("_____________________________________________________\n");
            do
            {
                y = Math.Log(x, 10);
                var vx = Convert.ToSingle(x);
                var vy = Convert.ToSingle(y);
                Console.WriteLine("\t{0} \t\t|\t\t {1}\n", vx, vy);
                x += dx;
            } while (x <= b);
            Console.WriteLine("_____________________________________________________\n");
        }
        public void third()
        {
            Console.WriteLine("\n\n\n\t\t3\n\n");

            int e = 0;
            bool el = false;
            Console.WriteLine("How many elements do you need?");
            while (el == false)
            {
                e = int.Parse(Console.ReadLine());
                if ((e > 1) & ((e % 1) == 0)) el = true;
                else Console.WriteLine("Try again.");
            }
            int[] a = new int[e];
            bool check = true;
            for (int i = 0; i < e; i++)
            {
                Console.WriteLine("Enter {0:G} number.", i + 1);
                do
                {
                    a[i] = int.Parse(Console.ReadLine());
                    if ((a[i] % 1) == 0) check = false;
                } while (check);
            }
            int sum = 0;
            bool st = false;
            bool art = false;
            int max = int.MinValue;
            for (int i = 0; i < e; i++)
            {
                if ((a[i] > 0) && !st) st = true;
                else if (a[i] > 0) art = true;
                else if (!art&&st) sum += a[i];
                if (a[i] > max) max = a[i];
            }
            if (!art) sum = 0;
            Console.WriteLine("The maximum number equals " + max + ".");
            Console.WriteLine("The sum of elements located between the 1st and the 2nd number equals " + sum + ".\n");
            Console.WriteLine("\n___________________________________RANDOM_____________________________________\n");
            Random aRand = new Random();
            int[] b = new int[e];
            for (int i = 0; i < e; i++)
            {
                b[i] = aRand.Next(-100, 100);
                Console.WriteLine("{0:G} number is {1:G}.", i + 1, b[i]);
            }
            sum = 0;
            st = false;
            art = false;
            max = int.MinValue;
            for (int i = 0; i < e; i++)
            {
                if ((b[i] > 0) && !st) st = true;
                else if (b[i] > 0) art = true;
                else if (!art && st) sum += b[i];
                if (b[i] > max) max = b[i];
            }
            if (!art) sum = 0;
            Console.WriteLine("The maximum number equals " + max + ".");
            Console.WriteLine("The sum of elements located between the 1st and the 2nd number equals " + sum + ".\n");
            Console.WriteLine("______________________________________________________________________________\n");
        }
        public void fifth()
        {
            Console.WriteLine("\n\n\n\t\t5\n\n");
            int n = 0;
            int m = 0;
            bool el = false;
            Console.WriteLine("How many rows do you need?");
            while (el == false)
            {
                n = int.Parse(Console.ReadLine());
                if ((n >= 1) & ((n % 1) == 0)) el = true;
                else Console.WriteLine("Try again.");
            }
            Console.WriteLine("How many columns do you need?");
            el = false;
            while (el == false)
            {
                m = int.Parse(Console.ReadLine());
                if ((m >= 1) & ((m % 1) == 0)) el = true;
                else Console.WriteLine("Try again.");
            }
            int[,] A = new int[n, m];
            bool check = true;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    Console.WriteLine("Enter A[{0:G}, {1:G}]", (i + 1), (j + 1));
                    do
                    {
                        A[i, j] = int.Parse(Console.ReadLine());
                        if ((A[i, j] % 1) == 0) check = false;
                    } while (check);
                }
            }
            int mat = int.MinValue;
            int o = 0;
            int p = 0;
            int k = 0;
            int h = 0;
            int max = int.MinValue;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        o = i;
                        p = j;
                    }
                }
            }
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if ((A[i, j] > mat)&&(i != o)&&(j!=p))
                    { 
                        mat = A[i, j];
                        k = i;
                        h = j;
                    }
                }
            }
            A[o, p] = 0;
            A[k, h] = 0;
            Console.Write("\n");
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    Console.Write(A[i, j]);
                    Console.Write("\t");
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n___________________________________RANDOM_____________________________________\n");
            Random aRand = new Random();
            int[,] B = new int[n, m];
            check = true;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    B[i, j] = aRand.Next(-100, 100);
                    Console.WriteLine("A[{0:G}, {1:G}] = {2:G}.", (i + 1), (j + 1), B[i, j]);
                }
            }
            mat = int.MinValue;
            o = 0;
            p = 0;
            k = 0;
            h = 0;
            max = int.MinValue;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (B[i, j] > max)
                    {
                        max = B[i, j];
                        o = i;
                        p = j;
                    }
                }
            }
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if ((B[i, j] > mat) && (i != o) && (j != p))
                    {
                        mat = B[i, j];
                        k = i;
                        h = j;
                    }
                }
            }
            B[o, p] = 0;
            B[k, h] = 0;
            Console.Write("\n");
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    Console.Write(B[i, j]);
                    Console.Write("\t");
                }
                Console.Write("\n");
            }
            Console.WriteLine("______________________________________________________________________________\n");
        }
        public static int maxa(int e, int[] a)
        {
            int max = int.MinValue;
            for (int i = 0; i < e; i++)
            {
                if (a[i] > max) max = a[i];
            }
            return max;
        }
        public static int sum_of(int e, int[] a)
        {
            int sum = 0;
            bool st = false;
            bool art = false;
            for (int i = 0; i < e; i++)
            {
                if ((a[i] > 0) && !st) st = true;
                else if (a[i] > 0) art = true;
                else if (!art) sum += a[i];
            }
            return sum;

        }
    }
}
