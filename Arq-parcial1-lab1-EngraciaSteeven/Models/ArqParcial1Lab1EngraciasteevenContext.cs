
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Arq_parcial1_lab1_EngraciaSteeven.Models;

public partial class ArqParcial1Lab1EngraciasteevenContext : IdentityDbContext<IdentityUser>
{
    public ArqParcial1Lab1EngraciasteevenContext()
    {
    }

    public ArqParcial1Lab1EngraciasteevenContext(DbContextOptions<ArqParcial1Lab1EngraciasteevenContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    
   
}
