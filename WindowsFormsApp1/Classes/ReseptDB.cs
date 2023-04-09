using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public class ReseptDB
    {
        public int Id_Bluda { get; set; }
        public string Bluda { get; set; }
        public string Resept { get; set; }
       
        public ReseptDB(int id_Bluda, string bluda,  string resept)
        {
            Id_Bluda = id_Bluda;
            Bluda = bluda;
            Resept = resept;
        }
    }
}
