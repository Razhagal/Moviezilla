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
            CharacterName = "John McCLane"
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
            ActorId = new Guid("cda5b584-c19f-48e5-9e4b-787bbbd441ff"),
            CharacterName = "Winston"
        },
        new MoviesActors()
        {
            MovieId = new Guid("d6bf3fb7-df18-4e5c-bce4-1f7cf55b8848"),
            ActorId = new Guid("43c89467-ac0e-4e79-9f8e-929848c36d6a"),
            CharacterName = "Iosef Tarasov"
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
            ActorId = new Guid("d1bdcd3f-a8be-4044-96b4-26a0745585e9")
        },
        new MoviesActors()
        {
            MovieId = new Guid("6f6779da-99ae-44d9-a61a-43ebe5f0fd77"),
            ActorId = new Guid("50cafa2b-71bd-4ea8-8eb0-a5ee95eff467")
        },
        new MoviesActors()
        {
            MovieId = new Guid("6f6779da-99ae-44d9-a61a-43ebe5f0fd77"),
            ActorId = new Guid("6fd39241-45d7-4435-beeb-6ef22cc912de")
        },
        new MoviesActors()
        {
            MovieId = new Guid("f01bf412-3480-4c18-9b6f-418f947c1ba2"),
            ActorId = new Guid("d246a339-8c96-4ee4-9377-c6110d1ebaef")
        },
        new MoviesActors()
        {
            MovieId = new Guid("f01bf412-3480-4c18-9b6f-418f947c1ba2"),
            ActorId = new Guid("f80c0da1-8be6-4a46-a578-edfce3af270d")
        },
        new MoviesActors()
        {
            MovieId = new Guid("f01bf412-3480-4c18-9b6f-418f947c1ba2"),
            ActorId = new Guid("8dcde184-4ee9-4ac3-8a01-e8827834d161")
        },
        new MoviesActors()
        {
            MovieId = new Guid("614bf670-e4d2-4b35-a208-c84a6c75c764"),
            ActorId = new Guid("d85eed69-92c7-4bcb-b978-9c2179a19f6c")
        },
        new MoviesActors()
        {
            MovieId = new Guid("614bf670-e4d2-4b35-a208-c84a6c75c764"),
            ActorId = new Guid("453399e4-7c51-46d3-aeae-99eb8f06fef9")
        },
        new MoviesActors()
        {
            MovieId = new Guid("614bf670-e4d2-4b35-a208-c84a6c75c764"),
            ActorId = new Guid("bfc71005-46f5-4f0e-a05d-eb99293367d5")
        },
        new MoviesActors()
        {
            MovieId = new Guid("78e7000a-1425-4340-938a-cf4a5bac6775"),
            ActorId = new Guid("00085ee6-52df-4585-967b-408c7ba486be")
        },
        new MoviesActors()
        {
            MovieId = new Guid("78e7000a-1425-4340-938a-cf4a5bac6775"),
            ActorId = new Guid("c7483292-2173-429e-bf47-be27c5dc820b")
        },
        new MoviesActors()
        {
            MovieId = new Guid("78e7000a-1425-4340-938a-cf4a5bac6775"),
            ActorId = new Guid("086a28bc-461c-4360-90e6-d34634bc7930")
        },
        new MoviesActors()
        {
            MovieId = new Guid("5247d8b6-6f31-4995-86c9-4196332328a0"),
            ActorId = new Guid("6547e436-757f-4cb1-a179-f337b0922121")
        },
        new MoviesActors()
        {
            MovieId = new Guid("5247d8b6-6f31-4995-86c9-4196332328a0"),
            ActorId = new Guid("cee50ddf-38c4-40fb-91a3-02bfc7bee4aa")
        },
        new MoviesActors()
        {
            MovieId = new Guid("5247d8b6-6f31-4995-86c9-4196332328a0"),
            ActorId = new Guid("70705055-5ce6-4a88-a3ba-5e031ae9b786")
        },
        new MoviesActors()
        {
            MovieId = new Guid("a7b10c31-a060-4436-bef3-4b08014e794e"),
            ActorId = new Guid("101916e7-e588-499f-829a-daa2793c23e8")
        },
        new MoviesActors()
        {
            MovieId = new Guid("a7b10c31-a060-4436-bef3-4b08014e794e"),
            ActorId = new Guid("3998723a-ebb9-4e63-a96b-8575e5345e5b")
        },
        new MoviesActors()
        {
            MovieId = new Guid("a7b10c31-a060-4436-bef3-4b08014e794e"),
            ActorId = new Guid("0dd7a860-af97-4fe5-86ca-d7b6a171e506")
        },
        new MoviesActors()
        {
            MovieId = new Guid("d83ca8b1-f2da-4aa3-b5b8-a35ec94d20c4"),
            ActorId = new Guid("f9e3238a-97a1-4718-ab92-31d5236547b3")
        },
        new MoviesActors()
        {
            MovieId = new Guid("d83ca8b1-f2da-4aa3-b5b8-a35ec94d20c4"),
            ActorId = new Guid("483c83dc-0645-46ea-80a7-2f227b5f80cf")
        },
        new MoviesActors()
        {
            MovieId = new Guid("d83ca8b1-f2da-4aa3-b5b8-a35ec94d20c4"),
            ActorId = new Guid("0f0f48ae-983b-48b1-a574-a8dc4f6ace0b")
        },
        new MoviesActors()
        {
            MovieId = new Guid("a7061bb8-f59a-4ab7-ad3c-dce86b7ccbdc"),
            ActorId = new Guid("1251c5c5-0fdd-40c1-89d7-0e10b338300c")
        },
        new MoviesActors()
        {
            MovieId = new Guid("a7061bb8-f59a-4ab7-ad3c-dce86b7ccbdc"),
            ActorId = new Guid("0a1a093a-54e3-454d-86f9-73523144b49d")
        },
        new MoviesActors()
        {
            MovieId = new Guid("a7061bb8-f59a-4ab7-ad3c-dce86b7ccbdc"),
            ActorId = new Guid("be6e3a70-0dd5-4da8-8534-4a208c09a614")
        },
        new MoviesActors()
        {
            MovieId = new Guid("9d52bd23-4ee9-499d-8789-0d860eef65a3"),
            ActorId = new Guid("362cae35-adc0-4ad9-8ff5-8a6603edf315")
        },
        new MoviesActors()
        {
            MovieId = new Guid("9d52bd23-4ee9-499d-8789-0d860eef65a3"),
            ActorId = new Guid("2c4f6a03-d0b1-4e0e-8e5a-d824d9ffa7c7")
        },
        new MoviesActors()
        {
            MovieId = new Guid("9d52bd23-4ee9-499d-8789-0d860eef65a3"),
            ActorId = new Guid("bf824b1f-8c4d-4be3-9566-dee5b7e512b0")
        },
        new MoviesActors()
        {
            MovieId = new Guid("69941e20-653e-4ddf-a9ef-7a98f601ba61"),
            ActorId = new Guid("84982976-ae90-4237-9520-d6239df1458d")
        },
        new MoviesActors()
        {
            MovieId = new Guid("69941e20-653e-4ddf-a9ef-7a98f601ba61"),
            ActorId = new Guid("9af1c7b4-2511-48e0-8868-fc0dab590d71")
        },
        new MoviesActors()
        {
            MovieId = new Guid("69941e20-653e-4ddf-a9ef-7a98f601ba61"),
            ActorId = new Guid("f3b65829-46e4-4143-b39b-86136de26b7f")
        },
        new MoviesActors()
        {
            MovieId = new Guid("4e35a624-d5db-4900-b43e-c0f9b7d28590"),
            ActorId = new Guid("fed28090-372d-456f-9a1e-c207058ac144")
        },
        new MoviesActors()
        {
            MovieId = new Guid("4e35a624-d5db-4900-b43e-c0f9b7d28590"),
            ActorId = new Guid("d70a393d-94ed-424f-ad8f-b0a041617c52")
        },
        new MoviesActors()
        {
            MovieId = new Guid("4e35a624-d5db-4900-b43e-c0f9b7d28590"),
            ActorId = new Guid("aec03985-5285-415c-b7c2-1245a6751576")
        },
        new MoviesActors()
        {
            MovieId = new Guid("66275523-30e6-48e0-8c65-dab3d3fb12f8"),
            ActorId = new Guid("a1c457e5-d6b5-4fce-81a1-e570ebca481a")
        },
        new MoviesActors()
        {
            MovieId = new Guid("66275523-30e6-48e0-8c65-dab3d3fb12f8"),
            ActorId = new Guid("e1d47d6f-e0e3-4214-b4f7-21b37d6db88d")
        },
        new MoviesActors()
        {
            MovieId = new Guid("66275523-30e6-48e0-8c65-dab3d3fb12f8"),
            ActorId = new Guid("d31a1794-c533-4a9a-85a9-d90e3390c8dd")
        },
        new MoviesActors()
        {
            MovieId = new Guid("d04029bd-e8d4-4e65-ac84-094d766d8306"),
            ActorId = new Guid("a1c457e5-d6b5-4fce-81a1-e570ebca481a")
        },
        new MoviesActors()
        {
            MovieId = new Guid("d04029bd-e8d4-4e65-ac84-094d766d8306"),
            ActorId = new Guid("8b3378bc-3e09-4921-9466-7bf8b3108211")
        },
        new MoviesActors()
        {
            MovieId = new Guid("d04029bd-e8d4-4e65-ac84-094d766d8306"),
            ActorId = new Guid("10ba4f1b-fb6f-4040-a38a-1de45d9d7605")
        },
        new MoviesActors()
        {
            MovieId = new Guid("e9626460-ec88-4203-99b7-d918105fef03"),
            ActorId = new Guid("362cae35-adc0-4ad9-8ff5-8a6603edf315")
        },
        new MoviesActors()
        {
            MovieId = new Guid("e9626460-ec88-4203-99b7-d918105fef03"),
            ActorId = new Guid("411fdf1d-ff3a-490c-86ac-ef8252b5c0fa")
        },
        new MoviesActors()
        {
            MovieId = new Guid("e9626460-ec88-4203-99b7-d918105fef03"),
            ActorId = new Guid("ef1f2981-782a-40c7-b0dc-5e6a85bb7055")
        },
        new MoviesActors()
        {
            MovieId = new Guid("00641073-88cb-471e-bea0-8e6601494d09"),
            ActorId = new Guid("846cc4c2-430e-42e8-b9a8-f3369310563a")
        },
        new MoviesActors()
        {
            MovieId = new Guid("00641073-88cb-471e-bea0-8e6601494d09"),
            ActorId = new Guid("32ac45d4-37c1-4f8c-9c9c-20e9cea6a21d")
        },
        new MoviesActors()
        {
            MovieId = new Guid("00641073-88cb-471e-bea0-8e6601494d09"),
            ActorId = new Guid("e337f1ec-b22c-4ddf-8b5e-bd5afa946129")
        },
        new MoviesActors()
        {
            MovieId = new Guid("b0e94565-1376-46f0-b5c4-2aedc6d30ce7"),
            ActorId = new Guid("362cae35-adc0-4ad9-8ff5-8a6603edf315")
        },
        new MoviesActors()
        {
            MovieId = new Guid("b0e94565-1376-46f0-b5c4-2aedc6d30ce7"),
            ActorId = new Guid("bd607b66-67f7-4fa5-8798-56fecc7d83e8")
        },
        new MoviesActors()
        {
            MovieId = new Guid("b0e94565-1376-46f0-b5c4-2aedc6d30ce7"),
            ActorId = new Guid("0dc023ca-c84f-4c6b-a1c3-ed3ca625b7bd")
        },
        new MoviesActors()
        {
            MovieId = new Guid("23fb559e-9a66-4423-af07-b97d9de649fe"),
            ActorId = new Guid("8441360b-3bb9-4f58-86c1-02dd3f04072a")
        },
        new MoviesActors()
        {
            MovieId = new Guid("23fb559e-9a66-4423-af07-b97d9de649fe"),
            ActorId = new Guid("0dc023ca-c84f-4c6b-a1c3-ed3ca625b7bd")
        },
        new MoviesActors()
        {
            MovieId = new Guid("23fb559e-9a66-4423-af07-b97d9de649fe"),
            ActorId = new Guid("51bab7d6-b37f-40b4-b787-5f6cb30af6f4")
        },
        new MoviesActors()
        {
            MovieId = new Guid("50219472-6180-4b85-a5ac-fdf4079ccf58"),
            ActorId = new Guid("310706f7-2d9a-4e5a-8e2f-5214084fd26d")
        },
        new MoviesActors()
        {
            MovieId = new Guid("50219472-6180-4b85-a5ac-fdf4079ccf58"),
            ActorId = new Guid("25538521-d4f1-4ca8-ba20-1628c98b6930")
        },
        new MoviesActors()
        {
            MovieId = new Guid("50219472-6180-4b85-a5ac-fdf4079ccf58"),
            ActorId = new Guid("545d9868-b224-46c4-9b60-21271dc2adc2")
        },
        new MoviesActors()
        {
            MovieId = new Guid("daed155e-81be-42e0-8d7a-dc2db09eb148"),
            ActorId = new Guid("d1c69566-30fd-47b2-9128-b7aadd4722a1")
        },
        new MoviesActors()
        {
            MovieId = new Guid("daed155e-81be-42e0-8d7a-dc2db09eb148"),
            ActorId = new Guid("0f312b1b-a6cd-4ed2-afe9-6b493205c424")
        },
        new MoviesActors()
        {
            MovieId = new Guid("daed155e-81be-42e0-8d7a-dc2db09eb148"),
            ActorId = new Guid("fcece400-14b5-481a-b5d7-fe67bf28f913")
        },
        new MoviesActors()
        {
            MovieId = new Guid("e131229c-a516-492d-898d-635a5b6c95e4"),
            ActorId = new Guid("a5381bf5-482b-4f12-9d17-d10e8fcb6fc1")
        },
        new MoviesActors()
        {
            MovieId = new Guid("e131229c-a516-492d-898d-635a5b6c95e4"),
            ActorId = new Guid("18638236-cb2e-4892-befc-cf0068444068")
        },
        new MoviesActors()
        {
            MovieId = new Guid("e131229c-a516-492d-898d-635a5b6c95e4"),
            ActorId = new Guid("de41865b-5b44-43f7-9275-495898638232")
        },
        new MoviesActors()
        {
            MovieId = new Guid("40009b98-ece3-42b4-8c7d-a10b4dda5b38"),
            ActorId = new Guid("b391372d-3bfd-48e4-be60-c343cc4b4f3f")
        },
        new MoviesActors()
        {
            MovieId = new Guid("40009b98-ece3-42b4-8c7d-a10b4dda5b38"),
            ActorId = new Guid("b32c87ff-b412-42d3-bbc1-521841443d40")
        },
        new MoviesActors()
        {
            MovieId = new Guid("40009b98-ece3-42b4-8c7d-a10b4dda5b38"),
            ActorId = new Guid("f3d34bfd-85e1-4dec-bc22-5f4eca6c9fc2")
        },
        new MoviesActors()
        {
            MovieId = new Guid("9dcd678b-7dee-47d1-aff7-567156607a86"),
            ActorId = new Guid("b32c87ff-b412-42d3-bbc1-521841443d40")
        },
        new MoviesActors()
        {
            MovieId = new Guid("9dcd678b-7dee-47d1-aff7-567156607a86"),
            ActorId = new Guid("18638236-cb2e-4892-befc-cf0068444068")
        },
        new MoviesActors()
        {
            MovieId = new Guid("9dcd678b-7dee-47d1-aff7-567156607a86"),
            ActorId = new Guid("d875ff93-4c8d-4470-9c2e-66209c6d63f2")
        },
        new MoviesActors()
        {
            MovieId = new Guid("794c142d-386f-4a8a-8290-adf396a07f6a"),
            ActorId = new Guid("b32c87ff-b412-42d3-bbc1-521841443d40")
        },
        new MoviesActors()
        {
            MovieId = new Guid("794c142d-386f-4a8a-8290-adf396a07f6a"),
            ActorId = new Guid("9c39c7a7-3897-494b-a8b5-970dd50d88b6")
        },
        new MoviesActors()
        {
            MovieId = new Guid("794c142d-386f-4a8a-8290-adf396a07f6a"),
            ActorId = new Guid("8ba7acf6-a509-48fe-92c0-c8c0528569fd")
        },
        new MoviesActors()
        {
            MovieId = new Guid("d5a8997f-b046-436f-aada-c06dd2ca0f1c"),
            ActorId = new Guid("00085ee6-52df-4585-967b-408c7ba486be")
        },
        new MoviesActors()
        {
            MovieId = new Guid("d5a8997f-b046-436f-aada-c06dd2ca0f1c"),
            ActorId = new Guid("57ad6e92-9f65-4871-b922-11600447149c")
        },
        new MoviesActors()
        {
            MovieId = new Guid("d5a8997f-b046-436f-aada-c06dd2ca0f1c"),
            ActorId = new Guid("f8124011-adb0-4454-9da7-91f0e182fa33")
        },
        new MoviesActors()
        {
            MovieId = new Guid("3a981e02-9650-4cc4-ba2f-978979789984"),
            ActorId = new Guid("f2dfcabe-52e1-4e25-84f2-054cc9f9a772")
        },
        new MoviesActors()
        {
            MovieId = new Guid("3a981e02-9650-4cc4-ba2f-978979789984"),
            ActorId = new Guid("990f0803-c80f-40cf-9d02-910e3d46a962")
        },
        new MoviesActors()
        {
            MovieId = new Guid("3a981e02-9650-4cc4-ba2f-978979789984"),
            ActorId = new Guid("08d54a07-c4a3-4467-8c2d-2791ccc3cb86")
        },
        new MoviesActors()
        {
            MovieId = new Guid("c6d7d61d-0ab2-4789-85fe-053e438cfe2a"),
            ActorId = new Guid("9ff68d83-fc39-4081-ae3f-06ef755711d3")
        },
        new MoviesActors()
        {
            MovieId = new Guid("c6d7d61d-0ab2-4789-85fe-053e438cfe2a"),
            ActorId = new Guid("9af80152-7958-47f9-8f8a-b1394b62bc12")
        },
        new MoviesActors()
        {
            MovieId = new Guid("c6d7d61d-0ab2-4789-85fe-053e438cfe2a"),
            ActorId = new Guid("556360a7-3f73-48c6-b971-52ff34371b93")
        },
        new MoviesActors()
        {
            MovieId = new Guid("c2159ffd-c180-4a04-8499-62c1886a4ac9"),
            ActorId = new Guid("12b4e8b1-deee-4931-baa3-bc4d5f3efb9b")
        },
        new MoviesActors()
        {
            MovieId = new Guid("c2159ffd-c180-4a04-8499-62c1886a4ac9"),
            ActorId = new Guid("0dc023ca-c84f-4c6b-a1c3-ed3ca625b7bd")
        },
        new MoviesActors()
        {
            MovieId = new Guid("c2159ffd-c180-4a04-8499-62c1886a4ac9"),
            ActorId = new Guid("5429c902-48d3-4dec-beac-49f37ff0b08d")
        },
        new MoviesActors()
        {
            MovieId = new Guid("c441109b-5d90-4b44-847f-ec113694e334"),
            ActorId = new Guid("ad15e2ca-4491-413c-a95b-8b2cc8935c4c")
        },
        new MoviesActors()
        {
            MovieId = new Guid("c441109b-5d90-4b44-847f-ec113694e334"),
            ActorId = new Guid("ba291cbf-a1f6-4a18-bfa8-fb2a3c299e6f")
        },
        new MoviesActors()
        {
            MovieId = new Guid("c441109b-5d90-4b44-847f-ec113694e334"),
            ActorId = new Guid("1d4c8ea4-7f11-453b-8be8-e2218e767055")
        },
        new MoviesActors()
        {
            MovieId = new Guid("f1ff0736-167e-464c-98b3-66361a5952bb"),
            ActorId = new Guid("a14ff11b-23f0-402f-ad77-15bdf9eb5a8d")
        },
        new MoviesActors()
        {
            MovieId = new Guid("f1ff0736-167e-464c-98b3-66361a5952bb"),
            ActorId = new Guid("8441360b-3bb9-4f58-86c1-02dd3f04072a")
        },
        new MoviesActors()
        {
            MovieId = new Guid("f1ff0736-167e-464c-98b3-66361a5952bb"),
            ActorId = new Guid("539b371e-f3ec-4d09-8add-4072cd23d277")
        },
        new MoviesActors()
        {
            MovieId = new Guid("e02b1783-545f-4c73-8374-768e6cfbf4c4"),
            ActorId = new Guid("38ebb771-b41b-43c4-ae42-d5da412e04d9")
        },
        new MoviesActors()
        {
            MovieId = new Guid("e02b1783-545f-4c73-8374-768e6cfbf4c4"),
            ActorId = new Guid("4123086b-dc4f-4e51-81fa-f64a6fc7f7bd")
        },
        new MoviesActors()
        {
            MovieId = new Guid("e02b1783-545f-4c73-8374-768e6cfbf4c4"),
            ActorId = new Guid("cfde46c5-342f-4560-85d2-493f082e0a01")
        },
        new MoviesActors()
        {
            MovieId = new Guid("86e3b9d0-b465-4b7e-95a4-f1da2a66ada2"),
            ActorId = new Guid("5d7cdba3-e8dc-4f19-a8a3-8992aec07fae")
        },
        new MoviesActors()
        {
            MovieId = new Guid("86e3b9d0-b465-4b7e-95a4-f1da2a66ada2"),
            ActorId = new Guid("b30648a8-3bfe-43be-bc09-65caf669fb09")
        },
        new MoviesActors()
        {
            MovieId = new Guid("86e3b9d0-b465-4b7e-95a4-f1da2a66ada2"),
            ActorId = new Guid("29ac4686-bfcd-49dc-8646-876522ab6472")
        },
        new MoviesActors()
        {
            MovieId = new Guid("d19b2756-5235-4f96-9577-7281f1d36d38"),
            ActorId = new Guid("ad15e2ca-4491-413c-a95b-8b2cc8935c4c")
        },
        new MoviesActors()
        {
            MovieId = new Guid("d19b2756-5235-4f96-9577-7281f1d36d38"),
            ActorId = new Guid("61cfb611-b7b6-4a63-8edc-7183a7a2dc35")
        },
        new MoviesActors()
        {
            MovieId = new Guid("d19b2756-5235-4f96-9577-7281f1d36d38"),
            ActorId = new Guid("29843c4b-6c08-4a57-9b36-95264eba65bd")
        },
        new MoviesActors()
        {
            MovieId = new Guid("34b8a65e-15f2-424a-b164-600afe23f814"),
            ActorId = new Guid("a5381bf5-482b-4f12-9d17-d10e8fcb6fc1")
        },
        new MoviesActors()
        {
            MovieId = new Guid("34b8a65e-15f2-424a-b164-600afe23f814"),
            ActorId = new Guid("084b109f-15d5-473a-9baa-ab748f461af5")
        },
        new MoviesActors()
        {
            MovieId = new Guid("34b8a65e-15f2-424a-b164-600afe23f814"),
            ActorId = new Guid("9d666c80-52f7-4e34-8871-245c0911979e")
        },
        new MoviesActors()
        {
            MovieId = new Guid("97448f10-b164-4880-82ed-a1ac239d0afd"),
            ActorId = new Guid("0863f099-87d9-4590-8a19-083384c1aa91")
        },
        new MoviesActors()
        {
            MovieId = new Guid("97448f10-b164-4880-82ed-a1ac239d0afd"),
            ActorId = new Guid("34ed4fe5-d30b-4edc-a00f-f75f019d46a3")
        },
        new MoviesActors()
        {
            MovieId = new Guid("97448f10-b164-4880-82ed-a1ac239d0afd"),
            ActorId = new Guid("3c328dc2-54a1-4a48-8962-6e7f903f2162")
        },
        new MoviesActors()
        {
            MovieId = new Guid("91e01bcd-a47d-48d9-b79d-8ed6c4886699"),
            ActorId = new Guid("44907d33-053a-47f7-ac1b-a2fddbbea5cc")
        },
        new MoviesActors()
        {
            MovieId = new Guid("91e01bcd-a47d-48d9-b79d-8ed6c4886699"),
            ActorId = new Guid("8d806e2a-9b9e-407e-bfde-d95afc6f0c04")
        },
        new MoviesActors()
        {
            MovieId = new Guid("91e01bcd-a47d-48d9-b79d-8ed6c4886699"),
            ActorId = new Guid("263f806e-5bb0-4cc5-bdc1-a6130e3a6ae7")
        },
        new MoviesActors()
        {
            MovieId = new Guid("7c1f4dea-492d-446f-ba11-aa0794b54350"),
            ActorId = new Guid("176400ce-53cf-4576-a2ed-432f78a43240")
        },
        new MoviesActors()
        {
            MovieId = new Guid("7c1f4dea-492d-446f-ba11-aa0794b54350"),
            ActorId = new Guid("09ad1d06-e8a1-406e-890b-d744e67ffa76")
        },
        new MoviesActors()
        {
            MovieId = new Guid("7c1f4dea-492d-446f-ba11-aa0794b54350"),
            ActorId = new Guid("dc4a4b36-d647-43f9-b215-1a6024cc712f")
        },
        new MoviesActors()
        {
            MovieId = new Guid("c4987c3e-6ee2-49f5-8caa-bb515b019e8b"),
            ActorId = new Guid("15aa84fd-f77a-483b-9499-7efa823c269c")
        },
        new MoviesActors()
        {
            MovieId = new Guid("c4987c3e-6ee2-49f5-8caa-bb515b019e8b"),
            ActorId = new Guid("b6564219-9a09-4767-b494-e9fd622084b0")
        },
        new MoviesActors()
        {
            MovieId = new Guid("c4987c3e-6ee2-49f5-8caa-bb515b019e8b"),
            ActorId = new Guid("76039504-7ee7-4356-a79d-161486a5b162")
        },
        new MoviesActors()
        {
            MovieId = new Guid("368e82a0-da8c-4d1b-90b0-749f12faecfa"),
            ActorId = new Guid("fd960aa9-8876-4dff-9d99-94c1c3738c04")
        },
        new MoviesActors()
        {
            MovieId = new Guid("368e82a0-da8c-4d1b-90b0-749f12faecfa"),
            ActorId = new Guid("bec8cce9-b5a4-4a5d-8a39-ebac11c6448e")
        },
        new MoviesActors()
        {
            MovieId = new Guid("368e82a0-da8c-4d1b-90b0-749f12faecfa"),
            ActorId = new Guid("eaf447ef-beea-4eaa-a94c-00acd311ef42")
        },
        new MoviesActors()
        {
            MovieId = new Guid("70a5373e-e526-4766-9194-e6d1a536485c"),
            ActorId = new Guid("179a8c49-2ace-4cc3-bef6-0d76f135c1ec")
        },
        new MoviesActors()
        {
            MovieId = new Guid("70a5373e-e526-4766-9194-e6d1a536485c"),
            ActorId = new Guid("2f276480-e052-4120-85d6-7f5fb2a0141f")
        },
        new MoviesActors()
        {
            MovieId = new Guid("70a5373e-e526-4766-9194-e6d1a536485c"),
            ActorId = new Guid("95ce32f0-7a46-4e31-8459-cd6ee973dba9")
        },
        new MoviesActors()
        {
            MovieId = new Guid("acc9eaf0-be41-4f4c-a4f2-4bee8da3e4a0"),
            ActorId = new Guid("3de01bc3-0480-4a01-8593-ddfb1849ff9b")
        },
        new MoviesActors()
        {
            MovieId = new Guid("acc9eaf0-be41-4f4c-a4f2-4bee8da3e4a0"),
            ActorId = new Guid("65970305-4fc7-4890-9f0b-5063affce076")
        },
        new MoviesActors()
        {
            MovieId = new Guid("acc9eaf0-be41-4f4c-a4f2-4bee8da3e4a0"),
            ActorId = new Guid("bc2dd711-8eac-439d-9353-dd355849ed8e")
        },
        new MoviesActors()
        {
            MovieId = new Guid("43268f2d-7bfb-4c62-b49d-b868b1fc2568"),
            ActorId = new Guid("ed9b74af-8587-4aff-abd4-8957e4eb1ca7")
        },
        new MoviesActors()
        {
            MovieId = new Guid("43268f2d-7bfb-4c62-b49d-b868b1fc2568"),
            ActorId = new Guid("e0fb708c-3052-473c-9f03-29f855010c16")
        },
        new MoviesActors()
        {
            MovieId = new Guid("43268f2d-7bfb-4c62-b49d-b868b1fc2568"),
            ActorId = new Guid("138ce271-e924-4e54-930e-0d8c04d0fc77")
        },
        new MoviesActors()
        {
            MovieId = new Guid("b235003d-d473-464d-a300-7049e31d0a6d"),
            ActorId = new Guid("1c76e80e-212e-49c2-bb82-d3cb7bb8a9ca")
        },
        new MoviesActors()
        {
            MovieId = new Guid("b235003d-d473-464d-a300-7049e31d0a6d"),
            ActorId = new Guid("8904c86f-88c7-4575-9c5a-70d83a4a53db")
        },
        new MoviesActors()
        {
            MovieId = new Guid("b235003d-d473-464d-a300-7049e31d0a6d"),
            ActorId = new Guid("f42cbe69-d1a1-45bd-9a93-8aaa606744ca")
        },
        new MoviesActors()
        {
            MovieId = new Guid("7c9e4721-3564-4a95-952b-37e8a5eff337"),
            ActorId = new Guid("baf8a9c9-d344-4e6f-b802-a85dad91ffb9")
        },
        new MoviesActors()
        {
            MovieId = new Guid("7c9e4721-3564-4a95-952b-37e8a5eff337"),
            ActorId = new Guid("1cea7dbe-d8be-44bc-bdcc-2ebfa35e8c9f")
        },
        new MoviesActors()
        {
            MovieId = new Guid("7c9e4721-3564-4a95-952b-37e8a5eff337"),
            ActorId = new Guid("afaa9921-7f23-482b-b344-19e43274db30")
        },
        new MoviesActors()
        {
            MovieId = new Guid("4d91f3a2-6c96-4a58-90f7-bbea29063a5f"),
            ActorId = new Guid("158a9d99-77ae-46ca-8818-65ab53540d11")
        },
        new MoviesActors()
        {
            MovieId = new Guid("4d91f3a2-6c96-4a58-90f7-bbea29063a5f"),
            ActorId = new Guid("3b9bf0a1-5001-4946-a64f-fbfe3a6f73a1")
        },
        new MoviesActors()
        {
            MovieId = new Guid("4d91f3a2-6c96-4a58-90f7-bbea29063a5f"),
            ActorId = new Guid("e4a264bc-0a02-4720-917c-fca59bb573ff")
        },
        new MoviesActors()
        {
            MovieId = new Guid("07d1c2e1-a2e2-4ee5-873f-b101cc613a25"),
            ActorId = new Guid("cf61c4ca-a860-4e52-848a-4014f336afc9")
        },
        new MoviesActors()
        {
            MovieId = new Guid("07d1c2e1-a2e2-4ee5-873f-b101cc613a25"),
            ActorId = new Guid("9186ec1d-7199-439e-b062-a103f1371d54")
        },
        new MoviesActors()
        {
            MovieId = new Guid("07d1c2e1-a2e2-4ee5-873f-b101cc613a25"),
            ActorId = new Guid("655b7c4a-7bde-4498-82b2-46288064039f")
        },
        new MoviesActors()
        {
            MovieId = new Guid("f2661055-d0cd-4e35-ada5-bd9369ecc094"),
            ActorId = new Guid("2f276480-e052-4120-85d6-7f5fb2a0141f")
        },
        new MoviesActors()
        {
            MovieId = new Guid("f2661055-d0cd-4e35-ada5-bd9369ecc094"),
            ActorId = new Guid("e52850d9-f3a4-4d46-a265-3667403ac2e9")
        },
        new MoviesActors()
        {
            MovieId = new Guid("f2661055-d0cd-4e35-ada5-bd9369ecc094"),
            ActorId = new Guid("1fc801b0-0633-4cff-97fe-c6068014dfa4")
        },
        new MoviesActors()
        {
            MovieId = new Guid("93d7a78d-d7aa-43d0-8d7d-91a22b7c7619"),
            ActorId = new Guid("d875ff93-4c8d-4470-9c2e-66209c6d63f2")
        },
        new MoviesActors()
        {
            MovieId = new Guid("93d7a78d-d7aa-43d0-8d7d-91a22b7c7619"),
            ActorId = new Guid("925ac384-48c7-4eac-96fd-36bf2b9f6bd4")
        },
        new MoviesActors()
        {
            MovieId = new Guid("93d7a78d-d7aa-43d0-8d7d-91a22b7c7619"),
            ActorId = new Guid("dfe14619-506f-4f09-9a8e-8bf0fdaa4e83")
        },
        new MoviesActors()
        {
            MovieId = new Guid("97951c83-8686-45c8-be13-a0b0f79539a5"),
            ActorId = new Guid("50e895bc-e9e1-445b-a99c-6615bd33437a")
        },
        new MoviesActors()
        {
            MovieId = new Guid("97951c83-8686-45c8-be13-a0b0f79539a5"),
            ActorId = new Guid("7c144da1-9cb5-498f-9f04-8d6d5418455e")
        },
        new MoviesActors()
        {
            MovieId = new Guid("97951c83-8686-45c8-be13-a0b0f79539a5"),
            ActorId = new Guid("bbf4da5f-54e3-4659-b179-978e5f6ab285")
        },
        new MoviesActors()
        {
            MovieId = new Guid("59d62ca3-2be7-4ef6-bfbc-362b4ff49fac"),
            ActorId = new Guid("447f0422-0955-41e1-9b47-f2b09a8a474c")
        },
        new MoviesActors()
        {
            MovieId = new Guid("59d62ca3-2be7-4ef6-bfbc-362b4ff49fac"),
            ActorId = new Guid("5b20c518-2ac0-4dbb-9e2f-db4d9f0bb879")
        },
        new MoviesActors()
        {
            MovieId = new Guid("59d62ca3-2be7-4ef6-bfbc-362b4ff49fac"),
            ActorId = new Guid("01258edc-1458-4035-af5c-19fde8c99a1d")
        },
        new MoviesActors()
        {
            MovieId = new Guid("cb0c0fb5-1799-4ad4-99f3-d78c0a1e21cf"),
            ActorId = new Guid("b391372d-3bfd-48e4-be60-c343cc4b4f3f")
        },
        new MoviesActors()
        {
            MovieId = new Guid("cb0c0fb5-1799-4ad4-99f3-d78c0a1e21cf"),
            ActorId = new Guid("8044275d-432e-4e99-a403-bc47b7208011")
        },
        new MoviesActors()
        {
            MovieId = new Guid("cb0c0fb5-1799-4ad4-99f3-d78c0a1e21cf"),
            ActorId = new Guid("b6a14c4f-815e-4be4-b6b3-b69717718c8d")
        },
        new MoviesActors()
        {
            MovieId = new Guid("75a766dd-73cd-4a3b-81ef-738e4b72a23d"),
            ActorId = new Guid("d875ff93-4c8d-4470-9c2e-66209c6d63f2")
        },
        new MoviesActors()
        {
            MovieId = new Guid("75a766dd-73cd-4a3b-81ef-738e4b72a23d"),
            ActorId = new Guid("51bab7d6-b37f-40b4-b787-5f6cb30af6f4")
        },
        new MoviesActors()
        {
            MovieId = new Guid("75a766dd-73cd-4a3b-81ef-738e4b72a23d"),
            ActorId = new Guid("2f5d38f8-9375-4e62-bde1-801bc44f2908")
        },
        new MoviesActors()
        {
            MovieId = new Guid("512d850d-0dad-429a-a2f8-5a492651e8d5"),
            ActorId = new Guid("d1bdcd3f-a8be-4044-96b4-26a0745585e9")
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
            ActorId = new Guid("cac1fee0-fd3a-47f8-b629-cb9b65d68b2c")
        },
        new MoviesActors()
        {
            MovieId = new Guid("377d6f6f-4aeb-4046-9ded-dfaf7e8d59a5"),
            ActorId = new Guid("e175c472-5291-47de-832d-003b3aa6527a")
        },
        new MoviesActors()
        {
            MovieId = new Guid("377d6f6f-4aeb-4046-9ded-dfaf7e8d59a5"),
            ActorId = new Guid("12cf4f78-7a6f-4421-b158-9df0034694e1")
        },
        new MoviesActors()
        {
            MovieId = new Guid("377d6f6f-4aeb-4046-9ded-dfaf7e8d59a5"),
            ActorId = new Guid("a9f10213-5b0f-42cb-b282-0daa96bb1519")
        },
        new MoviesActors()
        {
            MovieId = new Guid("6ea110b0-5980-49ec-9812-bdc05ca854be"),
            ActorId = new Guid("bbf4da5f-54e3-4659-b179-978e5f6ab285")
        },
        new MoviesActors()
        {
            MovieId = new Guid("6ea110b0-5980-49ec-9812-bdc05ca854be"),
            ActorId = new Guid("bb729c83-9964-434b-97b7-66c7665aa3da")
        },
        new MoviesActors()
        {
            MovieId = new Guid("6ea110b0-5980-49ec-9812-bdc05ca854be"),
            ActorId = new Guid("1a536677-8b72-42dc-b7ec-506ab25c501f")
        },
        new MoviesActors()
        {
            MovieId = new Guid("d5e2cd4f-959d-4a19-becf-404713d46271"),
            ActorId = new Guid("2e7678ba-e51a-402a-ae90-6585b837ea90")
        },
        new MoviesActors()
        {
            MovieId = new Guid("d5e2cd4f-959d-4a19-becf-404713d46271"),
            ActorId = new Guid("1f7c2d4c-cfb4-47ca-ba0e-575c6e5b1ae2")
        },
        new MoviesActors()
        {
            MovieId = new Guid("d5e2cd4f-959d-4a19-becf-404713d46271"),
            ActorId = new Guid("3fa7c993-1327-4a37-87f6-0020d90dbfea")
        },
        new MoviesActors()
        {
            MovieId = new Guid("5c3f62e1-a6ca-4286-9cb3-5cbc0afc3d8b"),
            ActorId = new Guid("26d5c98a-347d-49b0-9268-2029a7f0ee98")
        },
        new MoviesActors()
        {
            MovieId = new Guid("5c3f62e1-a6ca-4286-9cb3-5cbc0afc3d8b"),
            ActorId = new Guid("a7c020f2-1864-4e0a-98a5-4d3b03f6eee7")
        },
        new MoviesActors()
        {
            MovieId = new Guid("5c3f62e1-a6ca-4286-9cb3-5cbc0afc3d8b"),
            ActorId = new Guid("bfad936e-bf67-4b44-8a27-88606204e79e")
        }
    ];
}