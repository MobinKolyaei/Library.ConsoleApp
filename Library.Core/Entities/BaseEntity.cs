﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;
    }
}
