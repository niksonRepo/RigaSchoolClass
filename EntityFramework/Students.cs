﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class Students
    {
        [Key] 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
