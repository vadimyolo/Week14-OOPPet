using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
namespace MoviesFromFile
{
    class Program
    {
        class Presents
        {
            string name;
            string present;
            string howmuch;

            public Presents(string _name, string _present, string _howmuch)
            {
                name = _name;
                present = _present;
                howmuch = _howmuch;
            }

            public string Name
            {
                get { return name; }
            }
            public string Present
            {
                get { return present; }
            }
            public string Howmuch
            {
                get { return howmuch; }
            }
        }
        static void Main(string[] args)
        {
            List<string> presentListFromFile = getPresentsFromFile().ToList();
            List<Presents> listOfPresents = new List<Presents>();

            foreach (string movieRecord in presentListFromFile)
            {
                string[] tempArray = movieRecord.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                Presents newPresent = new Presents(tempArray[0], tempArray[1], tempArray[2]);

                listOfPresents.Add(newPresent);
            }


            foreach (Presents presents in listOfPresents)
            {
                Console.WriteLine($"{presents.Name} wants {presents.Present} ");
            }
        }

        public static string[] getPresentsFromFile()
        {
            string filePath = @"C:\Users\opilane\Samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
        public static void ShowDataFromArray(string[] someArray)
        {
            foreach (string line in someArray)
            {
                Console.WriteLine(line);
            }
        }
    }
}