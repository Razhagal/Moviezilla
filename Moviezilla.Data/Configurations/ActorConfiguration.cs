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
            ShortBio = "American actor known for dramatic roles in thrillers and character-driven films.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTc4MTAyNzMzNF5BMl5BanBnXkFtZTcwMzQ5MzQzMg@@._V1_FMjpg_UX286_.jpg"
        },
        new Actor()
        {
            Id = new Guid("4123086b-dc4f-4e51-81fa-f64a6fc7f7bd"),
            Name = "Al Pacino",
            ShortBio = "American actor known for intense, iconic roles in crime and drama.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTQzMzg1ODAyNl5BMl5BanBnXkFtZTYwMjAxODQ1._V1_FMjpg_UX266_.jpg"
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
            ShortBio = "American actor and musician known for anxious, layered dramatic roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BZjM2ZTEzZGQtMzA2Ni00MWQ3LTg1ZmMtMDM1MjgzOTU3YmQ5XkEyXkFqcGc@._V1_FMjpg_UY3360_.jpg"
        },
        new Actor()
        {
            Id = new Guid("e0fb708c-3052-473c-9f03-29f855010c16"),
            Name = "Allison Williams",
            ShortBio = "American actress known for polished performances in TV and film.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BM2IwNWZlYTQtYzYzMi00Mjg0LThmNTctODkzY2IyNGEzYTAzXkEyXkFqcGc@._V1_FMjpg_UY3600_.jpg"
        },
        new Actor()
        {
            Id = new Guid("f3b65829-46e4-4143-b39b-86136de26b7f"),
            Name = "Amanda Seyfried",
            ShortBio = "American actress known for musicals, dramas, and comedic roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BYTM0ZDcxNzctMzIwNi00NjliLTg5YzEtZDc4MDk0MDFiNzA4XkEyXkFqcGc@._V1_FMjpg_UX1168_.jpg"
        },
        new Actor()
        {
            Id = new Guid("8d806e2a-9b9e-407e-bfde-d95afc6f0c04"),
            Name = "Andrew Garfield",
            ShortBio = "English-American actor known for emotional performances in dramas and franchises.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BYWQyNzhiZjYtNjJlOS00MTRlLWI0YTYtZjg1YzJmNTc2YjQwXkEyXkFqcGc@._V1_FMjpg_UY8192_.jpg"
        },
        new Actor()
        {
            Id = new Guid("cac1fee0-fd3a-47f8-b629-cb9b65d68b2c"),
            Name = "Anne Hathaway",
            ShortBio = "American actress known for elegant performances in drama, comedy, and musicals.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNzA0MWI3ZDgtMDVkZS00NTVhLTkwMzQtNmNlODk5MDYzMzFmXkEyXkFqcGc@._V1_FMjpg_UY3000_.jpg"
        },
        new Actor()
        {
            Id = new Guid("0f312b1b-a6cd-4ed2-afe9-6b493205c424"),
            Name = "Anthony Hopkins",
            ShortBio = "Welsh actor renowned for commanding dramatic and villainous roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTg5ODk1NTc5Ml5BMl5BanBnXkFtZTYwMjAwOTI4._V1_FMjpg_UX287_.jpg"
        },
        new Actor()
        {
            Id = new Guid("d85eed69-92c7-4bcb-b978-9c2179a19f6c"),
            Name = "Arnold Schwarzenegger",
            ShortBio = "Austrian-American actor and former bodybuilder known for action cinema.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTI3MDc4NzUyMV5BMl5BanBnXkFtZTcwMTQyMTc5MQ@@._V1_FMjpg_UX318_.jpg"
        },
        new Actor()
        {
            Id = new Guid("1fc801b0-0633-4cff-97fe-c6068014dfa4"),
            Name = "Barbara Hershey",
            ShortBio = "American actress known for commanding roles in drama and thriller films.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTMwNzQ1NjU1N15BMl5BanBnXkFtZTcwNjYzMTkwNA@@._V1_FMjpg_UX266_.jpg"
        },
        new Actor()
        {
            Id = new Guid("310706f7-2d9a-4e5a-8e2f-5214084fd26d"),
            Name = "Ben Affleck",
            ShortBio = "American actor, writer, and director known for thrillers and dramas.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNTFjZDU5NmYtYzZlMy00YThmLTg5ZjUtYjkyZWI2OTk2Mjc1XkEyXkFqcGc@._V1_FMjpg_UY5041_.jpg"
        },
        new Actor()
        {
            Id = new Guid("de41865b-5b44-43f7-9275-495898638232"),
            Name = "Ben Kingsley",
            ShortBio = "English actor known for authoritative, versatile performances.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BOTU2Njg2NzM4M15BMl5BanBnXkFtZTgwNjYwNjQwMTI@._V1_FMjpg_UX595_.jpg"
        },
        new Actor()
        {
            Id = new Guid("bbf4da5f-54e3-4659-b179-978e5f6ab285"),
            Name = "Benedict Cumberbatch",
            ShortBio = "English actor known for cerebral performances in drama and fantasy.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjE0MDkzMDQwOF5BMl5BanBnXkFtZTgwOTE1Mjg1MzE@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("f42cbe69-d1a1-45bd-9a93-8aaa606744ca"),
            Name = "Bill Skarsgård",
            ShortBio = "Swedish actor known for unsettling performances in horror and drama.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMmNhMDQ1YjktYTg1Ny00Mjg0LWFmZTgtMmE0OTkxYmQzYzVlXkEyXkFqcGc@._V1_FMjpg_UX2160_.jpg"
        },
        new Actor()
        {
            Id = new Guid("9d666c80-52f7-4e34-8871-245c0911979e"),
            Name = "Billy Zane",
            ShortBio = "American actor known for villainous and charismatic supporting roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTI5NzA2NTE0NF5BMl5BanBnXkFtZTcwNzAxMTUxMw@@._V1_FMjpg_UX309_.jpg"
        },
        new Actor()
        {
            Id = new Guid("5429c902-48d3-4dec-beac-49f37ff0b08d"),
            Name = "Bob Gunton",
            ShortBio = "American actor known for stern, commanding supporting roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BOWQ1ZTI1ZDgtMjhmZC00OWExLTliNWQtNzgxNTExZWIwMDJkXkEyXkFqcGc@._V1_FMjpg_UY4811_.jpg"
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
            ShortBio = "American actor known for leading roles in dramas, thrillers, and action films.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjA1MjE2MTQ2MV5BMl5BanBnXkFtZTcwMjE5MDY0Nw@@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("f9e3238a-97a1-4718-ab92-31d5236547b3"),
            Name = "Bradley Cooper",
            ShortBio = "American actor known for comedies, dramas, and award-nominated performances.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BY2YwYjg4NjItZGFjNC00NzgzLWJhMTktYTZmODlmM2Y4ODJjXkEyXkFqcGc@._V1_FMjpg_UY5000_.jpg"
        },
        new Actor()
        {
            Id = new Guid("138ce271-e924-4e54-930e-0d8c04d0fc77"),
            Name = "Bradley Whitford",
            ShortBio = "American actor known for sharp roles in drama, comedy, and political stories.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjQwMzg3ODUxNF5BMl5BanBnXkFtZTgwMzc5MDcxNDM@._V1_FMjpg_UY2048_.jpg"
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
            ShortBio = "American actress known for romantic comedies, action, and comedic roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTkxNTI5NzM4MV5BMl5BanBnXkFtZTcwMTI3ODY3Mg@@._V1_FMjpg_UX271_.jpg"
        },
        new Actor()
        {
            Id = new Guid("8dcde184-4ee9-4ac3-8a01-e8827834d161"),
            Name = "Carrie-Anne Moss",
            ShortBio = "Canadian actress known for science fiction, thrillers, and television dramas.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTYxMjgwNzEwOF5BMl5BanBnXkFtZTcwNTQ0NzI5Ng@@._V1_QL75_UY414_CR17,0,280,414_.jpg"
        },
        new Actor()
        {
            Id = new Guid("3fa7c993-1327-4a37-87f6-0020d90dbfea"),
            Name = "Cate Blanchett",
            ShortBio = "Australian actress known for commanding performances in drama and fantasy.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTc1MDI0MDg1NV5BMl5BanBnXkFtZTgwMDM3OTAzMTE@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("447f0422-0955-41e1-9b47-f2b09a8a474c"),
            Name = "Chadwick Boseman",
            ShortBio = "American actor remembered for dignified, powerful leading performances.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTk2OTY5MzcwMV5BMl5BanBnXkFtZTgwODM4MDI5MjI@._V1_FMjpg_UX750_.jpg"
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
            ShortBio = "English actor known for dignified, layered dramatic performances.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNzA5MDEyMTY3Nl5BMl5BanBnXkFtZTgwODQ0MjcxMDE@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("925ac384-48c7-4eac-96fd-36bf2b9f6bd4"),
            Name = "Chris Evans",
            ShortBio = "American actor known for heroic roles and ensemble dramas.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNzQ0YWM1ODEtZDFkYy00MGJhLTkwZDUtMzVkZjljODU3ZTRmXkEyXkFqcGc@._V1_FMjpg_UY6000_.jpg"
        },
        new Actor()
        {
            Id = new Guid("2e7678ba-e51a-402a-ae90-6585b837ea90"),
            Name = "Chris Hemsworth",
            ShortBio = "Australian actor known for action roles and comedic charisma.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BOTU2MTI0NTIyNV5BMl5BanBnXkFtZTcwMTA4Nzc3OA@@._V1_FMjpg_UX384_.jpg"
        },
        new Actor()
        {
            Id = new Guid("26d5c98a-347d-49b0-9268-2029a7f0ee98"),
            Name = "Chris Pratt",
            ShortBio = "American actor known for action-comedy leading roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BY2I4MGI5ZmItZWNlNy00ZTZkLWJhMTgtMDhmYTRmNzUwNTI3XkEyXkFqcGc@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("32ac45d4-37c1-4f8c-9c9c-20e9cea6a21d"),
            Name = "Chris Tucker",
            ShortBio = "American comedian and actor known for high-energy comedic performances.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTc4NjAxMjQwMF5BMl5BanBnXkFtZTYwMzcxOTg0._V1_FMjpg_UX291_.jpg"
        },
        new Actor()
        {
            Id = new Guid("d1bdcd3f-a8be-4044-96b4-26a0745585e9"),
            Name = "Christian Bale",
            ShortBio = "English actor known for transformative performances in dramas and blockbusters.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTkxMzk4MjQ4MF5BMl5BanBnXkFtZTcwMzExODQxOA@@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("8b3378bc-3e09-4921-9466-7bf8b3108211"),
            Name = "Christina Applegate",
            ShortBio = "American actress known for sharp comedic roles in film and television.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTk2NDc2OTE2Nl5BMl5BanBnXkFtZTcwMTc4NDcxNg@@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("be6e3a70-0dd5-4da8-8534-4a208c09a614"),
            Name = "Christopher Mintz-Plasse",
            ShortBio = "American actor known for comedic supporting roles in youth-oriented films.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTQyNjUzMDk5N15BMl5BanBnXkFtZTcwNzk0Nzk5Mw@@._V1_FMjpg_UX295_.jpg"
        },
        new Actor()
        {
            Id = new Guid("f8124011-adb0-4454-9da7-91f0e182fa33"),
            Name = "Christopher Plummer",
            ShortBio = "Canadian actor celebrated for distinguished stage and screen performances.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTU5MzQ5MDY3NF5BMl5BanBnXkFtZTcwNzMxOTU5Ng@@._V1_FMjpg_UY2048_.jpg"
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
            ShortBio = "British-Spanish actress known for fierce breakout performances in action drama.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BOWI1M2MxM2YtMDdiNy00NTAwLWE2YzctMmU0MDlmNDUwYTIzXkEyXkFqcGc@._V1_FMjpg_UY3500_.jpg"
        },
        new Actor()
        {
            Id = new Guid("00085ee6-52df-4585-967b-408c7ba486be"),
            Name = "Daniel Craig",
            ShortBio = "English actor known for gritty leading roles and the James Bond series.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjEzMjk4NDU4MF5BMl5BanBnXkFtZTcwMDMyNjQzMg@@._V1_FMjpg_UX269_.jpg"
        },
        new Actor()
        {
            Id = new Guid("ed9b74af-8587-4aff-abd4-8957e4eb1ca7"),
            Name = "Daniel Kaluuya",
            ShortBio = "English actor known for intense, thoughtful performances in drama and horror.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BOTk1MzgzOTg5OV5BMl5BanBnXkFtZTcwNDQ4NjMxOA@@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("aec03985-5285-415c-b7c2-1245a6751576"),
            Name = "Daniel Stern",
            ShortBio = "American actor known for comedic film roles and memorable character parts.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTI3NTcwNDcxMF5BMl5BanBnXkFtZTcwMTI3Mjc4Mg@@._V1_FMjpg_UX297_.jpg"
        },
        new Actor()
        {
            Id = new Guid("bfad936e-bf67-4b44-8a27-88606204e79e"),
            Name = "Dave Bautista",
            ShortBio = "American actor and former wrestler known for powerful comedic-action roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BZjYyZTc3MzEtZTk0OC00NWNlLWJmOTMtYjFmOGY1YjZlNjI5XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg"
        },
        new Actor()
        {
            Id = new Guid("afaa9921-7f23-482b-b344-19e43274db30"),
            Name = "David Dorfman",
            ShortBio = "American actor known for intense child performances in thrillers.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNjQ2NzgzNTM0N15BMl5BanBnXkFtZTgwMzY0MDkyMzI@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("29843c4b-6c08-4a57-9b36-95264eba65bd"),
            Name = "David Morse",
            ShortBio = "American actor known for grounded performances in film and television.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTgwNjUzOTE1N15BMl5BanBnXkFtZTYwNTU4NDQ0._V1_FMjpg_UX273_.jpg"
        },
        new Actor()
        {
            Id = new Guid("0dd7a860-af97-4fe5-86ca-d7b6a171e506"),
            Name = "David Wenham",
            ShortBio = "Australian actor known for historical epics and character-driven performances.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTI0MjkxOTg1Nl5BMl5BanBnXkFtZTYwNjgyODgz._V1_FMjpg_UX286_.jpg"
        },
        new Actor()
        {
            Id = new Guid("3b9bf0a1-5001-4946-a64f-fbfe3a6f73a1"),
            Name = "Donald Pleasence",
            ShortBio = "English actor known for distinctive performances in horror and war films.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BODYyM2EwNGUtY2UzOS00YmQ2LWJlNWItMGUyMjU0NmYyYTBlXkEyXkFqcGc@._V1_FMjpg_UY2403_.jpg"
        },
        new Actor()
        {
            Id = new Guid("29ac4686-bfcd-49dc-8646-876522ab6472"),
            Name = "Ed Harris",
            ShortBio = "American actor known for authoritative roles in dramas, westerns, and thrillers.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjE4NDM4ODc2OV5BMl5BanBnXkFtZTcwNzA5NjQ5MQ@@._V1_FMjpg_UX289_.jpg"
        },
        new Actor()
        {
            Id = new Guid("483c83dc-0645-46ea-80a7-2f227b5f80cf"),
            Name = "Ed Helms",
            ShortBio = "American actor and comedian known for awkward, upbeat comedic roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTk2MDQwODEwNV5BMl5BanBnXkFtZTcwNjc4MTY0NA@@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("a9f10213-5b0f-42cb-b282-0daa96bb1519"),
            Name = "Ed Skrein",
            ShortBio = "English actor known for villainous and action-oriented performances.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BZDQ2MTUzMTktYTY0My00ODRlLTg0MWQtMDQwYzY4ZTQxNGViXkEyXkFqcGc@._V1_FMjpg_UY5253_.jpg"
        },
        new Actor()
        {
            Id = new Guid("bfc71005-46f5-4f0e-a05d-eb99293367d5"),
            Name = "Edward Furlong",
            ShortBio = "American actor known for breakout roles in 1990s dramas and action films.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTI1MzgxODkyMl5BMl5BanBnXkFtZTcwNTc1NDIzMQ@@._V1_FMjpg_UX450_.jpg"
        },
        new Actor()
        {
            Id = new Guid("a14ff11b-23f0-402f-ad77-15bdf9eb5a8d"),
            Name = "Edward Norton",
            ShortBio = "American actor known for cerebral, intense dramatic performances.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTYwNjQ5MTI1NF5BMl5BanBnXkFtZTcwMzU5MTI2Mw@@._V1_FMjpg_UX312_.jpg"
        },
        new Actor()
        {
            Id = new Guid("15aa84fd-f77a-483b-9499-7efa823c269c"),
            Name = "Ellen Burstyn",
            ShortBio = "American actress known for powerful dramatic performances.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTU4MjYxMDc3MF5BMl5BanBnXkFtZTYwNzU3MDIz._V1_FMjpg_UX267_.jpg"
        },
        new Actor()
        {
            Id = new Guid("c7483292-2173-429e-bf47-be27c5dc820b"),
            Name = "Eva Green",
            ShortBio = "French actress recognized for mysterious, dramatic, and fantasy roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTQ0MDA2ODE2Ml5BMl5BanBnXkFtZTcwMjI0Nzc3Nw@@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("1d4c8ea4-7f11-453b-8be8-e2218e767055"),
            Name = "Gary Sinise",
            ShortBio = "American actor known for disciplined, empathetic roles in drama and television.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMzE4NzcyMzU3OV5BMl5BanBnXkFtZTYwOTM2NDE2._V1_FMjpg_UX287_.jpg"
        },
        new Actor()
        {
            Id = new Guid("101916e7-e588-499f-829a-daa2793c23e8"),
            Name = "Gerard Butler",
            ShortBio = "Scottish actor known for action films, thrillers, and dramatic roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjE4NDMwMzc4Ml5BMl5BanBnXkFtZTcwMDg4Nzg4Mg@@._V1_FMjpg_UX285_.jpg"
        },
        new Actor()
        {
            Id = new Guid("51bab7d6-b37f-40b4-b787-5f6cb30af6f4"),
            Name = "Gwyneth Paltrow",
            ShortBio = "American actress known for dramas, romances, and character-driven films.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNzIxOTQ1NTU1OV5BMl5BanBnXkFtZTcwMTQ4MDY0Nw@@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("50cafa2b-71bd-4ea8-8eb0-a5ee95eff467"),
            Name = "Heath Ledger",
            ShortBio = "Australian actor remembered for emotionally rich performances and iconic roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTI2NTY0NzA4MF5BMl5BanBnXkFtZTYwMjE1MDE0._V1_FMjpg_UX267_.jpg"
        },
        new Actor()
        {
            Id = new Guid("3de01bc3-0480-4a01-8593-ddfb1849ff9b"),
            Name = "Heather Langenkamp",
            ShortBio = "American actress known for her defining role in horror cinema.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNGQ0ODZlNzEtODUwNy00M2QxLTlmNzUtODg5OWE4NjJkMDg4XkEyXkFqcGc@._V1_FMjpg_UY3000_.jpg"
        },
        new Actor()
        {
            Id = new Guid("539b371e-f3ec-4d09-8add-4072cd23d277"),
            Name = "Helena Bonham Carter",
            ShortBio = "English actress known for eccentric, gothic, and dramatic roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTc2OTMxNDIzMF5BMl5BanBnXkFtZTcwNDU1MjA1NA@@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("cee50ddf-38c4-40fb-91a3-02bfc7bee4aa"),
            Name = "Henry Cavill",
            ShortBio = "British actor known for action franchises and heroic screen roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNWFmNmI2NmYtNDUyYi00MDZhLTk0ZmEtODY0MmM5NGQxMWEwXkEyXkFqcGc@._V1_FMjpg_UX819_.jpg"
        },
        new Actor()
        {
            Id = new Guid("b391372d-3bfd-48e4-be60-c343cc4b4f3f"),
            Name = "Hugh Jackman",
            ShortBio = "Australian actor known for musicals, dramas, and action franchises.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNDExMzIzNjk3Nl5BMl5BanBnXkFtZTcwOTE4NDU5OA@@._V1_FMjpg_UY2048_.jpg"
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
            ShortBio = "American actor known for commanding, versatile performances in film and TV.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMzg2NTI5NzQ1MV5BMl5BanBnXkFtZTgwNjI1NDEwMDI@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("cf61c4ca-a860-4e52-848a-4014f336afc9"),
            Name = "Jack Nicholson",
            ShortBio = "American actor known for explosive, charismatic dramatic performances.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTQ3OTY0ODk0M15BMl5BanBnXkFtZTYwNzE4Njc4._V1_FMjpg_UX289_.jpg"
        },
        new Actor()
        {
            Id = new Guid("846cc4c2-430e-42e8-b9a8-f3369310563a"),
            Name = "Jackie Chan",
            ShortBio = "Hong Kong actor and martial artist known for action-comedy stunts.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTk4MDM0MDUzM15BMl5BanBnXkFtZTcwOTI4MzU1Mw@@._V1_FMjpg_UX288_.jpg"
        },
        new Actor()
        {
            Id = new Guid("1c76e80e-212e-49c2-bb82-d3cb7bb8a9ca"),
            Name = "Jaeden Martell",
            ShortBio = "American actor known for youthful dramatic and horror performances.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNWRiYjk4MTItNWMzMC00ZjE1LWFlNDItNDI2MmI4MDZlZjlkXkEyXkFqcGc@._V1_FMjpg_UY4841_.jpg"
        },
        new Actor()
        {
            Id = new Guid("b32c87ff-b412-42d3-bbc1-521841443d40"),
            Name = "Jake Gyllenhaal",
            ShortBio = "American actor known for intense and versatile dramatic performances.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNjA0MTU2NDY3MF5BMl5BanBnXkFtZTgwNDU4ODkzMzE@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("cfde46c5-342f-4560-85d2-493f082e0a01"),
            Name = "James Caan",
            ShortBio = "American actor known for forceful roles in crime films and dramas.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTI5NjkyNDQ3NV5BMl5BanBnXkFtZTcwNjY5NTQ0Mw@@._V1_FMjpg_UX267_.jpg"
        },
        new Actor()
        {
            Id = new Guid("158a9d99-77ae-46ca-8818-65ab53540d11"),
            Name = "Jamie Lee Curtis",
            ShortBio = "American actress known as a horror icon and comedy star.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjI0MTI0MDk2OV5BMl5BanBnXkFtZTgwODQ4MTE0NDE@._V1_FMjpg_UX564_.jpg"
        },
        new Actor()
        {
            Id = new Guid("9af80152-7958-47f9-8f8a-b1394b62bc12"),
            Name = "Javier Bardem",
            ShortBio = "Spanish actor known for powerful, menacing, and dramatic roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTY1NTc4NTYzMF5BMl5BanBnXkFtZTcwNDIwOTY1NA@@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("2f5d38f8-9375-4e62-bde1-801bc44f2908"),
            Name = "Jeff Bridges",
            ShortBio = "American actor known for relaxed, commanding performances across genres.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNTU1NjM4MDYzMl5BMl5BanBnXkFtZTcwMjIwMjMyMw@@._V1_FMjpg_UX448_.jpg"
        },
        new Actor()
        {
            Id = new Guid("2c4f6a03-d0b1-4e0e-8e5a-d824d9ffa7c7"),
            Name = "Jeff Daniels",
            ShortBio = "American actor known for both serious dramas and comedic roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BODA3MDI4NDcxNV5BMl5BanBnXkFtZTYwOTgyMzY1._V1_FMjpg_UX266_.jpg"
        },
        new Actor()
        {
            Id = new Guid("bd607b66-67f7-4fa5-8798-56fecc7d83e8"),
            Name = "Jennifer Aniston",
            ShortBio = "American actress known for television, romantic comedies, and light dramas.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNjk1MjIxNjUxNF5BMl5BanBnXkFtZTcwODk2NzM4Mg@@._V1_FMjpg_UX279_.jpg"
        },
        new Actor()
        {
            Id = new Guid("b30648a8-3bfe-43be-bc09-65caf669fb09"),
            Name = "Jennifer Connelly",
            ShortBio = "American actress known for emotionally rich performances in drama and fantasy.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNGMwYmU3MTAtYjcyOC00NGMzLTgzYzItMTc4YzQwNzNhYjRmXkEyXkFqcGc@._V1_FMjpg_UY2723_.jpg"
        },
        new Actor()
        {
            Id = new Guid("44907d33-053a-47f7-ac1b-a2fddbbea5cc"),
            Name = "Jesse Eisenberg",
            ShortBio = "American actor known for fast-talking, intellectual dramatic roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNTE3MzQzODE3OV5BMl5BanBnXkFtZTcwMDE0ODY1NA@@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("362cae35-adc0-4ad9-8ff5-8a6603edf315"),
            Name = "Jim Carrey",
            ShortBio = "Canadian-American actor famous for elastic comedy and dramatic reinvention.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTQwMjAwNzI0M15BMl5BanBnXkFtZTcwOTY1MTMyOQ@@._V1_FMjpg_UY2048_.jpg"
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
            ShortBio = "American actress known for intelligent, intense performances.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTM3MjgyOTQwNF5BMl5BanBnXkFtZTcwMDczMzEwNA@@._V1_FMjpg_UX274_.jpg"
        },
        new Actor()
        {
            Id = new Guid("d70a393d-94ed-424f-ad8f-b0a041617c52"),
            Name = "Joe Pesci",
            ShortBio = "American actor known for intense crime roles and sharp comedic turns.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMzc3MTcxNDYxNV5BMl5BanBnXkFtZTcwOTI3NjE1Mw@@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("e1d47d6f-e0e3-4214-b4f7-21b37d6db88d"),
            Name = "John C. Reilly",
            ShortBio = "American actor known for dramatic range and distinctive comedic performances.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTc5MTMyMzUwM15BMl5BanBnXkFtZTgwMTgwMjExNzM@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("65970305-4fc7-4890-9f0b-5063affce076"),
            Name = "John Saxon",
            ShortBio = "American actor known for genre classics and tough authority figures.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTk2NjE1NTk3Ml5BMl5BanBnXkFtZTcwOTAzMjg0NA@@._V1_FMjpg_UX2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("1251c5c5-0fdd-40c1-89d7-0e10b338300c"),
            Name = "Jonah Hill",
            ShortBio = "American actor, writer, and producer known for comedy and dramatic turns.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTUyNDU0NzAwNl5BMl5BanBnXkFtZTcwMzQxMzIzNw@@._V1_FMjpg_UX460_.jpg"
        },
        new Actor()
        {
            Id = new Guid("9ff68d83-fc39-4081-ae3f-06ef755711d3"),
            Name = "Josh Brolin",
            ShortBio = "American actor known for rugged performances in crime, western, and superhero films.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTQ1MzYyMjQ0Nl5BMl5BanBnXkFtZTcwMTA0ODkyMg@@._V1_FMjpg_UX266_.jpg"
        },
        new Actor()
        {
            Id = new Guid("263f806e-5bb0-4cc5-bdc1-a6130e3a6ae7"),
            Name = "Justin Timberlake",
            ShortBio = "American singer and actor known for stylish supporting roles in drama and comedy.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTUwMjE1MjU2N15BMl5BanBnXkFtZTcwNjk0ODY1NA@@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("084b109f-15d5-473a-9baa-ab748f461af5"),
            Name = "Kate Winslet",
            ShortBio = "English actress known for emotionally precise performances in drama and romance.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BODgzMzM2NTE0Ml5BMl5BanBnXkFtZTcwMTcyMTkyOQ@@._V1_FMjpg_UY2048_.jpg"
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
            ShortBio = "American-Canadian actress known for film, television, and romantic comedies.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BN2JjYThiNTQtZmUwYy00MDliLWE4NmQtNjc0ZDNlMzJkNTZkXkEyXkFqcGc@._V1_FMjpg_UX2160_.jpg"
        },
        new Actor()
        {
            Id = new Guid("f80c0da1-8be6-4a46-a578-edfce3af270d"),
            Name = "Laurence Fishburne",
            ShortBio = "American actor known for authoritative performances in film, TV, and theater.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTc0NjczNDc1MV5BMl5BanBnXkFtZTYwMDU0Mjg1._V1_FMjpg_UX267_.jpg"
        },
        new Actor()
        {
            Id = new Guid("3998723a-ebb9-4e63-a96b-8575e5345e5b"),
            Name = "Lena Headey",
            ShortBio = "English actress known for intense roles in fantasy, drama, and action.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMzIwMjIwNjg0M15BMl5BanBnXkFtZTgwOTI3MDEzMDE@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("a5381bf5-482b-4f12-9d17-d10e8fcb6fc1"),
            Name = "Leonardo DiCaprio",
            ShortBio = "American actor known for ambitious roles in major dramas and thrillers.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjI0MTg3MzI0M15BMl5BanBnXkFtZTcwMzQyODU2Mw@@._V1_FMjpg_UX297_.jpg"
        },
        new Actor()
        {
            Id = new Guid("95ce32f0-7a46-4e31-8459-cd6ee973dba9"),
            Name = "Lili Taylor",
            ShortBio = "American actress known for nuanced independent and genre roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTAyNzAyMzA1ODZeQTJeQWpwZ15BbWU4MDAzNDQxNjkx._V1_FMjpg_UX607_.jpg"
        },
        new Actor()
        {
            Id = new Guid("76039504-7ee7-4356-a79d-161486a5b162"),
            Name = "Linda Blair",
            ShortBio = "American actress known for her iconic breakthrough role in horror.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTYxNzMxMTMwMV5BMl5BanBnXkFtZTYwODM3MTI0._V1_FMjpg_UX267_.jpg"
        },
        new Actor()
        {
            Id = new Guid("453399e4-7c51-46d3-aeae-99eb8f06fef9"),
            Name = "Linda Hamilton",
            ShortBio = "American actress best known for tough, resilient action roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BZTI1MmRmYmMtYTZiMy00NGFkLThkMGEtNjgyYjFhMzE2NjUzXkEyXkFqcGc@._V1_FMjpg_UY3456_.jpg"
        },
        new Actor()
        {
            Id = new Guid("84982976-ae90-4237-9520-d6239df1458d"),
            Name = "Lindsay Lohan",
            ShortBio = "American actress known for teen comedies and coming-of-age films.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BN2VmNGZjNmItOTQ2Zi00ZjVhLWI2ZGItYzNiMzQ2NjVhZTYxXkEyXkFqcGc@._V1_FMjpg_UX921_.jpg"
        },
        new Actor()
        {
            Id = new Guid("01258edc-1458-4035-af5c-19fde8c99a1d"),
            Name = "Lupita Nyong'o",
            ShortBio = "Kenyan-Mexican actress known for emotionally vivid performances.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTY0NTQ4MDY2Nl5BMl5BanBnXkFtZTgwNDk1MTEyMDE@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("fed28090-372d-456f-9a1e-c207058ac144"),
            Name = "Macaulay Culkin",
            ShortBio = "American actor known for iconic child performances in family comedies.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTM1NzUwMjY2M15BMl5BanBnXkFtZTcwOTI5MTMyMw@@._V1_FMjpg_UX399_.jpg"
        },
        new Actor()
        {
            Id = new Guid("086a28bc-461c-4360-90e6-d34634bc7930"),
            Name = "Mads Mikkelsen",
            ShortBio = "Danish actor known for chilling villains and acclaimed dramatic performances.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTcyMTU5MzgxMF5BMl5BanBnXkFtZTYwMDI0NjI1._V1_FMjpg_UX267_.jpg"
        },
        new Actor()
        {
            Id = new Guid("18638236-cb2e-4892-befc-cf0068444068"),
            Name = "Mark Ruffalo",
            ShortBio = "American actor known for thoughtful performances in dramas and ensemble films.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BM2JiYzA0ZGItNmFhYy00MjIyLWEwN2QtMzRmNDUyNjNiZjBiXkEyXkFqcGc@._V1_FMjpg_UY7360_.jpg"
        },
        new Actor()
        {
            Id = new Guid("38ebb771-b41b-43c4-ae42-d5da412e04d9"),
            Name = "Marlon Brando",
            ShortBio = "American actor regarded as one of cinema’s most influential performers.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTg3MDYyMDE5OF5BMl5BanBnXkFtZTcwNjgyNTEzNA@@._V1_FMjpg_UX1023_.jpg"
        },
        new Actor()
        {
            Id = new Guid("1cea7dbe-d8be-44bc-bdcc-2ebfa35e8c9f"),
            Name = "Martin Henderson",
            ShortBio = "New Zealand actor known for drama, romance, and suspense roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjc4MTA3NDIzNF5BMl5BanBnXkFtZTcwNTIwNTU5MQ@@._V1_FMjpg_UY400_.jpg"
        },
        new Actor()
        {
            Id = new Guid("d31a1794-c533-4a9a-85a9-d90e3390c8dd"),
            Name = "Mary Steenburgen",
            ShortBio = "American actress known for warm, versatile performances in film and TV.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTk1OTI5OTc0Nl5BMl5BanBnXkFtZTcwNjc5NDMwNA@@._V1_FMjpg_UX305_.jpg"
        },
        new Actor()
        {
            Id = new Guid("b6564219-9a09-4767-b494-e9fd622084b0"),
            Name = "Max von Sydow",
            ShortBio = "Swedish actor known for towering performances in international cinema.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTI3MDQzOTMwN15BMl5BanBnXkFtZTYwMDgyMjM1._V1_FMjpg_UX275_.jpg"
        },
        new Actor()
        {
            Id = new Guid("5b20c518-2ac0-4dbb-9e2f-db4d9f0bb879"),
            Name = "Michael B. Jordan",
            ShortBio = "American actor known for intense roles in drama and franchise films.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjExOTY3NzExM15BMl5BanBnXkFtZTgwOTg1OTAzMTE@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("0a1a093a-54e3-454d-86f9-73523144b49d"),
            Name = "Michael Cera",
            ShortBio = "Canadian actor known for understated comic timing and indie films.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNTgyNDgxMjUyOV5BMl5BanBnXkFtZTcwMDYxNzY1OQ@@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("61cfb611-b7b6-4a63-8edc-7183a7a2dc35"),
            Name = "Michael Clarke Duncan",
            ShortBio = "American actor known for imposing yet gentle dramatic roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTI3NDY2ODk5OV5BMl5BanBnXkFtZTYwMjQ0NzE0._V1_FMjpg_UX340_.jpg"
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
            ShortBio = "American actress known for comedy, drama, and psychological thrillers.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BODQyNTQyNzY4MV5BMl5BanBnXkFtZTcwODg5MDA3MQ@@._V1_FMjpg_UX334_.jpg"
        },
        new Actor()
        {
            Id = new Guid("0863f099-87d9-4590-8a19-083384c1aa91"),
            Name = "Miles Teller",
            ShortBio = "American actor known for youthful dramatic roles and intense performances.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNWI3YWY1NWQtNDVhMy00ZWE1LWI2MzUtOTczNTg5MTllZmNjXkEyXkFqcGc@._V1_FMjpg_UY3611_.jpg"
        },
        new Actor()
        {
            Id = new Guid("eaf447ef-beea-4eaa-a94c-00acd311ef42"),
            Name = "Milly Shapiro",
            ShortBio = "American actress known for eerie, memorable genre performances.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BZWY3YTE1MGQtOTI0Ni00YmRmLWIyZGUtOTYxNWFlNmQxMWZkXkEyXkFqcGc@._V1_FMjpg_UY4746_.jpg"
        },
        new Actor()
        {
            Id = new Guid("12cf4f78-7a6f-4421-b158-9df0034694e1"),
            Name = "Morena Baccarin",
            ShortBio = "Brazilian-American actress known for genre television and film roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMDliNjQxZmQtZDM2ZS00MzEwLTliMjQtYTlmYTdiYTI3OWIyXkEyXkFqcGc@._V1_FMjpg_UX960_.jpg"
        },
        new Actor()
        {
            Id = new Guid("0dc023ca-c84f-4c6b-a1c3-ed3ca625b7bd"),
            Name = "Morgan Freeman",
            ShortBio = "American actor known for authoritative, warm performances across genres.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTc0MDMyMzI2OF5BMl5BanBnXkFtZTcwMzM2OTk1MQ@@._V1_FMjpg_UX267_.jpg"
        },
        new Actor()
        {
            Id = new Guid("baf8a9c9-d344-4e6f-b802-a85dad91ffb9"),
            Name = "Naomi Watts",
            ShortBio = "British-Australian actress known for psychological dramas and thrillers.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjIzMjY1NTA4OF5BMl5BanBnXkFtZTcwNjk3MDYwOQ@@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("f2dfcabe-52e1-4e25-84f2-054cc9f9a772"),
            Name = "Natalie Portman",
            ShortBio = "Israeli-American actress known for dramatic, psychological, and sci-fi roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNjk1M2RmODAtMjE0Ny00N2U0LWIwNWYtZTAxMDFiMzk1MjU5XkEyXkFqcGc@._V1_FMjpg_UY4000_.jpg"
        },
        new Actor()
        {
            Id = new Guid("545d9868-b224-46c4-9b60-21271dc2adc2"),
            Name = "Neil Patrick Harris",
            ShortBio = "American actor known for comedy, stage work, and dramatic supporting roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTUxNjQ4MjU5Ml5BMl5BanBnXkFtZTcwMTY5NzAzNw@@._V1_FMjpg_UY2048_.jpg"
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
            ShortBio = "American actor, writer, and director remembered for an iconic horror role.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNzgzMTk3Nzk0N15BMl5BanBnXkFtZTgwMTc3NTA4NTM@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("8044275d-432e-4e99-a403-bc47b7208011"),
            Name = "Patrick Stewart",
            ShortBio = "English actor known for dignified performances in stage, sci-fi, and drama.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTc0MzU5ODQ5OF5BMl5BanBnXkFtZTYwODIwODk1._V1_FMjpg_UX282_.jpg"
        },
        new Actor()
        {
            Id = new Guid("2f276480-e052-4120-85d6-7f5fb2a0141f"),
            Name = "Patrick Wilson",
            ShortBio = "American actor known for horror, drama, and musical performances.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTkzNzcxNzcxMF5BMl5BanBnXkFtZTgwOTM1ODUzMTE@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("f3d34bfd-85e1-4dec-bc22-5f4eca6c9fc2"),
            Name = "Paul Dano",
            ShortBio = "American actor known for nuanced roles in indie films and major dramas.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjMwMzE1OTc0OF5BMl5BanBnXkFtZTcwMDU2NTg0Nw@@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("3c328dc2-54a1-4a48-8962-6e7f903f2162"),
            Name = "Paul Reiser",
            ShortBio = "American actor and comedian known for television and supporting film roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTQ1MjUwMjI4M15BMl5BanBnXkFtZTcwNzc0NTg3NA@@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("ef1f2981-782a-40c7-b0dc-5e6a85bb7055"),
            Name = "Peter Riegert",
            ShortBio = "American actor known for character roles in comedies and dramas.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTc2Nzc4NzkyNF5BMl5BanBnXkFtZTcwMjE0ODQyOA@@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("9af1c7b4-2511-48e0-8868-fc0dab590d71"),
            Name = "Rachel McAdams",
            ShortBio = "Canadian actress known for charismatic performances in dramas and comedies.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTY5ODcxMDU4NV5BMl5BanBnXkFtZTcwMjAzNjQyNQ@@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("70705055-5ce6-4a88-a3ba-5e031ae9b786"),
            Name = "Rebecca Ferguson",
            ShortBio = "Swedish actress known for suspenseful performances in action and drama.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMDVlZjIzOTktYzNmZC00MjIzLTk1YTMtMzdlOTFiNzQ3ZGY0XkEyXkFqcGc@._V1_FMjpg_UX406_.jpg"
        },
        new Actor()
        {
            Id = new Guid("9c39c7a7-3897-494b-a8b5-970dd50d88b6"),
            Name = "Rene Russo",
            ShortBio = "American actress known for thrillers, dramas, and sharp character roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjIyMzc1Njk5N15BMl5BanBnXkFtZTgwMjk2MDkyNzM@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("8ba7acf6-a509-48fe-92c0-c8c0528569fd"),
            Name = "Riz Ahmed",
            ShortBio = "British actor and musician known for intense performances across film and TV.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTcxMTQ4MzY2Nl5BMl5BanBnXkFtZTgwMzAxOTY3MjI@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("09ad1d06-e8a1-406e-890b-d744e67ffa76"),
            Name = "Robert De Niro",
            ShortBio = "American actor known for legendary performances in crime films and dramas.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjAwNDU3MzcyOV5BMl5BanBnXkFtZTcwMjc0MTIxMw@@._V1_FMjpg_UX303_.jpg"
        },
        new Actor()
        {
            Id = new Guid("d875ff93-4c8d-4470-9c2e-66209c6d63f2"),
            Name = "Robert Downey Jr.",
            ShortBio = "American actor known for charismatic performances in drama, comedy, and superhero films.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNzg1MTUyNDYxOF5BMl5BanBnXkFtZTgwNTQ4MTE2MjE@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("bc2dd711-8eac-439d-9353-dd355849ed8e"),
            Name = "Robert Englund",
            ShortBio = "American actor best known for iconic horror villain roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNzQ4OTQwMjItMWQ3YS00ODE5LWEyMjQtMWU1NjJlZmIwMDA4XkEyXkFqcGc@._V1_FMjpg_UX1040_.jpg"
        },
        new Actor()
        {
            Id = new Guid("ba291cbf-a1f6-4a18-bfa8-fb2a3c299e6f"),
            Name = "Robin Wright",
            ShortBio = "American actress known for emotionally grounded performances in film and television.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTU0NTc4MzEyOV5BMl5BanBnXkFtZTcwODY0ODkzMQ@@._V1_FMjpg_UX280_.jpg"
        },
        new Actor()
        {
            Id = new Guid("57ad6e92-9f65-4871-b922-11600447149c"),
            Name = "Rooney Mara",
            ShortBio = "American actress known for intense, understated dramatic performances.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BZGIwMGJlNTctMjE2Zi00YzFlLTk3MjQtMTMzNzFlOWYyNzJhXkEyXkFqcGc@._V1_FMjpg_UY3712_.jpg"
        },
        new Actor()
        {
            Id = new Guid("25538521-d4f1-4ca8-ba20-1628c98b6930"),
            Name = "Rosamund Pike",
            ShortBio = "English actress known for intelligent, composed performances in thrillers and dramas.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNDQ5MDIyMjg3NV5BMl5BanBnXkFtZTgwOTU2NTE0NDM@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("e52850d9-f3a4-4d46-a265-3667403ac2e9"),
            Name = "Rose Byrne",
            ShortBio = "Australian actress known for smart performances in comedy, drama, and horror.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTc0MDA2Njc0OF5BMl5BanBnXkFtZTcwNzc3NDU3Mw@@._V1_FMjpg_UX289_.jpg"
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
            ShortBio = "Canadian actor known for fast-talking comedy and action roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMzRiNDhiMDQtYWZkMS00ZjU5LTg5NzUtOTc4NzE2Yzc0ZWUwXkEyXkFqcGc@._V1_FMjpg_UY3000_.jpg"
        },
        new Actor()
        {
            Id = new Guid("dfe14619-506f-4f09-9a8e-8bf0fdaa4e83"),
            Name = "Scarlett Johansson",
            ShortBio = "American actress known for action, drama, and emotionally complex roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTM3OTUwMDYwNl5BMl5BanBnXkFtZTcwNTUyNzc3Nw@@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("655b7c4a-7bde-4498-82b2-46288064039f"),
            Name = "Scatman Crothers",
            ShortBio = "American actor and musician known for warm supporting performances.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjEzNDY4OTU5N15BMl5BanBnXkFtZTcwNDU0MjYwOA@@._V1_FMjpg_UX945_.jpg"
        },
        new Actor()
        {
            Id = new Guid("fcece400-14b5-481a-b5d7-fe67bf28f913"),
            Name = "Scott Glenn",
            ShortBio = "American actor known for rugged roles in thrillers, dramas, and westerns.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTU3NzAwMzE1OF5BMl5BanBnXkFtZTYwMjkzOTY0._V1_FMjpg_UX303_.jpg"
        },
        new Actor()
        {
            Id = new Guid("9186ec1d-7199-439e-b062-a103f1371d54"),
            Name = "Shelley Duvall",
            ShortBio = "American actress known for vulnerable, distinctive screen presence.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNjE4MTY1Mzk0N15BMl5BanBnXkFtZTgwOTQzNDE2MDE@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("8904c86f-88c7-4575-9c5a-70d83a4a53db"),
            Name = "Sophia Lillis",
            ShortBio = "American actress known for coming-of-age and genre roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BZTVjMWI2MzYtM2FmNS00N2ZmLThlZTktMjhjOGNlOGNhM2FiXkEyXkFqcGc@._V1_FMjpg_UY6500_.jpg"
        },
        new Actor()
        {
            Id = new Guid("10ba4f1b-fb6f-4040-a38a-1de45d9d7605"),
            Name = "Steve Carell",
            ShortBio = "American actor and comedian known for awkward, lovable comedic characters.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjMyOTM2OTk1Ml5BMl5BanBnXkFtZTgwMTI3MzkyNjM@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("1a536677-8b72-42dc-b7ec-506ab25c501f"),
            Name = "Tilda Swinton",
            ShortBio = "Scottish actress known for transformative art-house and blockbuster roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTM4NzMzMTkwNV5BMl5BanBnXkFtZTcwMzU4MDg1Mw@@._V1_FMjpg_UX319_.jpg"
        },
        new Actor()
        {
            Id = new Guid("12b4e8b1-deee-4931-baa3-bc4d5f3efb9b"),
            Name = "Tim Robbins",
            ShortBio = "American actor known for thoughtful performances in dramas and political films.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTI1OTYxNzAxOF5BMl5BanBnXkFtZTYwNTE5ODI4._V1_FMjpg_UX311_.jpg"
        },
        new Actor()
        {
            Id = new Guid("6547e436-757f-4cb1-a179-f337b0922121"),
            Name = "Tom Cruise",
            ShortBio = "American actor and producer known for blockbuster action and dramatic roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMmU1YWU1NmMtMjAyMi00MjFiLWFmZmUtOTc1ZjI5ODkxYmQyXkEyXkFqcGc@._V1_FMjpg_UY5122_.jpg"
        },
        new Actor()
        {
            Id = new Guid("ad15e2ca-4491-413c-a95b-8b2cc8935c4c"),
            Name = "Tom Hanks",
            ShortBio = "American actor known for warm, versatile performances in dramas and comedies.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTQ2MjMwNDA3Nl5BMl5BanBnXkFtZTcwMTA2NDY3NQ@@._V1_FMjpg_UY2048_.jpg"
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
            ShortBio = "English actor known for intelligent, charismatic dramatic roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BYTU0NjUyMjktNTBkNS00ZWFjLTgyZmUtZjVhMmU1YTVkOTM2XkEyXkFqcGc@._V1_FMjpg_UY3217_.jpg"
        },
        new Actor()
        {
            Id = new Guid("50e895bc-e9e1-445b-a99c-6615bd33437a"),
            Name = "Tom Holland",
            ShortBio = "English actor known for youthful energy and blockbuster leading roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BYzU3NWRhMjgtNmNmMS00YjQ1LWIyYzgtYzdkYjRjNWEzM2E3XkEyXkFqcGc@._V1_FMjpg_UY5472_.jpg"
        },
        new Actor()
        {
            Id = new Guid("556360a7-3f73-48c6-b971-52ff34371b93"),
            Name = "Tommy Lee Jones",
            ShortBio = "American actor known for stoic performances in dramas, thrillers, and westerns.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTkyNjc4MDc0OV5BMl5BanBnXkFtZTcwOTc5OTUwOQ@@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("fd960aa9-8876-4dff-9d99-94c1c3738c04"),
            Name = "Toni Collette",
            ShortBio = "Australian actress known for emotionally intense performances.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BODYzOTE3ODc1Ml5BMl5BanBnXkFtZTgwODYwMjE4NTM@._V1_FMjpg_UX503_.jpg"
        },
        new Actor()
        {
            Id = new Guid("e337f1ec-b22c-4ddf-8b5e-bd5afa946129"),
            Name = "Tzi Ma",
            ShortBio = "Hong Kong-American actor known for supporting roles in film and television.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BZDhhOWZhMDctNTQ0Yy00Zjc0LWIwZTgtZTY0ZmI0Nzg4ZDQ4XkEyXkFqcGc@._V1_FMjpg_UY2434_.jpg"
        },
        new Actor()
        {
            Id = new Guid("179a8c49-2ace-4cc3-bef6-0d76f135c1ec"),
            Name = "Vera Farmiga",
            ShortBio = "American actress known for psychological dramas and horror films.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjIwNTU3NDUyMl5BMl5BanBnXkFtZTgwODEwODg5NDE@._V1_FMjpg_UX2160_.jpg"
        },
        new Actor()
        {
            Id = new Guid("08d54a07-c4a3-4467-8c2d-2791ccc3cb86"),
            Name = "Vincent Cassel",
            ShortBio = "French actor known for intense roles in international dramas and thrillers.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTc1NDUzMzM5MV5BMl5BanBnXkFtZTcwNzY1OTYyOQ@@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("a1c457e5-d6b5-4fce-81a1-e570ebca481a"),
            Name = "Will Ferrell",
            ShortBio = "American comedian and actor known for broad, improvisational comedy.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTMxMDIzMDEzNF5BMl5BanBnXkFtZTcwODcxMjE2Mg@@._V1_FMjpg_UX276_.jpg"
        },
        new Actor()
        {
            Id = new Guid("0f0f48ae-983b-48b1-a574-a8dc4f6ace0b"),
            Name = "Zach Galifianakis",
            ShortBio = "American comedian and actor known for offbeat and eccentric characters.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTQwNzI3NjIwMV5BMl5BanBnXkFtZTcwMzA1OTIwMw@@._V1_FMjpg_UX273_.jpg"
        },
        new Actor()
        {
            Id = new Guid("dc4a4b36-d647-43f9-b215-1a6024cc712f"),
            Name = "Zazie Beetz",
            ShortBio = "German-American actress known for energetic roles in drama, comedy, and genre films.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMDdlNjNkZTAtNWQ0Ny00ZDdiLWJlM2EtYzYxMjMyY2U2MjgxXkEyXkFqcGc@._V1_FMjpg_UX904_.jpg"
        },
        new Actor()
        {
            Id = new Guid("7c144da1-9cb5-498f-9f04-8d6d5418455e"),
            Name = "Zendaya",
            ShortBio = "American actress and singer known for modern drama, romance, and franchise films.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BZjM5N2U3MzQtZWU5My00YzE0LThmZTgtYjE1NDJjNmIzZmIxXkEyXkFqcGc@._V1_FMjpg_UX780_.jpg"
        },
        new Actor()
        {
            Id = new Guid("a7c020f2-1864-4e0a-98a5-4d3b03f6eee7"),
            Name = "Zoe Saldaña",
            ShortBio = "American actress known for major science fiction and action franchises.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMDFkMWQ5ZDItNGUzNS00YzI4LWIyOTctMDk0Mjc3MGQyZTYxXkEyXkFqcGc@._V1_FMjpg_UY2519_.jpg"
        },
        new Actor()
        {
            Id = new Guid("4b7fe159-069a-4c8f-8bd3-09ed79a4c5ae"),
            Name = "Elijah Wood",
            ShortBio = "American actor known for fantasy, independent film, and character-driven performances.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTM0NDIxMzQ5OF5BMl5BanBnXkFtZTcwNzAyNTA4Nw@@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("f03b85c5-d584-4d0b-8d38-d7356f469375"),
            Name = "Ian McKellen",
            ShortBio = "English actor renowned for stage work and fantasy epics.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTQ2MjgyNjk3MV5BMl5BanBnXkFtZTcwNTA3NTY5Mg@@._V1_FMjpg_UX295_.jpg"
        },
        new Actor()
        {
            Id = new Guid("d1fb6849-f352-4e51-a01c-e98b0f67fc40"),
            Name = "Viggo Mortensen",
            ShortBio = "American actor known for intense dramatic roles and historical epics.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNDQzOTg4NzA2Nl5BMl5BanBnXkFtZTcwMzkwNjkxMg@@._V1_FMjpg_UX269_.jpg"
        },
        new Actor()
        {
            Id = new Guid("b96f5e3e-e5c2-4005-93ba-14a6db7078b9"),
            Name = "Sean Astin",
            ShortBio = "American actor known for heartfelt performances in adventure and family films.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjEzMjczOTQ1NF5BMl5BanBnXkFtZTcwMzI2NzYyMQ@@._V1_FMjpg_UX300_.jpg"
        },
        new Actor()
        {
            Id = new Guid("950268ca-c69a-41f4-81c3-7cd61c42a9e1"),
            Name = "Daniel Radcliffe",
            ShortBio = "English actor best known for leading the Harry Potter film series.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BYzVmYjIxMzgtZWU2Ny00MjAyLTk5ZWUtZDEyMTliYjczMmIxXkEyXkFqcGc@._V1_FMjpg_UX760_.jpg"
        },
        new Actor()
        {
            Id = new Guid("1acc5129-33a7-4b35-b00b-f350c34c0b83"),
            Name = "Emma Watson",
            ShortBio = "English actress known for fantasy films and dramatic roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTQ3ODE2NTMxMV5BMl5BanBnXkFtZTgwOTIzOTQzMjE@._V1_FMjpg_UX1038_.jpg"
        },
        new Actor()
        {
            Id = new Guid("82d8d010-92a5-4189-b947-d56faf569ba6"),
            Name = "Rupert Grint",
            ShortBio = "English actor known for comedy and fantasy roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BODUwOTc5N2MtNTVmZi00MWE0LWE0Y2QtOTAyOTEzZDg1NGFiXkEyXkFqcGc@._V1_FMjpg_UY3600_.jpg"
        },
        new Actor()
        {
            Id = new Guid("95a09f9f-98a1-4a0b-a409-6a357ceb9930"),
            Name = "Gary Oldman",
            ShortBio = "English actor celebrated for transformative performances across genres.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTc3NTM4MzQ5MV5BMl5BanBnXkFtZTcwOTE4MDczNw@@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("339a12ea-c0b1-4c15-81eb-189212eda79d"),
            Name = "Ivana Baquero",
            ShortBio = "Spanish actress known for fantasy and dramatic roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BOTlmODE2ZjktOTM5OC00MWE1LThiNTUtZjYzNWM0MGU2ZjIyXkEyXkFqcGc@._V1_FMjpg_UY4780_.jpg"
        },
        new Actor()
        {
            Id = new Guid("4f53bb1c-0f91-48bc-9876-5dfd7ab74ebb"),
            Name = "Sergi López",
            ShortBio = "Spanish-French actor known for intense dramatic performances.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTIzMDc3NzE4NV5BMl5BanBnXkFtZTYwNjQwODc1._V1_FMjpg_UX271_.jpg"
        },
        new Actor()
        {
            Id = new Guid("93088ce9-c00a-4ea4-9cd6-2ac02db77c7d"),
            Name = "Maribel Verdú",
            ShortBio = "Spanish actress known for dramatic and fantasy films.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTQ1NjkwMjA0NV5BMl5BanBnXkFtZTYwNzU2NzE2._V1_FMjpg_UX284_.jpg"
        },
        new Actor()
        {
            Id = new Guid("96c08023-9ed3-46dd-a016-facb34a4bef9"),
            Name = "Martin Freeman",
            ShortBio = "English actor known for intelligent comic and dramatic roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjE0MjAwOTMzMF5BMl5BanBnXkFtZTcwMDg1MjEyNw@@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("f5faf27e-6f57-4035-a94e-1055cd927ed1"),
            Name = "Richard Armitage",
            ShortBio = "English actor known for period dramas and fantasy adventures.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BOGU1NDhiOTAtMTEyOC00ZDdkLThjNDgtMjUzZjdiN2FlMzcyXkEyXkFqcGc@._V1_FMjpg_UX1212_.jpg"
        },
        new Actor()
        {
            Id = new Guid("5f3878b6-e371-4be2-afcb-10906290b75a"),
            Name = "Johnny Depp",
            ShortBio = "American actor known for eccentric, transformative leading roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BZjA3NzZiZDktZjc2My00MzY2LThhOWMtZGFjYzg4ZDI2ZWVmXkEyXkFqcGc@._V1_FMjpg_UX1080_.jpg"
        },
        new Actor()
        {
            Id = new Guid("e2100a6d-cc7d-47c9-9927-72082d1b3843"),
            Name = "Orlando Bloom",
            ShortBio = "English actor known for fantasy and historical adventure films.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjE1MDkxMjQ3NV5BMl5BanBnXkFtZTcwMzQ3Mjc4MQ@@._V1_FMjpg_UX291_.jpg"
        },
        new Actor()
        {
            Id = new Guid("858afe84-3e5a-451b-bd2d-eda7f38e8467"),
            Name = "Keira Knightley",
            ShortBio = "English actress known for period dramas and adventure films.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTYwNDM0NDA3M15BMl5BanBnXkFtZTcwNTkzMjQ3OA@@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("0415474f-6528-4602-9803-b387d67b5b5d"),
            Name = "Georgie Henley",
            ShortBio = "English actress known for her breakout role in the Narnia films.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTEyOTEyODc1MDZeQTJeQWpwZ15BbWU3MDA5MjcwMzQ@._V1_FMjpg_UX295_.jpg"
        },
        new Actor()
        {
            Id = new Guid("3c550829-e360-4a0f-947f-b8510e01718a"),
            Name = "James McAvoy",
            ShortBio = "Scottish actor known for dramatic range in fantasy and period films.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTQzNzIxOTYzMl5BMl5BanBnXkFtZTcwNjYxNTk1Nw@@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("ca837102-6e0b-4bc6-a39c-d35bbc3dfa80"),
            Name = "Charlie Cox",
            ShortBio = "English actor known for fantasy, action, and television drama.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjA0Mzg5MTU3MV5BMl5BanBnXkFtZTgwOTUxMTQ5NzE@._V1_FMjpg_UX1178_.jpg"
        },
        new Actor()
        {
            Id = new Guid("13ec26d4-e9fc-4def-ae21-f93ab8d4d6b6"),
            Name = "Claire Danes",
            ShortBio = "American actress known for emotional performances in drama and fantasy.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BZDM0YWM5ZGYtODMwYS00ODYzLWFiNzMtOTNmZjc4ZmI2ZDk1XkEyXkFqcGc@._V1_FMjpg_UY2914_.jpg"
        },
        new Actor()
        {
            Id = new Guid("dc2957ed-c6dc-40c6-8dcb-8e93bdd8ba03"),
            Name = "Michelle Pfeiffer",
            ShortBio = "American actress known for glamorous and villainous roles across genres.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTUzNjI0Njc5NF5BMl5BanBnXkFtZTYwOTM2MjYz._V1_FMjpg_UX266_.jpg"
        },
        new Actor()
        {
            Id = new Guid("09b7ed63-7445-4c20-b6cf-271ddb9e4c96"),
            Name = "Joseph Gordon-Levitt",
            ShortBio = "American actor known for versatile roles in drama, comedy, and sci-fi.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTY3NTk0NDI3Ml5BMl5BanBnXkFtZTgwNDA3NjY0MjE@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("59d617f1-c06c-4dd0-8b8b-ad0fd2615135"),
            Name = "Ellen Page",
            ShortBio = "Canadian actress known for emotionally nuanced performances across genres.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BZmM3ZjE2M2QtYzljOC00ZTI4LWFhNTItOWVhNTkzM2JhOTE3XkEyXkFqcGc@._V1_FMjpg_UX480_.jpg"
        },
        new Actor()
        {
            Id = new Guid("00cdc0aa-e696-4628-b8cc-ec84f4a6dc06"),
            Name = "Matthew McConaughey",
            ShortBio = "American actor known for charismatic performances in drama and science fiction.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTg0MDc3ODUwOV5BMl5BanBnXkFtZTcwMTk2NjY4Nw@@._V1_FMjpg_UX1256_.jpg"
        },
        new Actor()
        {
            Id = new Guid("40f67ef1-8703-42e9-94af-f65e1a2ef186"),
            Name = "Jessica Chastain",
            ShortBio = "American actress known for intense dramatic roles and large-scale epics.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTU1MDM5NjczOF5BMl5BanBnXkFtZTcwOTY2MDE4OA@@._V1_FMjpg_UX1268_.jpg"
        },
        new Actor()
        {
            Id = new Guid("b479a3b8-5eba-43f0-a77c-797fc760ab1f"),
            Name = "Ryan Gosling",
            ShortBio = "Canadian actor known for understated performances in drama, crime, and science fiction.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTQzMjkwNTQ2OF5BMl5BanBnXkFtZTgwNTQ4MTQ4MTE@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("36e4bf12-895e-44a2-b635-e9e7930c0997"),
            Name = "Harrison Ford",
            ShortBio = "American actor known for iconic adventure and sci-fi roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTY4Mjg0NjIxOV5BMl5BanBnXkFtZTcwMTM2NTI3MQ@@._V1_FMjpg_UX269_.jpg"
        },
        new Actor()
        {
            Id = new Guid("dae9df12-f329-45e4-b256-a7e9646e838d"),
            Name = "Ana de Armas",
            ShortBio = "Cuban-Spanish actress known for emotionally layered performances.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BZDAxOWQ0NmMtNTIzNS00YTdkLWI4MzAtZDM3ZDdmYTNlMjZmXkEyXkFqcGc@._V1_FMjpg_UX2160_.jpg"
        },
        new Actor()
        {
            Id = new Guid("1b39c2ef-208c-4e08-b668-a533d279d528"),
            Name = "Sigourney Weaver",
            ShortBio = "American actress known for pioneering action and science-fiction roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTk1MTcyNTE3OV5BMl5BanBnXkFtZTcwMTA0MTMyMw@@._V1_FMjpg_UX450_.jpg"
        },
        new Actor()
        {
            Id = new Guid("a41a0cad-77db-47cc-a5a0-0d57342a9b65"),
            Name = "Tom Skerritt",
            ShortBio = "American actor known for rugged leading roles in film and television.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNzY3Mjk5MTMyMl5BMl5BanBnXkFtZTYwMjUxMTc1._V1_FMjpg_UX276_.jpg"
        },
        new Actor()
        {
            Id = new Guid("c3891de0-0cda-41bc-a2ae-e957df3d0f1a"),
            Name = "John Hurt",
            ShortBio = "English actor known for memorable performances in historical, horror, and sci-fi films.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTM1NTgyMTAyOV5BMl5BanBnXkFtZTcwMTE4MjQwNA@@._V1_FMjpg_UX284_.jpg"
        },
        new Actor()
        {
            Id = new Guid("c55c41c7-9a4d-40d2-b2fc-57eb139bf902"),
            Name = "Michael Biehn",
            ShortBio = "American actor known for action, sci-fi, and military roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BODBkMzQwZmUtN2QxNS00YmExLThhNTYtMzIzNTA4NDBjYzliXkEyXkFqcGc@._V1_FMjpg_UX605_.jpg"
        },
        new Actor()
        {
            Id = new Guid("a8360aca-2aa9-49da-925b-af9deaa40978"),
            Name = "Carrie Henn",
            ShortBio = "American former child actress known for her role in Aliens.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNDg5OTE4ZWEtZjk1ZC00YmE5LTljZGQtYWNjZGQ0ZTI2YmJiXkEyXkFqcGc@._V1_FMjpg_UX770_.jpg"
        },
        new Actor()
        {
            Id = new Guid("c9ee97ea-de38-4ce6-add4-ebc54fd7d92a"),
            Name = "Amy Adams",
            ShortBio = "American actress known for emotionally intelligent performances in drama and sci-fi.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTg2NTk2MTgxMV5BMl5BanBnXkFtZTgwNjcxMjAzMTI@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("ff728ce9-28c4-4e30-9e50-bd0e7fba3b39"),
            Name = "Jeremy Renner",
            ShortBio = "American actor known for action films and grounded dramatic roles.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BOTk2NDc2ODgzMF5BMl5BanBnXkFtZTcwMTMzOTQ4Nw@@._V1_FMjpg_UX363_.jpg"
        },
        new Actor()
        {
            Id = new Guid("a5f19f18-702b-49cb-8e8a-634045a81baa"),
            Name = "Forest Whitaker",
            ShortBio = "American actor known for commanding performances across genres.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTQzMDI3NTg2OV5BMl5BanBnXkFtZTcwNTgwMzg5Mg@@._V1_FMjpg_UX303_.jpg"
        },
        new Actor()
        {
            Id = new Guid("bdb9ef82-f830-4d22-96ea-7128d9fd92b7"),
            Name = "Matt Damon",
            ShortBio = "American actor known for intelligent leading roles in drama and action.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTM0NzYzNDgxMl5BMl5BanBnXkFtZTcwMDg2MTMyMw@@._V1_FMjpg_UX447_.jpg"
        },
        new Actor()
        {
            Id = new Guid("468fc8fc-00b2-4740-b025-f465bc99c283"),
            Name = "Sharlto Copley",
            ShortBio = "South African actor known for dynamic performances in sci-fi and action.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTU1MjU2MzkzNF5BMl5BanBnXkFtZTgwNDIzMjIwMjI@._V1_FMjpg_UY2048_.jpg"
        },
        new Actor()
        {
            Id = new Guid("480a5aa3-2618-4777-8d6c-764b0bac7a6b"),
            Name = "Jason Cope",
            ShortBio = "South African actor known for extensive genre and creature-performance work.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BODczYzdlYWYtNjIwMC00ZTQ3LTkwMjUtNmNiZmE0MzllZGM5XkEyXkFqcGc@._V1_FMjpg_UX800_.jpg"
        },
        new Actor()
        {
            Id = new Guid("7c412653-3c11-4b3a-8118-22a6c219f54c"),
            Name = "David James",
            ShortBio = "South African actor known for villainous roles in action and science fiction.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BYzUyMGE3YWItMDMxOS00NTA5LWJhZmEtNjg4N2Y3ZjI2ZGE5XkEyXkFqcGc@._V1_FMjpg_UY3553_.jpg"
        },
        new Actor()
        {
            Id = new Guid("d9963534-1f06-4a69-bf13-8e735e7c9e9f"),
            Name = "Clive Owen",
            ShortBio = "English actor known for tough, intelligent roles in thrillers and dramas.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjA4MzAyOTc5Ml5BMl5BanBnXkFtZTcwOTQ5NzEzMg@@._V1_FMjpg_UX303_.jpg"
        },
        new Actor()
        {
            Id = new Guid("f0c4a679-e5fd-4329-811c-0735cff97711"),
            Name = "Julianne Moore",
            ShortBio = "American actress known for emotionally rich performances across genres.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTM5NDI1MjE2Ml5BMl5BanBnXkFtZTgwNDE0Nzk0MDE@._V1_FMjpg_UX596_.jpg"
        },
        new Actor()
        {
            Id = new Guid("3dacabea-76fa-48d7-8b12-4095bacbd787"),
            Name = "Michael Caine",
            ShortBio = "English actor known for iconic performances in drama, crime, and fantasy.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjAwNzIwNTQ4Ml5BMl5BanBnXkFtZTYwMzE1MTUz._V1_FMjpg_UX288_.jpg"
        },
        new Actor()
        {
            Id = new Guid("879fffcf-e8fe-4a4a-bab5-da42fc4d1256"),
            Name = "Domhnall Gleeson",
            ShortBio = "Irish actor known for thoughtful performances in drama and science fiction.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjA5MjI0MzY2MF5BMl5BanBnXkFtZTcwMzM3ODM3OA@@._V1_FMjpg_UX720_.jpg"
        },
        new Actor()
        {
            Id = new Guid("2bb629f1-e03a-4c92-b265-6ba6f3674026"),
            Name = "Alicia Vikander",
            ShortBio = "Swedish actress known for precise performances in drama and sci-fi.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BOTIwZjBiMTQtZmM3ZS00YTI1LTk0NTYtY2UyMWM3NTMxMDJjXkEyXkFqcGc@._V1_FMjpg_UX642_.jpg"
        },
        new Actor()
        {
            Id = new Guid("ea2f8e0d-eb55-4452-90a1-f810474cbe7f"),
            Name = "Oscar Isaac",
            ShortBio = "Guatemalan-American actor known for charismatic roles in drama and science fiction.",
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTQ2ODE2NDQ5OF5BMl5BanBnXkFtZTcwOTU3OTM1OQ@@._V1_FMjpg_UY2048_.jpg"
        }
    ];
}