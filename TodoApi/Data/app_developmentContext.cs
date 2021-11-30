using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoApi;

    public class app_developmentContext : DbContext
    {
        public app_developmentContext (DbContextOptions<app_developmentContext> options)
            : base(options)
        {
        }

        public DbSet<TodoApi.Leads> Lead { get; set; }
    }
