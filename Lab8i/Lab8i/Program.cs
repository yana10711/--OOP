
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Lab8
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            StreamReader src = new StreamReader("inlet.in");
            string[] equation = src.ReadLine().Split(' ', '+');
            string[] equation2 = src.ReadLine().Split(' ', '+');
            equation = (from word in equation where word != "" select word).ToArray();
            equation2 = (from word in equation2 where word != "" select word).ToArray();
            StreamWriter csr = new StreamWriter("Outlet.out", false);
            List<double> Coef = new List<double>();
            List<double> Degr = new List<double>();
            List<double> Coef1 = new List<double>();
            List<double> Degr1 = new List<double>();
            for (int i = 0; i < equation.Length; i++)
            {

                if (equation[i].Contains("x"))
                {
                    string[] equation1 = equation[i].Split('*');
                    equation1 = (from word in equation1 where word != "" select word).ToArray();
                    for (int j = 0; j < equation1.Length; j++)
                    {
                        if (equation1[j] == "x")
                        {
                            try
                            {
                                Coef.Add(double.Parse(equation1[j - 1]));


                            }
                            catch (Exception)
                            {
                                Coef.Add(1);

                            }
                            try
                            {
                                Degr.Add(double.Parse(equation1[j + 1]));
                            }
                            catch (Exception)
                            {

                                Degr.Add(1);
                            }
                        }
                    }

                }
                else
                {
                    Coef.Add(double.Parse(equation[i]));
                    Degr.Add(0);
                }

            }
            for (int i = 0; i < equation2.Length; i++)
            {

                if (equation2[i].Contains("x"))
                {
                    string[] equation1 = equation2[i].Split('*');
                    equation1 = (from word in equation1 where word != "" select word).ToArray();
                    for (int j = 0; j < equation1.Length; j++)
                    {
                        if (equation1[j] == "x")
                        {
                            try
                            {
                                Coef1.Add(double.Parse(equation1[j - 1]));


                            }
                            catch (Exception)
                            {
                                Coef1.Add(1);

                            }
                            try
                            {
                                Degr1.Add(double.Parse(equation1[j + 1]));
                            }
                            catch (Exception)
                            {

                                Degr1.Add(1);
                            }
                        }
                    }

                }
                else
                {
                    Coef1.Add(double.Parse(equation2[i]));
                    Degr1.Add(0);
                }

            }





            if (Degr.Count == Degr1.Count)
            {
                for (int i = 0; i < Coef.Count; i++)
                {
                    try
                    {
                        if (Math.Abs(Math.Abs(Math.Abs(Coef[i] / Coef1[i]) - Math.Abs(Degr[i] / Degr1[i]))) > 0)
                        {
                            csr.WriteLine("No");
                            return;
                        }


                    }
                    catch (Exception)
                    {
                        csr.WriteLine("No");
                        return;
                    }
                }
            }
            else
            {
                csr.WriteLine("No");
                return;
            }
            csr.WriteLine("Yes");

          csr.Close();
        }
    }

}


        
    


