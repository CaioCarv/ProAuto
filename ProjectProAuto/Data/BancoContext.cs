using Microsoft.EntityFrameworkCore;
using ProjectProAuto.Models;

namespace ProjectProAuto.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) 
        {
        }

        public DbSet<AssociadoModel> AssociadoModel { get; set; }
    }
}
