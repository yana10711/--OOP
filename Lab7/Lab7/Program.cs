using System;
using System.IO;
using System.Linq;


namespace Lab10
{
    class Vector
    {
        public Vector()
        {
            StreamReader src = new StreamReader("Inlet.in");
            int [] numbers = src.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            Random rand = new Random();
            int[] arr = new int[numbers[0]];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, arr.Length - 1);
            }
        }
        public Vector(string file)
        {
            StreamReader src = new StreamReader(file);
            int[] numbers = src.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            int[] array = src.ReadToEnd().Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            PlaceArray(array);
            C(numbers[1]);
            Interval(numbers[2], numbers[3], C(numbers[1]));
            MinIndex(C(numbers[1]));
        }

        void PlaceArray(int[] play)
        {
            for (int i = 0; i < play.Length / 2; i++)
            {

                int n = play[2 * i + 1];
                play[2 * i + 1] = play[2 * i];
                play[2 * i] = n;

            }

        }
       

        static int[]  C(int C1)
        {
            int [] arrC = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arrC[i] = (int)Math.Pow(C1, i);
            }
            return  arrC ; 
            
        }


        void Interval(double a, double b,  int [] arrC )
        {
            int count = 0;
            for(int i = 0; i < arrC.Length; i++)
            {
                if (arrC[i] >= a && arrC[i] <= b)
                    count++;
            }
        }
        int MinIndex (int [] arrC)
        {
            int min = 0; int index=0;
            for(int i = 0; i < arrC.Length; i++)
            {
                if (arrC[i] < min)
                {
                    min = arrC[i];
                    index = i;
                }
            } return index;


        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Vector that = new Vector();
            Vector that1 = new Vector("Inlet.in"); 

        }
    }
}
