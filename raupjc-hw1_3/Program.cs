using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raupjc_hw1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> listOfIntegers = new GenericList<int>();
            listOfIntegers.Add(1); // [1]
            listOfIntegers.Add(2); // [1 ,2]
            listOfIntegers.Add(3); // [1 ,2 ,3]
            listOfIntegers.Add(4); // [1 ,2 ,3 ,4]
            listOfIntegers.Add(5); // [1 ,2 ,3 ,4 ,5]
            foreach (int value in listOfIntegers)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("Drugi");
            foreach (int value in listOfIntegers)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();

        }
    }
}
