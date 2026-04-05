namespace Moviezilla.Data.Models;

public class Actor
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;
    
    public string? ShortBio { get; set; }
    
    public string? ImageUrl { get; set; }
    
    public bool IsDeleted { get; set; }
    
    public ICollection<MoviesActors> MoviesActors { get; set; } = new HashSet<MoviesActors>();
}