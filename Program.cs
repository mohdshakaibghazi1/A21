using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConAppAssignment21_Threading
{
    internal class Program
    {
        static void DisplayDays(List<string> days)
        {
            Console.WriteLine("Days: ");
            foreach (var day in days)
            {
                Console.WriteLine(day);
                Thread.Sleep(2000);
            }
        }

        static void DisplayMonths(List<string> months)
        {
            Thread.Sleep(3000);
            Console.WriteLine("Months:");
            foreach (var month in months)
            {
                Console.WriteLine(month);
                Thread.Sleep(2000);
            }
        }

        static void DisplayFruitsAndWords(List<string> fruits)
        {
            Thread.Sleep(1000);
            Console.WriteLine("fruits and their meanings: ");
            Dictionary<string, string> wordsAndMeanings = new Dictionary<string, string>()
            {
                {"Apple", "A round fruit with red or green skin."},
                {"Kiwi", "A small green fruit with black seeds and fuzzy brown skin."},
                {"Mango", "A sweet tropical fruit with yellow or orange flesh."},
                {"Pineapple", "A spiky tropical fruit with sweet and tangy yellow flesh."},
                {"Watermelon", "A large, juicy fruit with red or pink flesh."},
                {"Peach", "A soft fruit with fuzzy skin and a large pit in the center."},
                {"Cherry", "A small, sweet fruit with red or black skin and a pit."},
                {"Grapefruit", "A large, citrus fruit with a tart taste."},
                {"Pomegranate", "A fruit with tough outer skin and juicy red seeds inside."},
                {"Blueberry", "A small, round fruit with blue or purple skin."},
            };

            foreach (var fruit in fruits)
            {
                Console.WriteLine($"Fruit: \t{fruit}");
                if (wordsAndMeanings.TryGetValue(fruit, out string meanings))
                {
                    Console.WriteLine($"Meanings: {meanings}");
                }
                Thread.Sleep(2000);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Learning");
            List<string> fruits = new List<string>
            {
                "Apple", "Kiwi", "Mango", "Pineapple", "Watermelon", "Peach", "Cherry", "Grapefruit", "Pomegranate", "Blueberry"
            };
            List<string> days = new List<string>
            {
                "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
            };
            List<string> months = new List<string>
            {
                "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
            };
            DisplayDays(days);
            Console.WriteLine("\n");
            DisplayMonths(months);
            Console.WriteLine("\n");
            DisplayFruitsAndWords(fruits);
            Console.WriteLine("Program Terminated!!");
            Console.ReadKey();
        }
    }
}
