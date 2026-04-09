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

    public static List<Movie> SeedMovies() =>
    [
        new Movie()
        {
            Id = new Guid("f0744c2c-c60f-4ae2-9227-beb769c6bb74"),
            Title = "Mad Max: Fury Road",
            Genre = "Action",
            Description = "An apocalyptic story set in the furthest reaches of our planet, in a stark desert landscape where humanity is broken, and almost everyone is crazed fighting for the necessities of life. Within this world exist two rebels on the run who just might be able to restore order. There's Max, a man of action and a man of few words, who seeks peace of mind following the loss of his wife and child in the aftermath of the chaos. And Furiosa, a woman of action and a woman who believes her path to survival may be achieved if she can make it across the desert back to her childhood homeland.\n",
            ShortDescription = "In a post-apocalyptic wasteland, a woman rebels against a tyrannical ruler in search for her homeland with the aid of a group of female prisoners, a psychotic worshipper and a drifter named Max.",
            ReleaseDate = new DateOnly(2015, 5, 15),
            DirectorName = "George Miller",
            Duration = 120,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BZDRkODJhOTgtOTc1OC00NTgzLTk4NjItNDgxZDY4YjlmNDY2XkEyXkFqcGc@._V1_FMjpg_UX675_.jpg"
        },
        new Movie()
        {
            Id = new Guid("12010e19-dd0f-4195-b3c6-7dc6702c8a32"),
            Title = "Die Hard",
            Genre = "Action",
            Description = "NYPD cop John McClane goes on a Christmas vacation to visit his wife Holly in Los Angeles where she works for the Nakatomi Corporation. While they are at the Nakatomi headquarters for a Christmas party, a group of robbers led by Hans Gruber take control of the building and hold everyone hostage, with the exception of John, while they plan to perform a lucrative heist. Unable to escape and with no immediate police response, John is forced to take matters into his own hands.",
            ShortDescription = "A New York City cop tries to save his wife and several others taken hostage by terrorists during a Christmas party in a Los Angeles skyscraper.",
            ReleaseDate = new DateOnly(1988, 7, 15),
            DirectorName = "John McTiernan",
            Duration = 132,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMGNlYmM1NmQtYWExMS00NmRjLTg5ZmEtMmYyYzJkMzljYWMxXkEyXkFqcGc@._V1_FMjpg_UX1066_.jpg"
        },
        new Movie()
        {
            Id = new Guid("d6bf3fb7-df18-4e5c-bce4-1f7cf55b8848"),
            Title = "John Wick",
            Genre = "Action",
            Description = "With the untimely death of his beloved wife still bitter in his mouth, John Wick, the expert former assassin, receives one final gift from her--a precious keepsake to help John find a new meaning in life now that she is gone. But when the arrogant Russian mob prince, Iosef Tarasov, and his men pay Wick a rather unwelcome visit to rob him of his prized 1969 Mustang and his wife's present, the legendary hitman will be forced to unearth his meticulously concealed identity. Blind with revenge, John will immediately unleash a carefully orchestrated maelstrom of destruction against the sophisticated kingpin, Viggo Tarasov, and his family, who are fully aware of his lethal capacity. Now, only blood can quench the boogeyman's thirst for retribution.",
            ShortDescription = "John Wick is a former hitman grieving the loss of his true love. When his home is broken into, robbed, and his dog killed, he is forced to return to action to exact revenge.",
            ReleaseDate = new DateOnly(2014, 10, 24),
            DirectorName = "Chad Stahelski",
            Duration = 101,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTU2NjA1ODgzMF5BMl5BanBnXkFtZTgwMTM2MTI4MjE@._V1_FMjpg_UY2048_.jpg"
        },
        new Movie()
        {
            Id = new Guid("a6600fb9-7a83-44fa-827e-03dd66e62e9a"),
            Title = "Gladiator",
            Genre = "Action",
            Description = "Maximus is a powerful Roman general, loved by the people and the aging Emperor, Marcus Aurelius. Before his death, the Emperor chooses Maximus to be his heir over his own son, Commodus, and a power struggle leaves Maximus and his family condemned to death. The powerful general is captured and put into the Gladiator games until he dies. The only desire that fuels him now is the chance to rise to the top so that he will be able to look into the eyes of the man who will feel his revenge.",
            ShortDescription = "A former Roman General sets out to exact vengeance against the corrupt emperor who murdered his family and sent him into slavery.",
            ReleaseDate = new DateOnly(2000, 5, 5),
            DirectorName = "Ridley Scott",
            Duration = 155,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BYWQ4YmNjYjEtOWE1Zi00Y2U4LWI4NTAtMTU0MjkxNWQ1ZmJiXkEyXkFqcGc@._V1_FMjpg_UY2599_.jpg"
        },
        new Movie()
        {
            Id = new Guid("6f6779da-99ae-44d9-a61a-43ebe5f0fd77"),
            Title = "The Dark Knight",
            Genre = "Action",
            Description = "Batman faces the Joker, whose campaign of chaos pushes Gotham and its heroes to the brink.",
            ShortDescription = "Batman vs Joker.",
            ReleaseDate = new DateOnly(2008, 7, 18),
            DirectorName = "Christopher Nolan",
            Duration = 152
        },
        new Movie()
        {
            Id = new Guid("f01bf412-3480-4c18-9b6f-418f947c1ba2"),
            Title = "The Matrix",
            Genre = "Action",
            Description =
                "A hacker discovers reality is a simulation and joins a rebellion against intelligent machines.",
            ShortDescription = "Reality is an illusion.",
            ReleaseDate = new DateOnly(1999, 3, 31),
            DirectorName = "The Wachowskis",
            Duration = 136
        },
        new Movie()
        {
            Id = new Guid("614bf670-e4d2-4b35-a208-c84a6c75c764"),
            Title = "Terminator 2: Judgment Day",
            Genre = "Action",
            Description =
                "A reprogrammed cyborg protects a young boy from a more advanced and deadly machine assassin.",
            ShortDescription = "Cyborg protector vs killer machine.",
            ReleaseDate = new DateOnly(1991, 7, 3),
            DirectorName = "James Cameron",
            Duration = 137
        },
        new Movie()
        {
            Id = new Guid("78e7000a-1425-4340-938a-cf4a5bac6775"),
            Title = "Casino Royale",
            Genre = "Action",
            Description =
                "James Bond earns his 00 status and pursues a terrorist financier through high-stakes games and espionage.",
            ShortDescription = "Bond’s first mission.",
            ReleaseDate = new DateOnly(2006, 11, 17),
            DirectorName = "Martin Campbell",
            Duration = 144
        },
        new Movie()
        {
            Id = new Guid("5247d8b6-6f31-4995-86c9-4196332328a0"),
            Title = "Mission: Impossible – Fallout",
            Genre = "Action",
            Description =
                "Ethan Hunt races across the globe after a mission fails and stolen plutonium threatens catastrophe.",
            ShortDescription = "High-stakes spy mission.",
            ReleaseDate = new DateOnly(2018, 7, 27),
            DirectorName = "Christopher McQuarrie",
            Duration = 147
        },
        new Movie()
        {
            Id = new Guid("a7b10c31-a060-4436-bef3-4b08014e794e"),
            Title = "300",
            Genre = "Action",
            Description = "King Leonidas leads a small Spartan force against the massive invading Persian army.",
            ShortDescription = "Epic Spartan battle.",
            ReleaseDate = new DateOnly(2007, 3, 9),
            DirectorName = "Zack Snyder",
            Duration = 117
        },
        new Movie()
        {
            Id = new Guid("d83ca8b1-f2da-4aa3-b5b8-a35ec94d20c4"),
            Title = "The Hangover",
            Genre = "Comedy",
            Description =
                "After a wild bachelor party in Las Vegas, three friends piece together a chaotic missing night.",
            ShortDescription = "Lost groom chaos.",
            ReleaseDate = new DateOnly(2009, 6, 5),
            DirectorName = "Todd Phillips",
            Duration = 100
        },
        new Movie()
        {
            Id = new Guid("a7061bb8-f59a-4ab7-ad3c-dce86b7ccbdc"),
            Title = "Superbad",
            Genre = "Comedy",
            Description = "Two inseparable teens chase one unforgettable party before high school ends.",
            ShortDescription = "Teen misadventures.",
            ReleaseDate = new DateOnly(2007, 8, 17),
            DirectorName = "Greg Mottola",
            Duration = 113
        },
        new Movie()
        {
            Id = new Guid("9d52bd23-4ee9-499d-8789-0d860eef65a3"),
            Title = "Dumb and Dumber",
            Genre = "Comedy",
            Description = "Two dimwitted friends travel cross-country and stumble into a criminal scheme.",
            ShortDescription = "Ridiculous road trip.",
            ReleaseDate = new DateOnly(1994, 12, 16),
            DirectorName = "Peter Farrelly",
            Duration = 107
        },
        new Movie()
        {
            Id = new Guid("69941e20-653e-4ddf-a9ef-7a98f601ba61"),
            Title = "Mean Girls",
            Genre = "Comedy",
            Description =
                "A homeschooled teen enters public high school and gets pulled into its ruthless social hierarchy.",
            ShortDescription = "High school social warfare.",
            ReleaseDate = new DateOnly(2004, 4, 30),
            DirectorName = "Mark Waters",
            Duration = 97
        },
        new Movie()
        {
            Id = new Guid("4e35a624-d5db-4900-b43e-c0f9b7d28590"),
            Title = "Home Alone",
            Genre = "Comedy",
            Description =
                "A resourceful boy defends his house from burglars after his family leaves him behind for Christmas.",
            ShortDescription = "Kid vs burglars.",
            ReleaseDate = new DateOnly(1990, 11, 16),
            DirectorName = "Chris Columbus",
            Duration = 103
        },
        new Movie()
        {
            Id = new Guid("66275523-30e6-48e0-8c65-dab3d3fb12f8"),
            Title = "Step Brothers",
            Genre = "Comedy",
            Description = "Two immature middle-aged men become stepbrothers and turn family life into absurd chaos.",
            ShortDescription = "Immature sibling rivalry.",
            ReleaseDate = new DateOnly(2008, 7, 25),
            DirectorName = "Adam McKay",
            Duration = 98
        },
        new Movie()
        {
            Id = new Guid("d04029bd-e8d4-4e65-ac84-094d766d8306"),
            Title = "Anchorman",
            Genre = "Comedy",
            Description =
                "A pompous television news anchor struggles when a talented woman joins his male-dominated newsroom.",
            ShortDescription = "Absurd newsroom comedy.",
            ReleaseDate = new DateOnly(2004, 7, 9),
            DirectorName = "Adam McKay",
            Duration = 94
        },
        new Movie()
        {
            Id = new Guid("e9626460-ec88-4203-99b7-d918105fef03"),
            Title = "The Mask",
            Genre = "Comedy",
            Description = "A timid bank clerk discovers a magical mask that unleashes his outrageous alter ego.",
            ShortDescription = "Wild transformation comedy.",
            ReleaseDate = new DateOnly(1994, 7, 29),
            DirectorName = "Chuck Russell",
            Duration = 101
        },
        new Movie()
        {
            Id = new Guid("00641073-88cb-471e-bea0-8e6601494d09"),
            Title = "Rush Hour",
            Genre = "Comedy",
            Description =
                "An American detective and a Hong Kong inspector clash while solving a kidnapping case in Los Angeles.",
            ShortDescription = "Buddy cop comedy.",
            ReleaseDate = new DateOnly(1998, 9, 18),
            DirectorName = "Brett Ratner",
            Duration = 98
        },
        new Movie()
        {
            Id = new Guid("b0e94565-1376-46f0-b5c4-2aedc6d30ce7"),
            Title = "Bruce Almighty",
            Genre = "Comedy",
            Description =
                "A frustrated TV reporter is temporarily given divine powers and discovers their heavy consequences.",
            ShortDescription = "Man becomes God.",
            ReleaseDate = new DateOnly(2003, 5, 23),
            DirectorName = "Tom Shadyac",
            Duration = 101
        },
        new Movie()
        {
            Id = new Guid("23fb559e-9a66-4423-af07-b97d9de649fe"),
            Title = "Se7en",
            Genre = "Thriller",
            Description = "Two detectives pursue a serial killer who stages murders around the seven deadly sins.",
            ShortDescription = "Deadly sins serial killer case.",
            ReleaseDate = new DateOnly(1995, 9, 22),
            DirectorName = "David Fincher",
            Duration = 127
        },
        new Movie()
        {
            Id = new Guid("50219472-6180-4b85-a5ac-fdf4079ccf58"),
            Title = "Gone Girl",
            Genre = "Thriller",
            Description =
                "A man becomes the focus of a media storm when his wife vanishes under suspicious circumstances.",
            ShortDescription = "Missing wife mystery.",
            ReleaseDate = new DateOnly(2014, 10, 3),
            DirectorName = "David Fincher",
            Duration = 149
        },
        new Movie()
        {
            Id = new Guid("daed155e-81be-42e0-8d7a-dc2db09eb148"),
            Title = "The Silence of the Lambs",
            Genre = "Thriller",
            Description = "An FBI trainee seeks help from an imprisoned killer to catch another murderer.",
            ShortDescription = "Psychological killer hunt.",
            ReleaseDate = new DateOnly(1991, 2, 14),
            DirectorName = "Jonathan Demme",
            Duration = 118
        },
        new Movie()
        {
            Id = new Guid("e131229c-a516-492d-898d-635a5b6c95e4"),
            Title = "Shutter Island",
            Genre = "Thriller",
            Description =
                "A U.S. Marshal investigates a disappearance at a remote psychiatric hospital on an isolated island.",
            ShortDescription = "Island asylum mystery.",
            ReleaseDate = new DateOnly(2010, 2, 19),
            DirectorName = "Martin Scorsese",
            Duration = 138
        },
        new Movie()
        {
            Id = new Guid("40009b98-ece3-42b4-8c7d-a10b4dda5b38"),
            Title = "Prisoners",
            Genre = "Thriller",
            Description =
                "When two girls disappear, a desperate father and a detective pursue the truth by different means.",
            ShortDescription = "Kidnapping revenge story.",
            ReleaseDate = new DateOnly(2013, 9, 20),
            DirectorName = "Denis Villeneuve",
            Duration = 153
        },
        new Movie()
        {
            Id = new Guid("9dcd678b-7dee-47d1-aff7-567156607a86"),
            Title = "Zodiac",
            Genre = "Thriller",
            Description = "Journalists and investigators become consumed by the hunt for the elusive Zodiac killer.",
            ShortDescription = "Obsessive killer investigation.",
            ReleaseDate = new DateOnly(2007, 3, 2),
            DirectorName = "David Fincher",
            Duration = 157
        },
        new Movie()
        {
            Id = new Guid("794c142d-386f-4a8a-8290-adf396a07f6a"),
            Title = "Nightcrawler",
            Genre = "Thriller",
            Description =
                "An ambitious drifter enters the world of freelance crime journalism and crosses dangerous moral lines.",
            ShortDescription = "Dark media ambition.",
            ReleaseDate = new DateOnly(2014, 10, 31),
            DirectorName = "Dan Gilroy",
            Duration = 117
        },
        new Movie()
        {
            Id = new Guid("d5a8997f-b046-436f-aada-c06dd2ca0f1c"),
            Title = "The Girl with the Dragon Tattoo",
            Genre = "Thriller",
            Description =
                "A journalist and a brilliant hacker investigate a wealthy family’s decades-old disappearance.",
            ShortDescription = "Cold case mystery.",
            ReleaseDate = new DateOnly(2011, 12, 21),
            DirectorName = "David Fincher",
            Duration = 158
        },
        new Movie()
        {
            Id = new Guid("3a981e02-9650-4cc4-ba2f-978979789984"),
            Title = "Black Swan",
            Genre = "Thriller",
            Description =
                "A dedicated ballerina spirals into obsession while preparing for the dual lead in Swan Lake.",
            ShortDescription = "Psychological breakdown.",
            ReleaseDate = new DateOnly(2010, 12, 17),
            DirectorName = "Darren Aronofsky",
            Duration = 108
        },
        new Movie()
        {
            Id = new Guid("c6d7d61d-0ab2-4789-85fe-053e438cfe2a"),
            Title = "No Country for Old Men",
            Genre = "Thriller",
            Description = "After finding money at a drug deal gone wrong, a hunter is pursued by a relentless killer.",
            ShortDescription = "Relentless pursuit.",
            ReleaseDate = new DateOnly(2007, 11, 9),
            DirectorName = "Coen Brothers",
            Duration = 122
        },
        new Movie()
        {
            Id = new Guid("c2159ffd-c180-4a04-8499-62c1886a4ac9"),
            Title = "The Shawshank Redemption",
            Genre = "Drama",
            Description =
                "A wrongfully convicted banker forms a lasting friendship and quietly plans for hope and freedom.",
            ShortDescription = "Hope in prison.",
            ReleaseDate = new DateOnly(1994, 9, 23),
            DirectorName = "Frank Darabont",
            Duration = 142
        },
        new Movie()
        {
            Id = new Guid("c441109b-5d90-4b44-847f-ec113694e334"),
            Title = "Forrest Gump",
            Genre = "Drama",
            Description =
                "A kindhearted man unwittingly witnesses and influences major events in modern American history.",
            ShortDescription = "Life journey story.",
            ReleaseDate = new DateOnly(1994, 7, 6),
            DirectorName = "Robert Zemeckis",
            Duration = 142
        },
        new Movie()
        {
            Id = new Guid("f1ff0736-167e-464c-98b3-66361a5952bb"),
            Title = "Fight Club",
            Genre = "Drama",
            Description =
                "An insomniac office worker forms an underground fight club that evolves into something much darker.",
            ShortDescription = "Underground rebellion.",
            ReleaseDate = new DateOnly(1999, 10, 15),
            DirectorName = "David Fincher",
            Duration = 139
        },
        new Movie()
        {
            Id = new Guid("e02b1783-545f-4c73-8374-768e6cfbf4c4"),
            Title = "The Godfather",
            Genre = "Drama",
            Description = "The aging head of a crime family prepares for a dangerous transfer of power to his son.",
            ShortDescription = "Mafia family saga.",
            ReleaseDate = new DateOnly(1972, 3, 24),
            DirectorName = "Francis Ford Coppola",
            Duration = 175
        },
        new Movie()
        {
            Id = new Guid("86e3b9d0-b465-4b7e-95a4-f1da2a66ada2"),
            Title = "A Beautiful Mind",
            Genre = "Drama",
            Description = "Mathematician John Nash battles personal demons while pursuing brilliant academic work.",
            ShortDescription = "Genius and struggle.",
            ReleaseDate = new DateOnly(2001, 12, 21),
            DirectorName = "Ron Howard",
            Duration = 135
        },
        new Movie()
        {
            Id = new Guid("d19b2756-5235-4f96-9577-7281f1d36d38"),
            Title = "The Green Mile",
            Genre = "Drama",
            Description = "Death row guards encounter a prisoner with mysterious powers and extraordinary compassion.",
            ShortDescription = "Miracles in prison.",
            ReleaseDate = new DateOnly(1999, 12, 10),
            DirectorName = "Frank Darabont",
            Duration = 189
        },
        new Movie()
        {
            Id = new Guid("34b8a65e-15f2-424a-b164-600afe23f814"),
            Title = "Titanic",
            Genre = "Drama",
            Description = "A romance blossoms across class lines aboard the ill-fated RMS Titanic.",
            ShortDescription = "Tragic love story.",
            ReleaseDate = new DateOnly(1997, 12, 19),
            DirectorName = "James Cameron",
            Duration = 195
        },
        new Movie()
        {
            Id = new Guid("97448f10-b164-4880-82ed-a1ac239d0afd"),
            Title = "Whiplash",
            Genre = "Drama",
            Description = "A driven young drummer pushes himself to extremes under a brutally demanding instructor.",
            ShortDescription = "Obsession and discipline.",
            ReleaseDate = new DateOnly(2014, 10, 10),
            DirectorName = "Damien Chazelle",
            Duration = 107
        },
        new Movie()
        {
            Id = new Guid("91e01bcd-a47d-48d9-b79d-8ed6c4886699"),
            Title = "The Social Network",
            Genre = "Drama",
            Description = "The founding of Facebook sparks ambition, betrayal, and a series of legal battles.",
            ShortDescription = "Rise of Facebook.",
            ReleaseDate = new DateOnly(2010, 10, 1),
            DirectorName = "David Fincher",
            Duration = 120
        },
        new Movie()
        {
            Id = new Guid("7c1f4dea-492d-446f-ba11-aa0794b54350"),
            Title = "Joker",
            Genre = "Drama",
            Description =
                "A struggling comedian’s descent into alienation and violence reshapes Gotham’s social unrest.",
            ShortDescription = "Origin of Joker.",
            ReleaseDate = new DateOnly(2019, 10, 4),
            DirectorName = "Todd Phillips",
            Duration = 122
        },
        new Movie()
        {
            Id = new Guid("c4987c3e-6ee2-49f5-8caa-bb515b019e8b"),
            Title = "The Exorcist",
            Genre = "Horror",
            Description = "A young girl’s disturbing possession leads her mother to seek help from two priests.",
            ShortDescription = "Classic demonic possession horror.",
            ReleaseDate = new DateOnly(1973, 12, 26),
            DirectorName = "William Friedkin",
            Duration = 122
        },
        new Movie()
        {
            Id = new Guid("368e82a0-da8c-4d1b-90b0-749f12faecfa"),
            Title = "Hereditary",
            Genre = "Horror",
            Description =
                "After a family matriarch dies, grief uncovers terrifying secrets passed down through generations.",
            ShortDescription = "Family trauma turns supernatural.",
            ReleaseDate = new DateOnly(2018, 6, 8),
            DirectorName = "Ari Aster",
            Duration = 127
        },
        new Movie()
        {
            Id = new Guid("70a5373e-e526-4766-9194-e6d1a536485c"),
            Title = "The Conjuring",
            Genre = "Horror",
            Description = "Paranormal investigators help a family terrorized by a dark presence in their farmhouse.",
            ShortDescription = "Haunted farmhouse case.",
            ReleaseDate = new DateOnly(2013, 7, 19),
            DirectorName = "James Wan",
            Duration = 112
        },
        new Movie()
        {
            Id = new Guid("acc9eaf0-be41-4f4c-a4f2-4bee8da3e4a0"),
            Title = "A Nightmare on Elm Street",
            Genre = "Horror",
            Description = "Teenagers are hunted in their dreams by a burned killer who can kill them in real life.",
            ShortDescription = "Nightmare slasher classic.",
            ReleaseDate = new DateOnly(1984, 11, 9),
            DirectorName = "Wes Craven",
            Duration = 91
        }, 
        new Movie()
        {
            Id = new Guid("43268f2d-7bfb-4c62-b49d-b868b1fc2568"),
            Title = "Get Out",
            Genre = "Horror",
            Description =
                "A Black photographer uncovers a horrifying secret during a visit to his girlfriend’s family estate.",
            ShortDescription = "Social horror thriller.",
            ReleaseDate = new DateOnly(2017, 2, 24),
            DirectorName = "Jordan Peele",
            Duration = 104
        },
        new Movie()
        {
            Id = new Guid("b235003d-d473-464d-a300-7049e31d0a6d"),
            Title = "It",
            Genre = "Horror",
            Description = "A group of children face an ancient evil that takes the shape of a terrifying clown.",
            ShortDescription = "Killer clown nightmare.",
            ReleaseDate = new DateOnly(2017, 9, 8),
            DirectorName = "Andy Muschietti",
            Duration = 135
        },
        new Movie()
        {
            Id = new Guid("7c9e4721-3564-4a95-952b-37e8a5eff337"),
            Title = "The Ring",
            Genre = "Horror",
            Description =
                "A journalist investigates a cursed videotape said to kill viewers seven days after watching it.",
            ShortDescription = "Cursed videotape mystery.",
            ReleaseDate = new DateOnly(2002, 10, 18),
            DirectorName = "Gore Verbinski",
            Duration = 115
        },
        new Movie()
        {
            Id = new Guid("4d91f3a2-6c96-4a58-90f7-bbea29063a5f"),
            Title = "Halloween",
            Genre = "Horror",
            Description = "An escaped killer returns to his hometown on Halloween night to stalk babysitters.",
            ShortDescription = "Classic masked slasher.",
            ReleaseDate = new DateOnly(1978, 10, 25),
            DirectorName = "John Carpenter",
            Duration = 91
        },
        new Movie()
        {
            Id = new Guid("07d1c2e1-a2e2-4ee5-873f-b101cc613a25"),
            Title = "The Shining",
            Genre = "Horror",
            Description = "A writer’s isolation in a haunted hotel drives him toward madness and violence.",
            ShortDescription = "Haunted hotel descent.",
            ReleaseDate = new DateOnly(1980, 5, 23),
            DirectorName = "Stanley Kubrick",
            Duration = 146
        },
        new Movie()
        {
            Id = new Guid("f2661055-d0cd-4e35-ada5-bd9369ecc094"),
            Title = "Insidious",
            Genre = "Horror",
            Description = "Parents seek supernatural help when their son becomes a vessel for terrifying entities.",
            ShortDescription = "Astral haunting terror.",
            ReleaseDate = new DateOnly(2010, 9, 14),
            DirectorName = "James Wan",
            Duration = 103
        },
        new Movie()
        {
            Id = new Guid("93d7a78d-d7aa-43d0-8d7d-91a22b7c7619"),
            Title = "Avengers: Endgame",
            Genre = "Superhero",
            Description =
                "The Avengers mount a final, universe-spanning effort to undo catastrophic loss and defeat Thanos.",
            ShortDescription = "The Avengers’ final stand.",
            ReleaseDate = new DateOnly(2019, 4, 26),
            DirectorName = "Russo Brothers",
            Duration = 181
        },
        new Movie()
        {
            Id = new Guid("97951c83-8686-45c8-be13-a0b0f79539a5"),
            Title = "Spider-Man: No Way Home",
            Genre = "Superhero",
            Description =
                "Peter Parker seeks magical help after his identity is exposed, unleashing threats from other worlds.",
            ShortDescription = "Multiverse Spider-Man adventure.",
            ReleaseDate = new DateOnly(2021, 12, 17),
            DirectorName = "Jon Watts",
            Duration = 148
        },
        new Movie()
        {
            Id = new Guid("59d62ca3-2be7-4ef6-bfbc-362b4ff49fac"),
            Title = "Black Panther",
            Genre = "Superhero",
            Description =
                "T’Challa returns home to rule Wakanda but faces a challenger who threatens the nation’s future.",
            ShortDescription = "Wakanda’s king under threat.",
            ReleaseDate = new DateOnly(2018, 2, 16),
            DirectorName = "Ryan Coogler",
            Duration = 134
        },
        new Movie()
        {
            Id = new Guid("cb0c0fb5-1799-4ad4-99f3-d78c0a1e21cf"),
            Title = "Logan",
            Genre = "Superhero",
            Description = "An aging Wolverine protects a young mutant while trying to escape a violent future.",
            ShortDescription = "A brutal final journey.",
            ReleaseDate = new DateOnly(2017, 3, 3),
            DirectorName = "James Mangold",
            Duration = 137
        },
        new Movie()
        {
            Id = new Guid("75a766dd-73cd-4a3b-81ef-738e4b72a23d"),
            Title = "Iron Man",
            Genre = "Superhero",
            Description = "A billionaire inventor builds a powered suit and reinvents himself as a hero.",
            ShortDescription = "The birth of Iron Man.",
            ReleaseDate = new DateOnly(2008, 5, 2),
            DirectorName = "Jon Favreau",
            Duration = 126
        },
        new Movie()
        {
            Id = new Guid("512d850d-0dad-429a-a2f8-5a492651e8d5"),
            Title = "The Dark Knight Rises",
            Genre = "Superhero",
            Description = "Batman returns from retirement when Bane threatens Gotham with destruction and revolution.",
            ShortDescription = "Batman’s final battle.",
            ReleaseDate = new DateOnly(2012, 7, 20),
            DirectorName = "Christopher Nolan",
            Duration = 164
        },
        new Movie()
        {
            Id = new Guid("377d6f6f-4aeb-4046-9ded-dfaf7e8d59a5"),
            Title = "Deadpool",
            Genre = "Superhero",
            Description = "A mercenary gains accelerated healing and embraces a wisecracking vigilante persona.",
            ShortDescription = "R-rated antihero chaos.",
            ReleaseDate = new DateOnly(2016, 2, 12),
            DirectorName = "Tim Miller",
            Duration = 108
        },
        new Movie()
        {
            Id = new Guid("6ea110b0-5980-49ec-9812-bdc05ca854be"),
            Title = "Doctor Strange",
            Genre = "Superhero",
            Description = "A brilliant surgeon turns to mystic arts after a devastating accident ends his career.",
            ShortDescription = "Mystic origin story.",
            ReleaseDate = new DateOnly(2016, 11, 4),
            DirectorName = "Scott Derrickson",
            Duration = 115
        },
        new Movie()
        {
            Id = new Guid("d5e2cd4f-959d-4a19-becf-404713d46271"),
            Title = "Thor: Ragnarok",
            Genre = "Superhero",
            Description = "Thor must escape a distant world and stop Hela from bringing ruin to Asgard.",
            ShortDescription = "Cosmic comedy adventure.",
            ReleaseDate = new DateOnly(2017, 11, 3),
            DirectorName = "Taika Waititi",
            Duration = 130
        },
        new Movie()
        {
            Id = new Guid("5c3f62e1-a6ca-4286-9cb3-5cbc0afc3d8b"),
            Title = "Guardians of the Galaxy",
            Genre = "Superhero",
            Description = "A band of intergalactic misfits joins forces to protect a powerful orb from a fanatic.",
            ShortDescription = "Misfit heroes in space.",
            ReleaseDate = new DateOnly(2014, 8, 1),
            DirectorName = "James Gunn",
            Duration = 121
        }
    ];
}