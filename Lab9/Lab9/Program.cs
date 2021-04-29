using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab9
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            StreamReader src = new StreamReader("Inlet.in");
            StreamWriter csr = new StreamWriter("Outlet.out");
            string[] words = src.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] words0 = src.ReadToEnd().Split(' ', '\n').Where(x => x != "").ToArray();
            LinkedList<string> words1 = new LinkedList<string>();
            LinkedList<string> words2 = new LinkedList<string>();
            LinkedListNode<string> node1;
            LinkedListNode<string> node2;
            List<string> equal = new List<string>();
            foreach(var item in words0)
                words2.AddLast(item);
            foreach (var item in words)
            {
                words1.AddLast(item);

            }
            int count=0;
          
            for (node1=words1.First;node1 != null; node1 = node1.Next)
            {
            for(node2=words2.First;node2 != null; node2 = node2.Next)
                {
                    if (node1.Value == node2.Value) {
                        equal.Add(node2.Value);
                        count++;
                    }
                    }      
            }
            string MaxWord = equal.OrderByDescending(n => n.Length).Max();
            if (count != 0)
                csr.WriteLine(MaxWord);
            else
            { csr.WriteLine("Empty"); }
            csr.Close();







        }
    }
}
