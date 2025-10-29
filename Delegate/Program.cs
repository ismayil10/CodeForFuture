namespace Delegate { 

    internal class Program
    {

        #region Task
        public static List<string> FilterStrings(List<string> items, Predicate<string> condition)
        {
            List<string> result = new List<string>();

            foreach (string item in items)
            {
                if (condition(item))  // Predicate true qaytarırsa, əlavə et
                {
                    result.Add(item);
                }
            }

            return result;
        }
        #endregion
        public delegate bool CheckNums(int num);
        public static bool CheckOdd(int num)
        {
                       return num % 2 != 0;
        }
        public static bool CheckEven(int num)
        {
            return num % 2 == 0 ;
        }
        public static bool CheckGreaterThanFive(int num)
        {
            return num > 5;
        }
        static void Main(string[] args)
        {
            int [] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(CheckAndSumNum((CheckOdd , nums));
            Console.WriteLine(CheckAndSumNum((CheckEven , nums));
            Console.WriteLine(CheckAndSumNum((CheckGreaterThanFive , nums));
            List<string> names = new List<string> { "Ali", "Ismayil", "Aydan", "Ramin", "Afaq" };

            List<string> filtered = FilterStrings(names, x => x.StartsWith("A"));

            Console.WriteLine("A ilə başlayan adlar:");
            foreach (string name in filtered)
            {
                Console.WriteLine(name);
            }
        }
        public static int CheckAndSumNum(CheckNums del, int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                if (del(num))
                {
                    sum += num;
                }
            }
            return sum;
        }
    }
}
