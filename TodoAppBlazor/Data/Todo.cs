﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoAppBlazor.Data
{
    public class Todo
    {
        
            [Key]
            public int Id { get; set; }
            public string Title { get; set; }
            public string Status { get; set; }
    }
}
