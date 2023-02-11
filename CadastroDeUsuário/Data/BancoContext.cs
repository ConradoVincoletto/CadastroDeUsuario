using CadastroDeUsuário.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroDeUsuário.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext (DbContextOptions<BancoContext> options) : base(options)
        {
        }
        public DbSet<Usuário> Usuário { get; set; }
    }
}
