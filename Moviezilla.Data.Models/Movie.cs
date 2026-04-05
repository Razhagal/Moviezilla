using Microsoft.EntityFrameworkCore;

namespace Moviezilla.Data.Models;

[Comment("Movie in the system")]
public class Movie
{
    public Guid Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string ShortDescription { get; set; } = null!;

    public DateOnly ReleaseDate { get; set; }

    public string DirectorName { get; set; } = null!;

    public string? ImageUrl { get; set; }
    
    public bool IsDeleted { get; set; }
    
    public ICollection<MoviesActors> MoviesActors { get; set; } = new HashSet<MoviesActors>();
}