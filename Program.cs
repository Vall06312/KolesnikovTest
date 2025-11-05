using System;
using System.Collections.Generic;
using LibraryLib;

namespace KolesnikovTest
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryFunctions library = new LibraryFunctions();

            Console.WriteLine("1. Тест GetLibraryName():");
            string libraryName = library.GetLibraryName();
            Console.WriteLine($"Название библиотеки: {libraryName}");
            Console.WriteLine();

            Console.WriteLine("2. Тест GetChiefLibrarian():");
            string chief = library.GetChiefLibrarian();
            Console.WriteLine($"Главный библиотекарь: {chief}");
            Console.WriteLine();

            Console.WriteLine("3. Тест GetStaff():");
            List<string> staff = library.GetStaff();
            Console.WriteLine("Список сотрудников:");
            foreach (var employee in staff)
            {
                Console.WriteLine($" - {employee}");
            }
            Console.WriteLine();

            Console.WriteLine("4. Тест GenerateBookCode():");
            string bookCode1 = library.GenerateBookCode("FIC", 123);
            string bookCode2 = library.GenerateBookCode("SCI", 456);
            Console.WriteLine($"Код книги 1: {bookCode1}");
            Console.WriteLine($"Код книги 2: {bookCode2}");
            Console.WriteLine();

            Console.WriteLine("5. Тест AddStaff():");
            Console.WriteLine("Добавляем нового сотрудника: Смирнов А.Л.");
            library.AddStaff("Смирнов А.Л.");

            List<string> updatedStaff = library.GetStaff();
            Console.WriteLine("Обновленный список сотрудников:");
            foreach (var employee in updatedStaff)
            {
                Console.WriteLine($" - {employee}");
            }
            Console.WriteLine();

            Console.WriteLine("6. Тест SetChiefLibrarian():");
            bool success1 = library.SetChiefLibrarian("Петров П.С.");
            Console.WriteLine($"Попытка назначить Петрова П.С.: {(success1 ? "УСПЕХ" : "НЕУДАЧА")}");
            Console.WriteLine($"Текущий главный библиотекарь: {library.GetChiefLibrarian()}");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}