using System;
using System.Reflection;

namespace LoginApp
{

    #region LoginException
    public class LoginException : Exception
    {
        public LoginException(string message) : base(message)
        {
        }
    }
    #endregion
    #region ReflectionPractice

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void SayHello()
        {
            Console.WriteLine("Salam! Mən " + Name + "am.");
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            #region LoginException
            string correctEmail = "test@mail.com";
            string correctPassword = "12345";

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Şifrə: ");
            string password = Console.ReadLine();

            try
            {
                if (email != correctEmail)
                    throw new LoginException("Email səhvdir!");

                if (password != correctPassword)
                    throw new LoginException("Şifrə səhvdir!");

                Console.WriteLine("Giriş uğurludur!");
            }
            catch (LoginException ex)
            {
                Console.WriteLine("Xəta: " + ex.Message);
            }
            #endregion
            #region ExceptionPractice
            try
            {
                Console.Write("Birinci ədədi daxil et: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("İkinci ədədi daxil et: ");
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine("Nəticə: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Xəta: 0-a bölmək olmaz!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Xəta: Yalnız ədəd daxil edə bilərsən!");
            }
            finally
            {
                Console.WriteLine("Proqram bitdi.");
            }
            #endregion
            #region ReflectionPractice
            Type type = typeof(Person);
            Console.WriteLine("Class adı: " + type.Name);

            Console.WriteLine("\nProperty-lər:");
            foreach (var prop in type.GetProperties())
            {
                Console.WriteLine("- " + prop.Name);
            }

            Console.WriteLine("\nMetodlar:");
            foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                Console.WriteLine("- " + method.Name);
            }

            Console.WriteLine("\nReflection uğurla işləyir!");
            #endregion

        }
    }
}
