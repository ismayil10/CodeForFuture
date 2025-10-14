using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace StringTasks
{
    public class Program
    {
        public static void Main(string[] args)
        {
         
            string text1 = "hello world";
            Console.WriteLine(CapitalizeWords(text1)); 
            string text2 = "Hello@2025!";
            Console.WriteLine(RemoveSpecialCharacters(text2)); 
            string text3 = "example.com";
            Console.WriteLine(EndsWithCom(text3)); 
        }

        
        public static string CapitalizeWords(string input)
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            return ti.ToTitleCase(input.ToLower());
        }

    
        public static string RemoveSpecialCharacters(string input)
        {
            return Regex.Replace(input, "[^a-zA-Z0-9]", "");
        }

        
        public static bool EndsWithCom(string input)
        {
            return input.EndsWith(".com");
        }
    }
}

