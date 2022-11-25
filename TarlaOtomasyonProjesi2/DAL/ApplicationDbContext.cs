using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarlaOtomasyonProjesi2.Entities;
namespace TarlaOtomasyonProjesi2.DAL
{
    public class ApplicationDbContext : DbContext
    {

       public DbSet<Tarla> Tarlalar { get; set; }
        public DbSet<IsciTotalMasraf> IsciToplamUcret {get;set;}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source =TarlaDb.db");
        }

    }
}
