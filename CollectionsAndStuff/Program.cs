using System;
using System.Collections.Generic;

namespace CollectionsAndStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> is a generic type => requires me to specify what type of stuff it does/uses
           var e14Names = new List<string>();

            // Add will add at the end of the list
            e14Names.Add("Martin");
            e14Names.Add("Chie");

            // Insert will add an item at a specific index. Index first, then item.
            e14Names.Insert(1, "Chris");

            // collection initializer - curly braces with elements inside
            var teacherNames = new List<string> { "Nathan", "Jameka", "Dylan" };

            // IEnumerable => Interfaces start with I. Enumarable => you can enumerate over it
            // A class can have many interfaces to implement. Unlike inheritance => can only inherit from one class

            // AddRange adds a collection to another
            e14Names.AddRange(teacherNames);

            // Reference equality => Point to the same place in memory
            e14Names.Remove("Tom");

            // remove by index
            e14Names.RemoveAt(0);

            // remove by expression
            // predicate => need a method that takes in a string and returns a bool
            // which tells you if string matches or not
            e14Names.RemoveAll(name => name.StartsWith("N"));

            foreach (var name in e14Names)
            {
                Console.WriteLine($"{name} is in e14");
            }
            // Action takes in string and returns void (hover below)
            e14Names.ForEach(name => Console.WriteLine($"{name} is in e14 again"));

            // ---------------------------------------------------------------------

            // DICTIONARY

            // Dictionary<TKey, TValue> ==> Open generic (didn't specifiy what type of thing it is yet)
            // TKey ==> Keys have to be unique => the type of keys in the dictionary

            // keyed by string and has string as the value
            var dictionary = new Dictionary<string, string>(); //Closed generic (they were told how to behave)

            dictionary.Add("Penaltimate", "second to last");
            dictionary.Add("Jib", "The things that stick out of rollercoasters");
            dictionary.Add("Arbitrary", "Someone who doesn't like Arby's");

            // get something based on its key
            var definition = dictionary["Arbitrary"];

            // try method return a boolean indicating success of failure
            if (!dictionary.TryAdd("Penultimate", "Thing said too many too many times at the olympics"))
            {
                Console.WriteLine("It's already in the dictionary, I coouldn't add it");
            }

            // If dictionary contains the penultimate key, we will set it's value to below
            if (dictionary.ContainsKey("Penultimate"))
            {
                dictionary["Penultimate"] = "Thing said too many too many times at the olympics";
            }

            // retusn all the values
            var allTheWords = dictionary.Values;

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key}'s definition is {item.Value}");
            }

            // destructuring the key value pairs 
            foreach (var (word, def) in dictionary)
            {
                Console.WriteLine($"{word}'s definition is {def}");
            }

            var complicatedDictionary = new Dictionary<string, List< string>> ();

            complicatedDictionary.Add("Soup", new List<string> { "How or cold liquid you eat." });

            var soupDefs = complicatedDictionary["Soup"];
            soupDefs.Add("This is a denition of soup");

            complicatedDictionary.Add("Arity", new List<string> { "A definition of arity" });

            foreach (var (word, definitions) in complicatedDictionary)
            {
                Console.WriteLine(word);
                foreach (var def in definitions)
                {
                    Console.WriteLine($"\t{def}");
                }

                // ----------------------------------------------------------------

                // HASHSETS

                // Hashset<T>
                // Store value at an index
                // value has to be unique
                // Completely different in that it eliminates non-unnique stuff witout errors
                // pretty slow at adding data
                // super fast getting data out, comparing data

                var uniqueNames = new HashSet<string>();
                uniqueNames.Add("Jameka");
                uniqueNames.Add("Jameka");
                uniqueNames.Add("Jameka");
                uniqueNames.Add("Jameka");
                uniqueNames.Add("Dylan");
                uniqueNames.Add("Dylan");
                uniqueNames.Add("Dylan");

                // This will only add Jameka and Dylan once despite adding it multiple times.
                // Will not thow an error 

                var jamekasName = "Jameka";

                jamekasName.GetHashCode();

                // ----------------------------------------------------------

                //  QUEUE

                //  Queue<T>
                // FIFO based collection ==> "First in, first out ==> If I enter something first, it will output first

                var queue = new Queue<int>();
                queue.Enqueue(3);
                queue.Enqueue(4);
                queue.Enqueue(5);
                queue.Enqueue(6);
                queue.Enqueue(7);

                // Will always add in order. There is no way to mix the order.
                // Queues are not very iterable


                while (queue.Count > 0)
                {
                    // Dequeue ==> takes next item and removes it AND returns it
                    Console.WriteLine($"dequeuing {queue.Dequeue()}");
                }

                // ----------------------------------------------------------------

                // STACKS

                //Stack<T>
                // LIFO based collection ==> Last in, first out
                // For things done in order, but most recent is first to be dealt with
                // Same as queues but in reverse

                var stack = new Stack<int>();

                stack.Push(2);
                stack.Push(5);
                stack.Push(6);
                stack.Push(1);
                stack.Push(21);

                while (stack.Count > 0)
                {
                    Console.WriteLine($"popping {stack.Pop()}");
                }



            }


        }
    }
}
