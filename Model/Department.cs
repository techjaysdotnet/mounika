﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class Department
    {
       public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string AvailableCount { get; set; }
        public string  TotalCount { get; set; }
    }
}
