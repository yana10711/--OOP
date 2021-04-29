using System;
using System.IO;
using System.Collections;
using System.Linq;


namespace Lab10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            StreamReader src = new StreamReader("Inlet.in");
            StreamWriter csr = new StreamWriter("Outlet.out");
            int[] numbers = src.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            IEnumerator ie = numbers.GetEnumerator();
            while (ie.MoveNext())
            {
                var item = (int)ie.Current;
                if ((item / 100000) % 10 + (item / 10000) % 10 + ((item / 1000) % 100) % 10 == (item % 1000) / 100 + ((item % 1000) % 100) / 10 + ((item % 1000) % 100) % 10)
                    csr.WriteLine(item);
            }
            csr.Close();


        }
    }
}