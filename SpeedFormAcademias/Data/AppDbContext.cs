using SpeedFormAcademias.Models;
using SpeedFormAcademias.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SpeedFormAcademias.Data;

public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Modalidade> Modalidades { get; set; }
    public DbSet<Unidade> Unidades { get; set; }
    public DbSet<UnidadeFoto> UnidadeFotos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
}
