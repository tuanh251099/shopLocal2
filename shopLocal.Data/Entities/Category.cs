﻿using Microsoft.EntityFrameworkCore;
using shopLocal.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopLocal.Data.Entities
{
    public class Category 
    {
        public int Id { get; set; }
        public int SortOrder { get; set; }
        public bool IsShowOnHome { get; set; }
        public int ? ParentId { get; set; }
        public Status Status { get; set; }

    }
}
