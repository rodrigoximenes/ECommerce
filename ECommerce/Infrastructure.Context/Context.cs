﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Context
{
    public class Context : DbContext
    {
        public DbSet<Produto> MyProperty { get; set; }
    }
}
