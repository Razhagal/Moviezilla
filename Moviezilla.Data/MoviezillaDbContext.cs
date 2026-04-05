using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

using Moviezilla.Data.Models;

namespace Moviezilla.Data;

public class MoviezillaDbContext(DbContextOptions<MoviezillaDbContext> options) : IdentityDbContext(options)
{
    public DbSet<Movie> Movies { get; set; }
    
    public DbSet<Actor> Actors { get; set; }
    
    public DbSet<MoviesActors> MoviesActors { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}