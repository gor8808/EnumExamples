using System;
using System.Collections;

namespace EnumExamples
{
    class Car<T>
    {
        public void Print()
        {
            Console.WriteLine(default(T));
        }
        public K Go<K,U>(ref K a, ref U b)
        {
            K oldA = a;
            
            return oldA;
        }
    }
    enum Days
    {
        Mon, Tue, Wed, Thu, Fri, Sat, Sun
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car<string> car = new Car<string>();
            string name = "Gor";
            int age = 15;
            car.Go(ref name, ref age);
            car.Print();
            Console.WriteLine($"{Days.Mon} --- {Days.Wed}");
            Console.WriteLine("\n\n\n");

            ArrayList strArray = new ArrayList();
            strArray.AddRange(new string[] { "First", "Second", "Third" });
            strArray.AddRange(new int[] {1,2,3 });
            // Show number of items in ArrayList.
            Console.WriteLine("This collection has {0} items.", strArray.Count);
            Console.WriteLine();
            // Add a new item and display current count.
            strArray.Add("Fourth!");
            Console.WriteLine("This collection has {0} items.", strArray.Count);
            // Display contents.
            foreach (object s in strArray)
            {
                Console.WriteLine("Entry: {0}", s);
            }
        }
    }
}
