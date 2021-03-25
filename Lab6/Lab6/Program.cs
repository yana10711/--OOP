using System.IO;
using System;
using System.Globalization;


namespace Lab6
{
    public struct Train
    {

        public double hour;
        public string city;
        public int numberTrain;
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            IFormatProvider formatter =  new NumberFormatInfo{ NumberDecimalSeparator="." };
            StreamWriter src = new StreamWriter("Outlet.out",false);
            /*StreamWriter writer = new StreamWriter("Inlet.in", false);
           
            while (Console.ReadLine() != null)
            {
                writer.WriteLine(Console.ReadLine());
            }*/

            string[] trains = File.ReadAllLines("Inlet.in");
            Train[] inTime = new Train[trains.Length/3];

            for (int i = 0; i < inTime.Length; i++) { 
                  inTime[i].hour = double.Parse(trains[3 * i],formatter);
                    inTime[i].city = trains[3 * i + 1];
                    inTime[i].numberTrain = int.Parse(trains[3 * i + 2]);

            }
          
                 int [] numbers = new int[inTime.Length];
                 int count = 0;
                 Console.WriteLine("Время?");
                 double T = double.Parse(Console.ReadLine(), formatter);
                 for (int i = 0; i < numbers.Length; i++){ 
                 if (T <=inTime[i].hour)
                 {
                    numbers[i] = inTime[i].numberTrain;
                    count++;
                 }
              }

            int a; string c;double b;
            for (int i = 0; i < inTime.Length; i++)
            {
                for (int j = i + 1; j < inTime.Length - 1; j++)
                {
                    if (inTime[i].numberTrain > inTime[j].numberTrain)
                    {
                        a = inTime[i].numberTrain;
                        b = inTime[i].hour;
                        c = inTime[i].city;
                        inTime[i].numberTrain = inTime[j].numberTrain;
                        inTime[i].hour = inTime[j].hour;
                        inTime[i].city = inTime[j].city;
                        inTime[j].numberTrain = a;
                        inTime[j].hour = b;
                        inTime[j].city = c;
                    }
                }
            }

            for (int i = 0; i < inTime.Length; i++)
            {
                src.WriteLine(inTime[i].numberTrain);
                src.WriteLine(inTime[i].city);
                src.WriteLine(inTime[i].hour);
            }
             if (count == 0)

                {
                    src.WriteLine(-1);
                }
            
            else
            {
                foreach(int number in numbers)
                {
                    if (number != 0)
                        src.WriteLine("Поезд номер:" + number);
                }
            }


            src.Close();




        }
    }
}






