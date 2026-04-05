using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        private static void RegUser()
        {

        }

        private static string CheckLogin(string login)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            string phonePattern = @"^\+[1-9]\d{0,2}-\d{3}-\d{3}-\d{4}$";
            string defaultPattern = @"^[a-zA-Z0-9_]+$";
            List<string> redectedLogins = ["test","admin","guest"];

            if (string.IsNullOrWhiteSpace(login))
                return "Логин не может быть пустым";

            if (Regex.IsMatch(login, emailPattern))
            {
                return "";
            }

            if (Regex.IsMatch(login, phonePattern))
            {
                return "";
            }        

            if (login.Length < 5)
                return "Логин должен содержать минимум 5 символов";

            if (!Regex.IsMatch(login, defaultPattern))
                return "Логин может содержать только латиницу, цифры и знак подчеркивания";

            if (redectedLogins.FirstOrDefault(x => x.Equals(login)) != null)
                return "Данный логин занят. Пожалуйста, выберите другой";

            return "";
        }
    }
}
