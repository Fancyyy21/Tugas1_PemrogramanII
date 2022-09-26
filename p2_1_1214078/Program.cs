using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2_1_1214078
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Silakan Masukkan Perhitungan Disini !");

            Console.Write("Angka Pertama = ");
            int angka1 = int.Parse(Console.ReadLine());

            Console.Write("Angka Kedua = ");
            int angka2 = int.Parse(Console.ReadLine());

           
            Console.Write(angka1);
            Console.Write(" + ");
            Console.Write(angka2 + " = ");
            Console.WriteLine(angka1 + angka2);

            Console.Write(angka1);
            Console.Write(" - ");
            Console.Write(angka2 + " = ");
            Console.WriteLine(angka1 - angka2);

            Console.Write(angka1);
            Console.Write(" x ");
            Console.Write(angka2 + " = ");
            Console.WriteLine(angka1 * angka2);

            Console.Write(angka1);
            Console.Write(" : ");
            Console.Write(angka2 + " = ");
            Console.WriteLine(angka1 / angka2);

        }
    }
}
