using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman3400
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan Paijo = new Karyawan();
            Karyawan Jono = new Karyawan();

            Paijo.NIK = 190302123;
            Paijo.Nama = "Paijo";
            Paijo.GajiBulanan = 3000000;

            Jono.NIK = 190302124;
            Jono.Nama = "Jono";
            Jono.GajiBulanan = 2000000;

            Console.WriteLine("NIK/Nama                    Gaji Bulanan");
            Console.WriteLine("-------------------------------------------");
            Paijo.gajiawal();
            Jono.gajiawal();

            Console.WriteLine("\nAlhamdulillah dapat kenaikan gaji 10%\n\n");

            Console.WriteLine("NIK Nama                    Gaji Bulanan");
            Console.WriteLine("-------------------------------------------");
            Paijo.gajiakhir();
            Jono.gajiakhir();

            Console.ReadKey();
        }
    }
}