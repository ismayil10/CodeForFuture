using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace StringTasks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 1) İlk hərfi böyük, qalanları kiçik et
            string text1 = "hello world";
            Console.WriteLine(CapitalizeWords(text1)); // Hello World

            // 2) Xüsusi simvolları sil
            string text2 = "Hello@2025!";
            Console.WriteLine(RemoveSpecialCharacters(text2)); // Hello2025

            // 3) Sətir .com ilə bitib-bitmədiyini yoxla
            string text3 = "example.com";
            Console.WriteLine(EndsWithCom(text3)); // True
        }

        // 1) İlk hərfi böyük, qalanları kiçik edən metod
        public static string CapitalizeWords(string input)
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            return ti.ToTitleCase(input.ToLower());
        }

        // 2) Xüsusi simvolları silən metod
        public static string RemoveSpecialCharacters(string input)
        {
            return Regex.Replace(input, "[^a-zA-Z0-9]", "");
        }

        // 3) Sətirin .com ilə bitib-bitmədiyini yoxlayan metod
        public static bool EndsWithCom(string input)
        {
            return input.EndsWith(".com");
        }
    }
}
