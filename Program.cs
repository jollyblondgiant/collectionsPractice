using System;
using System.Collections.Generic;

namespace Main {
    class Program {
        static void Main (string[] args) {
            Random rand = new Random ();
            int[] numArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] nameAray = { "Tim", "Martin", "Nikki", "Sara" };
            bool[] boolArray = { true, false, true, false, true, false, true, false, true, false };
            List<string> flavors = new List<string> ();
            flavors.Add ("Pistachio");
            flavors.Add ("Caramel");
            flavors.Add ("Mango");
            flavors.Add ("Coffee");
            flavors.Add ("Chocolate");
            Console.WriteLine (flavors.Count);
            Console.WriteLine (flavors[2]);
            flavors.RemoveAt (2);
            Console.WriteLine (flavors.Count);
            Dictionary<string, string> names = new Dictionary<string, string> ();
            foreach (string name in nameAray) {
                names.Add (name, null);

            }
            foreach(string name in nameAray){
                names[name] = flavors[rand.Next(0,flavors.Count)];
            }
            foreach(var key in names){
                Console.WriteLine(key);
            }

        }
    }
}