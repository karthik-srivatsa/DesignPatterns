using SingletonImplementation;
using System;
using System.IO;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = DatabaseReader.Instance;
            Console.WriteLine(reader.GetPopulation("India")); 
        }
    }
}
