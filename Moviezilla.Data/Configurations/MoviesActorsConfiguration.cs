using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Moviezilla.Data.Models;

namespace Moviezilla.Data.Configurations;

public class MoviesActorsConfiguration :IEntityTypeConfiguration<MoviesActors>
{
    public void Configure(EntityTypeBuilder<MoviesActors> builder)
    {
        builder
            .HasKey(ma => new { ma.MovieId, ma.ActorId });
        
        builder
            .HasOne(ma => ma.Movie)
            .WithMany(m => m.MoviesActors)
            .HasForeignKey(ma => ma.MovieId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder
            .HasOne(ma => ma.Actor)
            .WithMany(a => a.MoviesActors)
            .HasForeignKey(ma => ma.ActorId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}