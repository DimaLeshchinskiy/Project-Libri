﻿using System;
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

    }
}
