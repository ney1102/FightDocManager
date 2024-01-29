using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model.Entity.User;

namespace Model.Context
{

    public class AppDbContext: DbContext
    {
        
        public DbSet<User> Users { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
           
        //    var connectionString = "Data Source=Desktop-G0NTY\\MSSQLSERVER01;Initial Catalog=FlightManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        //    base.OnConfiguring(optionsBuilder);

        //    optionsBuilder.UseSqlServer(connectionString);
        //    optionsBuilder.UseSqlServer("YourConnectionString");

        //}

        
    }
}
