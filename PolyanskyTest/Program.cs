using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using LibraryLib;
using Microsoft.Win32.SafeHandles;

namespace PolyanskyTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // создаем экземпляр класса из нашей библиотеки
            LibraryFunctions lib = new LibraryFunctions();
            // проверяем получение название библиотеки и главного библиотекаря
            Console.WriteLine("Библиотека: " + lib.GetLibraryName());
            Console.WriteLine("Главный библиотекарь: " + lib.GetChiefLibrarian());
            // выводим исходный список сотрудников
            Console.WriteLine("Сотрудники: " + string.Join(", ", lib.GetStaff()));
            // добавляем новго сотрудника
            lib.AddStaff("Смирнов А.А.");
            Console.WriteLine("После добавления: " + string.Join(",", lib.GetStaff()));
            // пробуем назначить сотрудника не из списка (false) и из списка (true)
            Console.WriteLine("Смена на Волкова В.В.: " + lib.SetChiefLibrarian("Волков В.В."));
            Console.WriteLine("Смена на Петрова П.С.: " + lib.SetChiefLibrarian("Петров П.С."));
            Console.WriteLine("Смена главного библиотекаря: " + lib.GetChiefLibrarian());
            // генерим код для книги
            Random rnd = new Random();
            Console.WriteLine("Код книги: " + lib.GenerateBookCode("FIC", rnd.Next(100, 999)));
            Console.ReadLine();
        }
    }
}
