using Microsoft.EntityFrameworkCore;

namespace Moviezilla.Data.Models;

[Comment("Movie in the system")]
public class Movie
{
    [Comment("Movie Identifier")]
    public Guid Id { get; set; }

    [Comment("Movie Title")]
    public string Title { get; set; } = null!;

    [Comment("Movie Genre")]
    public string Genre { get; set; } = null!;
    
    [Comment("Movie Rating")]
    public float Rating { get; set; }
    
    [Comment("Movie Full Description")]
    public string Description { get; set; } = null!;

    [Comment("Movie Short Description")]
    public string ShortDescription { get; set; } = null!;

    [Comment("Movie Release Date")]
    public DateOnly ReleaseDate { get; set; }

    [Comment("Movie Director")]
    public string DirectorName { get; set; } = null!;
    
    [Comment("Movie Duration")]
    public int Duration { get; set; }
    
    [Comment("Movie Poster Image Url")]
    public string? ImageUrl { get; set; }
    
    public bool IsDeleted { get; set; }
    
    public ICollection<MoviesActors> MoviesActors { get; set; } = new HashSet<MoviesActors>();
}