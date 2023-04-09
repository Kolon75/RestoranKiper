using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public class Resept
    {
        public string NameProd { get; set; }

        public int Ves { get; set; }

        public Resept (string nameProd, int ves)
        {
            NameProd = nameProd;
            Ves = ves;
        }
    }
}
