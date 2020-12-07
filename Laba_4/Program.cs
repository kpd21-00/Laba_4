using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch time = new Stopwatch();
            TimeSpan timer;
            int N = 1000000;
            int[] numbers = new int[N];
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                numbers[i] = rand.Next(-8000, 8000);
            }
            foreach (int n in numbers)
                Console.Write(n + " ");
            Console.WriteLine();

            //LINQ

            Console.WriteLine("\n"+"LINQ");

            //   1.	Найти все четные числа
            time.Restart();
            int[] nums1 = numbers.Where(s => s % 2 == 0).OrderBy(s => s).ToArray();
            time.Stop();
            timer = time.Elapsed;
            Console.WriteLine(Convert.ToString(timer.TotalMilliseconds));
            if(nums1.Length < 10)
                for (int i = 0; i < nums1.Length; i++)
                {
                    Console.Write(nums1[i] + " ");
                }
            else
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(nums1[i] + " ");
                }
            Console.WriteLine();

            //   2.	Найти все нечётные числа
            time.Restart();
            int[] nums2 = numbers.Where(s => s % 2 != 0).OrderBy(s => s).ToArray();
            time.Stop();
            timer = time.Elapsed;
            Console.WriteLine(Convert.ToString(timer.TotalMilliseconds));
            if (nums2.Length < 10)
                for (int i = 0; i < nums2.Length; i++)
                {
                    Console.Write(nums2[i] + " ");
                }
            else
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(nums2[i] + " ");
                }
            Console.WriteLine();

            //   3.	Найти все числа, сумма первой и последней цифры которых равна 6
            time.Restart();
            int[] nums3 = numbers.Select(s => Convert.ToString(s)).Where(s => Convert.ToInt32(s.First()) + Convert.ToInt32(s.Last()) == 6).Select(s => Convert.ToInt32(s)).OrderBy(s => s).ToArray();
            time.Stop();
            timer = time.Elapsed;
            Console.WriteLine(Convert.ToString(timer.TotalMilliseconds));
            if (nums3.Length < 10)
                for (int i = 0; i < nums3.Length; i++)
                {
                    Console.Write(nums3[i] + " ");
                }
            else
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(nums3[i] + " ");
                }
            Console.WriteLine();

            //   4.	Найти все числа, содержащие комбинацию цифр: 666
            time.Restart();
            int[] nums4 = numbers.Select(s => Convert.ToString(s)).Where(s => s.IndexOf("666") > -1).Select(s => Convert.ToInt32(s)).OrderBy(s => s).ToArray();
            timer = time.Elapsed;
            Console.WriteLine(Convert.ToString(timer.TotalMilliseconds));
            if (nums4.Length < 10)
                for (int i = 0; i < nums4.Length; i++)
                {
                    Console.Write(nums4[i] + " ");
                }
            else
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(nums4[i] + " ");
                }
            Console.WriteLine();


           
            
            //PLINQ

            Console.WriteLine("\n" + "PLINQ");

            //   1.	Найти все четные числа
            time.Restart();
            int[] nums11 = numbers.AsParallel().Where(s => s % 2 == 0).OrderBy(s => s).ToArray();
            time.Stop();
            timer = time.Elapsed;
            Console.WriteLine(Convert.ToString(timer.TotalMilliseconds));
            if (nums11.Length < 10)
                for (int i = 0; i < nums11.Length; i++)
                {
                    Console.Write(nums11[i] + " ");
                }
            else
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(nums11[i] + " ");
                }
            Console.WriteLine();

            //   2.	Найти все нечётные числа
            time.Restart();
            int[] nums22 = numbers.AsParallel().Where(s => s % 2 != 0).OrderBy(s => s).ToArray();
            time.Stop();
            timer = time.Elapsed;
            Console.WriteLine(Convert.ToString(timer.TotalMilliseconds));
            if (nums22.Length < 10)
                for (int i = 0; i < nums22.Length; i++)
                {
                    Console.Write(nums22[i] + " ");
                }
            else
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(nums22[i] + " ");
                }
            Console.WriteLine();

            //   3.	Найти все числа, сумма первой и последней цифры которых равна 6
            time.Restart();
            int[] nums33 = numbers.AsParallel().Select(s => Convert.ToString(s)).Where(s => Convert.ToInt32(s.First()) + Convert.ToInt32(s.Last()) == 6).Select(s => Convert.ToInt32(s)).OrderBy(s => s).ToArray();
            time.Stop();
            timer = time.Elapsed;
            Console.WriteLine(Convert.ToString(timer.TotalMilliseconds));
            if (nums33.Length < 10)
                for (int i = 0; i < nums33.Length; i++)
                {
                    Console.Write(nums33[i] + " ");
                }
            else
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(nums33[i] + " ");
                }
            Console.WriteLine();

            //   4.	Найти все числа, содержащие комбинацию цифр: 666
            time.Restart();
            int[] nums44 = numbers.AsParallel().Select(s => Convert.ToString(s)).Where(s => s.IndexOf("666") > -1).Select(s => Convert.ToInt32(s)).OrderBy(s => s).ToArray();
            timer = time.Elapsed;
            Console.WriteLine(Convert.ToString(timer.TotalMilliseconds));
            if (nums44.Length < 10)
                for (int i = 0; i < nums44.Length; i++)
                {
                    Console.Write(nums44[i] + " ");
                }
            else
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(nums44[i] + " ");
                }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
