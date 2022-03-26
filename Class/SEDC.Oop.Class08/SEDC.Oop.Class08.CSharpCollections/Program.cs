using System;
using System.Collections;
using System.Collections.Generic;

namespace SEDC.Oop.Class08.CSharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {   
            #region List
            string[] array = new string[4];
            string[] array2 = { "Hello", "World" };
            GoThruCollection(array2, "array");

            Array.Resize(ref array2, array2.Length + 1);
            array2[array2.Length - 1] = "!";
            GoThruCollection(array2, "array");

            List<int> numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(7);
            numbers.Add(9);
            numbers.Add(3);
            numbers.Remove(9);
            Console.WriteLine("List count is: " + numbers.Count);
            GoThruCollection(numbers, "numbers");
            #endregion


            #region Dictionary

            Dictionary<string, string> dictionaryOne = new Dictionary<string, string>();
            dictionaryOne.Add("song1", "Winds of change");
            dictionaryOne.Add("song2", "Enter sandman");
            dictionaryOne.Add("animal", "dog");

            GoThruCollection(dictionaryOne, "dictionary");
            /*dictionaryOne.Add("animal", "cat");*/ // key always must be unique

            Dictionary<int, string> dictionaryTwo = new Dictionary<int, string>
            {
                {1, "Hello" },
                {2, "World" },
                {3, "!" }
            };

            Console.WriteLine(dictionaryOne["song2"]);
            Console.WriteLine(dictionaryTwo[2]);

            Console.WriteLine("Length: " + dictionaryTwo.Count);

            Dictionary<int, Mytype> myTypeDictionary = new Dictionary<int, Mytype>();
            Dictionary<string, List<string>> bandSongsDictionary = new Dictionary<string, List<string>>();

            foreach(KeyValuePair<int, string> keyvalue in dictionaryTwo)
            {
                Console.WriteLine("=======");
                Console.WriteLine(keyvalue.Value); ;

            }

            #endregion

            #region Stack and Queue

            Console.WriteLine("==================================QUEUE=========================================");
            Queue<int> someQueue = new Queue<int>();
            someQueue.Enqueue(1);
            someQueue.Enqueue(2);
            someQueue.Enqueue(3);
            someQueue.Enqueue(25);

            int firstEl = someQueue.Dequeue();
            Console.WriteLine(firstEl);
            GoThruCollection(someQueue, "queue");
            //Console.WriteLine(someQueue[2]); WeakReference cannot use indexes
            Console.WriteLine(someQueue.Peek());
            Console.WriteLine("Length: " + someQueue.Count);


            Console.WriteLine("==================================STACK=========================================");
            Stack<string> someStack = new Stack<string>();
            someStack.Push("Hello");
            someStack.Push("World");
            someStack.Push("Hey");
            someStack.Push("Zdravo");
            GoThruCollection(someStack, "stack");

            string item = someStack.Pop();
            Console.WriteLine(item);
            Console.WriteLine(someStack.Peek());
            Console.WriteLine("Length: " + someStack.Count);
              


            #endregion





            Console.ReadLine();
        }

        public static void GoThruCollection(IEnumerable collection, string name)
        {
            Console.WriteLine("Collection {0} items", name);
            foreach (var item in collection)
            {
                Console.WriteLine("{0}", item);
            }
            Console.WriteLine();
        }
    }

    public class Mytype
    {

    }
}
