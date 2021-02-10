using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectLibri.Models
{
    public class Function : IModel
    {

        public string id { get; set; }
        public string title { get; set; }
        public string url { get; set; }

        public List<> GetAllFunctions()
        {
            List<String> list = new List<string>();
            Random rnd = new Random();

            String A = GetRandomFunction();
            String B = GetRandomFunction();
            String C = GetRandomFunction();
            String D = GetRandomFunction();

            list.Add(A);
            list.Add(B);
            list.Add(C);
            list.Add(D);

            return list;
        }

        private String GetRandomFunction()
        {
            Random rnd = new Random();
            int a = rnd.Next(10);
            String func;

            switch(a)
            {
                case 0: func="Funkce0"; break;
                case 1: func="Funkce1"; break;
                case 2: func="Funkce2"; break;
                case 3: func="Funkce3"; break;
                case 4: func="Funkce4"; break;
                case 5: func="Funkce5"; break;
                case 6: func="Funkce6"; break;
                case 7: func="Funkce7"; break;
                case 8: func="Funkce8"; break;
                case 9: func="Funkce9"; break;       
            }

            return func;
        }
    }
}
