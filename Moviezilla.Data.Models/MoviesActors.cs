using Microsoft.EntityFrameworkCore;

namespace Moviezilla.Data.Models;

// TODO: Add role type - Main or Supporting

[Comment("Movies and Actors Joint Table")]
public class MoviesActors
{
    [Comment("Movie Identifier")]
    public Guid MovieId { get; set; }

    public Movie Movie { get; set; } = null!;

    [Comment("Actor Identifier")]
    public Guid ActorId { get; set; }
    
    public Actor Actor { get; set; } = null!;

    [Comment("Name of the  character played by the Actor")]
    public string CharacterName { get; set; } = null!;
}