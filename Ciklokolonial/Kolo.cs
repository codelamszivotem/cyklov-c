using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklokolonial
{
    public class Kolo
    {
        public string Sedadlo { get; set; }
        public string Barva { get; set; }
        public int VelikostKol { get; set; }
        public bool Blatniky { get; set; }

        public Kolo(string sedadlo, string barva, int velikostKol, bool blatniky)
        {
            Sedadlo = sedadlo;
            Barva = barva;
            VelikostKol = velikostKol;
            Blatniky = blatniky;
        }
    }
}
