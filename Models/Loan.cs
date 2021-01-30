using System;

namespace ProjectLibri.Models
{
    public class Loan : IModel
    {
        public String id { get; set; }
        public int state { get; set; }
        public DateTime createDate { get; set; }
        public DateTime endDate { get; set; }
        public Book book { get; set; }


    }
}