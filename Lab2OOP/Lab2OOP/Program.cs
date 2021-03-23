using System;
namespace Lab2OOP
{

    class A
    {
        public decimal a { get; set; }
        public decimal b { get; set; }
        public A(){}
        public A(decimal a, decimal b)
        {
            this.a = a;
            this.b = b;
        }

        public decimal c
        {
            get { return a += b; }
            set { --value; }
        }
    }

    class B : A
    {
        public int Value { get; set; }
        public decimal d;
        public decimal[] arr;
        public int[,] arr1 = new int[,] { { 12, 4, 3, 5, 6 }, { 2, 4, 3, 6, 6 } };
        public B() { }
        // Четвёртая лаба
        public decimal this[int index]
        {
            get
            {
                return arr[index];
            }
            set { arr[index] = value; }
        }
        public int this[int ind, int j]
        {
            get { return arr1[ind, j]; }
            set {
                arr1[ind, j] = value;
                foreach (var n in arr1)
                {
                    Console.Write(n);
                    Console.WriteLine();
                }
            }
        }

        public B(decimal d, decimal a, decimal b) : base(a, b) {
            this.d = d;
            //Третья лаба     
            arr = new decimal[Convert.ToInt32(a)];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = c2 * i;
            }
            foreach (var n in arr)
            {
                Console.Write(n);
                Console.WriteLine(" ");
            }
        }
        //Вторая лаба
        public decimal c2
        {
            get { return a + b + d; }
            set { while (b < Convert.ToDecimal(Math.Pow(Convert.ToDouble(b), 4))) {
                    b += a + d;
                    value = b;
                }
            }

        }
        // Пятая лаба 
        public static bool operator <(B one,B two)
        {
            return one.Value%2 <two.Value;
            
        }
        public static bool operator >(B one ,B two)
        {
            return (one.Value*two.Value)>Math.Pow(two.Value,2);

        }
        public static bool operator !(B one)
        {
            return one.Value != 0;
        }

    }
    // Четвёртая лаба

    public class C<T>
    {
        static int count = 0;
        public C()
        {
            count++;
        }
        public T an { get; set; }
        public static int sd()
        {
            return count;
        }
    }

    class MainClass
    {

        public static void Main(string[] args)
        {

            A firstobjeckt = new A(3.6m, 1.0m);
            Console.WriteLine(firstobjeckt.c);
            B secondObjeckt = new B(4.9m, 8.43m, 2.3m);
            Console.WriteLine(secondObjeckt.c2);


            C<string> s = new C<string>();
            s.an = "345";
            Console.WriteLine(s.an + " " + C<string>.sd());
            C<int> a = new C<int>();
            new C<string>();
            a.an = 435;
            Console.WriteLine(a.an + " " + C<string>.sd());

            B one = new B { Value = 32 };
            B two = new B { Value = 23 };
            Console.WriteLine(one.Value);



        }
    }
}





