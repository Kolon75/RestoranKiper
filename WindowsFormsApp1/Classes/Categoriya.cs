using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public class Categoriya
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public Categoriya (int id, string categoryName)
        {
            Id = id;
            CategoryName = categoryName;
        }
        public Categoriya()
        {

        }
    }
}
