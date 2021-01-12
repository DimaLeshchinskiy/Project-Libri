using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectLibri.Specification
{
    public class ExampleSpecification
    {
        public String value1 { set; get; }
        public String value2 { set; get; }
        public String value3 { set; get; }


        public String GetSql()
        {
            String sql = "SELECT * FROM table";

            List<String> conditions = new List<String>();

            if (value1 != null)
                conditions.Add($"propety1={value1}");
            if (value2 != null)
                conditions.Add($"propety2={value2}");
            if (value3 != null)
                conditions.Add($"propety3 IN ( SELECT * FROM table2 WHERE propety={value3}");

            //add where
            if (conditions.Count > 0)
                sql += " WHERE " + String.Join(" AND ", conditions);

            return sql;
        }
    }
}
