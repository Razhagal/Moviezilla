using Microsoft.EntityFrameworkCore;

namespace Moviezilla.Data.Models;

[Comment("Actor in the system")]
public class Actor
{
    [Comment("Actor Identifier")]
    public Guid Id { get; set; }

    [Comment("Actor Full Name")]
    public string Name { get; set; } = null!;
    
    [Comment("Actor Bio")]
    public string? ShortBio { get; set; }
    
    [Comment("Actor Picture Url")]
    public string? ImageUrl { get; set; }
    
    public bool IsDeleted { get; set; }
    
    public ICollection<MoviesActors> MoviesActors { get; set; } = new HashSet<MoviesActors>();
}