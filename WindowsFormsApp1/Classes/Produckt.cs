using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public class Produckt
    {
        public int Id { get; set; }
        public string Produck { get; set; }
        public int Belky { get; set; }
        public int Jiri { get; set; }
        public int Ugle { get; set; }
        public Produckt(int id, string produck, int belky, int jiri, int ugle)
        {
            Id = id;
            Produck = produck;
            Belky = belky;
            Jiri = jiri;
            Ugle = ugle;
        }
    }
}
