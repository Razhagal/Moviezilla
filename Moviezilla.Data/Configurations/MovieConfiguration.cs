using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Moviezilla.Data.Models;
using static Moviezilla.Data.Common.EntityConstants.Movie;

namespace Moviezilla.Data.Configurations;

public class MovieConfiguration : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
        builder
            .HasKey(m => m.Id);
        
        builder
            .Property(m => m.Title)
            .IsRequired()
            .HasMaxLength(TitleMaxLength);
        
        builder
            .Property(m => m.Genre)
            .IsRequired()
            .HasMaxLength(GenreMaxLength);
        
        builder
            .Property(m => m.Description)
            .IsRequired()
            .HasMaxLength(DescriptionMaxLength);
        
        builder
            .Property(m => m.ShortDescription)
            .IsRequired()
            .HasMaxLength(ShortDescriptionMaxLength);
        
        builder
            .Property(m => m.DirectorName)
            .IsRequired()
            .HasMaxLength(DirectorNameMaxLength);
        
        builder
            .Property(m => m.ImageUrl)
            .HasMaxLength(ImageUrlMaxLength);
        
        builder
            .Property(m => m.IsDeleted)
            .IsRequired()
            .HasDefaultValue(false);
        
        builder
            .HasQueryFilter(m => !m.IsDeleted);
    }

    private List<Movie> SeedMovies()
    {
        // TODO;
        return null;
    }
}