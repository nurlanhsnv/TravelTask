﻿using EntitiesT.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesT.Concrete
{
    public class BlogPost : BaseEntity
    {
        public string  Title { get; set; }
        public string Content { get; set; }
        public int UserID { get; set; }

    }
}
