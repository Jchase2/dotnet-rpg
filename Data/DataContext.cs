using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace dotnet_rpg.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        // Sets name of corresponding database table.
        // Remember to pluralize the type for the table name.
        public DbSet<Character> Characters { get; set; }
        public DbSet<User> Users { get; set; }
    }
}