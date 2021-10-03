using System;
using Microsoft.EntityFrameworkCore;
namespace ApiProgrammingTest.Data
{
    public class CityContext : DbContext
    {
        public CityContext(DbContextOptions<CityContext> options)
        {
        }

        public DbSet<CityContext> CityContexts { get; set; }
    }
}
