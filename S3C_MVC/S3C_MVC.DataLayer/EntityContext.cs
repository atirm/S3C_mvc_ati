﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3C_MVC.DataLayer
{
   public class EntityContext: DbContext
    {
        public EntityContext() 
            : base(System.Configuration.ConfigurationManager.ConnectionStrings["EntityConnectionStrings"].ConnectionString)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
