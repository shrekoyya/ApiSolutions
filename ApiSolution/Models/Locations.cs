﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
 

namespace ApiSolution.Models
{
    public class Locations
    {
        public int locationID { get; set; }
        public DateTime sartdate { get; set; }
        public DateTime enddate { get; set; }
        public string name { get; set; }
    }
}