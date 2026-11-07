using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using sharpness_sharp.Data.Models;



namespace sharpness_sharp.Data;

public class ApplicationAuthDbContext(DbContextOptions<ApplicationAuthDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Cafe> Cafes => Set<Cafe>();
}

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
}
