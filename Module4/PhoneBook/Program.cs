/* 
Author: Sergey Makarov
Date: 10/28/24
Assignment: Programming Assignment 4
*/

using System;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a phonebook object
            PhoneBook phoneBook = new PhoneBook();

            // Add business anmd person entities to the phonebook
            phoneBook.AddBusinessEntity("Tech Solutions Inc.", "4566 Corporate Blvd", "Seattle", "WA", "98109", "206-555-1234");
            phoneBook.AddPersonEntity("John", "Doe", "789 Residential St", "Tacoma", "WA", "98402", "253-555-5678");
            phoneBook.AddPersonEntity("Jane", "Smith", "321 Greenway Dr", "Bellevue", "WA", "98004", "425-555-7890");
            phoneBook.AddBusinessEntity("Creative Agency", "123 Innovation Ln", "Redmond", "WA", "98052", "425-555-2345");

            // print the phonebook entries
            phoneBook.PrintPhonebook();

            // test the search method
            Console.WriteLine("\nSearch for 'Smith':");
            phoneBook.Search("Smith");

            Console.WriteLine("\nSearch for 'Tech':");
            phoneBook.Search("Tech");

            Console.WriteLine("\nSearch for 'Nonexistent':");
            phoneBook.Search("Nonexistent");

            // add more entities to trigger the dynamic array resizing 
            for (int i = 0; i < 8; i++)
            {
                phoneBook.AddPersonEntity($"Person{i}", $"Lastname{i}", "Some Address", "Some City", "WA", "99999", $"555-000{i}");

            }

            // print phonebook after adding more entities
            Console.WriteLine("\nPhonebook after adding more entities (dynamic resizing test):");
            phoneBook.PrintPhonebook();
        }
    }
}
