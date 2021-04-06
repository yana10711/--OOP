using System;
using System.IO;


namespace Lab10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            StreamReader src = new StreamReader("Inlet.in");
            string[] numbers = src.ReadLine().Split(' ');
            foreach (var item in numbers)
                Console.WriteLine();
        }
    }
}