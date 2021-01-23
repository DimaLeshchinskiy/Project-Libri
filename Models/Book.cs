using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectLibri.Models
{
    public class Book : Author
    {

        public String id { get; set; }
        public String name { get; set; }
        public String litType { get; set; }
        List<string> genres = new List<string>();
        public int releaseYear { get; set; }
        public String litPeriod { get; set; }
        public String ISBN { get; set; }
        public Author Author { get; set; }
        List<string> litFunctions = new List<string>();
        public int inventoryCount { get; set; }
        public double purchasePrice { get; set; }



    }
}
