using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculator";

           int a, b;
           char menu;

            Console.WriteLine("Pilih Menu Calculator :");

            Console.WriteLine("\n1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.Write("Inputkan Menu[1..4] : ");
            menu = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();

            if(menu == '1')
            {
                Console.Write("Inputkan nilai a = ");
                a = int.Parse(Console.ReadLine()); // proses casting
                Console.Write("Inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine()); //proses casting

                Console.WriteLine("Hasil Penjumlahan {0} + {1} = {2}", a, b, Penjumlahan(a, b));
            }
            else if(menu == '2') 
            {
                Console.Write("Inputkan nilai a = ");
                a = int.Parse(Console.ReadLine()); // proses casting
                Console.Write("Inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine()); //proses casting
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            }
            else if (menu == '3')
            {
                Console.Write("Inputkan nilai a = ");
                a = int.Parse(Console.ReadLine()); // proses casting
                Console.Write("Inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine()); //proses casting
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            }
            else if (menu == '4')
            {
                Console.Write("Inputkan nilai a = ");
                a = int.Parse(Console.ReadLine()); // proses casting
                Console.Write("Inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine()); //proses casting
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }
            else
            {
                Console.WriteLine("Program tidak ditemukan!");
            }

            Console.ReadKey();
        }
        static int Penjumlahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
