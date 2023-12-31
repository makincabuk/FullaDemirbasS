﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Jobs
    {
        [Key]
        public int JobsID { get; set; }
        [StringLength(200)]
        public string JobsName { get; set; }
        [StringLength(200)]
        public string JobsDescription { get; set; }
        public bool JobsStatus { get; set; }
    }
}
