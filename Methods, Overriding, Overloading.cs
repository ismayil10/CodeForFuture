using System;

namespace TasksProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Check(21);
            Sum(4, 8);
            SumOdd(3, 10);
            int[] numbers1 = { 1, 2, 3, 4, 5, 7 };
            SumOfOdd(numbers1);
            int[] numbers2 = { 2, 3, 4, 6, 9, 10 };
            CountEven(numbers2);
            CheckPrime(29);
            Console.ReadLine();
        }

        // 1) n ədədinin 3-ə və 7-ə bölünüb-bölünmədiyini tapır
        static void Check(int n)
        {
            Console.WriteLine("Task 1:");
            if (n % 3 == 0 && n % 7 == 0)
                Console.WriteLine($"{n} həm 3-ə, həm də 7-yə bölünür.");
            else
                Console.WriteLine($"{n} 3-ə və 7-yə tam bölünmür.");
            Console.WriteLine();
        }

        // 2) n və m hər ikisi cütdürsə cəmini hesablayır
        static void Sum(int n, int m)
        {
            Console.WriteLine("Task 2:");
            if (n % 2 == 0 && m % 2 == 0)
            {
                int sum = n + m;
                Console.WriteLine($"{n} və {m} hər ikisi cütdür. Cəmi: {sum}");
            }
            else
            {
                Console.WriteLine("Ədədlərdən biri və ya hər ikisi təkdir.");
            }
            Console.WriteLine();
        }

        // 3) n və m (n<m) arasındakı tək ədədlərin cəmini tapır
        static void SumOdd(int n, int m)
        {
            Console.WriteLine("Task 3:");
            int sum = 0;
            for (int i = n + 1; i < m; i++)
            {
                if (i % 2 != 0)
                    sum += i;
            }
            Console.WriteLine($"{n} ilə {m} arasındakı tək ədədlərin cəmi: {sum}");
            Console.WriteLine();
        }

        // 4) Array-dəki tək ədədlərin cəmini tapır
        static void SumOfOdd(int[] arr)
        {
            Console.WriteLine("Task 4:");
            int sum = 0;
            foreach (int num in arr)
            {
                if (num % 2 != 0)
                    sum += num;
            }
            Console.WriteLine($"Array-dəki tək ədədlərin cəmi: {sum}");
            Console.WriteLine();
        }

        // 5) Array-dəki cüt ədədlərin sayını tapır
        static void CountEven(int[] arr)
        {
            Console.WriteLine("Task 5:");
            int count = 0;
            foreach (int num in arr)
            {
                if (num % 2 == 0)
                    count++;
            }
            Console.WriteLine($"Array-dəki cüt ədədlərin sayı: {count}");
            Console.WriteLine();
        }

        // 6) Verilmiş n tam ədədinin sadə və ya mürəkkəb olduğunu tapır
        static void CheckPrime(int n)
        {
            Console.WriteLine("Task 6:");
            bool isPrime = true;

            if (n <= 1)
                isPrime = false;
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
                Console.WriteLine($"{n} sadə ədəddir.");
            else
                Console.WriteLine($"{n} mürəkkəb ədəddir.");
            Console.WriteLine();
        }
    }
}
