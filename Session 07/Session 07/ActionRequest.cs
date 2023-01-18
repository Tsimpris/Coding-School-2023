﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public enum ActionEnum
    {
        Convert,
        Uppercase,
        Reverse
    }
    public class ActionRequest
    {
        
        public Guid RequestID { get; set; }
        public string? Input { get; set; }
        public ActionEnum Action { get; set; }


    }
}
