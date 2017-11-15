using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsDegrees
{
    class Program
    {
        
        public static void FindStu(string name,string[] names,double[] degrs)
        {
            
            int cont = 0;
            for (int i=0; i<names.Length; i++)
            {
                if (name == names[i])
                {
                    Console.WriteLine(" Name : " + names[i]);
                    Console.WriteLine(" Degree : " + degrs[i]);
                    Console.WriteLine(" -----------------------");
                    cont++;
                }

            }
            if (cont == 0)
            {
                Console.Write(" Student not found\n ");
            }
            else
            {
                Console.Write(" Found " + cont + " name(s)\n ");
            }
            Console.ReadKey();
            
        }

        public static void TopStu(string[] names, double[] degrs)
        {
            double max = degrs[0];
            int cont = 0;
            string[] nms = new string[degrs.Length];
            for (int i=1; i<degrs.Length; i++)
            {
                if (degrs[i] > max)
                {
                    max = degrs[i];
                }
            }
            for (int i=0; i<degrs.Length; i++)
            {
                if (degrs[i] == max)
                {
                    nms[cont] = names[i];
                    cont++;
                }
            }
            Console.WriteLine(" The top student (or students if they had the same degree) \n");
            for (int j=0; j<cont; j++)
            {
                Console.WriteLine(" Name : " + nms[j]);
                Console.WriteLine(" Degree : " + max);
                Console.WriteLine(" -----------------------");
            }
            Console.Write(" Found " + cont + " name(s)\n ");
            Console.ReadKey();
        }

        public static void ChangeStu(string name, string[] names, double[] degrs)
        {
            int cont = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (cont != 0)
                {
                    if (name == names[i])
                    {
                        Console.WriteLine(" Another match found, enter the new name for the student : ");
                        names[i] = Console.ReadLine();
                        cont++;
                    }
                }
                else
                {
                    if (name == names[i])
                    {
                        Console.Write("\n Student name found, enter the new name for the student : ");
                        names[i] = Console.ReadLine();
                        cont++;
                    }
                }
            }
            if (cont == 0)
            {
                Console.Write(" Student not found\n ");
                goto end;
            }
            Console.WriteLine(" -----------------------");
            Console.Write(" Changed " + cont + " name(s)\n ");
end:        Console.ReadKey();
        }
        static void Main(string[] args)
        {
            int m;
            string n;
            bool ifsuc, ifsuc1;
start:      Console.Write(" Enter the total number of students : ");
            ifsuc = int.TryParse(Console.ReadLine(), out m);
            if (ifsuc == false)
            {
                Console.Write(" Enter a valid number only :)");
                Console.ReadKey();
                Console.Clear();
                goto start;
            }
            Console.Clear();
            string[] names = new string[m];
            double[] degrs = new double[m];

            for (int i=0; i<names.Length; i++)
            {
                Console.Write(" Enter the name of student no. " + (i + 1) + " : ");
                names[i] = Console.ReadLine();
start1:         Console.Write(" Enter his/her degree in math : ");
                ifsuc1 = Double.TryParse(Console.ReadLine(), out degrs[i]);
                if (ifsuc1 == false)
                {
                    Console.Write(" Enter a valid number only :)");
                    Console.ReadKey();
                    goto start1;
                }
            }
restart:    Console.Clear();
            Console.WriteLine(" Please choose an option from the listed below : \n");
            Console.WriteLine(" 1. Search for student degree");
            Console.WriteLine(" 2. Get top student name and degree");
            Console.WriteLine(" 3. Change a student's name");
            Console.WriteLine(" 4. Exit ");
            Console.Write("\n -------------------------------------------------\n ");
            n = Console.ReadLine();
            if (n == "1")
            {
                Console.Clear();
                Console.Write(" Enter the student name : ");
                FindStu(Console.ReadLine(), names, degrs);
                goto restart;
            }
            else if (n == "2")
            {
                Console.Clear();
                TopStu(names, degrs);
                goto restart;
            }
            else if (n == "3")
            {
                Console.Clear();
                Console.Write(" Enter the student name you want to change : ");
                ChangeStu(Console.ReadLine(), names, degrs);
                goto restart;
            }
            else if (n == "4")
            {
                System.Environment.Exit(1);
            }
            else
            {
                Console.Write(" Wrong entry :( ");
                Console.ReadKey();
                goto restart;
            }
        }
    }
}
