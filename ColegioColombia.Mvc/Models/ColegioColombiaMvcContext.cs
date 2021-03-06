﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ColegioColombia.Mvc.Models
{
    public class ColegioColombiaMvcContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        //
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public ColegioColombiaMvcContext() : base("name=ColegioColombiaMvcContext")
        {
            //En Ambientes de desarrollo, para producción se usaría MigrateDatabaseToLatestVersion.
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<ColegioColombiaMvcContext>());
        }

        public System.Data.Entity.DbSet<ColegioColombia.Mvc.Models.Alumno> Alumnoes { get; set; }

        public System.Data.Entity.DbSet<ColegioColombia.Mvc.Models.Profesor> Profesors { get; set; }
    }
}