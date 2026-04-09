using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Moviezilla.Data.Models;
using static Moviezilla.Data.Common.EntityConstants.Actor;

namespace Moviezilla.Data.Configurations;

public class ActorConfiguration :IEntityTypeConfiguration<Actor>
{
    public void Configure(EntityTypeBuilder<Actor> builder)
    {
        builder
            .HasKey(a => a.Id);

        builder
            .Property(a => a.Name)
            .IsRequired()
            .HasMaxLength(NameMaxLength);

        builder
            .Property(a => a.ShortBio)
            .HasMaxLength(BiographyMaxLength);

        builder
            .Property(a => a.ImageUrl)
            .HasMaxLength(ImageUrlMaxLength);
        
        builder
            .Property(a => a.IsDeleted)
            .IsRequired()
            .HasDefaultValue(false);
        
        builder
            .HasQueryFilter(a => !a.IsDeleted);
    }

    public static List<Actor> SeedActors() =>
    [
        new Actor()
        {
            Id = new Guid("6fd39241-45d7-4435-beeb-6ef22cc912de"),
            Name = "Aaron Eckhart",
            ShortBio = "American actor known for dramatic roles in thrillers and character-driven films."
        },
        new Actor()
        {
            Id = new Guid("4123086b-dc4f-4e51-81fa-f64a6fc7f7bd"),
            Name = "Al Pacino",
            ShortBio = "American actor known for intense, iconic roles in crime and drama."
        },
        new Actor()
        {
            Id = new Guid("a2a8ed1f-aa12-411b-a221-2d2cdd7d5f2e"),
            Name = "Alan Rickman",
            ShortBio = "English actor celebrated for sophisticated villains and commanding dramatic roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTUwNTc4MTg4Ml5BMl5BanBnXkFtZTcwNDY2MjkxOA@@._V1_FMjpg_UY1850_.jpg"
        },
        new Actor()
        {
            Id = new Guid("bec8cce9-b5a4-4a5d-8a39-ebac11c6448e"),
            Name = "Alex Wolff",
            ShortBio = "American actor and musician known for anxious, layered dramatic roles."
        },
        new Actor()
        {
            Id = new Guid("e0fb708c-3052-473c-9f03-29f855010c16"),
            Name = "Allison Williams",
            ShortBio = "American actress known for polished performances in TV and film."
        },
        new Actor()
        {
            Id = new Guid("f3b65829-46e4-4143-b39b-86136de26b7f"),
            Name = "Amanda Seyfried",
            ShortBio = "American actress known for musicals, dramas, and comedic roles."
        },
        new Actor()
        {
            Id = new Guid("8d806e2a-9b9e-407e-bfde-d95afc6f0c04"),
            Name = "Andrew Garfield",
            ShortBio = "English-American actor known for emotional performances in dramas and franchises."
        },
        new Actor()
        {
            Id = new Guid("cac1fee0-fd3a-47f8-b629-cb9b65d68b2c"),
            Name = "Anne Hathaway",
            ShortBio = "American actress known for elegant performances in drama, comedy, and musicals."
        },
        new Actor()
        {
            Id = new Guid("0f312b1b-a6cd-4ed2-afe9-6b493205c424"),
            Name = "Anthony Hopkins",
            ShortBio = "Welsh actor renowned for commanding dramatic and villainous roles."
        },
        new Actor()
        {
            Id = new Guid("d85eed69-92c7-4bcb-b978-9c2179a19f6c"),
            Name = "Arnold Schwarzenegger",
            ShortBio = "Austrian-American actor and former bodybuilder known for action cinema."
        },
        new Actor()
        {
            Id = new Guid("1fc801b0-0633-4cff-97fe-c6068014dfa4"),
            Name = "Barbara Hershey",
            ShortBio = "American actress known for commanding roles in drama and thriller films."
        },
        new Actor()
        {
            Id = new Guid("310706f7-2d9a-4e5a-8e2f-5214084fd26d"),
            Name = "Ben Affleck",
            ShortBio = "American actor, writer, and director known for thrillers and dramas."
        },
        new Actor()
        {
            Id = new Guid("de41865b-5b44-43f7-9275-495898638232"),
            Name = "Ben Kingsley",
            ShortBio = "English actor known for authoritative, versatile performances."
        },
        new Actor()
        {
            Id = new Guid("bbf4da5f-54e3-4659-b179-978e5f6ab285"),
            Name = "Benedict Cumberbatch",
            ShortBio = "English actor known for cerebral performances in drama and fantasy."
        },
        new Actor()
        {
            Id = new Guid("f42cbe69-d1a1-45bd-9a93-8aaa606744ca"),
            Name = "Bill Skarsgård",
            ShortBio = "Swedish actor known for unsettling performances in horror and drama."
        },
        new Actor()
        {
            Id = new Guid("9d666c80-52f7-4e34-8871-245c0911979e"),
            Name = "Billy Zane",
            ShortBio = "American actor known for villainous and charismatic supporting roles."
        },
        new Actor()
        {
            Id = new Guid("5429c902-48d3-4dec-beac-49f37ff0b08d"),
            Name = "Bob Gunton",
            ShortBio = "American actor known for stern, commanding supporting roles."
        },
        new Actor()
        {
            Id = new Guid("1856d962-d4cb-491a-a94e-072cfa5662bd"),
            Name = "Bonnie Bedelia",
            ShortBio = "American actress known for film and television roles across several decades.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNzEyOTA4MTM5OV5BMl5BanBnXkFtZTcwNTQ4NTQzMQ@@._V1_FMjpg_UX450_.jpg"
        },
        new Actor()
        {
            Id = new Guid("8441360b-3bb9-4f58-86c1-02dd3f04072a"),
            Name = "Brad Pitt",
            ShortBio = "American actor known for leading roles in dramas, thrillers, and action films."
        },
        new Actor()
        {
            Id = new Guid("f9e3238a-97a1-4718-ab92-31d5236547b3"),
            Name = "Bradley Cooper",
            ShortBio = "American actor known for comedies, dramas, and award-nominated performances."
        },
        new Actor()
        {
            Id = new Guid("138ce271-e924-4e54-930e-0d8c04d0fc77"),
            Name = "Bradley Whitford",
            ShortBio = "American actor known for sharp roles in drama, comedy, and political stories."
        },
        new Actor()
        {
            Id = new Guid("c897ed9b-a2ac-4e31-8fa4-8c26cc33c652"),
            Name = "Bruce Willis",
            ShortBio = "American actor famous for action roles and wisecracking screen presence.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjA0MjMzMTE5OF5BMl5BanBnXkFtZTcwMzQ2ODE3Mw@@._V1_FMjpg_UX340_.jpg"
        },
        new Actor()
        {
            Id = new Guid("411fdf1d-ff3a-490c-86ac-ef8252b5c0fa"),
            Name = "Cameron Diaz",
            ShortBio = "American actress known for romantic comedies, action, and comedic roles."
        },
        new Actor()
        {
            Id = new Guid("8dcde184-4ee9-4ac3-8a01-e8827834d161"),
            Name = "Carrie-Anne Moss",
            ShortBio = "Canadian actress known for science fiction, thrillers, and television dramas."
        },
        new Actor()
        {
            Id = new Guid("3fa7c993-1327-4a37-87f6-0020d90dbfea"),
            Name = "Cate Blanchett",
            ShortBio = "Australian actress known for commanding performances in drama and fantasy."
        },
        new Actor()
        {
            Id = new Guid("447f0422-0955-41e1-9b47-f2b09a8a474c"),
            Name = "Chadwick Boseman",
            ShortBio = "American actor remembered for dignified, powerful leading performances."
        },
        new Actor()
        {
            Id = new Guid("cf615463-d189-4221-b69d-373d9ecbe762"),
            Name = "Charlize Theron",
            ShortBio = "Academy Award-winning actress known for action films and dramatic performances.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTk5Mzc4ODU0Ml5BMl5BanBnXkFtZTcwNjU1NTI0Mw@@._V1_FMjpg_UX300_.jpg"
        },
        new Actor()
        {
            Id = new Guid("bb729c83-9964-434b-97b7-66c7665aa3da"),
            Name = "Chiwetel Ejiofor",
            ShortBio = "English actor known for dignified, layered dramatic performances."
        },
        new Actor()
        {
            Id = new Guid("925ac384-48c7-4eac-96fd-36bf2b9f6bd4"),
            Name = "Chris Evans",
            ShortBio = "American actor known for heroic roles and ensemble dramas."
        },
        new Actor()
        {
            Id = new Guid("2e7678ba-e51a-402a-ae90-6585b837ea90"),
            Name = "Chris Hemsworth",
            ShortBio = "Australian actor known for action roles and comedic charisma."
        },
        new Actor()
        {
            Id = new Guid("26d5c98a-347d-49b0-9268-2029a7f0ee98"),
            Name = "Chris Pratt",
            ShortBio = "American actor known for action-comedy leading roles."
        },
        new Actor()
        {
            Id = new Guid("32ac45d4-37c1-4f8c-9c9c-20e9cea6a21d"),
            Name = "Chris Tucker",
            ShortBio = "American comedian and actor known for high-energy comedic performances."
        },
        new Actor()
        {
            Id = new Guid("d1bdcd3f-a8be-4044-96b4-26a0745585e9"),
            Name = "Christian Bale",
            ShortBio = "English actor known for transformative performances in dramas and blockbusters."
        },
        new Actor()
        {
            Id = new Guid("8b3378bc-3e09-4921-9466-7bf8b3108211"),
            Name = "Christina Applegate",
            ShortBio = "American actress known for sharp comedic roles in film and television."
        },
        new Actor()
        {
            Id = new Guid("be6e3a70-0dd5-4da8-8534-4a208c09a614"),
            Name = "Christopher Mintz-Plasse",
            ShortBio = "American actor known for comedic supporting roles in youth-oriented films."
        },
        new Actor()
        {
            Id = new Guid("f8124011-adb0-4454-9da7-91f0e182fa33"),
            Name = "Christopher Plummer",
            ShortBio = "Canadian actor celebrated for distinguished stage and screen performances."
        },
        new Actor()
        {
            Id = new Guid("ceaeb56b-d490-44c9-961c-06e8af100ba6"),
            Name = "Connie Nielsen",
            ShortBio = "Danish actress known for historical epics, dramas, and genre films.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNzc2NDViYTctNmNhYy00ZTU0LTk5ODMtMzIxYjBlZTQ1MmFlXkEyXkFqcGc@._V1_FMjpg_UY1800_.jpg"
        },
        new Actor()
        {
            Id = new Guid("b6a14c4f-815e-4be4-b6b3-b69717718c8d"),
            Name = "Dafne Keen",
            ShortBio = "British-Spanish actress known for fierce breakout performances in action drama."
        },
        new Actor()
        {
            Id = new Guid("00085ee6-52df-4585-967b-408c7ba486be"),
            Name = "Daniel Craig",
            ShortBio = "English actor known for gritty leading roles and the James Bond series."
        },
        new Actor()
        {
            Id = new Guid("ed9b74af-8587-4aff-abd4-8957e4eb1ca7"),
            Name = "Daniel Kaluuya",
            ShortBio = "English actor known for intense, thoughtful performances in drama and horror."
        },
        new Actor()
        {
            Id = new Guid("aec03985-5285-415c-b7c2-1245a6751576"),
            Name = "Daniel Stern",
            ShortBio = "American actor known for comedic film roles and memorable character parts."
        },
        new Actor()
        {
            Id = new Guid("bfad936e-bf67-4b44-8a27-88606204e79e"),
            Name = "Dave Bautista",
            ShortBio = "American actor and former wrestler known for powerful comedic-action roles."
        },
        new Actor()
        {
            Id = new Guid("afaa9921-7f23-482b-b344-19e43274db30"),
            Name = "David Dorfman",
            ShortBio = "American actor known for intense child performances in thrillers."
        },
        new Actor()
        {
            Id = new Guid("29843c4b-6c08-4a57-9b36-95264eba65bd"),
            Name = "David Morse",
            ShortBio = "American actor known for grounded performances in film and television."
        },
        new Actor()
        {
            Id = new Guid("0dd7a860-af97-4fe5-86ca-d7b6a171e506"),
            Name = "David Wenham",
            ShortBio = "Australian actor known for historical epics and character-driven performances."
        },
        new Actor()
        {
            Id = new Guid("3b9bf0a1-5001-4946-a64f-fbfe3a6f73a1"),
            Name = "Donald Pleasence",
            ShortBio = "English actor known for distinctive performances in horror and war films."
        },
        new Actor()
        {
            Id = new Guid("29ac4686-bfcd-49dc-8646-876522ab6472"),
            Name = "Ed Harris",
            ShortBio = "American actor known for authoritative roles in dramas, westerns, and thrillers."
        },
        new Actor()
        {
            Id = new Guid("483c83dc-0645-46ea-80a7-2f227b5f80cf"),
            Name = "Ed Helms",
            ShortBio = "American actor and comedian known for awkward, upbeat comedic roles."
        },
        new Actor()
        {
            Id = new Guid("a9f10213-5b0f-42cb-b282-0daa96bb1519"),
            Name = "Ed Skrein",
            ShortBio = "English actor known for villainous and action-oriented performances."
        },
        new Actor()
        {
            Id = new Guid("bfc71005-46f5-4f0e-a05d-eb99293367d5"),
            Name = "Edward Furlong",
            ShortBio = "American actor known for breakout roles in 1990s dramas and action films."
        },
        new Actor()
        {
            Id = new Guid("a14ff11b-23f0-402f-ad77-15bdf9eb5a8d"),
            Name = "Edward Norton",
            ShortBio = "American actor known for cerebral, intense dramatic performances."
        },
        new Actor()
        {
            Id = new Guid("15aa84fd-f77a-483b-9499-7efa823c269c"),
            Name = "Ellen Burstyn",
            ShortBio = "American actress known for powerful dramatic performances."
        },
        new Actor()
        {
            Id = new Guid("c7483292-2173-429e-bf47-be27c5dc820b"),
            Name = "Eva Green",
            ShortBio = "French actress recognized for mysterious, dramatic, and fantasy roles."
        },
        new Actor()
        {
            Id = new Guid("1d4c8ea4-7f11-453b-8be8-e2218e767055"),
            Name = "Gary Sinise",
            ShortBio = "American actor known for disciplined, empathetic roles in drama and television."
        },
        new Actor()
        {
            Id = new Guid("101916e7-e588-499f-829a-daa2793c23e8"),
            Name = "Gerard Butler",
            ShortBio = "Scottish actor known for action films, thrillers, and dramatic roles."
        },
        new Actor()
        {
            Id = new Guid("51bab7d6-b37f-40b4-b787-5f6cb30af6f4"),
            Name = "Gwyneth Paltrow",
            ShortBio = "American actress known for dramas, romances, and character-driven films."
        },
        new Actor()
        {
            Id = new Guid("50cafa2b-71bd-4ea8-8eb0-a5ee95eff467"),
            Name = "Heath Ledger",
            ShortBio = "Australian actor remembered for emotionally rich performances and iconic roles."
        },
        new Actor()
        {
            Id = new Guid("3de01bc3-0480-4a01-8593-ddfb1849ff9b"),
            Name = "Heather Langenkamp",
            ShortBio = "American actress known for her defining role in horror cinema."
        },
        new Actor()
        {
            Id = new Guid("539b371e-f3ec-4d09-8add-4072cd23d277"),
            Name = "Helena Bonham Carter",
            ShortBio = "English actress known for eccentric, gothic, and dramatic roles."
        },
        new Actor()
        {
            Id = new Guid("cee50ddf-38c4-40fb-91a3-02bfc7bee4aa"),
            Name = "Henry Cavill",
            ShortBio = "British actor known for action franchises and heroic screen roles."
        },
        new Actor()
        {
            Id = new Guid("b391372d-3bfd-48e4-be60-c343cc4b4f3f"),
            Name = "Hugh Jackman",
            ShortBio = "Australian actor known for musicals, dramas, and action franchises."
        },
        new Actor()
        {
            Id = new Guid("cda5b584-c19f-48e5-9e4b-787bbbd441ff"),
            Name = "Ian McShane",
            ShortBio = "English actor known for charismatic performances in crime, fantasy, and drama.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMmMyNDcwMDgtMmIxNC00NTcyLWIwMmItNDQzNmJjNmVhYjhhXkEyXkFqcGc@._V1_FMjpg_UY4774_.jpg"
        },
        new Actor()
        {
            Id = new Guid("43c89467-ac0e-4e79-9f8e-929848c36d6a"),
            Name = "Alfie Allen",
            ShortBio = "English actor best known for playing Theon Greyjoy in the HBO series Game of Thrones (2011-2019)",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BOTlhODE3NjItNTExYi00MGIzLWEzMzYtMTRlN2MwZmJlM2QxXkEyXkFqcGc@._V1_FMjpg_UX643_.jpg"
        },
        new Actor()
        {
            Id = new Guid("34ed4fe5-d30b-4edc-a00f-f75f019d46a3"),
            Name = "J.K. Simmons",
            ShortBio = "American actor known for commanding, versatile performances in film and TV."
        },
        new Actor()
        {
            Id = new Guid("cf61c4ca-a860-4e52-848a-4014f336afc9"),
            Name = "Jack Nicholson",
            ShortBio = "American actor known for explosive, charismatic dramatic performances."
        },
        new Actor()
        {
            Id = new Guid("846cc4c2-430e-42e8-b9a8-f3369310563a"),
            Name = "Jackie Chan",
            ShortBio = "Hong Kong actor and martial artist known for action-comedy stunts."
        },
        new Actor()
        {
            Id = new Guid("1c76e80e-212e-49c2-bb82-d3cb7bb8a9ca"),
            Name = "Jaeden Martell",
            ShortBio = "American actor known for youthful dramatic and horror performances."
        },
        new Actor()
        {
            Id = new Guid("b32c87ff-b412-42d3-bbc1-521841443d40"),
            Name = "Jake Gyllenhaal",
            ShortBio = "American actor known for intense and versatile dramatic performances."
        },
        new Actor()
        {
            Id = new Guid("cfde46c5-342f-4560-85d2-493f082e0a01"),
            Name = "James Caan",
            ShortBio = "American actor known for forceful roles in crime films and dramas."
        },
        new Actor()
        {
            Id = new Guid("158a9d99-77ae-46ca-8818-65ab53540d11"),
            Name = "Jamie Lee Curtis",
            ShortBio = "American actress known as a horror icon and comedy star."
        },
        new Actor()
        {
            Id = new Guid("9af80152-7958-47f9-8f8a-b1394b62bc12"),
            Name = "Javier Bardem",
            ShortBio = "Spanish actor known for powerful, menacing, and dramatic roles."
        },
        new Actor()
        {
            Id = new Guid("2f5d38f8-9375-4e62-bde1-801bc44f2908"),
            Name = "Jeff Bridges",
            ShortBio = "American actor known for relaxed, commanding performances across genres."
        },
        new Actor()
        {
            Id = new Guid("2c4f6a03-d0b1-4e0e-8e5a-d824d9ffa7c7"),
            Name = "Jeff Daniels",
            ShortBio = "American actor known for both serious dramas and comedic roles."
        },
        new Actor()
        {
            Id = new Guid("bd607b66-67f7-4fa5-8798-56fecc7d83e8"),
            Name = "Jennifer Aniston",
            ShortBio = "American actress known for television, romantic comedies, and light dramas."
        },
        new Actor()
        {
            Id = new Guid("b30648a8-3bfe-43be-bc09-65caf669fb09"),
            Name = "Jennifer Connelly",
            ShortBio = "American actress known for emotionally rich performances in drama and fantasy."
        },
        new Actor()
        {
            Id = new Guid("44907d33-053a-47f7-ac1b-a2fddbbea5cc"),
            Name = "Jesse Eisenberg",
            ShortBio = "American actor known for fast-talking, intellectual dramatic roles."
        },
        new Actor()
        {
            Id = new Guid("362cae35-adc0-4ad9-8ff5-8a6603edf315"),
            Name = "Jim Carrey",
            ShortBio = "Canadian-American actor famous for elastic comedy and dramatic reinvention."
        },
        new Actor()
        {
            Id = new Guid("176400ce-53cf-4576-a2ed-432f78a43240"),
            Name = "Joaquin Phoenix",
            ShortBio = "American actor acclaimed for intense, transformative character work.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BYjFjNGYzYjEtNGE0Ny00M2IyLTk5ZmYtODE3ZGFkMzVjYmNmXkEyXkFqcGc@._V1_FMjpg_UX214_.jpg"
        },
        new Actor()
        {
            Id = new Guid("d1c69566-30fd-47b2-9128-b7aadd4722a1"),
            Name = "Jodie Foster",
            ShortBio = "American actress known for intelligent, intense performances."
        },
        new Actor()
        {
            Id = new Guid("d70a393d-94ed-424f-ad8f-b0a041617c52"),
            Name = "Joe Pesci",
            ShortBio = "American actor known for intense crime roles and sharp comedic turns."
        },
        new Actor()
        {
            Id = new Guid("e1d47d6f-e0e3-4214-b4f7-21b37d6db88d"),
            Name = "John C. Reilly",
            ShortBio = "American actor known for dramatic range and distinctive comedic performances."
        },
        new Actor()
        {
            Id = new Guid("65970305-4fc7-4890-9f0b-5063affce076"),
            Name = "John Saxon",
            ShortBio = "American actor known for genre classics and tough authority figures."
        },
        new Actor()
        {
            Id = new Guid("1251c5c5-0fdd-40c1-89d7-0e10b338300c"),
            Name = "Jonah Hill",
            ShortBio = "American actor, writer, and producer known for comedy and dramatic turns."
        },
        new Actor()
        {
            Id = new Guid("9ff68d83-fc39-4081-ae3f-06ef755711d3"),
            Name = "Josh Brolin",
            ShortBio = "American actor known for rugged performances in crime, western, and superhero films."
        },
        new Actor()
        {
            Id = new Guid("263f806e-5bb0-4cc5-bdc1-a6130e3a6ae7"),
            Name = "Justin Timberlake",
            ShortBio = "American singer and actor known for stylish supporting roles in drama and comedy."
        },
        new Actor()
        {
            Id = new Guid("084b109f-15d5-473a-9baa-ab748f461af5"),
            Name = "Kate Winslet",
            ShortBio = "English actress known for emotionally precise performances in drama and romance."
        },
        new Actor()
        {
            Id = new Guid("d246a339-8c96-4ee4-9377-c6110d1ebaef"),
            Name = "Keanu Reeves",
            ShortBio = "Canadian actor known for action franchises and understated leading roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNDEzOTdhNDUtY2EyMy00YTNmLWE5MjItZmRjMmQzYTRlMGRkXkEyXkFqcGc@._V1_FMjpg_UY2700_.jpg"
        },
        new Actor()
        {
            Id = new Guid("bf824b1f-8c4d-4be3-9566-dee5b7e512b0"),
            Name = "Lauren Holly",
            ShortBio = "American-Canadian actress known for film, television, and romantic comedies."
        },
        new Actor()
        {
            Id = new Guid("f80c0da1-8be6-4a46-a578-edfce3af270d"),
            Name = "Laurence Fishburne",
            ShortBio = "American actor known for authoritative performances in film, TV, and theater."
        },
        new Actor()
        {
            Id = new Guid("3998723a-ebb9-4e63-a96b-8575e5345e5b"),
            Name = "Lena Headey",
            ShortBio = "English actress known for intense roles in fantasy, drama, and action."
        },
        new Actor()
        {
            Id = new Guid("a5381bf5-482b-4f12-9d17-d10e8fcb6fc1"),
            Name = "Leonardo DiCaprio",
            ShortBio = "American actor known for ambitious roles in major dramas and thrillers."
        },
        new Actor()
        {
            Id = new Guid("95ce32f0-7a46-4e31-8459-cd6ee973dba9"),
            Name = "Lili Taylor",
            ShortBio = "American actress known for nuanced independent and genre roles."
        },
        new Actor()
        {
            Id = new Guid("76039504-7ee7-4356-a79d-161486a5b162"),
            Name = "Linda Blair",
            ShortBio = "American actress known for her iconic breakthrough role in horror."
        },
        new Actor()
        {
            Id = new Guid("453399e4-7c51-46d3-aeae-99eb8f06fef9"),
            Name = "Linda Hamilton",
            ShortBio = "American actress best known for tough, resilient action roles."
        },
        new Actor()
        {
            Id = new Guid("84982976-ae90-4237-9520-d6239df1458d"),
            Name = "Lindsay Lohan",
            ShortBio = "American actress known for teen comedies and coming-of-age films."
        },
        new Actor()
        {
            Id = new Guid("01258edc-1458-4035-af5c-19fde8c99a1d"),
            Name = "Lupita Nyong'o",
            ShortBio = "Kenyan-Mexican actress known for emotionally vivid performances."
        },
        new Actor()
        {
            Id = new Guid("fed28090-372d-456f-9a1e-c207058ac144"),
            Name = "Macaulay Culkin",
            ShortBio = "American actor known for iconic child performances in family comedies."
        },
        new Actor()
        {
            Id = new Guid("086a28bc-461c-4360-90e6-d34634bc7930"),
            Name = "Mads Mikkelsen",
            ShortBio = "Danish actor known for chilling villains and acclaimed dramatic performances."
        },
        new Actor()
        {
            Id = new Guid("18638236-cb2e-4892-befc-cf0068444068"),
            Name = "Mark Ruffalo",
            ShortBio = "American actor known for thoughtful performances in dramas and ensemble films."
        },
        new Actor()
        {
            Id = new Guid("38ebb771-b41b-43c4-ae42-d5da412e04d9"),
            Name = "Marlon Brando",
            ShortBio = "American actor regarded as one of cinema’s most influential performers."
        },
        new Actor()
        {
            Id = new Guid("1cea7dbe-d8be-44bc-bdcc-2ebfa35e8c9f"),
            Name = "Martin Henderson",
            ShortBio = "New Zealand actor known for drama, romance, and suspense roles."
        },
        new Actor()
        {
            Id = new Guid("d31a1794-c533-4a9a-85a9-d90e3390c8dd"),
            Name = "Mary Steenburgen",
            ShortBio = "American actress known for warm, versatile performances in film and TV."
        },
        new Actor()
        {
            Id = new Guid("b6564219-9a09-4767-b494-e9fd622084b0"),
            Name = "Max von Sydow",
            ShortBio = "Swedish actor known for towering performances in international cinema."
        },
        new Actor()
        {
            Id = new Guid("5b20c518-2ac0-4dbb-9e2f-db4d9f0bb879"),
            Name = "Michael B. Jordan",
            ShortBio = "American actor known for intense roles in drama and franchise films."
        },
        new Actor()
        {
            Id = new Guid("0a1a093a-54e3-454d-86f9-73523144b49d"),
            Name = "Michael Cera",
            ShortBio = "Canadian actor known for understated comic timing and indie films."
        },
        new Actor()
        {
            Id = new Guid("61cfb611-b7b6-4a63-8edc-7183a7a2dc35"),
            Name = "Michael Clarke Duncan",
            ShortBio = "American actor known for imposing yet gentle dramatic roles."
        },
        new Actor()
        {
            Id = new Guid("64ea884a-b2a5-46ae-9532-ce5d559ead97"),
            Name = "Michael Nyqvist",
            ShortBio = "Swedish actor known internationally for thrillers and crime dramas.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTg1MDM4MTg1NV5BMl5BanBnXkFtZTcwMTExOTcwNw@@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("990f0803-c80f-40cf-9d02-910e3d46a962"),
            Name = "Mila Kunis",
            ShortBio = "American actress known for comedy, drama, and psychological thrillers."
        },
        new Actor()
        {
            Id = new Guid("0863f099-87d9-4590-8a19-083384c1aa91"),
            Name = "Miles Teller",
            ShortBio = "American actor known for youthful dramatic roles and intense performances."
        },
        new Actor()
        {
            Id = new Guid("eaf447ef-beea-4eaa-a94c-00acd311ef42"),
            Name = "Milly Shapiro",
            ShortBio = "American actress known for eerie, memorable genre performances."
        },
        new Actor()
        {
            Id = new Guid("12cf4f78-7a6f-4421-b158-9df0034694e1"),
            Name = "Morena Baccarin",
            ShortBio = "Brazilian-American actress known for genre television and film roles."
        },
        new Actor()
        {
            Id = new Guid("0dc023ca-c84f-4c6b-a1c3-ed3ca625b7bd"),
            Name = "Morgan Freeman",
            ShortBio = "American actor known for authoritative, warm performances across genres."
        },
        new Actor()
        {
            Id = new Guid("baf8a9c9-d344-4e6f-b802-a85dad91ffb9"),
            Name = "Naomi Watts",
            ShortBio = "British-Australian actress known for psychological dramas and thrillers."
        },
        new Actor()
        {
            Id = new Guid("f2dfcabe-52e1-4e25-84f2-054cc9f9a772"),
            Name = "Natalie Portman",
            ShortBio = "Israeli-American actress known for dramatic, psychological, and sci-fi roles."
        },
        new Actor()
        {
            Id = new Guid("545d9868-b224-46c4-9b60-21271dc2adc2"),
            Name = "Neil Patrick Harris",
            ShortBio = "American actor known for comedy, stage work, and dramatic supporting roles."
        },
        new Actor()
        {
            Id = new Guid("af0ea72b-6f8f-4db0-afa7-2ea8c7859c30"),
            Name = "Nicholas Hoult",
            ShortBio = "English actor recognized for roles in period dramas, action films, and dark comedies.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BZDE2YjY4ODUtZjVmMy00ZmE2LTgwZjgtMWJiZGI0NWY3ODAzXkEyXkFqcGc@._V1_FMjpg_UY4500_.jpg"
        },
        new Actor()
        {
            Id = new Guid("e4a264bc-0a02-4720-917c-fca59bb573ff"),
            Name = "Nick Castle",
            ShortBio = "American actor, writer, and director remembered for an iconic horror role."
        },
        new Actor()
        {
            Id = new Guid("8044275d-432e-4e99-a403-bc47b7208011"),
            Name = "Patrick Stewart",
            ShortBio = "English actor known for dignified performances in stage, sci-fi, and drama."
        },
        new Actor()
        {
            Id = new Guid("2f276480-e052-4120-85d6-7f5fb2a0141f"),
            Name = "Patrick Wilson",
            ShortBio = "American actor known for horror, drama, and musical performances."
        },
        new Actor()
        {
            Id = new Guid("f3d34bfd-85e1-4dec-bc22-5f4eca6c9fc2"),
            Name = "Paul Dano",
            ShortBio = "American actor known for nuanced roles in indie films and major dramas."
        },
        new Actor()
        {
            Id = new Guid("3c328dc2-54a1-4a48-8962-6e7f903f2162"),
            Name = "Paul Reiser",
            ShortBio = "American actor and comedian known for television and supporting film roles."
        },
        new Actor()
        {
            Id = new Guid("ef1f2981-782a-40c7-b0dc-5e6a85bb7055"),
            Name = "Peter Riegert",
            ShortBio = "American actor known for character roles in comedies and dramas."
        },
        new Actor()
        {
            Id = new Guid("9af1c7b4-2511-48e0-8868-fc0dab590d71"),
            Name = "Rachel McAdams",
            ShortBio = "Canadian actress known for charismatic performances in dramas and comedies."
        },
        new Actor()
        {
            Id = new Guid("70705055-5ce6-4a88-a3ba-5e031ae9b786"),
            Name = "Rebecca Ferguson",
            ShortBio = "Swedish actress known for suspenseful performances in action and drama."
        },
        new Actor()
        {
            Id = new Guid("9c39c7a7-3897-494b-a8b5-970dd50d88b6"),
            Name = "Rene Russo",
            ShortBio = "American actress known for thrillers, dramas, and sharp character roles."
        },
        new Actor()
        {
            Id = new Guid("8ba7acf6-a509-48fe-92c0-c8c0528569fd"),
            Name = "Riz Ahmed",
            ShortBio = "British actor and musician known for intense performances across film and TV."
        },
        new Actor()
        {
            Id = new Guid("09ad1d06-e8a1-406e-890b-d744e67ffa76"),
            Name = "Robert De Niro",
            ShortBio = "American actor known for legendary performances in crime films and dramas."
        },
        new Actor()
        {
            Id = new Guid("d875ff93-4c8d-4470-9c2e-66209c6d63f2"),
            Name = "Robert Downey Jr.",
            ShortBio = "American actor known for charismatic performances in drama, comedy, and superhero films."
        },
        new Actor()
        {
            Id = new Guid("bc2dd711-8eac-439d-9353-dd355849ed8e"),
            Name = "Robert Englund",
            ShortBio = "American actor best known for iconic horror villain roles."
        },
        new Actor()
        {
            Id = new Guid("ba291cbf-a1f6-4a18-bfa8-fb2a3c299e6f"),
            Name = "Robin Wright",
            ShortBio = "American actress known for emotionally grounded performances in film and television."
        },
        new Actor()
        {
            Id = new Guid("57ad6e92-9f65-4871-b922-11600447149c"),
            Name = "Rooney Mara",
            ShortBio = "American actress known for intense, understated dramatic performances."
        },
        new Actor()
        {
            Id = new Guid("25538521-d4f1-4ca8-ba20-1628c98b6930"),
            Name = "Rosamund Pike",
            ShortBio = "English actress known for intelligent, composed performances in thrillers and dramas."
        },
        new Actor()
        {
            Id = new Guid("e52850d9-f3a4-4d46-a265-3667403ac2e9"),
            Name = "Rose Byrne",
            ShortBio = "Australian actress known for smart performances in comedy, drama, and horror."
        },
        new Actor()
        {
            Id = new Guid("5d7cdba3-e8dc-4f19-a8a3-8992aec07fae"),
            Name = "Russell Crowe",
            ShortBio = "New Zealand-born actor known for powerful dramatic and historical performances.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTQyMTExNTMxOF5BMl5BanBnXkFtZTcwNDg1NzkzNw@@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("e175c472-5291-47de-832d-003b3aa6527a"),
            Name = "Ryan Reynolds",
            ShortBio = "Canadian actor known for fast-talking comedy and action roles."
        },
        new Actor()
        {
            Id = new Guid("dfe14619-506f-4f09-9a8e-8bf0fdaa4e83"),
            Name = "Scarlett Johansson",
            ShortBio = "American actress known for action, drama, and emotionally complex roles."
        },
        new Actor()
        {
            Id = new Guid("655b7c4a-7bde-4498-82b2-46288064039f"),
            Name = "Scatman Crothers",
            ShortBio = "American actor and musician known for warm supporting performances."
        },
        new Actor()
        {
            Id = new Guid("fcece400-14b5-481a-b5d7-fe67bf28f913"),
            Name = "Scott Glenn",
            ShortBio = "American actor known for rugged roles in thrillers, dramas, and westerns."
        },
        new Actor()
        {
            Id = new Guid("9186ec1d-7199-439e-b062-a103f1371d54"),
            Name = "Shelley Duvall",
            ShortBio = "American actress known for vulnerable, distinctive screen presence."
        },
        new Actor()
        {
            Id = new Guid("8904c86f-88c7-4575-9c5a-70d83a4a53db"),
            Name = "Sophia Lillis",
            ShortBio = "American actress known for coming-of-age and genre roles."
        },
        new Actor()
        {
            Id = new Guid("10ba4f1b-fb6f-4040-a38a-1de45d9d7605"),
            Name = "Steve Carell",
            ShortBio = "American actor and comedian known for awkward, lovable comedic characters."
        },
        new Actor()
        {
            Id = new Guid("1a536677-8b72-42dc-b7ec-506ab25c501f"),
            Name = "Tilda Swinton",
            ShortBio = "Scottish actress known for transformative art-house and blockbuster roles."
        },
        new Actor()
        {
            Id = new Guid("12b4e8b1-deee-4931-baa3-bc4d5f3efb9b"),
            Name = "Tim Robbins",
            ShortBio = "American actor known for thoughtful performances in dramas and political films."
        },
        new Actor()
        {
            Id = new Guid("6547e436-757f-4cb1-a179-f337b0922121"),
            Name = "Tom Cruise",
            ShortBio = "American actor and producer known for blockbuster action and dramatic roles."
        },
        new Actor()
        {
            Id = new Guid("ad15e2ca-4491-413c-a95b-8b2cc8935c4c"),
            Name = "Tom Hanks",
            ShortBio = "American actor known for warm, versatile performances in dramas and comedies."
        },
        new Actor()
        {
            Id = new Guid("bc65dca2-6946-4eeb-841d-add7c0fd0376"),
            Name = "Tom Hardy",
            ShortBio = "English actor known for intense performances in action, crime, and dramatic roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTQ3ODEyNjA4Nl5BMl5BanBnXkFtZTgwMTE4ODMyMjE@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("1f7c2d4c-cfb4-47ca-ba0e-575c6e5b1ae2"),
            Name = "Tom Hiddleston",
            ShortBio = "English actor known for intelligent, charismatic dramatic roles."
        },
        new Actor()
        {
            Id = new Guid("50e895bc-e9e1-445b-a99c-6615bd33437a"),
            Name = "Tom Holland",
            ShortBio = "English actor known for youthful energy and blockbuster leading roles."
        },
        new Actor()
        {
            Id = new Guid("556360a7-3f73-48c6-b971-52ff34371b93"),
            Name = "Tommy Lee Jones",
            ShortBio = "American actor known for stoic performances in dramas, thrillers, and westerns."
        },
        new Actor()
        {
            Id = new Guid("fd960aa9-8876-4dff-9d99-94c1c3738c04"),
            Name = "Toni Collette",
            ShortBio = "Australian actress known for emotionally intense performances."
        },
        new Actor()
        {
            Id = new Guid("e337f1ec-b22c-4ddf-8b5e-bd5afa946129"),
            Name = "Tzi Ma",
            ShortBio = "Hong Kong-American actor known for supporting roles in film and television."
        },
        new Actor()
        {
            Id = new Guid("179a8c49-2ace-4cc3-bef6-0d76f135c1ec"),
            Name = "Vera Farmiga",
            ShortBio = "American actress known for psychological dramas and horror films."
        },
        new Actor()
        {
            Id = new Guid("08d54a07-c4a3-4467-8c2d-2791ccc3cb86"),
            Name = "Vincent Cassel",
            ShortBio = "French actor known for intense roles in international dramas and thrillers."
        },
        new Actor()
        {
            Id = new Guid("a1c457e5-d6b5-4fce-81a1-e570ebca481a"),
            Name = "Will Ferrell",
            ShortBio = "American comedian and actor known for broad, improvisational comedy."
        },
        new Actor()
        {
            Id = new Guid("0f0f48ae-983b-48b1-a574-a8dc4f6ace0b"),
            Name = "Zach Galifianakis",
            ShortBio = "American comedian and actor known for offbeat and eccentric characters."
        },
        new Actor()
        {
            Id = new Guid("dc4a4b36-d647-43f9-b215-1a6024cc712f"),
            Name = "Zazie Beetz",
            ShortBio = "German-American actress known for energetic roles in drama, comedy, and genre films."
        },
        new Actor()
        {
            Id = new Guid("7c144da1-9cb5-498f-9f04-8d6d5418455e"),
            Name = "Zendaya",
            ShortBio = "American actress and singer known for modern drama, romance, and franchise films."
        },
        new Actor()
        {
            Id = new Guid("a7c020f2-1864-4e0a-98a5-4d3b03f6eee7"),
            Name = "Zoe Saldaña",
            ShortBio = "American actress known for major science fiction and action franchises."
        },
    ];
}