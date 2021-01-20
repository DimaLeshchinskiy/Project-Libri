using System;
using System.Reflection;


namespace ProjectLibri.Models
{
    public abstract class IModel
    {
        public override string ToString()
        {
            Type type = this.GetType();
            PropertyInfo[] myPropertyInfo = type.GetProperties();

            string result = type.ToString() + ":{ ";
            foreach (PropertyInfo prop in myPropertyInfo)
            {
                result += prop.Name + ":" + prop.GetValue(this, null) + ", ";
            }
            return result.Substring(0, result.Length - 2) + " }";
        }
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }
}
