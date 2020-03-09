using System;
using System.Collections.Generic;
using System.Linq;

namespace linq {
    class Program {
        static void Main (string[] args) {
            // Find the words in the collection that start with the letter 'L'
            // List<string> fruits = new List<string> () { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };
            var fruits = new List<string> () { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            // IEnumerable<string> LFruits = fruits.Where (fruit => {
            var LFruits = fruits.Where (fruit => {
                return fruit.StartsWith ("L");
            });

            foreach (var fruit in LFruits) {
                Console.WriteLine ($"{fruit}");
            }
            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int> () {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            IEnumerable<int> fourSixMultiples = numbers.Where (num => {
                return (num % 4 == 0 || num % 6 == 0);
            });
            foreach (var num in fourSixMultiples) {
                Console.WriteLine ($"{num}");
            }

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string> () {
                "Heather",
                "James",
                "Xavier",
                "Michelle",
                "Brian",
                "Nina",
                "Kathleen",
                "Sophia",
                "Amir",
                "Douglas",
                "Zarley",
                "Beatrice",
                "Theodora",
                "William",
                "Svetlana",
                "Charisse",
                "Yolanda",
                "Gregorio",
                "Jean-Paul",
                "Evangelina",
                "Viktor",
                "Jacqueline",
                "Francisco",
                "Tre"
            };

            List<string> descend = names.OrderByDescending (name => name).ToList ();
            foreach (var name in descend) {
                Console.WriteLine ($"{name}");
            }

            // Build a collection of these numbers sorted in ascending order
            var numbers2 = new List<int> () {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            var ascend = numbers2.OrderBy (num2 => num2).ToList ();
            foreach (var num2 in ascend) {
                Console.WriteLine ($"{num2}");
            }

        }
    }
}