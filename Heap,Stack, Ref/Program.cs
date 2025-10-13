using System;

namespace MethodsExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 1. Method Overloading (metodların eyni adda, fərqli parametrlə olması)
            PrintInfo("Ismayil");
            PrintInfo("Ismayil", 19);

            // 2. Ref parametrlə dəyişəni dəyişmək
            int number = 10;
            Console.WriteLine($"Before: {number}");
            Increase(ref number);
            Console.WriteLine($"After: {number}");

            // 3. Out parametrlə nəticə qaytarmaq
            int result;
            CalculateSquare(5, out result);
            Console.WriteLine($"Square: {result}");

            // 4. Params ilə istənilən sayda parametr ötürmək
            int total = SumNumbers(1, 2, 3, 4, 5);
            Console.WriteLine($"Total: {total}");

            // 5. Boolean method nümunəsi
            Console.WriteLine(IsEven(10));  // true
            Console.WriteLine(IsEven(7));   // false
        }

        // 1. Overloading
        public static void PrintInfo(string name)
        {
            Console.WriteLine($"Name: {name}");
        }

        public static void PrintInfo(string name, int age)
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        // 2. Ref parametri
        public static void Increase(ref int n)
        {
            n += 20;
        }

        // 3. Out parametri
        public static void CalculateSquare(int n, out int result)
        {
            result = n * n;
        }

        // 4. Params parametri
        public static int SumNumbers(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
                sum += num;
            return sum;
        }

        // 5. Sadə bool method
        public static bool IsEven(int n)
        {
            return n % 2 == 0;
        }
    }
}
