using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_1_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan angka: ");
            int angka = int.Parse(Console.ReadLine());

            if (angka >=  100) 
            {
                Console.WriteLine("Angka lebih besar dari 100");
            }
            else
            {
                Console.WriteLine("Angka lebih kecil dari 100");
            }
        }
    }
}
