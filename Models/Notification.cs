using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectLibri.Models
{
    public class Notification : IModel
    {
        public string id { get; set; }
        public int state { get; set; }
        public int type { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime createDate { get; set; } 
    }
}
