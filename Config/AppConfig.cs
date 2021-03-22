using System;

namespace ProjectLibri.Config
{
    public class AppConfig
    {
        public static readonly String SectionName = "AppConfig";

        public bool isDev { set; get; }

        public String ConnectionString { set; get; }

    }
}
