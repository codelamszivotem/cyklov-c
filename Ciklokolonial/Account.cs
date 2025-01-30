using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklokolonial
{
    internal class Account
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Age { get; set; }    
        

        public Account (string jmeno, string prijmeni, int age)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Age = age;
        } 
        

    }
}
