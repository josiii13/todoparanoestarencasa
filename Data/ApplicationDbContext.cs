using System.ClientModel.Primitives;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using sharpness_sharp.Data.Models;



namespace sharpness_sharp.Data;

public class ApplicationAuthDbContext(DbContextOptions<ApplicationAuthDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Cafe> Cafes => Set<Cafe>();
    public DbSet<Ventas> Ventas=> Set<Ventas>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Ventas>(venta =>
        {
            venta.HasOne(venta=>venta.Cliente)
            .WithMany(cliente=>cliente.lstVentas).
            HasForeignKey(venta=>venta.Id_Cliente);

            venta.HasOne(venta=>venta.Cafe).WithMany().
            HasForeignKey(venta=>venta.Id_Cafe);
        });
        base.OnModelCreating(builder);
    }
}

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
}
