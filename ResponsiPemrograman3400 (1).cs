using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman3400
{
    class Karyawan
    {
        public int NIK { get; set; }
        public string Nama { get; set; }
        public float GajiBulanan { get; set; }

        public void gajiawal()
        {
 
            Console.WriteLine("{0} {1}      {2}", NIK, Nama, GajiBulanan);

        }

        public void gajiakhir()
        {
            Console.WriteLine("{0} {1}      {2}", NIK, Nama, GajiBulanan + GajiBulanan * 10/100);
        }
    }
}
