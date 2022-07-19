using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDatabaseContext
{
    public class Film
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public int Rating { get; set; }
        public bool EighteenPlus { get; set; }

    }
}
