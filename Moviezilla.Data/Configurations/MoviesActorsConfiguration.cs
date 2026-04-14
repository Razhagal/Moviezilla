using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Moviezilla.Data.Common;
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

        builder
            .Property(ma => ma.CharacterName)
            .IsRequired()
            .HasMaxLength(EntityConstants.Actor.PlayedCharacterNameMaxLength);
    }
    
    public static List<MoviesActors> SeedMoviesActors() =>
    [
        new MoviesActors()
        {
            MovieId = new Guid("f0744c2c-c60f-4ae2-9227-beb769c6bb74"),
            ActorId = new Guid("bc65dca2-6946-4eeb-841d-add7c0fd0376"),
            CharacterName = "Max Rockatansky"
        },
        new MoviesActors()
        {
            MovieId = new Guid("f0744c2c-c60f-4ae2-9227-beb769c6bb74"),
            ActorId = new Guid("cf615463-d189-4221-b69d-373d9ecbe762"),
            CharacterName = "Imperator Furiosa"
        },
        new MoviesActors()
        {
            MovieId = new Guid("f0744c2c-c60f-4ae2-9227-beb769c6bb74"),
            ActorId = new Guid("af0ea72b-6f8f-4db0-afa7-2ea8c7859c30"),
            CharacterName = "Nux"
        },
        new MoviesActors()
        {
            MovieId = new Guid("12010e19-dd0f-4195-b3c6-7dc6702c8a32"),
            ActorId = new Guid("c897ed9b-a2ac-4e31-8fa4-8c26cc33c652"),
            CharacterName = "John McClane"
        },
        new MoviesActors()
        {
            MovieId = new Guid("12010e19-dd0f-4195-b3c6-7dc6702c8a32"),
            ActorId = new Guid("a2a8ed1f-aa12-411b-a221-2d2cdd7d5f2e"),
            CharacterName = "Hans Gruber"
        },
        new MoviesActors()
        {
            MovieId = new Guid("12010e19-dd0f-4195-b3c6-7dc6702c8a32"),
            ActorId = new Guid("1856d962-d4cb-491a-a94e-072cfa5662bd"),
            CharacterName = "Holly Gennaro McClane"
        },
        new MoviesActors()
        {
            MovieId = new Guid("d6bf3fb7-df18-4e5c-bce4-1f7cf55b8848"),
            ActorId = new Guid("d246a339-8c96-4ee4-9377-c6110d1ebaef"),
            CharacterName = "John Wick"
        },
        new MoviesActors()
        {
            MovieId = new Guid("d6bf3fb7-df18-4e5c-bce4-1f7cf55b8848"),
            ActorId = new Guid("64ea884a-b2a5-46ae-9532-ce5d559ead97"),
            CharacterName = "Viggo Tarasov"
        },
        new MoviesActors()
        {
            MovieId = new Guid("d6bf3fb7-df18-4e5c-bce4-1f7cf55b8848"),
            ActorId = new Guid("43c89467-ac0e-4e79-9f8e-929848c36d6a"),
            CharacterName = "Iosef Tarasov"
        },
        new MoviesActors()
        {
            MovieId = new Guid("d6bf3fb7-df18-4e5c-bce4-1f7cf55b8848"),
            ActorId = new Guid("cda5b584-c19f-48e5-9e4b-787bbbd441ff"),
            CharacterName = "Winston"
        },
        new MoviesActors()
        {
            MovieId = new Guid("a6600fb9-7a83-44fa-827e-03dd66e62e9a"),
            ActorId = new Guid("5d7cdba3-e8dc-4f19-a8a3-8992aec07fae"),
            CharacterName = "Maximus"
        },
        new MoviesActors()
        {
            MovieId = new Guid("a6600fb9-7a83-44fa-827e-03dd66e62e9a"),
            ActorId = new Guid("176400ce-53cf-4576-a2ed-432f78a43240"),
            CharacterName = "Commodus"
        },
        new MoviesActors()
        {
            MovieId = new Guid("a6600fb9-7a83-44fa-827e-03dd66e62e9a"),
            ActorId = new Guid("ceaeb56b-d490-44c9-961c-06e8af100ba6"),
            CharacterName = "Lucilla"
        },
        new MoviesActors()
        {
            MovieId = new Guid("6f6779da-99ae-44d9-a61a-43ebe5f0fd77"),
            ActorId = new Guid("d1bdcd3f-a8be-4044-96b4-26a0745585e9"),
            CharacterName = "Bruce Wayne"
        },
        new MoviesActors()
        {
            MovieId = new Guid("6f6779da-99ae-44d9-a61a-43ebe5f0fd77"),
            ActorId = new Guid("50cafa2b-71bd-4ea8-8eb0-a5ee95eff467"),
            CharacterName = "Joker"
        },
        new MoviesActors()
        {
            MovieId = new Guid("6f6779da-99ae-44d9-a61a-43ebe5f0fd77"),
            ActorId = new Guid("6fd39241-45d7-4435-beeb-6ef22cc912de"),
            CharacterName = "Harvey Dent"
        },
        new MoviesActors()
        {
            MovieId = new Guid("f01bf412-3480-4c18-9b6f-418f947c1ba2"),
            ActorId = new Guid("d246a339-8c96-4ee4-9377-c6110d1ebaef"),
            CharacterName = "Neo"
        },
        new MoviesActors()
        {
            MovieId = new Guid("f01bf412-3480-4c18-9b6f-418f947c1ba2"),
            ActorId = new Guid("f80c0da1-8be6-4a46-a578-edfce3af270d"),
            CharacterName = "Morpheus"
        },
        new MoviesActors()
        {
            MovieId = new Guid("f01bf412-3480-4c18-9b6f-418f947c1ba2"),
            ActorId = new Guid("8dcde184-4ee9-4ac3-8a01-e8827834d161"),
            CharacterName = "Trinity"
        },
        new MoviesActors()
        {
            MovieId = new Guid("614bf670-e4d2-4b35-a208-c84a6c75c764"),
            ActorId = new Guid("d85eed69-92c7-4bcb-b978-9c2179a19f6c"),
            CharacterName = "The Terminator"
        },
        new MoviesActors()
        {
            MovieId = new Guid("614bf670-e4d2-4b35-a208-c84a6c75c764"),
            ActorId = new Guid("453399e4-7c51-46d3-aeae-99eb8f06fef9"),
            CharacterName = "Sarah Connor"
        },
        new MoviesActors()
        {
            MovieId = new Guid("614bf670-e4d2-4b35-a208-c84a6c75c764"),
            ActorId = new Guid("bfc71005-46f5-4f0e-a05d-eb99293367d5"),
            CharacterName = "John Connor"
        },
        new MoviesActors()
        {
            MovieId = new Guid("78e7000a-1425-4340-938a-cf4a5bac6775"),
            ActorId = new Guid("00085ee6-52df-4585-967b-408c7ba486be"),
            CharacterName = "James Bond"
        },
        new MoviesActors()
        {
            MovieId = new Guid("78e7000a-1425-4340-938a-cf4a5bac6775"),
            ActorId = new Guid("c7483292-2173-429e-bf47-be27c5dc820b"),
            CharacterName = "Vesper Lynd"
        },
        new MoviesActors()
        {
            MovieId = new Guid("78e7000a-1425-4340-938a-cf4a5bac6775"),
            ActorId = new Guid("086a28bc-461c-4360-90e6-d34634bc7930"),
            CharacterName = "Le Chiffre"
        },
        new MoviesActors()
        {
            MovieId = new Guid("5247d8b6-6f31-4995-86c9-4196332328a0"),
            ActorId = new Guid("6547e436-757f-4cb1-a179-f337b0922121"),
            CharacterName = "Ethan Hunt"
        },
        new MoviesActors()
        {
            MovieId = new Guid("5247d8b6-6f31-4995-86c9-4196332328a0"),
            ActorId = new Guid("cee50ddf-38c4-40fb-91a3-02bfc7bee4aa"),
            CharacterName = "August Walker"
        },
        new MoviesActors()
        {
            MovieId = new Guid("5247d8b6-6f31-4995-86c9-4196332328a0"),
            ActorId = new Guid("70705055-5ce6-4a88-a3ba-5e031ae9b786"),
            CharacterName = "Ilsa Faust"
        },
        new MoviesActors()
        {
            MovieId = new Guid("a7b10c31-a060-4436-bef3-4b08014e794e"),
            ActorId = new Guid("101916e7-e588-499f-829a-daa2793c23e8"),
            CharacterName = "King Leonidas"
        },
        new MoviesActors()
        {
            MovieId = new Guid("a7b10c31-a060-4436-bef3-4b08014e794e"),
            ActorId = new Guid("3998723a-ebb9-4e63-a96b-8575e5345e5b"),
            CharacterName = "Queen Gorgo"
        },
        new MoviesActors()
        {
            MovieId = new Guid("a7b10c31-a060-4436-bef3-4b08014e794e"),
            ActorId = new Guid("0dd7a860-af97-4fe5-86ca-d7b6a171e506"),
            CharacterName = "Dilios"
        },
        new MoviesActors()
        {
            MovieId = new Guid("d83ca8b1-f2da-4aa3-b5b8-a35ec94d20c4"),
            ActorId = new Guid("f9e3238a-97a1-4718-ab92-31d5236547b3"),
            CharacterName = "Phil Wenneck"
        },
        new MoviesActors()
        {
            MovieId = new Guid("d83ca8b1-f2da-4aa3-b5b8-a35ec94d20c4"),
            ActorId = new Guid("483c83dc-0645-46ea-80a7-2f227b5f80cf"),
            CharacterName = "Stu Price"
        },
        new MoviesActors()
        {
            MovieId = new Guid("d83ca8b1-f2da-4aa3-b5b8-a35ec94d20c4"),
            ActorId = new Guid("0f0f48ae-983b-48b1-a574-a8dc4f6ace0b"),
            CharacterName = "Alan Garner"
        },
        new MoviesActors()
        {
            MovieId = new Guid("a7061bb8-f59a-4ab7-ad3c-dce86b7ccbdc"),
            ActorId = new Guid("1251c5c5-0fdd-40c1-89d7-0e10b338300c"),
            CharacterName = "Seth"
        },
        new MoviesActors()
        {
            MovieId = new Guid("a7061bb8-f59a-4ab7-ad3c-dce86b7ccbdc"),
            ActorId = new Guid("0a1a093a-54e3-454d-86f9-73523144b49d"),
            CharacterName = "Evan"
        },
        new MoviesActors()
        {
            MovieId = new Guid("a7061bb8-f59a-4ab7-ad3c-dce86b7ccbdc"),
            ActorId = new Guid("be6e3a70-0dd5-4da8-8534-4a208c09a614"),
            CharacterName = "Fogell"
        },
        new MoviesActors()
        {
            MovieId = new Guid("9d52bd23-4ee9-499d-8789-0d860eef65a3"),
            ActorId = new Guid("362cae35-adc0-4ad9-8ff5-8a6603edf315"),
            CharacterName = "Lloyd Christmas"
        },
        new MoviesActors()
        {
            MovieId = new Guid("9d52bd23-4ee9-499d-8789-0d860eef65a3"),
            ActorId = new Guid("2c4f6a03-d0b1-4e0e-8e5a-d824d9ffa7c7"),
            CharacterName = "Harry Dunne"
        },
        new MoviesActors()
        {
            MovieId = new Guid("9d52bd23-4ee9-499d-8789-0d860eef65a3"),
            ActorId = new Guid("bf824b1f-8c4d-4be3-9566-dee5b7e512b0"),
            CharacterName = "Mary Swanson"
        },
        new MoviesActors()
        {
            MovieId = new Guid("69941e20-653e-4ddf-a9ef-7a98f601ba61"),
            ActorId = new Guid("84982976-ae90-4237-9520-d6239df1458d"),
            CharacterName = "Cady Heron"
        },
        new MoviesActors()
        {
            MovieId = new Guid("69941e20-653e-4ddf-a9ef-7a98f601ba61"),
            ActorId = new Guid("9af1c7b4-2511-48e0-8868-fc0dab590d71"),
            CharacterName = "Regina George"
        },
        new MoviesActors()
        {
            MovieId = new Guid("69941e20-653e-4ddf-a9ef-7a98f601ba61"),
            ActorId = new Guid("f3b65829-46e4-4143-b39b-86136de26b7f"),
            CharacterName = "Karen Smith"
        },
        new MoviesActors()
        {
            MovieId = new Guid("4e35a624-d5db-4900-b43e-c0f9b7d28590"),
            ActorId = new Guid("fed28090-372d-456f-9a1e-c207058ac144"),
            CharacterName = "Kevin McCallister"
        },
        new MoviesActors()
        {
            MovieId = new Guid("4e35a624-d5db-4900-b43e-c0f9b7d28590"),
            ActorId = new Guid("d70a393d-94ed-424f-ad8f-b0a041617c52"),
            CharacterName = "Harry"
        },
        new MoviesActors()
        {
            MovieId = new Guid("4e35a624-d5db-4900-b43e-c0f9b7d28590"),
            ActorId = new Guid("aec03985-5285-415c-b7c2-1245a6751576"),
            CharacterName = "Marv"
        },
        new MoviesActors()
        {
            MovieId = new Guid("66275523-30e6-48e0-8c65-dab3d3fb12f8"),
            ActorId = new Guid("a1c457e5-d6b5-4fce-81a1-e570ebca481a"),
            CharacterName = "Brennan Huff"
        },
        new MoviesActors()
        {
            MovieId = new Guid("66275523-30e6-48e0-8c65-dab3d3fb12f8"),
            ActorId = new Guid("e1d47d6f-e0e3-4214-b4f7-21b37d6db88d"),
            CharacterName = "Dale Doback"
        },
        new MoviesActors()
        {
            MovieId = new Guid("66275523-30e6-48e0-8c65-dab3d3fb12f8"),
            ActorId = new Guid("d31a1794-c533-4a9a-85a9-d90e3390c8dd"),
            CharacterName = "Nancy Huff"
        },
        new MoviesActors()
        {
            MovieId = new Guid("d04029bd-e8d4-4e65-ac84-094d766d8306"),
            ActorId = new Guid("a1c457e5-d6b5-4fce-81a1-e570ebca481a"),
            CharacterName = "Ron Burgundy"
        },
        new MoviesActors()
        {
            MovieId = new Guid("d04029bd-e8d4-4e65-ac84-094d766d8306"),
            ActorId = new Guid("8b3378bc-3e09-4921-9466-7bf8b3108211"),
            CharacterName = "Veronica Corningstone"
        },
        new MoviesActors()
        {
            MovieId = new Guid("d04029bd-e8d4-4e65-ac84-094d766d8306"),
            ActorId = new Guid("10ba4f1b-fb6f-4040-a38a-1de45d9d7605"),
            CharacterName = "Brick Tamland"
        },
        new MoviesActors()
        {
            MovieId = new Guid("e9626460-ec88-4203-99b7-d918105fef03"),
            ActorId = new Guid("362cae35-adc0-4ad9-8ff5-8a6603edf315"),
            CharacterName = "Stanley Ipkiss"
        },
        new MoviesActors()
        {
            MovieId = new Guid("e9626460-ec88-4203-99b7-d918105fef03"),
            ActorId = new Guid("411fdf1d-ff3a-490c-86ac-ef8252b5c0fa"),
            CharacterName = "Tina Carlyle"
        },
        new MoviesActors()
        {
            MovieId = new Guid("e9626460-ec88-4203-99b7-d918105fef03"),
            ActorId = new Guid("ef1f2981-782a-40c7-b0dc-5e6a85bb7055"),
            CharacterName = "Lt. Kellaway"
        },
        new MoviesActors()
        {
            MovieId = new Guid("00641073-88cb-471e-bea0-8e6601494d09"),
            ActorId = new Guid("846cc4c2-430e-42e8-b9a8-f3369310563a"),
            CharacterName = "Lee"
        },
        new MoviesActors()
        {
            MovieId = new Guid("00641073-88cb-471e-bea0-8e6601494d09"),
            ActorId = new Guid("32ac45d4-37c1-4f8c-9c9c-20e9cea6a21d"),
            CharacterName = "Carter"
        },
        new MoviesActors()
        {
            MovieId = new Guid("00641073-88cb-471e-bea0-8e6601494d09"),
            ActorId = new Guid("e337f1ec-b22c-4ddf-8b5e-bd5afa946129"),
            CharacterName = "Consul Han"
        },
        new MoviesActors()
        {
            MovieId = new Guid("b0e94565-1376-46f0-b5c4-2aedc6d30ce7"),
            ActorId = new Guid("362cae35-adc0-4ad9-8ff5-8a6603edf315"),
            CharacterName = "Bruce Nolan"
        },
        new MoviesActors()
        {
            MovieId = new Guid("b0e94565-1376-46f0-b5c4-2aedc6d30ce7"),
            ActorId = new Guid("bd607b66-67f7-4fa5-8798-56fecc7d83e8"),
            CharacterName = "Grace Connelly"
        },
        new MoviesActors()
        {
            MovieId = new Guid("b0e94565-1376-46f0-b5c4-2aedc6d30ce7"),
            ActorId = new Guid("0dc023ca-c84f-4c6b-a1c3-ed3ca625b7bd"),
            CharacterName = "God"
        },
        new MoviesActors()
        {
            MovieId = new Guid("23fb559e-9a66-4423-af07-b97d9de649fe"),
            ActorId = new Guid("8441360b-3bb9-4f58-86c1-02dd3f04072a"),
            CharacterName = "David Mills"
        },
        new MoviesActors()
        {
            MovieId = new Guid("23fb559e-9a66-4423-af07-b97d9de649fe"),
            ActorId = new Guid("0dc023ca-c84f-4c6b-a1c3-ed3ca625b7bd"),
            CharacterName = "William Somerset"
        },
        new MoviesActors()
        {
            MovieId = new Guid("23fb559e-9a66-4423-af07-b97d9de649fe"),
            ActorId = new Guid("51bab7d6-b37f-40b4-b787-5f6cb30af6f4"),
            CharacterName = "Tracy Mills"
        },
        new MoviesActors()
        {
            MovieId = new Guid("50219472-6180-4b85-a5ac-fdf4079ccf58"),
            ActorId = new Guid("310706f7-2d9a-4e5a-8e2f-5214084fd26d"),
            CharacterName = "Nick Dunne"
        },
        new MoviesActors()
        {
            MovieId = new Guid("50219472-6180-4b85-a5ac-fdf4079ccf58"),
            ActorId = new Guid("25538521-d4f1-4ca8-ba20-1628c98b6930"),
            CharacterName = "Amy Dunne"
        },
        new MoviesActors()
        {
            MovieId = new Guid("50219472-6180-4b85-a5ac-fdf4079ccf58"),
            ActorId = new Guid("545d9868-b224-46c4-9b60-21271dc2adc2"),
            CharacterName = "Desi Collings"
        },
        new MoviesActors()
        {
            MovieId = new Guid("daed155e-81be-42e0-8d7a-dc2db09eb148"),
            ActorId = new Guid("d1c69566-30fd-47b2-9128-b7aadd4722a1"),
            CharacterName = "Clarice Starling"
        },
        new MoviesActors()
        {
            MovieId = new Guid("daed155e-81be-42e0-8d7a-dc2db09eb148"),
            ActorId = new Guid("0f312b1b-a6cd-4ed2-afe9-6b493205c424"),
            CharacterName = "Dr. Hannibal Lecter"
        },
        new MoviesActors()
        {
            MovieId = new Guid("daed155e-81be-42e0-8d7a-dc2db09eb148"),
            ActorId = new Guid("fcece400-14b5-481a-b5d7-fe67bf28f913"),
            CharacterName = "Jack Crawford"
        },
        new MoviesActors()
        {
            MovieId = new Guid("e131229c-a516-492d-898d-635a5b6c95e4"),
            ActorId = new Guid("a5381bf5-482b-4f12-9d17-d10e8fcb6fc1"),
            CharacterName = "Teddy Daniels"
        },
        new MoviesActors()
        {
            MovieId = new Guid("e131229c-a516-492d-898d-635a5b6c95e4"),
            ActorId = new Guid("18638236-cb2e-4892-befc-cf0068444068"),
            CharacterName = "Chuck Aule"
        },
        new MoviesActors()
        {
            MovieId = new Guid("e131229c-a516-492d-898d-635a5b6c95e4"),
            ActorId = new Guid("de41865b-5b44-43f7-9275-495898638232"),
            CharacterName = "Dr. Cawley"
        },
        new MoviesActors()
        {
            MovieId = new Guid("40009b98-ece3-42b4-8c7d-a10b4dda5b38"),
            ActorId = new Guid("b391372d-3bfd-48e4-be60-c343cc4b4f3f"),
            CharacterName = "Keller Dover"
        },
        new MoviesActors()
        {
            MovieId = new Guid("40009b98-ece3-42b4-8c7d-a10b4dda5b38"),
            ActorId = new Guid("b32c87ff-b412-42d3-bbc1-521841443d40"),
            CharacterName = "Detective Loki"
        },
        new MoviesActors()
        {
            MovieId = new Guid("40009b98-ece3-42b4-8c7d-a10b4dda5b38"),
            ActorId = new Guid("f3d34bfd-85e1-4dec-bc22-5f4eca6c9fc2"),
            CharacterName = "Alex Jones"
        },
        new MoviesActors()
        {
            MovieId = new Guid("9dcd678b-7dee-47d1-aff7-567156607a86"),
            ActorId = new Guid("b32c87ff-b412-42d3-bbc1-521841443d40"),
            CharacterName = "Robert Graysmith"
        },
        new MoviesActors()
        {
            MovieId = new Guid("9dcd678b-7dee-47d1-aff7-567156607a86"),
            ActorId = new Guid("18638236-cb2e-4892-befc-cf0068444068"),
            CharacterName = "Inspector David Toschi"
        },
        new MoviesActors()
        {
            MovieId = new Guid("9dcd678b-7dee-47d1-aff7-567156607a86"),
            ActorId = new Guid("d875ff93-4c8d-4470-9c2e-66209c6d63f2"),
            CharacterName = "Paul Avery"
        },
        new MoviesActors()
        {
            MovieId = new Guid("794c142d-386f-4a8a-8290-adf396a07f6a"),
            ActorId = new Guid("b32c87ff-b412-42d3-bbc1-521841443d40"),
            CharacterName = "Louis Bloom"
        },
        new MoviesActors()
        {
            MovieId = new Guid("794c142d-386f-4a8a-8290-adf396a07f6a"),
            ActorId = new Guid("9c39c7a7-3897-494b-a8b5-970dd50d88b6"),
            CharacterName = "Nina Romina"
        },
        new MoviesActors()
        {
            MovieId = new Guid("794c142d-386f-4a8a-8290-adf396a07f6a"),
            ActorId = new Guid("8ba7acf6-a509-48fe-92c0-c8c0528569fd"),
            CharacterName = "Rick"
        },
        new MoviesActors()
        {
            MovieId = new Guid("d5a8997f-b046-436f-aada-c06dd2ca0f1c"),
            ActorId = new Guid("00085ee6-52df-4585-967b-408c7ba486be"),
            CharacterName = "Mikael Blomkvist"
        },
        new MoviesActors()
        {
            MovieId = new Guid("d5a8997f-b046-436f-aada-c06dd2ca0f1c"),
            ActorId = new Guid("57ad6e92-9f65-4871-b922-11600447149c"),
            CharacterName = "Lisbeth Salander"
        },
        new MoviesActors()
        {
            MovieId = new Guid("d5a8997f-b046-436f-aada-c06dd2ca0f1c"),
            ActorId = new Guid("f8124011-adb0-4454-9da7-91f0e182fa33"),
            CharacterName = "Henrik Vanger"
        },
        new MoviesActors()
        {
            MovieId = new Guid("3a981e02-9650-4cc4-ba2f-978979789984"),
            ActorId = new Guid("f2dfcabe-52e1-4e25-84f2-054cc9f9a772"),
            CharacterName = "Nina Sayers"
        },
        new MoviesActors()
        {
            MovieId = new Guid("3a981e02-9650-4cc4-ba2f-978979789984"),
            ActorId = new Guid("990f0803-c80f-40cf-9d02-910e3d46a962"),
            CharacterName = "Lily"
        },
        new MoviesActors()
        {
            MovieId = new Guid("3a981e02-9650-4cc4-ba2f-978979789984"),
            ActorId = new Guid("08d54a07-c4a3-4467-8c2d-2791ccc3cb86"),
            CharacterName = "Thomas Leroy"
        },
        new MoviesActors()
        {
            MovieId = new Guid("c6d7d61d-0ab2-4789-85fe-053e438cfe2a"),
            ActorId = new Guid("9ff68d83-fc39-4081-ae3f-06ef755711d3"),
            CharacterName = "Llewelyn Moss"
        },
        new MoviesActors()
        {
            MovieId = new Guid("c6d7d61d-0ab2-4789-85fe-053e438cfe2a"),
            ActorId = new Guid("9af80152-7958-47f9-8f8a-b1394b62bc12"),
            CharacterName = "Anton Chigurh"
        },
        new MoviesActors()
        {
            MovieId = new Guid("c6d7d61d-0ab2-4789-85fe-053e438cfe2a"),
            ActorId = new Guid("556360a7-3f73-48c6-b971-52ff34371b93"),
            CharacterName = "Ed Tom Bell"
        },
        new MoviesActors()
        {
            MovieId = new Guid("c2159ffd-c180-4a04-8499-62c1886a4ac9"),
            ActorId = new Guid("12b4e8b1-deee-4931-baa3-bc4d5f3efb9b"),
            CharacterName = "Andy Dufresne"
        },
        new MoviesActors()
        {
            MovieId = new Guid("c2159ffd-c180-4a04-8499-62c1886a4ac9"),
            ActorId = new Guid("0dc023ca-c84f-4c6b-a1c3-ed3ca625b7bd"),
            CharacterName = "Ellis Boyd 'Red' Redding"
        },
        new MoviesActors()
        {
            MovieId = new Guid("c2159ffd-c180-4a04-8499-62c1886a4ac9"),
            ActorId = new Guid("5429c902-48d3-4dec-beac-49f37ff0b08d"),
            CharacterName = "Warden Norton"
        },
        new MoviesActors()
        {
            MovieId = new Guid("c441109b-5d90-4b44-847f-ec113694e334"),
            ActorId = new Guid("ad15e2ca-4491-413c-a95b-8b2cc8935c4c"),
            CharacterName = "Forrest Gump"
        },
        new MoviesActors()
        {
            MovieId = new Guid("c441109b-5d90-4b44-847f-ec113694e334"),
            ActorId = new Guid("ba291cbf-a1f6-4a18-bfa8-fb2a3c299e6f"),
            CharacterName = "Jenny Curran"
        },
        new MoviesActors()
        {
            MovieId = new Guid("c441109b-5d90-4b44-847f-ec113694e334"),
            ActorId = new Guid("1d4c8ea4-7f11-453b-8be8-e2218e767055"),
            CharacterName = "Lieutenant Dan Taylor"
        },
        new MoviesActors()
        {
            MovieId = new Guid("f1ff0736-167e-464c-98b3-66361a5952bb"),
            ActorId = new Guid("a14ff11b-23f0-402f-ad77-15bdf9eb5a8d"),
            CharacterName = "The Narrator"
        },
        new MoviesActors()
        {
            MovieId = new Guid("f1ff0736-167e-464c-98b3-66361a5952bb"),
            ActorId = new Guid("8441360b-3bb9-4f58-86c1-02dd3f04072a"),
            CharacterName = "Tyler Durden"
        },
        new MoviesActors()
        {
            MovieId = new Guid("f1ff0736-167e-464c-98b3-66361a5952bb"),
            ActorId = new Guid("539b371e-f3ec-4d09-8add-4072cd23d277"),
            CharacterName = "Marla Singer"
        },
        new MoviesActors()
        {
            MovieId = new Guid("e02b1783-545f-4c73-8374-768e6cfbf4c4"),
            ActorId = new Guid("38ebb771-b41b-43c4-ae42-d5da412e04d9"),
            CharacterName = "Don Vito Corleone"
        },
        new MoviesActors()
        {
            MovieId = new Guid("e02b1783-545f-4c73-8374-768e6cfbf4c4"),
            ActorId = new Guid("4123086b-dc4f-4e51-81fa-f64a6fc7f7bd"),
            CharacterName = "Michael Corleone"
        },
        new MoviesActors()
        {
            MovieId = new Guid("e02b1783-545f-4c73-8374-768e6cfbf4c4"),
            ActorId = new Guid("cfde46c5-342f-4560-85d2-493f082e0a01"),
            CharacterName = "Sonny Corleone"
        },
        new MoviesActors()
        {
            MovieId = new Guid("86e3b9d0-b465-4b7e-95a4-f1da2a66ada2"),
            ActorId = new Guid("5d7cdba3-e8dc-4f19-a8a3-8992aec07fae"),
            CharacterName = "John Nash"
        },
        new MoviesActors()
        {
            MovieId = new Guid("86e3b9d0-b465-4b7e-95a4-f1da2a66ada2"),
            ActorId = new Guid("b30648a8-3bfe-43be-bc09-65caf669fb09"),
            CharacterName = "Alicia Nash"
        },
        new MoviesActors()
        {
            MovieId = new Guid("86e3b9d0-b465-4b7e-95a4-f1da2a66ada2"),
            ActorId = new Guid("29ac4686-bfcd-49dc-8646-876522ab6472"),
            CharacterName = "William Parcher"
        },
        new MoviesActors()
        {
            MovieId = new Guid("d19b2756-5235-4f96-9577-7281f1d36d38"),
            ActorId = new Guid("ad15e2ca-4491-413c-a95b-8b2cc8935c4c"),
            CharacterName = "Paul Edgecomb"
        },
        new MoviesActors()
        {
            MovieId = new Guid("d19b2756-5235-4f96-9577-7281f1d36d38"),
            ActorId = new Guid("61cfb611-b7b6-4a63-8edc-7183a7a2dc35"),
            CharacterName = "John Coffey"
        },
        new MoviesActors()
        {
            MovieId = new Guid("d19b2756-5235-4f96-9577-7281f1d36d38"),
            ActorId = new Guid("29843c4b-6c08-4a57-9b36-95264eba65bd"),
            CharacterName = "Brutus 'Brutal' Howell"
        },
        new MoviesActors()
        {
            MovieId = new Guid("34b8a65e-15f2-424a-b164-600afe23f814"),
            ActorId = new Guid("a5381bf5-482b-4f12-9d17-d10e8fcb6fc1"),
            CharacterName = "Jack Dawson"
        },
        new MoviesActors()
        {
            MovieId = new Guid("34b8a65e-15f2-424a-b164-600afe23f814"),
            ActorId = new Guid("084b109f-15d5-473a-9baa-ab748f461af5"),
            CharacterName = "Rose DeWitt Bukater"
        },
        new MoviesActors()
        {
            MovieId = new Guid("34b8a65e-15f2-424a-b164-600afe23f814"),
            ActorId = new Guid("9d666c80-52f7-4e34-8871-245c0911979e"),
            CharacterName = "Cal Hockley"
        },
        new MoviesActors()
        {
            MovieId = new Guid("97448f10-b164-4880-82ed-a1ac239d0afd"),
            ActorId = new Guid("0863f099-87d9-4590-8a19-083384c1aa91"),
            CharacterName = "Andrew Neiman"
        },
        new MoviesActors()
        {
            MovieId = new Guid("97448f10-b164-4880-82ed-a1ac239d0afd"),
            ActorId = new Guid("34ed4fe5-d30b-4edc-a00f-f75f019d46a3"),
            CharacterName = "Terence Fletcher"
        },
        new MoviesActors()
        {
            MovieId = new Guid("97448f10-b164-4880-82ed-a1ac239d0afd"),
            ActorId = new Guid("3c328dc2-54a1-4a48-8962-6e7f903f2162"),
            CharacterName = "Jim Neiman"
        },
        new MoviesActors()
        {
            MovieId = new Guid("91e01bcd-a47d-48d9-b79d-8ed6c4886699"),
            ActorId = new Guid("44907d33-053a-47f7-ac1b-a2fddbbea5cc"),
            CharacterName = "Mark Zuckerberg"
        },
        new MoviesActors()
        {
            MovieId = new Guid("91e01bcd-a47d-48d9-b79d-8ed6c4886699"),
            ActorId = new Guid("8d806e2a-9b9e-407e-bfde-d95afc6f0c04"),
            CharacterName = "Eduardo Saverin"
        },
        new MoviesActors()
        {
            MovieId = new Guid("91e01bcd-a47d-48d9-b79d-8ed6c4886699"),
            ActorId = new Guid("263f806e-5bb0-4cc5-bdc1-a6130e3a6ae7"),
            CharacterName = "Sean Parker"
        },
        new MoviesActors()
        {
            MovieId = new Guid("7c1f4dea-492d-446f-ba11-aa0794b54350"),
            ActorId = new Guid("176400ce-53cf-4576-a2ed-432f78a43240"),
            CharacterName = "Arthur Fleck"
        },
        new MoviesActors()
        {
            MovieId = new Guid("7c1f4dea-492d-446f-ba11-aa0794b54350"),
            ActorId = new Guid("09ad1d06-e8a1-406e-890b-d744e67ffa76"),
            CharacterName = "Murray Franklin"
        },
        new MoviesActors()
        {
            MovieId = new Guid("7c1f4dea-492d-446f-ba11-aa0794b54350"),
            ActorId = new Guid("dc4a4b36-d647-43f9-b215-1a6024cc712f"),
            CharacterName = "Sophie Dumond"
        },
        new MoviesActors()
        {
            MovieId = new Guid("c4987c3e-6ee2-49f5-8caa-bb515b019e8b"),
            ActorId = new Guid("15aa84fd-f77a-483b-9499-7efa823c269c"),
            CharacterName = "Chris MacNeil"
        },
        new MoviesActors()
        {
            MovieId = new Guid("c4987c3e-6ee2-49f5-8caa-bb515b019e8b"),
            ActorId = new Guid("b6564219-9a09-4767-b494-e9fd622084b0"),
            CharacterName = "Father Merrin"
        },
        new MoviesActors()
        {
            MovieId = new Guid("c4987c3e-6ee2-49f5-8caa-bb515b019e8b"),
            ActorId = new Guid("76039504-7ee7-4356-a79d-161486a5b162"),
            CharacterName = "Regan"
        },
        new MoviesActors()
        {
            MovieId = new Guid("368e82a0-da8c-4d1b-90b0-749f12faecfa"),
            ActorId = new Guid("fd960aa9-8876-4dff-9d99-94c1c3738c04"),
            CharacterName = "Annie Graham"
        },
        new MoviesActors()
        {
            MovieId = new Guid("368e82a0-da8c-4d1b-90b0-749f12faecfa"),
            ActorId = new Guid("bec8cce9-b5a4-4a5d-8a39-ebac11c6448e"),
            CharacterName = "Peter Graham"
        },
        new MoviesActors()
        {
            MovieId = new Guid("368e82a0-da8c-4d1b-90b0-749f12faecfa"),
            ActorId = new Guid("eaf447ef-beea-4eaa-a94c-00acd311ef42"),
            CharacterName = "Charlie Graham"
        },
        new MoviesActors()
        {
            MovieId = new Guid("70a5373e-e526-4766-9194-e6d1a536485c"),
            ActorId = new Guid("179a8c49-2ace-4cc3-bef6-0d76f135c1ec"),
            CharacterName = "Lorraine Warren"
        },
        new MoviesActors()
        {
            MovieId = new Guid("70a5373e-e526-4766-9194-e6d1a536485c"),
            ActorId = new Guid("2f276480-e052-4120-85d6-7f5fb2a0141f"),
            CharacterName = "Ed Warren"
        },
        new MoviesActors()
        {
            MovieId = new Guid("70a5373e-e526-4766-9194-e6d1a536485c"),
            ActorId = new Guid("95ce32f0-7a46-4e31-8459-cd6ee973dba9"),
            CharacterName = "Carolyn Perron"
        },
        new MoviesActors()
        {
            MovieId = new Guid("acc9eaf0-be41-4f4c-a4f2-4bee8da3e4a0"),
            ActorId = new Guid("3de01bc3-0480-4a01-8593-ddfb1849ff9b"),
            CharacterName = "Nancy Thompson"
        },
        new MoviesActors()
        {
            MovieId = new Guid("acc9eaf0-be41-4f4c-a4f2-4bee8da3e4a0"),
            ActorId = new Guid("65970305-4fc7-4890-9f0b-5063affce076"),
            CharacterName = "Lt. Donald Thompson"
        },
        new MoviesActors()
        {
            MovieId = new Guid("acc9eaf0-be41-4f4c-a4f2-4bee8da3e4a0"),
            ActorId = new Guid("bc2dd711-8eac-439d-9353-dd355849ed8e"),
            CharacterName = "Freddy Krueger"
        },
        new MoviesActors()
        {
            MovieId = new Guid("43268f2d-7bfb-4c62-b49d-b868b1fc2568"),
            ActorId = new Guid("ed9b74af-8587-4aff-abd4-8957e4eb1ca7"),
            CharacterName = "Chris Washington"
        },
        new MoviesActors()
        {
            MovieId = new Guid("43268f2d-7bfb-4c62-b49d-b868b1fc2568"),
            ActorId = new Guid("e0fb708c-3052-473c-9f03-29f855010c16"),
            CharacterName = "Rose Armitage"
        },
        new MoviesActors()
        {
            MovieId = new Guid("43268f2d-7bfb-4c62-b49d-b868b1fc2568"),
            ActorId = new Guid("138ce271-e924-4e54-930e-0d8c04d0fc77"),
            CharacterName = "Dean Armitage"
        },
        new MoviesActors()
        {
            MovieId = new Guid("b235003d-d473-464d-a300-7049e31d0a6d"),
            ActorId = new Guid("1c76e80e-212e-49c2-bb82-d3cb7bb8a9ca"),
            CharacterName = "Bill Denbrough"
        },
        new MoviesActors()
        {
            MovieId = new Guid("b235003d-d473-464d-a300-7049e31d0a6d"),
            ActorId = new Guid("8904c86f-88c7-4575-9c5a-70d83a4a53db"),
            CharacterName = "Beverly Marsh"
        },
        new MoviesActors()
        {
            MovieId = new Guid("b235003d-d473-464d-a300-7049e31d0a6d"),
            ActorId = new Guid("f42cbe69-d1a1-45bd-9a93-8aaa606744ca"),
            CharacterName = "Pennywise"
        },
        new MoviesActors()
        {
            MovieId = new Guid("7c9e4721-3564-4a95-952b-37e8a5eff337"),
            ActorId = new Guid("baf8a9c9-d344-4e6f-b802-a85dad91ffb9"),
            CharacterName = "Rachel Keller"
        },
        new MoviesActors()
        {
            MovieId = new Guid("7c9e4721-3564-4a95-952b-37e8a5eff337"),
            ActorId = new Guid("1cea7dbe-d8be-44bc-bdcc-2ebfa35e8c9f"),
            CharacterName = "Noah Clay"
        },
        new MoviesActors()
        {
            MovieId = new Guid("7c9e4721-3564-4a95-952b-37e8a5eff337"),
            ActorId = new Guid("afaa9921-7f23-482b-b344-19e43274db30"),
            CharacterName = "Aidan Keller"
        },
        new MoviesActors()
        {
            MovieId = new Guid("4d91f3a2-6c96-4a58-90f7-bbea29063a5f"),
            ActorId = new Guid("158a9d99-77ae-46ca-8818-65ab53540d11"),
            CharacterName = "Laurie Strode"
        },
        new MoviesActors()
        {
            MovieId = new Guid("4d91f3a2-6c96-4a58-90f7-bbea29063a5f"),
            ActorId = new Guid("3b9bf0a1-5001-4946-a64f-fbfe3a6f73a1"),
            CharacterName = "Dr. Sam Loomis"
        },
        new MoviesActors()
        {
            MovieId = new Guid("4d91f3a2-6c96-4a58-90f7-bbea29063a5f"),
            ActorId = new Guid("e4a264bc-0a02-4720-917c-fca59bb573ff"),
            CharacterName = "The Shape"
        },
        new MoviesActors()
        {
            MovieId = new Guid("07d1c2e1-a2e2-4ee5-873f-b101cc613a25"),
            ActorId = new Guid("cf61c4ca-a860-4e52-848a-4014f336afc9"),
            CharacterName = "Jack Torrance"
        },
        new MoviesActors()
        {
            MovieId = new Guid("07d1c2e1-a2e2-4ee5-873f-b101cc613a25"),
            ActorId = new Guid("9186ec1d-7199-439e-b062-a103f1371d54"),
            CharacterName = "Wendy Torrance"
        },
        new MoviesActors()
        {
            MovieId = new Guid("07d1c2e1-a2e2-4ee5-873f-b101cc613a25"),
            ActorId = new Guid("655b7c4a-7bde-4498-82b2-46288064039f"),
            CharacterName = "Dick Hallorann"
        },
        new MoviesActors()
        {
            MovieId = new Guid("f2661055-d0cd-4e35-ada5-bd9369ecc094"),
            ActorId = new Guid("2f276480-e052-4120-85d6-7f5fb2a0141f"),
            CharacterName = "Josh Lambert"
        },
        new MoviesActors()
        {
            MovieId = new Guid("f2661055-d0cd-4e35-ada5-bd9369ecc094"),
            ActorId = new Guid("e52850d9-f3a4-4d46-a265-3667403ac2e9"),
            CharacterName = "Renai Lambert"
        },
        new MoviesActors()
        {
            MovieId = new Guid("f2661055-d0cd-4e35-ada5-bd9369ecc094"),
            ActorId = new Guid("1fc801b0-0633-4cff-97fe-c6068014dfa4"),
            CharacterName = "Lorraine Lambert"
        },
        new MoviesActors()
        {
            MovieId = new Guid("93d7a78d-d7aa-43d0-8d7d-91a22b7c7619"),
            ActorId = new Guid("d875ff93-4c8d-4470-9c2e-66209c6d63f2"),
            CharacterName = "Tony Stark"
        },
        new MoviesActors()
        {
            MovieId = new Guid("93d7a78d-d7aa-43d0-8d7d-91a22b7c7619"),
            ActorId = new Guid("925ac384-48c7-4eac-96fd-36bf2b9f6bd4"),
            CharacterName = "Steve Rogers"
        },
        new MoviesActors()
        {
            MovieId = new Guid("93d7a78d-d7aa-43d0-8d7d-91a22b7c7619"),
            ActorId = new Guid("dfe14619-506f-4f09-9a8e-8bf0fdaa4e83"),
            CharacterName = "Natasha Romanoff"
        },
        new MoviesActors()
        {
            MovieId = new Guid("97951c83-8686-45c8-be13-a0b0f79539a5"),
            ActorId = new Guid("50e895bc-e9e1-445b-a99c-6615bd33437a"),
            CharacterName = "Peter Parker"
        },
        new MoviesActors()
        {
            MovieId = new Guid("97951c83-8686-45c8-be13-a0b0f79539a5"),
            ActorId = new Guid("7c144da1-9cb5-498f-9f04-8d6d5418455e"),
            CharacterName = "MJ"
        },
        new MoviesActors()
        {
            MovieId = new Guid("97951c83-8686-45c8-be13-a0b0f79539a5"),
            ActorId = new Guid("bbf4da5f-54e3-4659-b179-978e5f6ab285"),
            CharacterName = "Doctor Strange"
        },
        new MoviesActors()
        {
            MovieId = new Guid("59d62ca3-2be7-4ef6-bfbc-362b4ff49fac"),
            ActorId = new Guid("447f0422-0955-41e1-9b47-f2b09a8a474c"),
            CharacterName = "T'Challa"
        },
        new MoviesActors()
        {
            MovieId = new Guid("59d62ca3-2be7-4ef6-bfbc-362b4ff49fac"),
            ActorId = new Guid("5b20c518-2ac0-4dbb-9e2f-db4d9f0bb879"),
            CharacterName = "Killmonger"
        },
        new MoviesActors()
        {
            MovieId = new Guid("59d62ca3-2be7-4ef6-bfbc-362b4ff49fac"),
            ActorId = new Guid("01258edc-1458-4035-af5c-19fde8c99a1d"),
            CharacterName = "Nakia"
        },
        new MoviesActors()
        {
            MovieId = new Guid("cb0c0fb5-1799-4ad4-99f3-d78c0a1e21cf"),
            ActorId = new Guid("b391372d-3bfd-48e4-be60-c343cc4b4f3f"),
            CharacterName = "Logan"
        },
        new MoviesActors()
        {
            MovieId = new Guid("cb0c0fb5-1799-4ad4-99f3-d78c0a1e21cf"),
            ActorId = new Guid("8044275d-432e-4e99-a403-bc47b7208011"),
            CharacterName = "Charles"
        },
        new MoviesActors()
        {
            MovieId = new Guid("cb0c0fb5-1799-4ad4-99f3-d78c0a1e21cf"),
            ActorId = new Guid("b6a14c4f-815e-4be4-b6b3-b69717718c8d"),
            CharacterName = "Laura"
        },
        new MoviesActors()
        {
            MovieId = new Guid("75a766dd-73cd-4a3b-81ef-738e4b72a23d"),
            ActorId = new Guid("d875ff93-4c8d-4470-9c2e-66209c6d63f2"),
            CharacterName = "Tony Stark"
        },
        new MoviesActors()
        {
            MovieId = new Guid("75a766dd-73cd-4a3b-81ef-738e4b72a23d"),
            ActorId = new Guid("51bab7d6-b37f-40b4-b787-5f6cb30af6f4"),
            CharacterName = "Pepper Potts"
        },
        new MoviesActors()
        {
            MovieId = new Guid("75a766dd-73cd-4a3b-81ef-738e4b72a23d"),
            ActorId = new Guid("2f5d38f8-9375-4e62-bde1-801bc44f2908"),
            CharacterName = "Obadiah Stane"
        },
        new MoviesActors()
        {
            MovieId = new Guid("512d850d-0dad-429a-a2f8-5a492651e8d5"),
            ActorId = new Guid("d1bdcd3f-a8be-4044-96b4-26a0745585e9"),
            CharacterName = "Bruce Wayne"
        },
        new MoviesActors()
        {
            MovieId = new Guid("512d850d-0dad-429a-a2f8-5a492651e8d5"),
            ActorId = new Guid("bc65dca2-6946-4eeb-841d-add7c0fd0376"),
            CharacterName = "Bane"
        },
        new MoviesActors()
        {
            MovieId = new Guid("512d850d-0dad-429a-a2f8-5a492651e8d5"),
            ActorId = new Guid("cac1fee0-fd3a-47f8-b629-cb9b65d68b2c"),
            CharacterName = "Selina"
        },
        new MoviesActors()
        {
            MovieId = new Guid("377d6f6f-4aeb-4046-9ded-dfaf7e8d59a5"),
            ActorId = new Guid("e175c472-5291-47de-832d-003b3aa6527a"),
            CharacterName = "Wade Wilson"
        },
        new MoviesActors()
        {
            MovieId = new Guid("377d6f6f-4aeb-4046-9ded-dfaf7e8d59a5"),
            ActorId = new Guid("12cf4f78-7a6f-4421-b158-9df0034694e1"),
            CharacterName = "Vanessa"
        },
        new MoviesActors()
        {
            MovieId = new Guid("377d6f6f-4aeb-4046-9ded-dfaf7e8d59a5"),
            ActorId = new Guid("a9f10213-5b0f-42cb-b282-0daa96bb1519"),
            CharacterName = "Ajax"
        },
        new MoviesActors()
        {
            MovieId = new Guid("6ea110b0-5980-49ec-9812-bdc05ca854be"),
            ActorId = new Guid("bbf4da5f-54e3-4659-b179-978e5f6ab285"),
            CharacterName = "Dr. Stephen Strange"
        },
        new MoviesActors()
        {
            MovieId = new Guid("6ea110b0-5980-49ec-9812-bdc05ca854be"),
            ActorId = new Guid("bb729c83-9964-434b-97b7-66c7665aa3da"),
            CharacterName = "Mordo"
        },
        new MoviesActors()
        {
            MovieId = new Guid("6ea110b0-5980-49ec-9812-bdc05ca854be"),
            ActorId = new Guid("1a536677-8b72-42dc-b7ec-506ab25c501f"),
            CharacterName = "The Ancient One"
        },
        new MoviesActors()
        {
            MovieId = new Guid("d5e2cd4f-959d-4a19-becf-404713d46271"),
            ActorId = new Guid("2e7678ba-e51a-402a-ae90-6585b837ea90"),
            CharacterName = "Thor"
        },
        new MoviesActors()
        {
            MovieId = new Guid("d5e2cd4f-959d-4a19-becf-404713d46271"),
            ActorId = new Guid("1f7c2d4c-cfb4-47ca-ba0e-575c6e5b1ae2"),
            CharacterName = "Loki"
        },
        new MoviesActors()
        {
            MovieId = new Guid("d5e2cd4f-959d-4a19-becf-404713d46271"),
            ActorId = new Guid("3fa7c993-1327-4a37-87f6-0020d90dbfea"),
            CharacterName = "Hela"
        },
        new MoviesActors()
        {
            MovieId = new Guid("5c3f62e1-a6ca-4286-9cb3-5cbc0afc3d8b"),
            ActorId = new Guid("26d5c98a-347d-49b0-9268-2029a7f0ee98"),
            CharacterName = "Peter Quill"
        },
        new MoviesActors()
        {
            MovieId = new Guid("5c3f62e1-a6ca-4286-9cb3-5cbc0afc3d8b"),
            ActorId = new Guid("a7c020f2-1864-4e0a-98a5-4d3b03f6eee7"),
            CharacterName = "Gamora"
        },
        new MoviesActors()
        {
            MovieId = new Guid("5c3f62e1-a6ca-4286-9cb3-5cbc0afc3d8b"),
            ActorId = new Guid("bfad936e-bf67-4b44-8a27-88606204e79e"),
            CharacterName = "Drax"
        },
        new MoviesActors()
        {
            MovieId = new Guid("885e7b27-c1c2-4ab8-8a6c-f676ecec60df"),
            ActorId = new Guid("4b7fe159-069a-4c8f-8bd3-09ed79a4c5ae"),
            CharacterName = "Frodo Baggins"
        },
        new MoviesActors()
        {
            MovieId = new Guid("885e7b27-c1c2-4ab8-8a6c-f676ecec60df"),
            ActorId = new Guid("f03b85c5-d584-4d0b-8d38-d7356f469375"),
            CharacterName = "Gandalf"
        },
        new MoviesActors()
        {
            MovieId = new Guid("885e7b27-c1c2-4ab8-8a6c-f676ecec60df"),
            ActorId = new Guid("d1fb6849-f352-4e51-a01c-e98b0f67fc40"),
            CharacterName = "Aragorn"
        },
        new MoviesActors()
        {
            MovieId = new Guid("c6c210c2-c80b-474e-9d97-2751200097ae"),
            ActorId = new Guid("4b7fe159-069a-4c8f-8bd3-09ed79a4c5ae"),
            CharacterName = "Frodo Baggins"
        },
        new MoviesActors()
        {
            MovieId = new Guid("c6c210c2-c80b-474e-9d97-2751200097ae"),
            ActorId = new Guid("f03b85c5-d584-4d0b-8d38-d7356f469375"),
            CharacterName = "Gandalf"
        },
        new MoviesActors()
        {
            MovieId = new Guid("c6c210c2-c80b-474e-9d97-2751200097ae"),
            ActorId = new Guid("d1fb6849-f352-4e51-a01c-e98b0f67fc40"),
            CharacterName = "Aragorn"
        },
        new MoviesActors()
        {
            MovieId = new Guid("bd56340e-eea7-4e83-9b69-6ede4a939bd8"),
            ActorId = new Guid("4b7fe159-069a-4c8f-8bd3-09ed79a4c5ae"),
            CharacterName = "Frodo Baggins"
        },
        new MoviesActors()
        {
            MovieId = new Guid("bd56340e-eea7-4e83-9b69-6ede4a939bd8"),
            ActorId = new Guid("d1fb6849-f352-4e51-a01c-e98b0f67fc40"),
            CharacterName = "Aragorn"
        },
        new MoviesActors()
        {
            MovieId = new Guid("bd56340e-eea7-4e83-9b69-6ede4a939bd8"),
            ActorId = new Guid("b96f5e3e-e5c2-4005-93ba-14a6db7078b9"),
            CharacterName = "Samwise Gamgee"
        },
        new MoviesActors()
        {
            MovieId = new Guid("2a90d8b6-82d8-4581-9fa7-ecaa5832dc26"),
            ActorId = new Guid("950268ca-c69a-41f4-81c3-7cd61c42a9e1"),
            CharacterName = "Harry Potter"
        },
        new MoviesActors()
        {
            MovieId = new Guid("2a90d8b6-82d8-4581-9fa7-ecaa5832dc26"),
            ActorId = new Guid("1acc5129-33a7-4b35-b00b-f350c34c0b83"),
            CharacterName = "Hermione Granger"
        },
        new MoviesActors()
        {
            MovieId = new Guid("2a90d8b6-82d8-4581-9fa7-ecaa5832dc26"),
            ActorId = new Guid("82d8d010-92a5-4189-b947-d56faf569ba6"),
            CharacterName = "Ron Weasley"
        },
        new MoviesActors()
        {
            MovieId = new Guid("cb8a9632-001b-464e-905c-2a0062f1bcaf"),
            ActorId = new Guid("950268ca-c69a-41f4-81c3-7cd61c42a9e1"),
            CharacterName = "Harry Potter"
        },
        new MoviesActors()
        {
            MovieId = new Guid("cb8a9632-001b-464e-905c-2a0062f1bcaf"),
            ActorId = new Guid("1acc5129-33a7-4b35-b00b-f350c34c0b83"),
            CharacterName = "Hermione Granger"
        },
        new MoviesActors()
        {
            MovieId = new Guid("cb8a9632-001b-464e-905c-2a0062f1bcaf"),
            ActorId = new Guid("95a09f9f-98a1-4a0b-a409-6a357ceb9930"),
            CharacterName = "Sirius Black"
        },
        new MoviesActors()
        {
            MovieId = new Guid("2fad653d-7cde-4b92-a5e8-a3928570f756"),
            ActorId = new Guid("339a12ea-c0b1-4c15-81eb-189212eda79d"),
            CharacterName = "Ofelia"
        },
        new MoviesActors()
        {
            MovieId = new Guid("2fad653d-7cde-4b92-a5e8-a3928570f756"),
            ActorId = new Guid("4f53bb1c-0f91-48bc-9876-5dfd7ab74ebb"),
            CharacterName = "Captain Vidal"
        },
        new MoviesActors()
        {
            MovieId = new Guid("2fad653d-7cde-4b92-a5e8-a3928570f756"),
            ActorId = new Guid("93088ce9-c00a-4ea4-9cd6-2ac02db77c7d"),
            CharacterName = "Mercedes"
        },
        new MoviesActors()
        {
            MovieId = new Guid("9d0944ab-9bfa-4345-8ee6-6f52787b19c4"),
            ActorId = new Guid("96c08023-9ed3-46dd-a016-facb34a4bef9"),
            CharacterName = "Bilbo Baggins"
        },
        new MoviesActors()
        {
            MovieId = new Guid("9d0944ab-9bfa-4345-8ee6-6f52787b19c4"),
            ActorId = new Guid("f03b85c5-d584-4d0b-8d38-d7356f469375"),
            CharacterName = "Gandalf"
        },
        new MoviesActors()
        {
            MovieId = new Guid("9d0944ab-9bfa-4345-8ee6-6f52787b19c4"),
            ActorId = new Guid("f5faf27e-6f57-4035-a94e-1055cd927ed1"),
            CharacterName = "Thorin Oakenshield"
        },
        new MoviesActors()
        {
            MovieId = new Guid("623d306a-95f7-48f7-9f09-aa298685ac3b"),
            ActorId = new Guid("5f3878b6-e371-4be2-afcb-10906290b75a"),
            CharacterName = "Captain Jack Sparrow"
        },
        new MoviesActors()
        {
            MovieId = new Guid("623d306a-95f7-48f7-9f09-aa298685ac3b"),
            ActorId = new Guid("e2100a6d-cc7d-47c9-9927-72082d1b3843"),
            CharacterName = "Will Turner"
        },
        new MoviesActors()
        {
            MovieId = new Guid("623d306a-95f7-48f7-9f09-aa298685ac3b"),
            ActorId = new Guid("858afe84-3e5a-451b-bd2d-eda7f38e8467"),
            CharacterName = "Elizabeth Swann"
        },
        new MoviesActors()
        {
            MovieId = new Guid("4ab20a27-63b5-42ee-a9de-aef4b0866153"),
            ActorId = new Guid("0415474f-6528-4602-9803-b387d67b5b5d"),
            CharacterName = "Lucy Pevensie"
        },
        new MoviesActors()
        {
            MovieId = new Guid("4ab20a27-63b5-42ee-a9de-aef4b0866153"),
            ActorId = new Guid("1a536677-8b72-42dc-b7ec-506ab25c501f"),
            CharacterName = "White Witch"
        },
        new MoviesActors()
        {
            MovieId = new Guid("4ab20a27-63b5-42ee-a9de-aef4b0866153"),
            ActorId = new Guid("3c550829-e360-4a0f-947f-b8510e01718a"),
            CharacterName = "Mr. Tumnus"
        },
        new MoviesActors()
        {
            MovieId = new Guid("441db5ba-a442-43f9-8e18-363cf678f5d2"),
            ActorId = new Guid("ca837102-6e0b-4bc6-a39c-d35bbc3dfa80"),
            CharacterName = "Tristan Thorn"
        },
        new MoviesActors()
        {
            MovieId = new Guid("441db5ba-a442-43f9-8e18-363cf678f5d2"),
            ActorId = new Guid("13ec26d4-e9fc-4def-ae21-f93ab8d4d6b6"),
            CharacterName = "Yvaine"
        },
        new MoviesActors()
        {
            MovieId = new Guid("441db5ba-a442-43f9-8e18-363cf678f5d2"),
            ActorId = new Guid("dc2957ed-c6dc-40c6-8dcb-8e93bdd8ba03"),
            CharacterName = "Lamia"
        },
        new MoviesActors()
        {
            MovieId = new Guid("9e1126ac-ddca-4012-9204-8d0480e417d1"),
            ActorId = new Guid("a5381bf5-482b-4f12-9d17-d10e8fcb6fc1"),
            CharacterName = "Cobb"
        },
        new MoviesActors()
        {
            MovieId = new Guid("9e1126ac-ddca-4012-9204-8d0480e417d1"),
            ActorId = new Guid("09b7ed63-7445-4c20-b6cf-271ddb9e4c96"),
            CharacterName = "Arthur"
        },
        new MoviesActors()
        {
            MovieId = new Guid("9e1126ac-ddca-4012-9204-8d0480e417d1"),
            ActorId = new Guid("59d617f1-c06c-4dd0-8b8b-ad0fd2615135"),
            CharacterName = "Ariadne"
        },
        new MoviesActors()
        {
            MovieId = new Guid("6851194f-61a0-4df1-8e89-2030ca47fe24"),
            ActorId = new Guid("00cdc0aa-e696-4628-b8cc-ec84f4a6dc06"),
            CharacterName = "Cooper"
        },
        new MoviesActors()
        {
            MovieId = new Guid("6851194f-61a0-4df1-8e89-2030ca47fe24"),
            ActorId = new Guid("cac1fee0-fd3a-47f8-b629-cb9b65d68b2c"),
            CharacterName = "Brand"
        },
        new MoviesActors()
        {
            MovieId = new Guid("6851194f-61a0-4df1-8e89-2030ca47fe24"),
            ActorId = new Guid("40f67ef1-8703-42e9-94af-f65e1a2ef186"),
            CharacterName = "Murph"
        },
        new MoviesActors()
        {
            MovieId = new Guid("63c3517c-d626-4181-a444-0adeeb056878"),
            ActorId = new Guid("b479a3b8-5eba-43f0-a77c-797fc760ab1f"),
            CharacterName = "K"
        },
        new MoviesActors()
        {
            MovieId = new Guid("63c3517c-d626-4181-a444-0adeeb056878"),
            ActorId = new Guid("36e4bf12-895e-44a2-b635-e9e7930c0997"),
            CharacterName = "Rick Deckard"
        },
        new MoviesActors()
        {
            MovieId = new Guid("63c3517c-d626-4181-a444-0adeeb056878"),
            ActorId = new Guid("dae9df12-f329-45e4-b256-a7e9646e838d"),
            CharacterName = "Joi"
        },
        new MoviesActors()
        {
            MovieId = new Guid("e96c3640-af75-4342-bf73-2c249993f934"),
            ActorId = new Guid("1b39c2ef-208c-4e08-b668-a533d279d528"),
            CharacterName = "Ripley"
        },
        new MoviesActors()
        {
            MovieId = new Guid("e96c3640-af75-4342-bf73-2c249993f934"),
            ActorId = new Guid("a41a0cad-77db-47cc-a5a0-0d57342a9b65"),
            CharacterName = "Dallas"
        },
        new MoviesActors()
        {
            MovieId = new Guid("e96c3640-af75-4342-bf73-2c249993f934"),
            ActorId = new Guid("c3891de0-0cda-41bc-a2ae-e957df3d0f1a"),
            CharacterName = "Kane"
        },
        new MoviesActors()
        {
            MovieId = new Guid("a4a49163-f174-4a42-9f88-1f1b30325ef5"),
            ActorId = new Guid("1b39c2ef-208c-4e08-b668-a533d279d528"),
            CharacterName = "Ripley"
        },
        new MoviesActors()
        {
            MovieId = new Guid("a4a49163-f174-4a42-9f88-1f1b30325ef5"),
            ActorId = new Guid("c55c41c7-9a4d-40d2-b2fc-57eb139bf902"),
            CharacterName = "Corporal Hicks"
        },
        new MoviesActors()
        {
            MovieId = new Guid("a4a49163-f174-4a42-9f88-1f1b30325ef5"),
            ActorId = new Guid("a8360aca-2aa9-49da-925b-af9deaa40978"),
            CharacterName = "Newt"
        },
        new MoviesActors()
        {
            MovieId = new Guid("13f91c44-a819-49c8-8ed3-3c003171ddc3"),
            ActorId = new Guid("c9ee97ea-de38-4ce6-add4-ebc54fd7d92a"),
            CharacterName = "Louise Banks"
        },
        new MoviesActors()
        {
            MovieId = new Guid("13f91c44-a819-49c8-8ed3-3c003171ddc3"),
            ActorId = new Guid("ff728ce9-28c4-4e30-9e50-bd0e7fba3b39"),
            CharacterName = "Ian Donnelly"
        },
        new MoviesActors()
        {
            MovieId = new Guid("13f91c44-a819-49c8-8ed3-3c003171ddc3"),
            ActorId = new Guid("a5f19f18-702b-49cb-8e8a-634045a81baa"),
            CharacterName = "Colonel Weber"
        },
        new MoviesActors()
        {
            MovieId = new Guid("5b248551-840b-4632-8aaf-3e1b16252d65"),
            ActorId = new Guid("bdb9ef82-f830-4d22-96ea-7128d9fd92b7"),
            CharacterName = "Mark Watney"
        },
        new MoviesActors()
        {
            MovieId = new Guid("5b248551-840b-4632-8aaf-3e1b16252d65"),
            ActorId = new Guid("40f67ef1-8703-42e9-94af-f65e1a2ef186"),
            CharacterName = "Melissa Lewis"
        },
        new MoviesActors()
        {
            MovieId = new Guid("5b248551-840b-4632-8aaf-3e1b16252d65"),
            ActorId = new Guid("2c4f6a03-d0b1-4e0e-8e5a-d824d9ffa7c7"),
            CharacterName = "Teddy Sanders"
        },
        new MoviesActors()
        {
            MovieId = new Guid("700ebda0-232e-4b1c-9be2-bf6a99893d6d"),
            ActorId = new Guid("468fc8fc-00b2-4740-b025-f465bc99c283"),
            CharacterName = "Wikus van de Merwe"
        },
        new MoviesActors()
        {
            MovieId = new Guid("700ebda0-232e-4b1c-9be2-bf6a99893d6d"),
            ActorId = new Guid("480a5aa3-2618-4777-8d6c-764b0bac7a6b"),
            CharacterName = "Christopher Johnson"
        },
        new MoviesActors()
        {
            MovieId = new Guid("700ebda0-232e-4b1c-9be2-bf6a99893d6d"),
            ActorId = new Guid("7c412653-3c11-4b3a-8118-22a6c219f54c"),
            CharacterName = "Koobus Venter"
        },
        new MoviesActors()
        {
            MovieId = new Guid("af12ea31-878c-43ce-95ac-bb3d54f277f4"),
            ActorId = new Guid("d9963534-1f06-4a69-bf13-8e735e7c9e9f"),
            CharacterName = "Theo Faron"
        },
        new MoviesActors()
        {
            MovieId = new Guid("af12ea31-878c-43ce-95ac-bb3d54f277f4"),
            ActorId = new Guid("f0c4a679-e5fd-4329-811c-0735cff97711"),
            CharacterName = "Julian"
        },
        new MoviesActors()
        {
            MovieId = new Guid("af12ea31-878c-43ce-95ac-bb3d54f277f4"),
            ActorId = new Guid("3dacabea-76fa-48d7-8b12-4095bacbd787"),
            CharacterName = "Jasper"
        },
        new MoviesActors()
        {
            MovieId = new Guid("88b25038-308e-4253-82c0-4a57151ad908"),
            ActorId = new Guid("879fffcf-e8fe-4a4a-bab5-da42fc4d1256"),
            CharacterName = "Caleb Smith"
        },
        new MoviesActors()
        {
            MovieId = new Guid("88b25038-308e-4253-82c0-4a57151ad908"),
            ActorId = new Guid("2bb629f1-e03a-4c92-b265-6ba6f3674026"),
            CharacterName = "Ava"
        },
        new MoviesActors()
        {
            MovieId = new Guid("88b25038-308e-4253-82c0-4a57151ad908"),
            ActorId = new Guid("ea2f8e0d-eb55-4452-90a1-f810474cbe7f"),
            CharacterName = "Nathan Bateman"
        }
    ];
}