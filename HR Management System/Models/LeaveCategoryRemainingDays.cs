﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management_System.Models
{
    public class LeaveCategoryRemainingDays
    {
        public string CategoryName { get; set; }
        public int TotalDays { get; set; }
        public int UsedDays { get; set; }
        public int RemainingDyas { get; set; }
    }
}
