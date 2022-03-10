using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_Basic_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Иванов ";
            string lastName = "Саша ";

            Console.WriteLine("Имя - " + firstName + "   Фамилия - " + lastName);

            firstName = "Саша";
            lastName = "Иванов";

            Console.WriteLine("\nУпс ошибка.");
            Console.WriteLine("Имя - " + firstName + "   Фамилия - " + lastName);
        }
    }
}
