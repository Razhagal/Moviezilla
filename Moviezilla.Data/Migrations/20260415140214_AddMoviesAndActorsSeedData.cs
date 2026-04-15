using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Moviezilla.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMoviesAndActorsSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "actors",
                columns: new[] { "id", "image_url", "name", "short_bio" },
                values: new object[,]
                {
                    { new Guid("00085ee6-52df-4585-967b-408c7ba486be"), "https://m.media-amazon.com/images/M/MV5BMjEzMjk4NDU4MF5BMl5BanBnXkFtZTcwMDMyNjQzMg@@._V1_FMjpg_UX269_.jpg", "Daniel Craig", "English actor known for gritty leading roles and the James Bond series." },
                    { new Guid("00cdc0aa-e696-4628-b8cc-ec84f4a6dc06"), "https://m.media-amazon.com/images/M/MV5BMTg0MDc3ODUwOV5BMl5BanBnXkFtZTcwMTk2NjY4Nw@@._V1_FMjpg_UX1256_.jpg", "Matthew McConaughey", "American actor known for charismatic performances in drama and science fiction." },
                    { new Guid("01258edc-1458-4035-af5c-19fde8c99a1d"), "https://m.media-amazon.com/images/M/MV5BMTY0NTQ4MDY2Nl5BMl5BanBnXkFtZTgwNDk1MTEyMDE@._V1_FMjpg_UY2048_.jpg", "Lupita Nyong'o", "Kenyan-Mexican actress known for emotionally vivid performances." },
                    { new Guid("0415474f-6528-4602-9803-b387d67b5b5d"), "https://m.media-amazon.com/images/M/MV5BMTEyOTEyODc1MDZeQTJeQWpwZ15BbWU3MDA5MjcwMzQ@._V1_FMjpg_UX295_.jpg", "Georgie Henley", "English actress known for her breakout role in the Narnia films." },
                    { new Guid("084b109f-15d5-473a-9baa-ab748f461af5"), "https://m.media-amazon.com/images/M/MV5BODgzMzM2NTE0Ml5BMl5BanBnXkFtZTcwMTcyMTkyOQ@@._V1_FMjpg_UY2048_.jpg", "Kate Winslet", "English actress known for emotionally precise performances in drama and romance." },
                    { new Guid("0863f099-87d9-4590-8a19-083384c1aa91"), "https://m.media-amazon.com/images/M/MV5BNWI3YWY1NWQtNDVhMy00ZWE1LWI2MzUtOTczNTg5MTllZmNjXkEyXkFqcGc@._V1_FMjpg_UY3611_.jpg", "Miles Teller", "American actor known for youthful dramatic roles and intense performances." },
                    { new Guid("086a28bc-461c-4360-90e6-d34634bc7930"), "https://m.media-amazon.com/images/M/MV5BMTcyMTU5MzgxMF5BMl5BanBnXkFtZTYwMDI0NjI1._V1_FMjpg_UX267_.jpg", "Mads Mikkelsen", "Danish actor known for chilling villains and acclaimed dramatic performances." },
                    { new Guid("08d54a07-c4a3-4467-8c2d-2791ccc3cb86"), "https://m.media-amazon.com/images/M/MV5BMTc1NDUzMzM5MV5BMl5BanBnXkFtZTcwNzY1OTYyOQ@@._V1_FMjpg_UY2048_.jpg", "Vincent Cassel", "French actor known for intense roles in international dramas and thrillers." },
                    { new Guid("09ad1d06-e8a1-406e-890b-d744e67ffa76"), "https://m.media-amazon.com/images/M/MV5BMjAwNDU3MzcyOV5BMl5BanBnXkFtZTcwMjc0MTIxMw@@._V1_FMjpg_UX303_.jpg", "Robert De Niro", "American actor known for legendary performances in crime films and dramas." },
                    { new Guid("09b7ed63-7445-4c20-b6cf-271ddb9e4c96"), "https://m.media-amazon.com/images/M/MV5BMTY3NTk0NDI3Ml5BMl5BanBnXkFtZTgwNDA3NjY0MjE@._V1_FMjpg_UY2048_.jpg", "Joseph Gordon-Levitt", "American actor known for versatile roles in drama, comedy, and sci-fi." },
                    { new Guid("0a1a093a-54e3-454d-86f9-73523144b49d"), "https://m.media-amazon.com/images/M/MV5BNTgyNDgxMjUyOV5BMl5BanBnXkFtZTcwMDYxNzY1OQ@@._V1_FMjpg_UY2048_.jpg", "Michael Cera", "Canadian actor known for understated comic timing and indie films." },
                    { new Guid("0dc023ca-c84f-4c6b-a1c3-ed3ca625b7bd"), "https://m.media-amazon.com/images/M/MV5BMTc0MDMyMzI2OF5BMl5BanBnXkFtZTcwMzM2OTk1MQ@@._V1_FMjpg_UX267_.jpg", "Morgan Freeman", "American actor known for authoritative, warm performances across genres." },
                    { new Guid("0dd7a860-af97-4fe5-86ca-d7b6a171e506"), "https://m.media-amazon.com/images/M/MV5BMTI0MjkxOTg1Nl5BMl5BanBnXkFtZTYwNjgyODgz._V1_FMjpg_UX286_.jpg", "David Wenham", "Australian actor known for historical epics and character-driven performances." },
                    { new Guid("0f0f48ae-983b-48b1-a574-a8dc4f6ace0b"), "https://m.media-amazon.com/images/M/MV5BMTQwNzI3NjIwMV5BMl5BanBnXkFtZTcwMzA1OTIwMw@@._V1_FMjpg_UX273_.jpg", "Zach Galifianakis", "American comedian and actor known for offbeat and eccentric characters." },
                    { new Guid("0f312b1b-a6cd-4ed2-afe9-6b493205c424"), "https://m.media-amazon.com/images/M/MV5BMTg5ODk1NTc5Ml5BMl5BanBnXkFtZTYwMjAwOTI4._V1_FMjpg_UX287_.jpg", "Anthony Hopkins", "Welsh actor renowned for commanding dramatic and villainous roles." },
                    { new Guid("101916e7-e588-499f-829a-daa2793c23e8"), "https://m.media-amazon.com/images/M/MV5BMjE4NDMwMzc4Ml5BMl5BanBnXkFtZTcwMDg4Nzg4Mg@@._V1_FMjpg_UX285_.jpg", "Gerard Butler", "Scottish actor known for action films, thrillers, and dramatic roles." },
                    { new Guid("10ba4f1b-fb6f-4040-a38a-1de45d9d7605"), "https://m.media-amazon.com/images/M/MV5BMjMyOTM2OTk1Ml5BMl5BanBnXkFtZTgwMTI3MzkyNjM@._V1_FMjpg_UY2048_.jpg", "Steve Carell", "American actor and comedian known for awkward, lovable comedic characters." },
                    { new Guid("1251c5c5-0fdd-40c1-89d7-0e10b338300c"), "https://m.media-amazon.com/images/M/MV5BMTUyNDU0NzAwNl5BMl5BanBnXkFtZTcwMzQxMzIzNw@@._V1_FMjpg_UX460_.jpg", "Jonah Hill", "American actor, writer, and producer known for comedy and dramatic turns." },
                    { new Guid("12b4e8b1-deee-4931-baa3-bc4d5f3efb9b"), "https://m.media-amazon.com/images/M/MV5BMTI1OTYxNzAxOF5BMl5BanBnXkFtZTYwNTE5ODI4._V1_FMjpg_UX311_.jpg", "Tim Robbins", "American actor known for thoughtful performances in dramas and political films." },
                    { new Guid("12cf4f78-7a6f-4421-b158-9df0034694e1"), "https://m.media-amazon.com/images/M/MV5BMDliNjQxZmQtZDM2ZS00MzEwLTliMjQtYTlmYTdiYTI3OWIyXkEyXkFqcGc@._V1_FMjpg_UX960_.jpg", "Morena Baccarin", "Brazilian-American actress known for genre television and film roles." },
                    { new Guid("138ce271-e924-4e54-930e-0d8c04d0fc77"), "https://m.media-amazon.com/images/M/MV5BMjQwMzg3ODUxNF5BMl5BanBnXkFtZTgwMzc5MDcxNDM@._V1_FMjpg_UY2048_.jpg", "Bradley Whitford", "American actor known for sharp roles in drama, comedy, and political stories." },
                    { new Guid("13ec26d4-e9fc-4def-ae21-f93ab8d4d6b6"), "https://m.media-amazon.com/images/M/MV5BZDM0YWM5ZGYtODMwYS00ODYzLWFiNzMtOTNmZjc4ZmI2ZDk1XkEyXkFqcGc@._V1_FMjpg_UY2914_.jpg", "Claire Danes", "American actress known for emotional performances in drama and fantasy." },
                    { new Guid("158a9d99-77ae-46ca-8818-65ab53540d11"), "https://m.media-amazon.com/images/M/MV5BMjI0MTI0MDk2OV5BMl5BanBnXkFtZTgwODQ4MTE0NDE@._V1_FMjpg_UX564_.jpg", "Jamie Lee Curtis", "American actress known as a horror icon and comedy star." },
                    { new Guid("15aa84fd-f77a-483b-9499-7efa823c269c"), "https://m.media-amazon.com/images/M/MV5BMTU4MjYxMDc3MF5BMl5BanBnXkFtZTYwNzU3MDIz._V1_FMjpg_UX267_.jpg", "Ellen Burstyn", "American actress known for powerful dramatic performances." },
                    { new Guid("176400ce-53cf-4576-a2ed-432f78a43240"), "https://m.media-amazon.com/images/M/MV5BYjFjNGYzYjEtNGE0Ny00M2IyLTk5ZmYtODE3ZGFkMzVjYmNmXkEyXkFqcGc@._V1_FMjpg_UX214_.jpg", "Joaquin Phoenix", "American actor acclaimed for intense, transformative character work." },
                    { new Guid("179a8c49-2ace-4cc3-bef6-0d76f135c1ec"), "https://m.media-amazon.com/images/M/MV5BMjIwNTU3NDUyMl5BMl5BanBnXkFtZTgwODEwODg5NDE@._V1_FMjpg_UX2160_.jpg", "Vera Farmiga", "American actress known for psychological dramas and horror films." },
                    { new Guid("1856d962-d4cb-491a-a94e-072cfa5662bd"), "https://m.media-amazon.com/images/M/MV5BNzEyOTA4MTM5OV5BMl5BanBnXkFtZTcwNTQ4NTQzMQ@@._V1_FMjpg_UX450_.jpg", "Bonnie Bedelia", "American actress known for film and television roles across several decades." },
                    { new Guid("18638236-cb2e-4892-befc-cf0068444068"), "https://m.media-amazon.com/images/M/MV5BM2JiYzA0ZGItNmFhYy00MjIyLWEwN2QtMzRmNDUyNjNiZjBiXkEyXkFqcGc@._V1_FMjpg_UY7360_.jpg", "Mark Ruffalo", "American actor known for thoughtful performances in dramas and ensemble films." },
                    { new Guid("1a536677-8b72-42dc-b7ec-506ab25c501f"), "https://m.media-amazon.com/images/M/MV5BMTM4NzMzMTkwNV5BMl5BanBnXkFtZTcwMzU4MDg1Mw@@._V1_FMjpg_UX319_.jpg", "Tilda Swinton", "Scottish actress known for transformative art-house and blockbuster roles." },
                    { new Guid("1acc5129-33a7-4b35-b00b-f350c34c0b83"), "https://m.media-amazon.com/images/M/MV5BMTQ3ODE2NTMxMV5BMl5BanBnXkFtZTgwOTIzOTQzMjE@._V1_FMjpg_UX1038_.jpg", "Emma Watson", "English actress known for fantasy films and dramatic roles." },
                    { new Guid("1b39c2ef-208c-4e08-b668-a533d279d528"), "https://m.media-amazon.com/images/M/MV5BMTk1MTcyNTE3OV5BMl5BanBnXkFtZTcwMTA0MTMyMw@@._V1_FMjpg_UX450_.jpg", "Sigourney Weaver", "American actress known for pioneering action and science-fiction roles." },
                    { new Guid("1c76e80e-212e-49c2-bb82-d3cb7bb8a9ca"), "https://m.media-amazon.com/images/M/MV5BNWRiYjk4MTItNWMzMC00ZjE1LWFlNDItNDI2MmI4MDZlZjlkXkEyXkFqcGc@._V1_FMjpg_UY4841_.jpg", "Jaeden Martell", "American actor known for youthful dramatic and horror performances." },
                    { new Guid("1cea7dbe-d8be-44bc-bdcc-2ebfa35e8c9f"), "https://m.media-amazon.com/images/M/MV5BMjc4MTA3NDIzNF5BMl5BanBnXkFtZTcwNTIwNTU5MQ@@._V1_FMjpg_UY400_.jpg", "Martin Henderson", "New Zealand actor known for drama, romance, and suspense roles." },
                    { new Guid("1d4c8ea4-7f11-453b-8be8-e2218e767055"), "https://m.media-amazon.com/images/M/MV5BMzE4NzcyMzU3OV5BMl5BanBnXkFtZTYwOTM2NDE2._V1_FMjpg_UX287_.jpg", "Gary Sinise", "American actor known for disciplined, empathetic roles in drama and television." },
                    { new Guid("1f7c2d4c-cfb4-47ca-ba0e-575c6e5b1ae2"), "https://m.media-amazon.com/images/M/MV5BYTU0NjUyMjktNTBkNS00ZWFjLTgyZmUtZjVhMmU1YTVkOTM2XkEyXkFqcGc@._V1_FMjpg_UY3217_.jpg", "Tom Hiddleston", "English actor known for intelligent, charismatic dramatic roles." },
                    { new Guid("1fc801b0-0633-4cff-97fe-c6068014dfa4"), "https://m.media-amazon.com/images/M/MV5BMTMwNzQ1NjU1N15BMl5BanBnXkFtZTcwNjYzMTkwNA@@._V1_FMjpg_UX266_.jpg", "Barbara Hershey", "American actress known for commanding roles in drama and thriller films." },
                    { new Guid("25538521-d4f1-4ca8-ba20-1628c98b6930"), "https://m.media-amazon.com/images/M/MV5BNDQ5MDIyMjg3NV5BMl5BanBnXkFtZTgwOTU2NTE0NDM@._V1_FMjpg_UY2048_.jpg", "Rosamund Pike", "English actress known for intelligent, composed performances in thrillers and dramas." },
                    { new Guid("263f806e-5bb0-4cc5-bdc1-a6130e3a6ae7"), "https://m.media-amazon.com/images/M/MV5BMTUwMjE1MjU2N15BMl5BanBnXkFtZTcwNjk0ODY1NA@@._V1_FMjpg_UY2048_.jpg", "Justin Timberlake", "American singer and actor known for stylish supporting roles in drama and comedy." },
                    { new Guid("26d5c98a-347d-49b0-9268-2029a7f0ee98"), "https://m.media-amazon.com/images/M/MV5BY2I4MGI5ZmItZWNlNy00ZTZkLWJhMTgtMDhmYTRmNzUwNTI3XkEyXkFqcGc@._V1_FMjpg_UY2048_.jpg", "Chris Pratt", "American actor known for action-comedy leading roles." },
                    { new Guid("29843c4b-6c08-4a57-9b36-95264eba65bd"), "https://m.media-amazon.com/images/M/MV5BMTgwNjUzOTE1N15BMl5BanBnXkFtZTYwNTU4NDQ0._V1_FMjpg_UX273_.jpg", "David Morse", "American actor known for grounded performances in film and television." },
                    { new Guid("29ac4686-bfcd-49dc-8646-876522ab6472"), "https://m.media-amazon.com/images/M/MV5BMjE4NDM4ODc2OV5BMl5BanBnXkFtZTcwNzA5NjQ5MQ@@._V1_FMjpg_UX289_.jpg", "Ed Harris", "American actor known for authoritative roles in dramas, westerns, and thrillers." },
                    { new Guid("2bb629f1-e03a-4c92-b265-6ba6f3674026"), "https://m.media-amazon.com/images/M/MV5BOTIwZjBiMTQtZmM3ZS00YTI1LTk0NTYtY2UyMWM3NTMxMDJjXkEyXkFqcGc@._V1_FMjpg_UX642_.jpg", "Alicia Vikander", "Swedish actress known for precise performances in drama and sci-fi." },
                    { new Guid("2c4f6a03-d0b1-4e0e-8e5a-d824d9ffa7c7"), "https://m.media-amazon.com/images/M/MV5BODA3MDI4NDcxNV5BMl5BanBnXkFtZTYwOTgyMzY1._V1_FMjpg_UX266_.jpg", "Jeff Daniels", "American actor known for both serious dramas and comedic roles." },
                    { new Guid("2e7678ba-e51a-402a-ae90-6585b837ea90"), "https://m.media-amazon.com/images/M/MV5BOTU2MTI0NTIyNV5BMl5BanBnXkFtZTcwMTA4Nzc3OA@@._V1_FMjpg_UX384_.jpg", "Chris Hemsworth", "Australian actor known for action roles and comedic charisma." },
                    { new Guid("2f276480-e052-4120-85d6-7f5fb2a0141f"), "https://m.media-amazon.com/images/M/MV5BMTkzNzcxNzcxMF5BMl5BanBnXkFtZTgwOTM1ODUzMTE@._V1_FMjpg_UY2048_.jpg", "Patrick Wilson", "American actor known for horror, drama, and musical performances." },
                    { new Guid("2f5d38f8-9375-4e62-bde1-801bc44f2908"), "https://m.media-amazon.com/images/M/MV5BNTU1NjM4MDYzMl5BMl5BanBnXkFtZTcwMjIwMjMyMw@@._V1_FMjpg_UX448_.jpg", "Jeff Bridges", "American actor known for relaxed, commanding performances across genres." },
                    { new Guid("310706f7-2d9a-4e5a-8e2f-5214084fd26d"), "https://m.media-amazon.com/images/M/MV5BNTFjZDU5NmYtYzZlMy00YThmLTg5ZjUtYjkyZWI2OTk2Mjc1XkEyXkFqcGc@._V1_FMjpg_UY5041_.jpg", "Ben Affleck", "American actor, writer, and director known for thrillers and dramas." },
                    { new Guid("32ac45d4-37c1-4f8c-9c9c-20e9cea6a21d"), "https://m.media-amazon.com/images/M/MV5BMTc4NjAxMjQwMF5BMl5BanBnXkFtZTYwMzcxOTg0._V1_FMjpg_UX291_.jpg", "Chris Tucker", "American comedian and actor known for high-energy comedic performances." },
                    { new Guid("339a12ea-c0b1-4c15-81eb-189212eda79d"), "https://m.media-amazon.com/images/M/MV5BOTlmODE2ZjktOTM5OC00MWE1LThiNTUtZjYzNWM0MGU2ZjIyXkEyXkFqcGc@._V1_FMjpg_UY4780_.jpg", "Ivana Baquero", "Spanish actress known for fantasy and dramatic roles." },
                    { new Guid("34ed4fe5-d30b-4edc-a00f-f75f019d46a3"), "https://m.media-amazon.com/images/M/MV5BMzg2NTI5NzQ1MV5BMl5BanBnXkFtZTgwNjI1NDEwMDI@._V1_FMjpg_UY2048_.jpg", "J.K. Simmons", "American actor known for commanding, versatile performances in film and TV." },
                    { new Guid("362cae35-adc0-4ad9-8ff5-8a6603edf315"), "https://m.media-amazon.com/images/M/MV5BMTQwMjAwNzI0M15BMl5BanBnXkFtZTcwOTY1MTMyOQ@@._V1_FMjpg_UY2048_.jpg", "Jim Carrey", "Canadian-American actor famous for elastic comedy and dramatic reinvention." },
                    { new Guid("36e4bf12-895e-44a2-b635-e9e7930c0997"), "https://m.media-amazon.com/images/M/MV5BMTY4Mjg0NjIxOV5BMl5BanBnXkFtZTcwMTM2NTI3MQ@@._V1_FMjpg_UX269_.jpg", "Harrison Ford", "American actor known for iconic adventure and sci-fi roles." },
                    { new Guid("38ebb771-b41b-43c4-ae42-d5da412e04d9"), "https://m.media-amazon.com/images/M/MV5BMTg3MDYyMDE5OF5BMl5BanBnXkFtZTcwNjgyNTEzNA@@._V1_FMjpg_UX1023_.jpg", "Marlon Brando", "American actor regarded as one of cinema’s most influential performers." },
                    { new Guid("3998723a-ebb9-4e63-a96b-8575e5345e5b"), "https://m.media-amazon.com/images/M/MV5BMzIwMjIwNjg0M15BMl5BanBnXkFtZTgwOTI3MDEzMDE@._V1_FMjpg_UY2048_.jpg", "Lena Headey", "English actress known for intense roles in fantasy, drama, and action." },
                    { new Guid("3b9bf0a1-5001-4946-a64f-fbfe3a6f73a1"), "https://m.media-amazon.com/images/M/MV5BODYyM2EwNGUtY2UzOS00YmQ2LWJlNWItMGUyMjU0NmYyYTBlXkEyXkFqcGc@._V1_FMjpg_UY2403_.jpg", "Donald Pleasence", "English actor known for distinctive performances in horror and war films." },
                    { new Guid("3c328dc2-54a1-4a48-8962-6e7f903f2162"), "https://m.media-amazon.com/images/M/MV5BMTQ1MjUwMjI4M15BMl5BanBnXkFtZTcwNzc0NTg3NA@@._V1_FMjpg_UY2048_.jpg", "Paul Reiser", "American actor and comedian known for television and supporting film roles." },
                    { new Guid("3c550829-e360-4a0f-947f-b8510e01718a"), "https://m.media-amazon.com/images/M/MV5BMTQzNzIxOTYzMl5BMl5BanBnXkFtZTcwNjYxNTk1Nw@@._V1_FMjpg_UY2048_.jpg", "James McAvoy", "Scottish actor known for dramatic range in fantasy and period films." },
                    { new Guid("3dacabea-76fa-48d7-8b12-4095bacbd787"), "https://m.media-amazon.com/images/M/MV5BMjAwNzIwNTQ4Ml5BMl5BanBnXkFtZTYwMzE1MTUz._V1_FMjpg_UX288_.jpg", "Michael Caine", "English actor known for iconic performances in drama, crime, and fantasy." },
                    { new Guid("3de01bc3-0480-4a01-8593-ddfb1849ff9b"), "https://m.media-amazon.com/images/M/MV5BNGQ0ODZlNzEtODUwNy00M2QxLTlmNzUtODg5OWE4NjJkMDg4XkEyXkFqcGc@._V1_FMjpg_UY3000_.jpg", "Heather Langenkamp", "American actress known for her defining role in horror cinema." },
                    { new Guid("3fa7c993-1327-4a37-87f6-0020d90dbfea"), "https://m.media-amazon.com/images/M/MV5BMTc1MDI0MDg1NV5BMl5BanBnXkFtZTgwMDM3OTAzMTE@._V1_FMjpg_UY2048_.jpg", "Cate Blanchett", "Australian actress known for commanding performances in drama and fantasy." },
                    { new Guid("40f67ef1-8703-42e9-94af-f65e1a2ef186"), "https://m.media-amazon.com/images/M/MV5BMTU1MDM5NjczOF5BMl5BanBnXkFtZTcwOTY2MDE4OA@@._V1_FMjpg_UX1268_.jpg", "Jessica Chastain", "American actress known for intense dramatic roles and large-scale epics." },
                    { new Guid("411fdf1d-ff3a-490c-86ac-ef8252b5c0fa"), "https://m.media-amazon.com/images/M/MV5BMTkxNTI5NzM4MV5BMl5BanBnXkFtZTcwMTI3ODY3Mg@@._V1_FMjpg_UX271_.jpg", "Cameron Diaz", "American actress known for romantic comedies, action, and comedic roles." },
                    { new Guid("4123086b-dc4f-4e51-81fa-f64a6fc7f7bd"), "https://m.media-amazon.com/images/M/MV5BMTQzMzg1ODAyNl5BMl5BanBnXkFtZTYwMjAxODQ1._V1_FMjpg_UX266_.jpg", "Al Pacino", "American actor known for intense, iconic roles in crime and drama." },
                    { new Guid("43c89467-ac0e-4e79-9f8e-929848c36d6a"), "https://m.media-amazon.com/images/M/MV5BOTlhODE3NjItNTExYi00MGIzLWEzMzYtMTRlN2MwZmJlM2QxXkEyXkFqcGc@._V1_FMjpg_UX643_.jpg", "Alfie Allen", "English actor best known for playing Theon Greyjoy in the HBO series Game of Thrones (2011-2019)" },
                    { new Guid("447f0422-0955-41e1-9b47-f2b09a8a474c"), "https://m.media-amazon.com/images/M/MV5BMTk2OTY5MzcwMV5BMl5BanBnXkFtZTgwODM4MDI5MjI@._V1_FMjpg_UX750_.jpg", "Chadwick Boseman", "American actor remembered for dignified, powerful leading performances." },
                    { new Guid("44907d33-053a-47f7-ac1b-a2fddbbea5cc"), "https://m.media-amazon.com/images/M/MV5BNTE3MzQzODE3OV5BMl5BanBnXkFtZTcwMDE0ODY1NA@@._V1_FMjpg_UY2048_.jpg", "Jesse Eisenberg", "American actor known for fast-talking, intellectual dramatic roles." },
                    { new Guid("453399e4-7c51-46d3-aeae-99eb8f06fef9"), "https://m.media-amazon.com/images/M/MV5BZTI1MmRmYmMtYTZiMy00NGFkLThkMGEtNjgyYjFhMzE2NjUzXkEyXkFqcGc@._V1_FMjpg_UY3456_.jpg", "Linda Hamilton", "American actress best known for tough, resilient action roles." },
                    { new Guid("468fc8fc-00b2-4740-b025-f465bc99c283"), "https://m.media-amazon.com/images/M/MV5BMTU1MjU2MzkzNF5BMl5BanBnXkFtZTgwNDIzMjIwMjI@._V1_FMjpg_UY2048_.jpg", "Sharlto Copley", "South African actor known for dynamic performances in sci-fi and action." },
                    { new Guid("480a5aa3-2618-4777-8d6c-764b0bac7a6b"), "https://m.media-amazon.com/images/M/MV5BODczYzdlYWYtNjIwMC00ZTQ3LTkwMjUtNmNiZmE0MzllZGM5XkEyXkFqcGc@._V1_FMjpg_UX800_.jpg", "Jason Cope", "South African actor known for extensive genre and creature-performance work." },
                    { new Guid("483c83dc-0645-46ea-80a7-2f227b5f80cf"), "https://m.media-amazon.com/images/M/MV5BMTk2MDQwODEwNV5BMl5BanBnXkFtZTcwNjc4MTY0NA@@._V1_FMjpg_UY2048_.jpg", "Ed Helms", "American actor and comedian known for awkward, upbeat comedic roles." },
                    { new Guid("4b7fe159-069a-4c8f-8bd3-09ed79a4c5ae"), "https://m.media-amazon.com/images/M/MV5BMTM0NDIxMzQ5OF5BMl5BanBnXkFtZTcwNzAyNTA4Nw@@._V1_FMjpg_UY2048_.jpg", "Elijah Wood", "American actor known for fantasy, independent film, and character-driven performances." },
                    { new Guid("4f53bb1c-0f91-48bc-9876-5dfd7ab74ebb"), "https://m.media-amazon.com/images/M/MV5BMTIzMDc3NzE4NV5BMl5BanBnXkFtZTYwNjQwODc1._V1_FMjpg_UX271_.jpg", "Sergi López", "Spanish-French actor known for intense dramatic performances." },
                    { new Guid("50cafa2b-71bd-4ea8-8eb0-a5ee95eff467"), "https://m.media-amazon.com/images/M/MV5BMTI2NTY0NzA4MF5BMl5BanBnXkFtZTYwMjE1MDE0._V1_FMjpg_UX267_.jpg", "Heath Ledger", "Australian actor remembered for emotionally rich performances and iconic roles." },
                    { new Guid("50e895bc-e9e1-445b-a99c-6615bd33437a"), "https://m.media-amazon.com/images/M/MV5BYzU3NWRhMjgtNmNmMS00YjQ1LWIyYzgtYzdkYjRjNWEzM2E3XkEyXkFqcGc@._V1_FMjpg_UY5472_.jpg", "Tom Holland", "English actor known for youthful energy and blockbuster leading roles." },
                    { new Guid("51bab7d6-b37f-40b4-b787-5f6cb30af6f4"), "https://m.media-amazon.com/images/M/MV5BNzIxOTQ1NTU1OV5BMl5BanBnXkFtZTcwMTQ4MDY0Nw@@._V1_FMjpg_UY2048_.jpg", "Gwyneth Paltrow", "American actress known for dramas, romances, and character-driven films." },
                    { new Guid("539b371e-f3ec-4d09-8add-4072cd23d277"), "https://m.media-amazon.com/images/M/MV5BMTc2OTMxNDIzMF5BMl5BanBnXkFtZTcwNDU1MjA1NA@@._V1_FMjpg_UY2048_.jpg", "Helena Bonham Carter", "English actress known for eccentric, gothic, and dramatic roles." },
                    { new Guid("5429c902-48d3-4dec-beac-49f37ff0b08d"), "https://m.media-amazon.com/images/M/MV5BOWQ1ZTI1ZDgtMjhmZC00OWExLTliNWQtNzgxNTExZWIwMDJkXkEyXkFqcGc@._V1_FMjpg_UY4811_.jpg", "Bob Gunton", "American actor known for stern, commanding supporting roles." },
                    { new Guid("545d9868-b224-46c4-9b60-21271dc2adc2"), "https://m.media-amazon.com/images/M/MV5BMTUxNjQ4MjU5Ml5BMl5BanBnXkFtZTcwMTY5NzAzNw@@._V1_FMjpg_UY2048_.jpg", "Neil Patrick Harris", "American actor known for comedy, stage work, and dramatic supporting roles." },
                    { new Guid("556360a7-3f73-48c6-b971-52ff34371b93"), "https://m.media-amazon.com/images/M/MV5BMTkyNjc4MDc0OV5BMl5BanBnXkFtZTcwOTc5OTUwOQ@@._V1_FMjpg_UY2048_.jpg", "Tommy Lee Jones", "American actor known for stoic performances in dramas, thrillers, and westerns." },
                    { new Guid("57ad6e92-9f65-4871-b922-11600447149c"), "https://m.media-amazon.com/images/M/MV5BZGIwMGJlNTctMjE2Zi00YzFlLTk3MjQtMTMzNzFlOWYyNzJhXkEyXkFqcGc@._V1_FMjpg_UY3712_.jpg", "Rooney Mara", "American actress known for intense, understated dramatic performances." },
                    { new Guid("59d617f1-c06c-4dd0-8b8b-ad0fd2615135"), "https://m.media-amazon.com/images/M/MV5BZmM3ZjE2M2QtYzljOC00ZTI4LWFhNTItOWVhNTkzM2JhOTE3XkEyXkFqcGc@._V1_FMjpg_UX480_.jpg", "Ellen Page", "Canadian actress known for emotionally nuanced performances across genres." },
                    { new Guid("5b20c518-2ac0-4dbb-9e2f-db4d9f0bb879"), "https://m.media-amazon.com/images/M/MV5BMjExOTY3NzExM15BMl5BanBnXkFtZTgwOTg1OTAzMTE@._V1_FMjpg_UY2048_.jpg", "Michael B. Jordan", "American actor known for intense roles in drama and franchise films." },
                    { new Guid("5d7cdba3-e8dc-4f19-a8a3-8992aec07fae"), "https://m.media-amazon.com/images/M/MV5BMTQyMTExNTMxOF5BMl5BanBnXkFtZTcwNDg1NzkzNw@@._V1_FMjpg_UY2048_.jpg", "Russell Crowe", "New Zealand-born actor known for powerful dramatic and historical performances." },
                    { new Guid("5f3878b6-e371-4be2-afcb-10906290b75a"), "https://m.media-amazon.com/images/M/MV5BZjA3NzZiZDktZjc2My00MzY2LThhOWMtZGFjYzg4ZDI2ZWVmXkEyXkFqcGc@._V1_FMjpg_UX1080_.jpg", "Johnny Depp", "American actor known for eccentric, transformative leading roles." },
                    { new Guid("61cfb611-b7b6-4a63-8edc-7183a7a2dc35"), "https://m.media-amazon.com/images/M/MV5BMTI3NDY2ODk5OV5BMl5BanBnXkFtZTYwMjQ0NzE0._V1_FMjpg_UX340_.jpg", "Michael Clarke Duncan", "American actor known for imposing yet gentle dramatic roles." },
                    { new Guid("64ea884a-b2a5-46ae-9532-ce5d559ead97"), "https://m.media-amazon.com/images/M/MV5BMTg1MDM4MTg1NV5BMl5BanBnXkFtZTcwMTExOTcwNw@@._V1_FMjpg_UY2048_.jpg", "Michael Nyqvist", "Swedish actor known internationally for thrillers and crime dramas." },
                    { new Guid("6547e436-757f-4cb1-a179-f337b0922121"), "https://m.media-amazon.com/images/M/MV5BMmU1YWU1NmMtMjAyMi00MjFiLWFmZmUtOTc1ZjI5ODkxYmQyXkEyXkFqcGc@._V1_FMjpg_UY5122_.jpg", "Tom Cruise", "American actor and producer known for blockbuster action and dramatic roles." },
                    { new Guid("655b7c4a-7bde-4498-82b2-46288064039f"), "https://m.media-amazon.com/images/M/MV5BMjEzNDY4OTU5N15BMl5BanBnXkFtZTcwNDU0MjYwOA@@._V1_FMjpg_UX945_.jpg", "Scatman Crothers", "American actor and musician known for warm supporting performances." },
                    { new Guid("65970305-4fc7-4890-9f0b-5063affce076"), "https://m.media-amazon.com/images/M/MV5BMTk2NjE1NTk3Ml5BMl5BanBnXkFtZTcwOTAzMjg0NA@@._V1_FMjpg_UX2048_.jpg", "John Saxon", "American actor known for genre classics and tough authority figures." },
                    { new Guid("6fd39241-45d7-4435-beeb-6ef22cc912de"), "https://m.media-amazon.com/images/M/MV5BMTc4MTAyNzMzNF5BMl5BanBnXkFtZTcwMzQ5MzQzMg@@._V1_FMjpg_UX286_.jpg", "Aaron Eckhart", "American actor known for dramatic roles in thrillers and character-driven films." },
                    { new Guid("70705055-5ce6-4a88-a3ba-5e031ae9b786"), "https://m.media-amazon.com/images/M/MV5BMDVlZjIzOTktYzNmZC00MjIzLTk1YTMtMzdlOTFiNzQ3ZGY0XkEyXkFqcGc@._V1_FMjpg_UX406_.jpg", "Rebecca Ferguson", "Swedish actress known for suspenseful performances in action and drama." },
                    { new Guid("76039504-7ee7-4356-a79d-161486a5b162"), "https://m.media-amazon.com/images/M/MV5BMTYxNzMxMTMwMV5BMl5BanBnXkFtZTYwODM3MTI0._V1_FMjpg_UX267_.jpg", "Linda Blair", "American actress known for her iconic breakthrough role in horror." },
                    { new Guid("7c144da1-9cb5-498f-9f04-8d6d5418455e"), "https://m.media-amazon.com/images/M/MV5BZjM5N2U3MzQtZWU5My00YzE0LThmZTgtYjE1NDJjNmIzZmIxXkEyXkFqcGc@._V1_FMjpg_UX780_.jpg", "Zendaya", "American actress and singer known for modern drama, romance, and franchise films." },
                    { new Guid("7c412653-3c11-4b3a-8118-22a6c219f54c"), "https://m.media-amazon.com/images/M/MV5BYzUyMGE3YWItMDMxOS00NTA5LWJhZmEtNjg4N2Y3ZjI2ZGE5XkEyXkFqcGc@._V1_FMjpg_UY3553_.jpg", "David James", "South African actor known for villainous roles in action and science fiction." },
                    { new Guid("8044275d-432e-4e99-a403-bc47b7208011"), "https://m.media-amazon.com/images/M/MV5BMTc0MzU5ODQ5OF5BMl5BanBnXkFtZTYwODIwODk1._V1_FMjpg_UX282_.jpg", "Patrick Stewart", "English actor known for dignified performances in stage, sci-fi, and drama." },
                    { new Guid("82d8d010-92a5-4189-b947-d56faf569ba6"), "https://m.media-amazon.com/images/M/MV5BODUwOTc5N2MtNTVmZi00MWE0LWE0Y2QtOTAyOTEzZDg1NGFiXkEyXkFqcGc@._V1_FMjpg_UY3600_.jpg", "Rupert Grint", "English actor known for comedy and fantasy roles." },
                    { new Guid("8441360b-3bb9-4f58-86c1-02dd3f04072a"), "https://m.media-amazon.com/images/M/MV5BMjA1MjE2MTQ2MV5BMl5BanBnXkFtZTcwMjE5MDY0Nw@@._V1_FMjpg_UY2048_.jpg", "Brad Pitt", "American actor known for leading roles in dramas, thrillers, and action films." },
                    { new Guid("846cc4c2-430e-42e8-b9a8-f3369310563a"), "https://m.media-amazon.com/images/M/MV5BMTk4MDM0MDUzM15BMl5BanBnXkFtZTcwOTI4MzU1Mw@@._V1_FMjpg_UX288_.jpg", "Jackie Chan", "Hong Kong actor and martial artist known for action-comedy stunts." },
                    { new Guid("84982976-ae90-4237-9520-d6239df1458d"), "https://m.media-amazon.com/images/M/MV5BN2VmNGZjNmItOTQ2Zi00ZjVhLWI2ZGItYzNiMzQ2NjVhZTYxXkEyXkFqcGc@._V1_FMjpg_UX921_.jpg", "Lindsay Lohan", "American actress known for teen comedies and coming-of-age films." },
                    { new Guid("858afe84-3e5a-451b-bd2d-eda7f38e8467"), "https://m.media-amazon.com/images/M/MV5BMTYwNDM0NDA3M15BMl5BanBnXkFtZTcwNTkzMjQ3OA@@._V1_FMjpg_UY2048_.jpg", "Keira Knightley", "English actress known for period dramas and adventure films." },
                    { new Guid("879fffcf-e8fe-4a4a-bab5-da42fc4d1256"), "https://m.media-amazon.com/images/M/MV5BMjA5MjI0MzY2MF5BMl5BanBnXkFtZTcwMzM3ODM3OA@@._V1_FMjpg_UX720_.jpg", "Domhnall Gleeson", "Irish actor known for thoughtful performances in drama and science fiction." },
                    { new Guid("8904c86f-88c7-4575-9c5a-70d83a4a53db"), "https://m.media-amazon.com/images/M/MV5BZTVjMWI2MzYtM2FmNS00N2ZmLThlZTktMjhjOGNlOGNhM2FiXkEyXkFqcGc@._V1_FMjpg_UY6500_.jpg", "Sophia Lillis", "American actress known for coming-of-age and genre roles." },
                    { new Guid("8b3378bc-3e09-4921-9466-7bf8b3108211"), "https://m.media-amazon.com/images/M/MV5BMTk2NDc2OTE2Nl5BMl5BanBnXkFtZTcwMTc4NDcxNg@@._V1_FMjpg_UY2048_.jpg", "Christina Applegate", "American actress known for sharp comedic roles in film and television." },
                    { new Guid("8ba7acf6-a509-48fe-92c0-c8c0528569fd"), "https://m.media-amazon.com/images/M/MV5BMTcxMTQ4MzY2Nl5BMl5BanBnXkFtZTgwMzAxOTY3MjI@._V1_FMjpg_UY2048_.jpg", "Riz Ahmed", "British actor and musician known for intense performances across film and TV." },
                    { new Guid("8d806e2a-9b9e-407e-bfde-d95afc6f0c04"), "https://m.media-amazon.com/images/M/MV5BYWQyNzhiZjYtNjJlOS00MTRlLWI0YTYtZjg1YzJmNTc2YjQwXkEyXkFqcGc@._V1_FMjpg_UY8192_.jpg", "Andrew Garfield", "English-American actor known for emotional performances in dramas and franchises." },
                    { new Guid("8dcde184-4ee9-4ac3-8a01-e8827834d161"), "https://m.media-amazon.com/images/M/MV5BMTYxMjgwNzEwOF5BMl5BanBnXkFtZTcwNTQ0NzI5Ng@@._V1_QL75_UY414_CR17,0,280,414_.jpg", "Carrie-Anne Moss", "Canadian actress known for science fiction, thrillers, and television dramas." },
                    { new Guid("9186ec1d-7199-439e-b062-a103f1371d54"), "https://m.media-amazon.com/images/M/MV5BNjE4MTY1Mzk0N15BMl5BanBnXkFtZTgwOTQzNDE2MDE@._V1_FMjpg_UY2048_.jpg", "Shelley Duvall", "American actress known for vulnerable, distinctive screen presence." },
                    { new Guid("925ac384-48c7-4eac-96fd-36bf2b9f6bd4"), "https://m.media-amazon.com/images/M/MV5BNzQ0YWM1ODEtZDFkYy00MGJhLTkwZDUtMzVkZjljODU3ZTRmXkEyXkFqcGc@._V1_FMjpg_UY6000_.jpg", "Chris Evans", "American actor known for heroic roles and ensemble dramas." },
                    { new Guid("93088ce9-c00a-4ea4-9cd6-2ac02db77c7d"), "https://m.media-amazon.com/images/M/MV5BMTQ1NjkwMjA0NV5BMl5BanBnXkFtZTYwNzU2NzE2._V1_FMjpg_UX284_.jpg", "Maribel Verdú", "Spanish actress known for dramatic and fantasy films." },
                    { new Guid("950268ca-c69a-41f4-81c3-7cd61c42a9e1"), "https://m.media-amazon.com/images/M/MV5BYzVmYjIxMzgtZWU2Ny00MjAyLTk5ZWUtZDEyMTliYjczMmIxXkEyXkFqcGc@._V1_FMjpg_UX760_.jpg", "Daniel Radcliffe", "English actor best known for leading the Harry Potter film series." },
                    { new Guid("95a09f9f-98a1-4a0b-a409-6a357ceb9930"), "https://m.media-amazon.com/images/M/MV5BMTc3NTM4MzQ5MV5BMl5BanBnXkFtZTcwOTE4MDczNw@@._V1_FMjpg_UY2048_.jpg", "Gary Oldman", "English actor celebrated for transformative performances across genres." },
                    { new Guid("95ce32f0-7a46-4e31-8459-cd6ee973dba9"), "https://m.media-amazon.com/images/M/MV5BMTAyNzAyMzA1ODZeQTJeQWpwZ15BbWU4MDAzNDQxNjkx._V1_FMjpg_UX607_.jpg", "Lili Taylor", "American actress known for nuanced independent and genre roles." },
                    { new Guid("96c08023-9ed3-46dd-a016-facb34a4bef9"), "https://m.media-amazon.com/images/M/MV5BMjE0MjAwOTMzMF5BMl5BanBnXkFtZTcwMDg1MjEyNw@@._V1_FMjpg_UY2048_.jpg", "Martin Freeman", "English actor known for intelligent comic and dramatic roles." },
                    { new Guid("990f0803-c80f-40cf-9d02-910e3d46a962"), "https://m.media-amazon.com/images/M/MV5BODQyNTQyNzY4MV5BMl5BanBnXkFtZTcwODg5MDA3MQ@@._V1_FMjpg_UX334_.jpg", "Mila Kunis", "American actress known for comedy, drama, and psychological thrillers." },
                    { new Guid("9af1c7b4-2511-48e0-8868-fc0dab590d71"), "https://m.media-amazon.com/images/M/MV5BMTY5ODcxMDU4NV5BMl5BanBnXkFtZTcwMjAzNjQyNQ@@._V1_FMjpg_UY2048_.jpg", "Rachel McAdams", "Canadian actress known for charismatic performances in dramas and comedies." },
                    { new Guid("9af80152-7958-47f9-8f8a-b1394b62bc12"), "https://m.media-amazon.com/images/M/MV5BMTY1NTc4NTYzMF5BMl5BanBnXkFtZTcwNDIwOTY1NA@@._V1_FMjpg_UY2048_.jpg", "Javier Bardem", "Spanish actor known for powerful, menacing, and dramatic roles." },
                    { new Guid("9c39c7a7-3897-494b-a8b5-970dd50d88b6"), "https://m.media-amazon.com/images/M/MV5BMjIyMzc1Njk5N15BMl5BanBnXkFtZTgwMjk2MDkyNzM@._V1_FMjpg_UY2048_.jpg", "Rene Russo", "American actress known for thrillers, dramas, and sharp character roles." },
                    { new Guid("9d666c80-52f7-4e34-8871-245c0911979e"), "https://m.media-amazon.com/images/M/MV5BMTI5NzA2NTE0NF5BMl5BanBnXkFtZTcwNzAxMTUxMw@@._V1_FMjpg_UX309_.jpg", "Billy Zane", "American actor known for villainous and charismatic supporting roles." },
                    { new Guid("9ff68d83-fc39-4081-ae3f-06ef755711d3"), "https://m.media-amazon.com/images/M/MV5BMTQ1MzYyMjQ0Nl5BMl5BanBnXkFtZTcwMTA0ODkyMg@@._V1_FMjpg_UX266_.jpg", "Josh Brolin", "American actor known for rugged performances in crime, western, and superhero films." },
                    { new Guid("a14ff11b-23f0-402f-ad77-15bdf9eb5a8d"), "https://m.media-amazon.com/images/M/MV5BMTYwNjQ5MTI1NF5BMl5BanBnXkFtZTcwMzU5MTI2Mw@@._V1_FMjpg_UX312_.jpg", "Edward Norton", "American actor known for cerebral, intense dramatic performances." },
                    { new Guid("a1c457e5-d6b5-4fce-81a1-e570ebca481a"), "https://m.media-amazon.com/images/M/MV5BMTMxMDIzMDEzNF5BMl5BanBnXkFtZTcwODcxMjE2Mg@@._V1_FMjpg_UX276_.jpg", "Will Ferrell", "American comedian and actor known for broad, improvisational comedy." },
                    { new Guid("a2a8ed1f-aa12-411b-a221-2d2cdd7d5f2e"), "https://m.media-amazon.com/images/M/MV5BMTUwNTc4MTg4Ml5BMl5BanBnXkFtZTcwNDY2MjkxOA@@._V1_FMjpg_UY1850_.jpg", "Alan Rickman", "English actor celebrated for sophisticated villains and commanding dramatic roles." },
                    { new Guid("a41a0cad-77db-47cc-a5a0-0d57342a9b65"), "https://m.media-amazon.com/images/M/MV5BNzY3Mjk5MTMyMl5BMl5BanBnXkFtZTYwMjUxMTc1._V1_FMjpg_UX276_.jpg", "Tom Skerritt", "American actor known for rugged leading roles in film and television." },
                    { new Guid("a5381bf5-482b-4f12-9d17-d10e8fcb6fc1"), "https://m.media-amazon.com/images/M/MV5BMjI0MTg3MzI0M15BMl5BanBnXkFtZTcwMzQyODU2Mw@@._V1_FMjpg_UX297_.jpg", "Leonardo DiCaprio", "American actor known for ambitious roles in major dramas and thrillers." },
                    { new Guid("a5f19f18-702b-49cb-8e8a-634045a81baa"), "https://m.media-amazon.com/images/M/MV5BMTQzMDI3NTg2OV5BMl5BanBnXkFtZTcwNTgwMzg5Mg@@._V1_FMjpg_UX303_.jpg", "Forest Whitaker", "American actor known for commanding performances across genres." },
                    { new Guid("a7c020f2-1864-4e0a-98a5-4d3b03f6eee7"), "https://m.media-amazon.com/images/M/MV5BMDFkMWQ5ZDItNGUzNS00YzI4LWIyOTctMDk0Mjc3MGQyZTYxXkEyXkFqcGc@._V1_FMjpg_UY2519_.jpg", "Zoe Saldaña", "American actress known for major science fiction and action franchises." },
                    { new Guid("a8360aca-2aa9-49da-925b-af9deaa40978"), "https://m.media-amazon.com/images/M/MV5BNDg5OTE4ZWEtZjk1ZC00YmE5LTljZGQtYWNjZGQ0ZTI2YmJiXkEyXkFqcGc@._V1_FMjpg_UX770_.jpg", "Carrie Henn", "American former child actress known for her role in Aliens." },
                    { new Guid("a9f10213-5b0f-42cb-b282-0daa96bb1519"), "https://m.media-amazon.com/images/M/MV5BZDQ2MTUzMTktYTY0My00ODRlLTg0MWQtMDQwYzY4ZTQxNGViXkEyXkFqcGc@._V1_FMjpg_UY5253_.jpg", "Ed Skrein", "English actor known for villainous and action-oriented performances." },
                    { new Guid("ad15e2ca-4491-413c-a95b-8b2cc8935c4c"), "https://m.media-amazon.com/images/M/MV5BMTQ2MjMwNDA3Nl5BMl5BanBnXkFtZTcwMTA2NDY3NQ@@._V1_FMjpg_UY2048_.jpg", "Tom Hanks", "American actor known for warm, versatile performances in dramas and comedies." },
                    { new Guid("aec03985-5285-415c-b7c2-1245a6751576"), "https://m.media-amazon.com/images/M/MV5BMTI3NTcwNDcxMF5BMl5BanBnXkFtZTcwMTI3Mjc4Mg@@._V1_FMjpg_UX297_.jpg", "Daniel Stern", "American actor known for comedic film roles and memorable character parts." },
                    { new Guid("af0ea72b-6f8f-4db0-afa7-2ea8c7859c30"), "https://m.media-amazon.com/images/M/MV5BZDE2YjY4ODUtZjVmMy00ZmE2LTgwZjgtMWJiZGI0NWY3ODAzXkEyXkFqcGc@._V1_FMjpg_UY4500_.jpg", "Nicholas Hoult", "English actor recognized for roles in period dramas, action films, and dark comedies." },
                    { new Guid("afaa9921-7f23-482b-b344-19e43274db30"), "https://m.media-amazon.com/images/M/MV5BNjQ2NzgzNTM0N15BMl5BanBnXkFtZTgwMzY0MDkyMzI@._V1_FMjpg_UY2048_.jpg", "David Dorfman", "American actor known for intense child performances in thrillers." },
                    { new Guid("b30648a8-3bfe-43be-bc09-65caf669fb09"), "https://m.media-amazon.com/images/M/MV5BNGMwYmU3MTAtYjcyOC00NGMzLTgzYzItMTc4YzQwNzNhYjRmXkEyXkFqcGc@._V1_FMjpg_UY2723_.jpg", "Jennifer Connelly", "American actress known for emotionally rich performances in drama and fantasy." },
                    { new Guid("b32c87ff-b412-42d3-bbc1-521841443d40"), "https://m.media-amazon.com/images/M/MV5BNjA0MTU2NDY3MF5BMl5BanBnXkFtZTgwNDU4ODkzMzE@._V1_FMjpg_UY2048_.jpg", "Jake Gyllenhaal", "American actor known for intense and versatile dramatic performances." },
                    { new Guid("b391372d-3bfd-48e4-be60-c343cc4b4f3f"), "https://m.media-amazon.com/images/M/MV5BNDExMzIzNjk3Nl5BMl5BanBnXkFtZTcwOTE4NDU5OA@@._V1_FMjpg_UY2048_.jpg", "Hugh Jackman", "Australian actor known for musicals, dramas, and action franchises." },
                    { new Guid("b479a3b8-5eba-43f0-a77c-797fc760ab1f"), "https://m.media-amazon.com/images/M/MV5BMTQzMjkwNTQ2OF5BMl5BanBnXkFtZTgwNTQ4MTQ4MTE@._V1_FMjpg_UY2048_.jpg", "Ryan Gosling", "Canadian actor known for understated performances in drama, crime, and science fiction." },
                    { new Guid("b6564219-9a09-4767-b494-e9fd622084b0"), "https://m.media-amazon.com/images/M/MV5BMTI3MDQzOTMwN15BMl5BanBnXkFtZTYwMDgyMjM1._V1_FMjpg_UX275_.jpg", "Max von Sydow", "Swedish actor known for towering performances in international cinema." },
                    { new Guid("b6a14c4f-815e-4be4-b6b3-b69717718c8d"), "https://m.media-amazon.com/images/M/MV5BOWI1M2MxM2YtMDdiNy00NTAwLWE2YzctMmU0MDlmNDUwYTIzXkEyXkFqcGc@._V1_FMjpg_UY3500_.jpg", "Dafne Keen", "British-Spanish actress known for fierce breakout performances in action drama." },
                    { new Guid("b96f5e3e-e5c2-4005-93ba-14a6db7078b9"), "https://m.media-amazon.com/images/M/MV5BMjEzMjczOTQ1NF5BMl5BanBnXkFtZTcwMzI2NzYyMQ@@._V1_FMjpg_UX300_.jpg", "Sean Astin", "American actor known for heartfelt performances in adventure and family films." },
                    { new Guid("ba291cbf-a1f6-4a18-bfa8-fb2a3c299e6f"), "https://m.media-amazon.com/images/M/MV5BMTU0NTc4MzEyOV5BMl5BanBnXkFtZTcwODY0ODkzMQ@@._V1_FMjpg_UX280_.jpg", "Robin Wright", "American actress known for emotionally grounded performances in film and television." },
                    { new Guid("baf8a9c9-d344-4e6f-b802-a85dad91ffb9"), "https://m.media-amazon.com/images/M/MV5BMjIzMjY1NTA4OF5BMl5BanBnXkFtZTcwNjk3MDYwOQ@@._V1_FMjpg_UY2048_.jpg", "Naomi Watts", "British-Australian actress known for psychological dramas and thrillers." },
                    { new Guid("bb729c83-9964-434b-97b7-66c7665aa3da"), "https://m.media-amazon.com/images/M/MV5BNzA5MDEyMTY3Nl5BMl5BanBnXkFtZTgwODQ0MjcxMDE@._V1_FMjpg_UY2048_.jpg", "Chiwetel Ejiofor", "English actor known for dignified, layered dramatic performances." },
                    { new Guid("bbf4da5f-54e3-4659-b179-978e5f6ab285"), "https://m.media-amazon.com/images/M/MV5BMjE0MDkzMDQwOF5BMl5BanBnXkFtZTgwOTE1Mjg1MzE@._V1_FMjpg_UY2048_.jpg", "Benedict Cumberbatch", "English actor known for cerebral performances in drama and fantasy." },
                    { new Guid("bc2dd711-8eac-439d-9353-dd355849ed8e"), "https://m.media-amazon.com/images/M/MV5BNzQ4OTQwMjItMWQ3YS00ODE5LWEyMjQtMWU1NjJlZmIwMDA4XkEyXkFqcGc@._V1_FMjpg_UX1040_.jpg", "Robert Englund", "American actor best known for iconic horror villain roles." },
                    { new Guid("bc65dca2-6946-4eeb-841d-add7c0fd0376"), "https://m.media-amazon.com/images/M/MV5BMTQ3ODEyNjA4Nl5BMl5BanBnXkFtZTgwMTE4ODMyMjE@._V1_FMjpg_UY2048_.jpg", "Tom Hardy", "English actor known for intense performances in action, crime, and dramatic roles." },
                    { new Guid("bd607b66-67f7-4fa5-8798-56fecc7d83e8"), "https://m.media-amazon.com/images/M/MV5BNjk1MjIxNjUxNF5BMl5BanBnXkFtZTcwODk2NzM4Mg@@._V1_FMjpg_UX279_.jpg", "Jennifer Aniston", "American actress known for television, romantic comedies, and light dramas." },
                    { new Guid("bdb9ef82-f830-4d22-96ea-7128d9fd92b7"), "https://m.media-amazon.com/images/M/MV5BMTM0NzYzNDgxMl5BMl5BanBnXkFtZTcwMDg2MTMyMw@@._V1_FMjpg_UX447_.jpg", "Matt Damon", "American actor known for intelligent leading roles in drama and action." },
                    { new Guid("be6e3a70-0dd5-4da8-8534-4a208c09a614"), "https://m.media-amazon.com/images/M/MV5BMTQyNjUzMDk5N15BMl5BanBnXkFtZTcwNzk0Nzk5Mw@@._V1_FMjpg_UX295_.jpg", "Christopher Mintz-Plasse", "American actor known for comedic supporting roles in youth-oriented films." },
                    { new Guid("bec8cce9-b5a4-4a5d-8a39-ebac11c6448e"), "https://m.media-amazon.com/images/M/MV5BZjM2ZTEzZGQtMzA2Ni00MWQ3LTg1ZmMtMDM1MjgzOTU3YmQ5XkEyXkFqcGc@._V1_FMjpg_UY3360_.jpg", "Alex Wolff", "American actor and musician known for anxious, layered dramatic roles." },
                    { new Guid("bf824b1f-8c4d-4be3-9566-dee5b7e512b0"), "https://m.media-amazon.com/images/M/MV5BN2JjYThiNTQtZmUwYy00MDliLWE4NmQtNjc0ZDNlMzJkNTZkXkEyXkFqcGc@._V1_FMjpg_UX2160_.jpg", "Lauren Holly", "American-Canadian actress known for film, television, and romantic comedies." },
                    { new Guid("bfad936e-bf67-4b44-8a27-88606204e79e"), "https://m.media-amazon.com/images/M/MV5BZjYyZTc3MzEtZTk0OC00NWNlLWJmOTMtYjFmOGY1YjZlNjI5XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", "Dave Bautista", "American actor and former wrestler known for powerful comedic-action roles." },
                    { new Guid("bfc71005-46f5-4f0e-a05d-eb99293367d5"), "https://m.media-amazon.com/images/M/MV5BMTI1MzgxODkyMl5BMl5BanBnXkFtZTcwNTc1NDIzMQ@@._V1_FMjpg_UX450_.jpg", "Edward Furlong", "American actor known for breakout roles in 1990s dramas and action films." },
                    { new Guid("c3891de0-0cda-41bc-a2ae-e957df3d0f1a"), "https://m.media-amazon.com/images/M/MV5BMTM1NTgyMTAyOV5BMl5BanBnXkFtZTcwMTE4MjQwNA@@._V1_FMjpg_UX284_.jpg", "John Hurt", "English actor known for memorable performances in historical, horror, and sci-fi films." },
                    { new Guid("c55c41c7-9a4d-40d2-b2fc-57eb139bf902"), "https://m.media-amazon.com/images/M/MV5BODBkMzQwZmUtN2QxNS00YmExLThhNTYtMzIzNTA4NDBjYzliXkEyXkFqcGc@._V1_FMjpg_UX605_.jpg", "Michael Biehn", "American actor known for action, sci-fi, and military roles." },
                    { new Guid("c7483292-2173-429e-bf47-be27c5dc820b"), "https://m.media-amazon.com/images/M/MV5BMTQ0MDA2ODE2Ml5BMl5BanBnXkFtZTcwMjI0Nzc3Nw@@._V1_FMjpg_UY2048_.jpg", "Eva Green", "French actress recognized for mysterious, dramatic, and fantasy roles." },
                    { new Guid("c897ed9b-a2ac-4e31-8fa4-8c26cc33c652"), "https://m.media-amazon.com/images/M/MV5BMjA0MjMzMTE5OF5BMl5BanBnXkFtZTcwMzQ2ODE3Mw@@._V1_FMjpg_UX340_.jpg", "Bruce Willis", "American actor famous for action roles and wisecracking screen presence." },
                    { new Guid("c9ee97ea-de38-4ce6-add4-ebc54fd7d92a"), "https://m.media-amazon.com/images/M/MV5BMTg2NTk2MTgxMV5BMl5BanBnXkFtZTgwNjcxMjAzMTI@._V1_FMjpg_UY2048_.jpg", "Amy Adams", "American actress known for emotionally intelligent performances in drama and sci-fi." },
                    { new Guid("ca837102-6e0b-4bc6-a39c-d35bbc3dfa80"), "https://m.media-amazon.com/images/M/MV5BMjA0Mzg5MTU3MV5BMl5BanBnXkFtZTgwOTUxMTQ5NzE@._V1_FMjpg_UX1178_.jpg", "Charlie Cox", "English actor known for fantasy, action, and television drama." },
                    { new Guid("cac1fee0-fd3a-47f8-b629-cb9b65d68b2c"), "https://m.media-amazon.com/images/M/MV5BNzA0MWI3ZDgtMDVkZS00NTVhLTkwMzQtNmNlODk5MDYzMzFmXkEyXkFqcGc@._V1_FMjpg_UY3000_.jpg", "Anne Hathaway", "American actress known for elegant performances in drama, comedy, and musicals." },
                    { new Guid("cda5b584-c19f-48e5-9e4b-787bbbd441ff"), "https://m.media-amazon.com/images/M/MV5BMmMyNDcwMDgtMmIxNC00NTcyLWIwMmItNDQzNmJjNmVhYjhhXkEyXkFqcGc@._V1_FMjpg_UY4774_.jpg", "Ian McShane", "English actor known for charismatic performances in crime, fantasy, and drama." },
                    { new Guid("ceaeb56b-d490-44c9-961c-06e8af100ba6"), "https://m.media-amazon.com/images/M/MV5BNzc2NDViYTctNmNhYy00ZTU0LTk5ODMtMzIxYjBlZTQ1MmFlXkEyXkFqcGc@._V1_FMjpg_UY1800_.jpg", "Connie Nielsen", "Danish actress known for historical epics, dramas, and genre films." },
                    { new Guid("cee50ddf-38c4-40fb-91a3-02bfc7bee4aa"), "https://m.media-amazon.com/images/M/MV5BNWFmNmI2NmYtNDUyYi00MDZhLTk0ZmEtODY0MmM5NGQxMWEwXkEyXkFqcGc@._V1_FMjpg_UX819_.jpg", "Henry Cavill", "British actor known for action franchises and heroic screen roles." },
                    { new Guid("cf615463-d189-4221-b69d-373d9ecbe762"), "https://m.media-amazon.com/images/M/MV5BMTk5Mzc4ODU0Ml5BMl5BanBnXkFtZTcwNjU1NTI0Mw@@._V1_FMjpg_UX300_.jpg", "Charlize Theron", "Academy Award-winning actress known for action films and dramatic performances." },
                    { new Guid("cf61c4ca-a860-4e52-848a-4014f336afc9"), "https://m.media-amazon.com/images/M/MV5BMTQ3OTY0ODk0M15BMl5BanBnXkFtZTYwNzE4Njc4._V1_FMjpg_UX289_.jpg", "Jack Nicholson", "American actor known for explosive, charismatic dramatic performances." },
                    { new Guid("cfde46c5-342f-4560-85d2-493f082e0a01"), "https://m.media-amazon.com/images/M/MV5BMTI5NjkyNDQ3NV5BMl5BanBnXkFtZTcwNjY5NTQ0Mw@@._V1_FMjpg_UX267_.jpg", "James Caan", "American actor known for forceful roles in crime films and dramas." },
                    { new Guid("d1bdcd3f-a8be-4044-96b4-26a0745585e9"), "https://m.media-amazon.com/images/M/MV5BMTkxMzk4MjQ4MF5BMl5BanBnXkFtZTcwMzExODQxOA@@._V1_FMjpg_UY2048_.jpg", "Christian Bale", "English actor known for transformative performances in dramas and blockbusters." },
                    { new Guid("d1c69566-30fd-47b2-9128-b7aadd4722a1"), "https://m.media-amazon.com/images/M/MV5BMTM3MjgyOTQwNF5BMl5BanBnXkFtZTcwMDczMzEwNA@@._V1_FMjpg_UX274_.jpg", "Jodie Foster", "American actress known for intelligent, intense performances." },
                    { new Guid("d1fb6849-f352-4e51-a01c-e98b0f67fc40"), "https://m.media-amazon.com/images/M/MV5BNDQzOTg4NzA2Nl5BMl5BanBnXkFtZTcwMzkwNjkxMg@@._V1_FMjpg_UX269_.jpg", "Viggo Mortensen", "American actor known for intense dramatic roles and historical epics." },
                    { new Guid("d246a339-8c96-4ee4-9377-c6110d1ebaef"), "https://m.media-amazon.com/images/M/MV5BNDEzOTdhNDUtY2EyMy00YTNmLWE5MjItZmRjMmQzYTRlMGRkXkEyXkFqcGc@._V1_FMjpg_UY2700_.jpg", "Keanu Reeves", "Canadian actor known for action franchises and understated leading roles." },
                    { new Guid("d31a1794-c533-4a9a-85a9-d90e3390c8dd"), "https://m.media-amazon.com/images/M/MV5BMTk1OTI5OTc0Nl5BMl5BanBnXkFtZTcwNjc5NDMwNA@@._V1_FMjpg_UX305_.jpg", "Mary Steenburgen", "American actress known for warm, versatile performances in film and TV." },
                    { new Guid("d70a393d-94ed-424f-ad8f-b0a041617c52"), "https://m.media-amazon.com/images/M/MV5BMzc3MTcxNDYxNV5BMl5BanBnXkFtZTcwOTI3NjE1Mw@@._V1_FMjpg_UY2048_.jpg", "Joe Pesci", "American actor known for intense crime roles and sharp comedic turns." },
                    { new Guid("d85eed69-92c7-4bcb-b978-9c2179a19f6c"), "https://m.media-amazon.com/images/M/MV5BMTI3MDc4NzUyMV5BMl5BanBnXkFtZTcwMTQyMTc5MQ@@._V1_FMjpg_UX318_.jpg", "Arnold Schwarzenegger", "Austrian-American actor and former bodybuilder known for action cinema." },
                    { new Guid("d875ff93-4c8d-4470-9c2e-66209c6d63f2"), "https://m.media-amazon.com/images/M/MV5BNzg1MTUyNDYxOF5BMl5BanBnXkFtZTgwNTQ4MTE2MjE@._V1_FMjpg_UY2048_.jpg", "Robert Downey Jr.", "American actor known for charismatic performances in drama, comedy, and superhero films." },
                    { new Guid("d9963534-1f06-4a69-bf13-8e735e7c9e9f"), "https://m.media-amazon.com/images/M/MV5BMjA4MzAyOTc5Ml5BMl5BanBnXkFtZTcwOTQ5NzEzMg@@._V1_FMjpg_UX303_.jpg", "Clive Owen", "English actor known for tough, intelligent roles in thrillers and dramas." },
                    { new Guid("dae9df12-f329-45e4-b256-a7e9646e838d"), "https://m.media-amazon.com/images/M/MV5BZDAxOWQ0NmMtNTIzNS00YTdkLWI4MzAtZDM3ZDdmYTNlMjZmXkEyXkFqcGc@._V1_FMjpg_UX2160_.jpg", "Ana de Armas", "Cuban-Spanish actress known for emotionally layered performances." },
                    { new Guid("dc2957ed-c6dc-40c6-8dcb-8e93bdd8ba03"), "https://m.media-amazon.com/images/M/MV5BMTUzNjI0Njc5NF5BMl5BanBnXkFtZTYwOTM2MjYz._V1_FMjpg_UX266_.jpg", "Michelle Pfeiffer", "American actress known for glamorous and villainous roles across genres." },
                    { new Guid("dc4a4b36-d647-43f9-b215-1a6024cc712f"), "https://m.media-amazon.com/images/M/MV5BMDdlNjNkZTAtNWQ0Ny00ZDdiLWJlM2EtYzYxMjMyY2U2MjgxXkEyXkFqcGc@._V1_FMjpg_UX904_.jpg", "Zazie Beetz", "German-American actress known for energetic roles in drama, comedy, and genre films." },
                    { new Guid("de41865b-5b44-43f7-9275-495898638232"), "https://m.media-amazon.com/images/M/MV5BOTU2Njg2NzM4M15BMl5BanBnXkFtZTgwNjYwNjQwMTI@._V1_FMjpg_UX595_.jpg", "Ben Kingsley", "English actor known for authoritative, versatile performances." },
                    { new Guid("dfe14619-506f-4f09-9a8e-8bf0fdaa4e83"), "https://m.media-amazon.com/images/M/MV5BMTM3OTUwMDYwNl5BMl5BanBnXkFtZTcwNTUyNzc3Nw@@._V1_FMjpg_UY2048_.jpg", "Scarlett Johansson", "American actress known for action, drama, and emotionally complex roles." },
                    { new Guid("e0fb708c-3052-473c-9f03-29f855010c16"), "https://m.media-amazon.com/images/M/MV5BM2IwNWZlYTQtYzYzMi00Mjg0LThmNTctODkzY2IyNGEzYTAzXkEyXkFqcGc@._V1_FMjpg_UY3600_.jpg", "Allison Williams", "American actress known for polished performances in TV and film." },
                    { new Guid("e175c472-5291-47de-832d-003b3aa6527a"), "https://m.media-amazon.com/images/M/MV5BMzRiNDhiMDQtYWZkMS00ZjU5LTg5NzUtOTc4NzE2Yzc0ZWUwXkEyXkFqcGc@._V1_FMjpg_UY3000_.jpg", "Ryan Reynolds", "Canadian actor known for fast-talking comedy and action roles." },
                    { new Guid("e1d47d6f-e0e3-4214-b4f7-21b37d6db88d"), "https://m.media-amazon.com/images/M/MV5BMTc5MTMyMzUwM15BMl5BanBnXkFtZTgwMTgwMjExNzM@._V1_FMjpg_UY2048_.jpg", "John C. Reilly", "American actor known for dramatic range and distinctive comedic performances." },
                    { new Guid("e2100a6d-cc7d-47c9-9927-72082d1b3843"), "https://m.media-amazon.com/images/M/MV5BMjE1MDkxMjQ3NV5BMl5BanBnXkFtZTcwMzQ3Mjc4MQ@@._V1_FMjpg_UX291_.jpg", "Orlando Bloom", "English actor known for fantasy and historical adventure films." },
                    { new Guid("e337f1ec-b22c-4ddf-8b5e-bd5afa946129"), "https://m.media-amazon.com/images/M/MV5BZDhhOWZhMDctNTQ0Yy00Zjc0LWIwZTgtZTY0ZmI0Nzg4ZDQ4XkEyXkFqcGc@._V1_FMjpg_UY2434_.jpg", "Tzi Ma", "Hong Kong-American actor known for supporting roles in film and television." },
                    { new Guid("e4a264bc-0a02-4720-917c-fca59bb573ff"), "https://m.media-amazon.com/images/M/MV5BNzgzMTk3Nzk0N15BMl5BanBnXkFtZTgwMTc3NTA4NTM@._V1_FMjpg_UY2048_.jpg", "Nick Castle", "American actor, writer, and director remembered for an iconic horror role." },
                    { new Guid("e52850d9-f3a4-4d46-a265-3667403ac2e9"), "https://m.media-amazon.com/images/M/MV5BMTc0MDA2Njc0OF5BMl5BanBnXkFtZTcwNzc3NDU3Mw@@._V1_FMjpg_UX289_.jpg", "Rose Byrne", "Australian actress known for smart performances in comedy, drama, and horror." },
                    { new Guid("ea2f8e0d-eb55-4452-90a1-f810474cbe7f"), "https://m.media-amazon.com/images/M/MV5BMTQ2ODE2NDQ5OF5BMl5BanBnXkFtZTcwOTU3OTM1OQ@@._V1_FMjpg_UY2048_.jpg", "Oscar Isaac", "Guatemalan-American actor known for charismatic roles in drama and science fiction." },
                    { new Guid("eaf447ef-beea-4eaa-a94c-00acd311ef42"), "https://m.media-amazon.com/images/M/MV5BZWY3YTE1MGQtOTI0Ni00YmRmLWIyZGUtOTYxNWFlNmQxMWZkXkEyXkFqcGc@._V1_FMjpg_UY4746_.jpg", "Milly Shapiro", "American actress known for eerie, memorable genre performances." },
                    { new Guid("ed9b74af-8587-4aff-abd4-8957e4eb1ca7"), "https://m.media-amazon.com/images/M/MV5BOTk1MzgzOTg5OV5BMl5BanBnXkFtZTcwNDQ4NjMxOA@@._V1_FMjpg_UY2048_.jpg", "Daniel Kaluuya", "English actor known for intense, thoughtful performances in drama and horror." },
                    { new Guid("ef1f2981-782a-40c7-b0dc-5e6a85bb7055"), "https://m.media-amazon.com/images/M/MV5BMTc2Nzc4NzkyNF5BMl5BanBnXkFtZTcwMjE0ODQyOA@@._V1_FMjpg_UY2048_.jpg", "Peter Riegert", "American actor known for character roles in comedies and dramas." },
                    { new Guid("f03b85c5-d584-4d0b-8d38-d7356f469375"), "https://m.media-amazon.com/images/M/MV5BMTQ2MjgyNjk3MV5BMl5BanBnXkFtZTcwNTA3NTY5Mg@@._V1_FMjpg_UX295_.jpg", "Ian McKellen", "English actor renowned for stage work and fantasy epics." },
                    { new Guid("f0c4a679-e5fd-4329-811c-0735cff97711"), "https://m.media-amazon.com/images/M/MV5BMTM5NDI1MjE2Ml5BMl5BanBnXkFtZTgwNDE0Nzk0MDE@._V1_FMjpg_UX596_.jpg", "Julianne Moore", "American actress known for emotionally rich performances across genres." },
                    { new Guid("f2dfcabe-52e1-4e25-84f2-054cc9f9a772"), "https://m.media-amazon.com/images/M/MV5BNjk1M2RmODAtMjE0Ny00N2U0LWIwNWYtZTAxMDFiMzk1MjU5XkEyXkFqcGc@._V1_FMjpg_UY4000_.jpg", "Natalie Portman", "Israeli-American actress known for dramatic, psychological, and sci-fi roles." },
                    { new Guid("f3b65829-46e4-4143-b39b-86136de26b7f"), "https://m.media-amazon.com/images/M/MV5BYTM0ZDcxNzctMzIwNi00NjliLTg5YzEtZDc4MDk0MDFiNzA4XkEyXkFqcGc@._V1_FMjpg_UX1168_.jpg", "Amanda Seyfried", "American actress known for musicals, dramas, and comedic roles." },
                    { new Guid("f3d34bfd-85e1-4dec-bc22-5f4eca6c9fc2"), "https://m.media-amazon.com/images/M/MV5BMjMwMzE1OTc0OF5BMl5BanBnXkFtZTcwMDU2NTg0Nw@@._V1_FMjpg_UY2048_.jpg", "Paul Dano", "American actor known for nuanced roles in indie films and major dramas." },
                    { new Guid("f42cbe69-d1a1-45bd-9a93-8aaa606744ca"), "https://m.media-amazon.com/images/M/MV5BMmNhMDQ1YjktYTg1Ny00Mjg0LWFmZTgtMmE0OTkxYmQzYzVlXkEyXkFqcGc@._V1_FMjpg_UX2160_.jpg", "Bill Skarsgård", "Swedish actor known for unsettling performances in horror and drama." },
                    { new Guid("f5faf27e-6f57-4035-a94e-1055cd927ed1"), "https://m.media-amazon.com/images/M/MV5BOGU1NDhiOTAtMTEyOC00ZDdkLThjNDgtMjUzZjdiN2FlMzcyXkEyXkFqcGc@._V1_FMjpg_UX1212_.jpg", "Richard Armitage", "English actor known for period dramas and fantasy adventures." },
                    { new Guid("f80c0da1-8be6-4a46-a578-edfce3af270d"), "https://m.media-amazon.com/images/M/MV5BMTc0NjczNDc1MV5BMl5BanBnXkFtZTYwMDU0Mjg1._V1_FMjpg_UX267_.jpg", "Laurence Fishburne", "American actor known for authoritative performances in film, TV, and theater." },
                    { new Guid("f8124011-adb0-4454-9da7-91f0e182fa33"), "https://m.media-amazon.com/images/M/MV5BMTU5MzQ5MDY3NF5BMl5BanBnXkFtZTcwNzMxOTU5Ng@@._V1_FMjpg_UY2048_.jpg", "Christopher Plummer", "Canadian actor celebrated for distinguished stage and screen performances." },
                    { new Guid("f9e3238a-97a1-4718-ab92-31d5236547b3"), "https://m.media-amazon.com/images/M/MV5BY2YwYjg4NjItZGFjNC00NzgzLWJhMTktYTZmODlmM2Y4ODJjXkEyXkFqcGc@._V1_FMjpg_UY5000_.jpg", "Bradley Cooper", "American actor known for comedies, dramas, and award-nominated performances." },
                    { new Guid("fcece400-14b5-481a-b5d7-fe67bf28f913"), "https://m.media-amazon.com/images/M/MV5BMTU3NzAwMzE1OF5BMl5BanBnXkFtZTYwMjkzOTY0._V1_FMjpg_UX303_.jpg", "Scott Glenn", "American actor known for rugged roles in thrillers, dramas, and westerns." },
                    { new Guid("fd960aa9-8876-4dff-9d99-94c1c3738c04"), "https://m.media-amazon.com/images/M/MV5BODYzOTE3ODc1Ml5BMl5BanBnXkFtZTgwODYwMjE4NTM@._V1_FMjpg_UX503_.jpg", "Toni Collette", "Australian actress known for emotionally intense performances." },
                    { new Guid("fed28090-372d-456f-9a1e-c207058ac144"), "https://m.media-amazon.com/images/M/MV5BMTM1NzUwMjY2M15BMl5BanBnXkFtZTcwOTI5MTMyMw@@._V1_FMjpg_UX399_.jpg", "Macaulay Culkin", "American actor known for iconic child performances in family comedies." },
                    { new Guid("ff728ce9-28c4-4e30-9e50-bd0e7fba3b39"), "https://m.media-amazon.com/images/M/MV5BOTk2NDc2ODgzMF5BMl5BanBnXkFtZTcwMTMzOTQ4Nw@@._V1_FMjpg_UX363_.jpg", "Jeremy Renner", "American actor known for action films and grounded dramatic roles." }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "description", "director_name", "duration", "genre", "image_url", "rating", "release_date", "short_description", "title" },
                values: new object[,]
                {
                    { new Guid("00641073-88cb-471e-bea0-8e6601494d09"), "Cultures clash and tempers flares as the two cops named Detective Inspector Lee a Hong Kong Detective and Detective James Carter LAPD, a big-mouthed work-alone Los Angeles cop who are from different worlds discovers one thing in common: they can't stand each other. With time running out, they must join forces to catch the criminals and save the eleven-year-old Chinese girl of the Chinese consul named Soo Yung.", "Brett Ratner", 98, "Comedy", "https://m.media-amazon.com/images/M/MV5BMGZiMzViNmEtNTNlZi00MzFmLTk5NTEtNDE2OTUzNmNlMTY4XkEyXkFqcGc@._V1_FMjpg_UX850_.jpg", 7.1f, new DateOnly(1998, 9, 18), "A loyal and dedicated Hong Kong Inspector teams up with a reckless and loudmouthed L.A.P.D. detective to rescue the Chinese Consul's kidnapped daughter, while trying to arrest a dangerous crime lord along the way.", "Rush Hour" },
                    { new Guid("07d1c2e1-a2e2-4ee5-873f-b101cc613a25"), "After landing a job as an off-season caretaker, Jack Torrance, an aspiring author and recovering alcoholic, drags his wife Wendy and gifted son Danny to snow-covered Colorado's secluded Overlook Hotel. However, writer's block prevents Jack from pursuing a new writing career. Everything has its time, however. First, the manager must give Jack a grand tour. Then, Mr Hallorann, the facility's aging chef, chats with Danny about rare psychic gifts. The mysterious employee also warns the boy about the cavernous hotel's abandoned rooms. Room 237, especially, is off-limits. That's all very well, but Jack is gradually losing his mind. After all, strange occurrences and blood-chilling visions have trapped the family in a silent gargantuan prison hammered by endless snowstorms. And now, incessant voices inside Jack's head demand sacrifice. However, is Jack capable of murder?", "Stanley Kubrick", 146, "Horror", "https://m.media-amazon.com/images/M/MV5BYjZiZDIxMjctZTk0NS00YTE1LTg5NGYtOTZkOTNkZDAzZjkwXkEyXkFqcGc@._V1_FMjpg_UX1080_.jpg", 8.4f, new DateOnly(1980, 5, 23), "A family heads to an isolated hotel for the winter, where a sinister presence influences the father into violence. At the same time, his psychic son sees horrifying forebodings from both the past and the future.", "The Shining" },
                    { new Guid("12010e19-dd0f-4195-b3c6-7dc6702c8a32"), "NYPD cop John McClane goes on a Christmas vacation to visit his wife Holly in Los Angeles where she works for the Nakatomi Corporation. While they are at the Nakatomi headquarters for a Christmas party, a group of robbers led by Hans Gruber take control of the building and hold everyone hostage, with the exception of John, while they plan to perform a lucrative heist. Unable to escape and with no immediate police response, John is forced to take matters into his own hands.", "John McTiernan", 132, "Action", "https://m.media-amazon.com/images/M/MV5BMGNlYmM1NmQtYWExMS00NmRjLTg5ZmEtMmYyYzJkMzljYWMxXkEyXkFqcGc@._V1_FMjpg_UX1066_.jpg", 8.2f, new DateOnly(1988, 7, 15), "A New York City cop tries to save his wife and several others taken hostage by terrorists during a Christmas party in a Los Angeles skyscraper.", "Die Hard" },
                    { new Guid("13f91c44-a819-49c8-8ed3-3c003171ddc3"), "Linguistics professor Louise Banks leads an elite team of investigators when gigantic spaceships touchdown in 12 locations around the world. As nations teeter on the verge of global war, Banks and her crew must race against time to find a way to communicate with the extraterrestrial visitors. Hoping to unravel the mystery, she takes a chance that could threaten her life and quite possibly all of mankind.", "Denis Villeneuve", 116, "Sci-fi", "https://m.media-amazon.com/images/M/MV5BMTExMzU0ODcxNDheQTJeQWpwZ15BbWU4MDE1OTI4MzAy._V1_FMjpg_UY2048_.jpg", 7.9f, new DateOnly(2016, 11, 11), "Linguist Louise Banks leads a team of investigators when gigantic spaceships touch down around the world. As nations teeter on the verge of global war, Banks and her crew must find a way to communicate with the extraterrestrial visitors.", "Arrival" },
                    { new Guid("23fb559e-9a66-4423-af07-b97d9de649fe"), "Taking place in a nameless city, Se7en follows the story of two homicide detectives tracking down a sadistic serial killer who chooses his victims according to the seven deadly sins. Brad Pitt stars as Detective David Mills, a hopeful but naive rookie who finds himself partnered with veteran Detective William Somerset (Morgan Freeman). Together they trace the killer's every step, witnessing the aftermath of his horrific crimes one by one as the victims pile up in rapid succession, all the while moving closer to a gruesome fate neither of them could have predicted.", "David Fincher", 127, "Thriller", "https://m.media-amazon.com/images/M/MV5BY2IzNzMxZjctZjUxZi00YzAxLTk3ZjMtODFjODdhMDU5NDM1XkEyXkFqcGc@._V1_FMjpg_UY2815_.jpg", 8.6f, new DateOnly(1995, 9, 22), "Two detectives try to track down a serial killer who chooses his victims based on the Seven Deadly Sins.", "Se7en" },
                    { new Guid("2a90d8b6-82d8-4581-9fa7-ecaa5832dc26"), "This is the tale of Harry Potter (Daniel Radcliffe), an ordinary eleven-year-old boy serving as a sort of slave for his aunt and uncle who learns that he is actually a wizard and has been invited to attend the Hogwarts School for Witchcraft and Wizardry. Harry is snatched away from his mundane existence by Rubeus Hagrid (Robbie Coltrane), the groundskeeper for Hogwarts, and quickly thrown into a world completely foreign to both him and the viewer. Famous for an incident that happened at his birth, Harry makes friends easily at his new school. He soon finds, however, that the wizarding world is far more dangerous for him than he would have imagined, and he quickly learns that not all wizards are ones to be trusted.", "Chris Columbus", 152, "Fantasy", "https://m.media-amazon.com/images/M/MV5BNTU1MzgyMDMtMzBlZS00YzczLThmYWEtMjU3YmFlOWEyMjE1XkEyXkFqcGc@._V1_FMjpg_UY2902_.jpg", 7.7f, new DateOnly(2001, 11, 16), "An orphaned boy enrolls in a school of wizardry, where he learns the truth about himself, his family and the terrible evil that haunts the magical world.", "Harry Potter and the Sorcerer's Stone" },
                    { new Guid("2fad653d-7cde-4b92-a5e8-a3928570f756"), "In 1944 Falangist Spain, a girl, fascinated with fairy-tales, is sent along with her pregnant mother to live with her new stepfather, a ruthless captain of the Spanish army. During the night, she meets a fairy who takes her to an old faun in the center of the labyrinth. He tells her she's a princess, but must prove her royalty by surviving three gruesome tasks. If she fails, she will never prove herself to be the true princess and will never see her real father, the king, again.", "Guillermo del Toro", 118, "Fantasy", "https://m.media-amazon.com/images/M/MV5BOTc1NTAxMWItMWFlNy00MmU2LTkwMTMtNzMwOTg5OTQ5YTFiXkEyXkFqcGc@._V1_FMjpg_UY2892_.jpg", 8.2f, new DateOnly(2006, 12, 29), "In 1944 Francoist Spain, an imaginative young girl meets a faun who tells her she's a princess and that she must prove her worthiness by completing three dangerous tasks.", "Pan's Labyrinth" },
                    { new Guid("34b8a65e-15f2-424a-b164-600afe23f814"), "84 years later, a 100 year-old woman named Rose DeWitt Bukater tells the story to her granddaughter Lizzy Calvert, Brock Lovett, Lewis Bodine, Bobby Buell and Anatoly Mikailavich on the Keldysh about her life set in April 10th 1912, on a ship called Titanic when young Rose boards the departing ship with the upper-class passengers and her mother, Ruth DeWitt Bukater, and her fiancé, Caledon Hockley. Meanwhile, a drifter and artist named Jack Dawson and his best friend Fabrizio De Rossi win third-class tickets to the ship in a game. And she explains the whole story from departure until the death of Titanic on its first and last voyage April 15th, 1912 at 2:20 in the morning.", "James Cameron", 195, "Drama", "https://m.media-amazon.com/images/M/MV5BYzYyN2FiZmUtYWYzMy00MzViLWJkZTMtOGY1ZjgzNWMwN2YxXkEyXkFqcGc@._V1_FMjpg_UY3000_.jpg", 8f, new DateOnly(1997, 12, 19), "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic.", "Titanic" },
                    { new Guid("368e82a0-da8c-4d1b-90b0-749f12faecfa"), "When Ellen, the matriarch of the Graham family, passes away, her daughter's family begins to unravel cryptic and increasingly terrifying secrets about their ancestry. The more they discover, the more they find themselves trying to outrun the sinister fate they seem to have inherited. Making his feature debut, writer-director Ari Aster unleashes a nightmare vision of a domestic breakdown that exhibits the craft and precision of a nascent auteur, transforming a familial tragedy into something ominous and deeply disquieting, and pushing the horror movie into chilling new terrain with its shattering portrait of heritage gone to hell.", "Ari Aster", 127, "Horror", "https://m.media-amazon.com/images/M/MV5BNTEyZGQwODctYWJjZi00NjFmLTg3YmEtMzlhNjljOGZhMWMyXkEyXkFqcGc@._V1_FMjpg_UY3000_.jpg", 7.3f, new DateOnly(2018, 6, 8), "A grieving family is haunted by tragic and disturbing occurrences.", "Hereditary" },
                    { new Guid("377d6f6f-4aeb-4046-9ded-dfaf7e8d59a5"), "This is the origin story of former Special Forces operative turned mercenary Wade Wilson, who after being subjected to a rogue experiment that leaves him with accelerated healing powers, adopts the alter ego Deadpool. Armed with his new abilities and a dark, twisted sense of humor, Deadpool hunts down the man who nearly destroyed his life.", "Tim Miller", 108, "Superhero", "https://m.media-amazon.com/images/M/MV5BNzY3ZWU5NGQtOTViNC00ZWVmLTliNjAtNzViNzlkZWQ4YzQ4XkEyXkFqcGc@._V1_FMjpg_UY3000_.jpg", 8f, new DateOnly(2016, 2, 12), "A wisecracking mercenary gets experimented on and becomes immortal yet hideously scarred, and sets out to track down the man who ruined his looks.", "Deadpool" },
                    { new Guid("3a981e02-9650-4cc4-ba2f-978979789984"), "Nina (Portman) is a ballerina in a New York City ballet company whose life, like all those in her profession, is completely consumed with dance. She lives with her obsessive former ballerina mother Erica (Hershey) who exerts a suffocating control over her. When artistic director Thomas Leroy (Cassel) decides to replace prima ballerina Beth MacIntyre (Ryder) for the opening production of their new season, Swan Lake, Nina is his first choice. But Nina has competition: a new dancer, Lily (Kunis), who impresses Leroy as well. Swan Lake requires a dancer who can play both the White Swan with innocence and grace, and the Black Swan, who represents guile and sensuality. Nina fits the White Swan role perfectly but Lily is the personification of the Black Swan. As the two young dancers expand their rivalry into a twisted friendship, Nina begins to get more in touch with her dark side - a recklessness that threatens to destroy her.", "Darren Aronofsky", 108, "Thriller", "https://m.media-amazon.com/images/M/MV5BNzY2NzI4OTE5MF5BMl5BanBnXkFtZTcwMjMyNDY4Mw@@._V1_FMjpg_UY2048_.jpg", 8f, new DateOnly(2010, 12, 17), "Nina is a talented but unstable ballerina on the verge of stardom. Pushed to the breaking point by her artistic director and a seductive rival, Nina's grip on reality slips, plunging her into a waking nightmare.", "Black Swan" },
                    { new Guid("40009b98-ece3-42b4-8c7d-a10b4dda5b38"), "How far would you go to protect your family? Keller Dover is facing every parent's worst nightmare. His six-year-old daughter, Anna, is missing, together with her young friend, Joy, and as minutes turn to hours, panic sets in. The only lead is a dilapidated RV that had earlier been parked on their street. Heading the investigation, Detective Loki arrests its driver, Alex Jones, but a lack of evidence forces his release. As the police pursue multiple leads and pressure mounts, knowing his child's life is at stake the frantic Dover decides he has no choice but to take matters into his own hands. But just how far will this desperate father go to protect his family?", "Denis Villeneuve", 153, "Thriller", "https://m.media-amazon.com/images/M/MV5BMTg0NTIzMjQ1NV5BMl5BanBnXkFtZTcwNDc3MzM5OQ@@._V1_FMjpg_UY2048_.jpg", 8.2f, new DateOnly(2013, 9, 20), "A desperate father takes the law into his own hands after police fail to find two kidnapped girls.", "Prisoners" },
                    { new Guid("43268f2d-7bfb-4c62-b49d-b868b1fc2568"), "Chris and his girlfriend Rose go upstate to visit her parents for the weekend. At first, Chris reads the family's overly accommodating behavior as nervous attempts to deal with their daughter's interracial relationship, but as the weekend progresses, a series of increasingly disturbing discoveries lead him to a truth that he never could have imagined.", "Jordan Peele", 104, "Horror", "https://m.media-amazon.com/images/M/MV5BMjUxMDQwNjcyNl5BMl5BanBnXkFtZTgwNzcwMzc0MTI@._V1_FMjpg_UY2048_.jpg", 7.8f, new DateOnly(2017, 2, 24), "A young African-American visits his white girlfriend's parents for the weekend, where his simmering uneasiness about their reception of him eventually reaches a boiling point.", "Get Out" },
                    { new Guid("441db5ba-a442-43f9-8e18-363cf678f5d2"), "The passage from this world to the fantasy kingdom of Stormhold is through a breach in a wall beside an English village. In the 1800s, a boy becomes a man when he ventures through the breach in pursuit of a fallen star, to prove his love for the village beauty. The star is no lump of rock, it's a maiden, Yvaine. Tristan, the youth, is not the only one looking for her: three witches, led by Lamia, want her heart to make them young; and, the sons of the dead king of Stormhold want her because she holds a ruby that will give one of them title to the throne. Assisting Tristan are his mother, the victim of a spell, and a cross-dressing pirate of the skies. Will Tristan win his true love?", "Matthew Vaughn", 127, "Fantasy", "https://m.media-amazon.com/images/M/MV5BMjkyMTE1OTYwNF5BMl5BanBnXkFtZTcwMDIxODYzMw@@._V1_FMjpg_UY2048_.jpg", 7.6f, new DateOnly(2007, 8, 10), "In a countryside town bordering on a magical land, a young man makes a promise to his beloved that he'll retrieve a fallen star by venturing into the magical realm.", "Stardust" },
                    { new Guid("4ab20a27-63b5-42ee-a9de-aef4b0866153"), "Four children from the same family have to leave their town because of the bombings of WWII. A woman and a professor take the children to their house. While playing a game of hide-and-seek, the youngest member of the family, Lucy, finds a wardrobe to hide in. She travels back and back into the wardrobe and finds a place named Narnia. After going in twice, the four children go in together for the last time. They battle wolves, meet talking animals, encounter an evil white witch and meet a magnificent lion named Aslan. Will this be the end of their journey to Narnia or will they stay?", "Andrew Adamson", 143, "Fantasy", "https://m.media-amazon.com/images/M/MV5BMTc0NTUwMTU5OV5BMl5BanBnXkFtZTcwNjAwNzQzMw@@._V1_FMjpg_UY2048_.jpg", 6.9f, new DateOnly(2005, 12, 9), "Four siblings wind up entering the magical land of Narnia. Once there, they discover a world inhabited by fantastical creatures and find themselves in a battle to defeat a witch.", "The Chronicles of Narnia: The Lion, the Witch and the Wardrobe" },
                    { new Guid("4d91f3a2-6c96-4a58-90f7-bbea29063a5f"), "The year is 1963, the night: Halloween. Police are called to 43 Lampkin Ln. only to discover that 15-year-old Judith Myers has been stabbed to death by her 6-year-old brother, Michael. After being institutionalized for 15 years, Myers breaks out on the night before Halloween. No one knows, nor wants to find out, what will happen on October 31st 1978, besides Myers' psychiatrist, Dr. Loomis. He knows Michael is coming back to Haddonfield, but by the time the town realizes it, it'll be too late for many people.", "John Carpenter", 91, "Horror", "https://m.media-amazon.com/images/M/MV5BMzZiNTdiYTgtYjNkMS00MmJmLWEwZGQtNmY0NGJkMGE0YmYzXkEyXkFqcGc@._V1_FMjpg_UX580_.jpg", 7.7f, new DateOnly(1978, 10, 25), "Fifteen years after murdering his sister on Halloween night 1963, Michael Myers escapes from a mental hospital and returns to the small town of Haddonfield, Illinois, to kill again.", "Halloween" },
                    { new Guid("4e35a624-d5db-4900-b43e-c0f9b7d28590"), "It is Christmas time and the McCallister family is preparing for a vacation in Paris, France. But the youngest in the family, Kevin (Macaulay Culkin), got into a scuffle with his older brother Buzz (Devin Ratray) and was sent to his room, which is on the third floor of his house. Then, the next morning, while the rest of the family was in a rush to make it to the airport on time, they completely forgot about Kevin, who now has the house all to himself. Being home alone was fun for Kevin, having a pizza all to himself, jumping on his parents' bed, and making a mess. Then, Kevin discovers about two burglars, Harry (Joe Pesci) and Marv (Daniel Stern), about to rob his house on Christmas Eve. Kevin acts quickly by wiring his own house with makeshift booby traps to stop the burglars and to bring them to justice.", "Chris Columbus", 103, "Comedy", "https://m.media-amazon.com/images/M/MV5BNzNmNmQ2ZDEtMTc1MS00NjNiLThlMGUtZmQxNTg1Nzg5NWMzXkEyXkFqcGc@._V1_FMjpg_UY1985_.jpg", 7.8f, new DateOnly(1990, 11, 16), "An eight-year-old troublemaker, mistakenly left home alone, must defend his home against a pair of burglars on Christmas Eve.", "Home Alone" },
                    { new Guid("50219472-6180-4b85-a5ac-fdf4079ccf58"), "On the occasion of his fifth wedding anniversary, Nick Dunne reports that his wife, Amy, has gone missing. Under pressure from the police and a growing media frenzy, Nick's portrait of a blissful union begins to crumble. Soon his lies, deceits and strange behavior have everyone asking the same dark question: Did Nick Dunne kill his wife?", "David Fincher", 149, "Thriller", "https://m.media-amazon.com/images/M/MV5BMTk0MDQ3MzAzOV5BMl5BanBnXkFtZTgwNzU1NzE3MjE@._V1_FMjpg_UY2048_.jpg", 8.1f, new DateOnly(2014, 10, 3), "The husband of a missing woman becomes the main suspect in her disappearance.", "Gone Girl" },
                    { new Guid("512d850d-0dad-429a-a2f8-5a492651e8d5"), "Despite his tarnished reputation after the events of The Dark Knight (2008), in which he took the rap for Dent's crimes, Batman feels compelled to intervene to assist the city and its Police force, which is struggling to cope with Bane's plans to destroy the city.", "Christopher Nolan", 164, "Superhero", "https://m.media-amazon.com/images/M/MV5BMTk4ODQzNDY3Ml5BMl5BanBnXkFtZTcwODA0NTM4Nw@@._V1_FMjpg_UX486_.jpg", 8.4f, new DateOnly(2012, 7, 20), "Bane, an imposing terrorist, attacks Gotham City and disrupts its eight-year-long period of peace. This forces Bruce Wayne to come out of hiding and don the cape and cowl of Batman again.", "The Dark Knight Rises" },
                    { new Guid("5247d8b6-6f31-4995-86c9-4196332328a0"), "Two years after Ethan Hunt had successfully captured Solomon Lane, the remnants of the Syndicate have reformed into another organization called the Apostles. Under the leadership of a mysterious fundamentalist known only as John Lark, the organization is planning on acquiring three plutonium cores. Ethan and his team are sent to Berlin to intercept them, but the mission fails when Ethan saves Luther and the Apostles escape with the plutonium. With CIA agent August Walker joining the team, Ethan and his allies must now find the plutonium cores before it's too late.", "Christopher McQuarrie", 147, "Action", "https://m.media-amazon.com/images/M/MV5BZGEzYjgxYmEtODY2My00NGM2LTlkOTEtNjMzY2Y4Yzg4MTJmXkEyXkFqcGc@._V1_FMjpg_UX726_.jpg", 7.7f, new DateOnly(2018, 7, 27), "A group of terrorists plans to detonate three plutonium cores for a simultaneous nuclear attack on different cities. Ethan Hunt, along with his IMF team, sets out to stop the carnage.", "Mission: Impossible – Fallout" },
                    { new Guid("59d62ca3-2be7-4ef6-bfbc-362b4ff49fac"), "After the events of Captain America: Civil War, Prince T'Challa returns home to the reclusive, technologically advanced African nation of Wakanda to serve as his country's new king. However, T'Challa soon finds that he is challenged for the throne from factions within his own country. When two foes conspire to destroy Wakanda, the hero known as Black Panther must team up with C.I.A. agent Everett K. Ross and members of the Dora Milaje, Wakandan special forces, to prevent Wakanda from being dragged into a world war.", "Ryan Coogler", 134, "Superhero", "https://m.media-amazon.com/images/M/MV5BMTg1MTY2MjYzNV5BMl5BanBnXkFtZTgwMTc4NTMwNDI@._V1_FMjpg_UY2048_.jpg", 7.3f, new DateOnly(2018, 2, 16), "T'Challa, heir to the hidden but advanced kingdom of Wakanda, must step forward to lead his people into a new future and must confront a challenger from his country's past.", "Black Panther" },
                    { new Guid("5b248551-840b-4632-8aaf-3e1b16252d65"), "During a manned mission to Mars, Astronaut Mark Watney is presumed dead after a fierce storm and left behind by his crew. But Watney has survived and finds himself stranded and alone on the hostile planet. With only meager supplies, he must draw upon his ingenuity, wit and spirit to subsist and find a way to signal to Earth that he is alive. Millions of miles away, NASA and a team of international scientists work tirelessly to bring \"the Martian\" home, while his crewmates concurrently plot a daring, if not impossible, rescue mission. As these stories of incredible bravery unfold, the world comes together to root for Watney's safe return.", "Ridley Scott", 144, "Sci-fi", "https://m.media-amazon.com/images/M/MV5BMTc2MTQ3MDA1Nl5BMl5BanBnXkFtZTgwODA3OTI4NjE@._V1_FMjpg_UX865_.jpg", 8f, new DateOnly(2015, 10, 2), "An astronaut becomes stranded on Mars after his team assumes him dead, and must rely on his ingenuity to find a way to signal to Earth that he is alive and can survive until a potential rescue.", "The Martian" },
                    { new Guid("5c3f62e1-a6ca-4286-9cb3-5cbc0afc3d8b"), "After stealing a mysterious orb in the far reaches of outer space, Peter Quill from Earth is now the main target of a manhunt led by the villain known as Ronan the Accuser. To help fight Ronan and his team and save the galaxy from his power, Quill creates a team of space heroes known as the \"Guardians of the Galaxy\" to save the galaxy.", "James Gunn", 121, "Superhero", "https://m.media-amazon.com/images/M/MV5BM2ZmNjQ2MzAtNDlhNi00MmQyLWJhZDMtNmJiMjFlOWY4MzcxXkEyXkFqcGc@._V1_FMjpg_UX1012_.jpg", 8f, new DateOnly(2014, 8, 1), "A group of intergalactic criminals must pull together to stop a fanatical warrior with plans to purge the universe.", "Guardians of the Galaxy" },
                    { new Guid("614bf670-e4d2-4b35-a208-c84a6c75c764"), "Over ten years have passed since the first machine called The Terminator tried to kill Sarah Connor and her unborn son, John. The man who will become the future leader of the human resistance against the Machines is now a healthy young boy. However, another Terminator, called the T-1000, is sent back through time by the self-aware computer system, Skynet. This new Terminator is more advanced and more powerful than its predecessor and its mission is to kill John Connor when he's still a child. However, Sarah and John do not have to face the threat of the T-1000 alone. Another Terminator (identical to the same model that tried and failed to kill Sarah Connor in 1984) is also sent back through time to protect them. While John teaches the Terminator about humanity, Sarah tries to prevent the creation of Skynet and the Machines.", "James Cameron", 137, "Action", "https://m.media-amazon.com/images/M/MV5BMWM3MDE3ZmYtMGQ3MC00NTMzLThjMGItOWQxM2YzNTI4YTE4XkEyXkFqcGc@._V1_FMjpg_UY2500_.jpg", 8.6f, new DateOnly(1991, 7, 3), "A cyborg from the future, identical to the one who failed to kill Sarah Connor, must now protect her ten-year-old son John from an even more advanced and powerful cyborg.", "Terminator 2: Judgment Day" },
                    { new Guid("623d306a-95f7-48f7-9f09-aa298685ac3b"), "This swash-buckling tale follows the quest of Captain Jack Sparrow, a savvy pirate, and Will Turner, a resourceful blacksmith, as they search for Elizabeth Swann. Elizabeth, the daughter of the governor and the love of Will's life, has been kidnapped by the feared Captain Barbossa. Little do they know, but the fierce and clever Barbossa has been cursed. He, along with his large crew, are under an ancient curse, doomed for eternity to neither live, nor die. That is, unless a blood sacrifice is made.", "Gore Verbinski", 143, "Fantasy", "https://m.media-amazon.com/images/M/MV5BNDhlMzEyNzItMTA5Mi00YWRhLThlNTktYTQyMTA0MDIyNDEyXkEyXkFqcGc@._V1_FMjpg_UX671_.jpg", 8.1f, new DateOnly(2003, 7, 9), "An intrepid blacksmith teams up with an eccentric pirate captain to save his love from an undead pirate crew.", "Pirates of the Caribbean: The Curse of the Black Pearl" },
                    { new Guid("63c3517c-d626-4181-a444-0adeeb056878"), "Thirty years after the events of Blade Runner (1982), a new Blade Runner, L.A.P.D. Officer \"K\" (Ryan Gosling), unearths a long-buried secret that has the potential to plunge what's left of society into chaos. K's discovery leads him on a quest to find Rick Deckard (Harrison Ford), a former L.A.P.D. Blade Runner, who has been missing for thirty years.", "Denis Villeneuve", 164, "Sci-fi", "https://m.media-amazon.com/images/M/MV5BNzA1Njg4NzYxOV5BMl5BanBnXkFtZTgwODk5NjU3MzI@._V1_FMjpg_UY2048_.jpg", 8f, new DateOnly(2017, 10, 6), "Young Blade Runner K's discovery of a long-buried secret leads him to track down former Blade Runner Rick Deckard, who's been missing for thirty years.", "Blade Runner 2049" },
                    { new Guid("66275523-30e6-48e0-8c65-dab3d3fb12f8"), "Brennan Huff and Dale Doback are both about 40 when Brennan's mom and Dale's dad marry. The sons still live with the parents so they must now share a room. Initial antipathy threatens the household's peace and the parents' relationship. Dad lays down the law: both slackers have a month to find a job. Out of the job search and their love of music comes a pact that leads to friendship but more domestic disarray compounded by the boys' sleepwalking. Hovering nearby are Brennan's successful brother and his lonely wife: the brother wants to help sell his step-father's house, the wife wants Dale's attention, and the newlyweds want to retire and sail the seven seas. Can harmony come from the discord?", "Adam McKay", 98, "Comedy", "https://m.media-amazon.com/images/M/MV5BYWNiOGZkOTgtNGMzMC00MDg5LTliM2UtN2VjMDI3N2ViOWE5XkEyXkFqcGc@._V1_FMjpg_UX1079_.jpg", 6.9f, new DateOnly(2008, 7, 25), "Two aimless middle-aged losers still living at home are forced against their will to become roommates when their parents marry.", "Step Brothers" },
                    { new Guid("6851194f-61a0-4df1-8e89-2030ca47fe24"), "In the near future around the American Midwest, Cooper, an ex-science engineer and pilot, is tied to his farming land with his daughter Murph and son Tom. As devastating sandstorms ravage Earth's crops, the people of Earth realize their life here is coming to an end as food begins to run out. Eventually stumbling upon a N.A.S.A. base 6 hours from Cooper's home, he is asked to go on a daring mission with a few other scientists into a wormhole because of Cooper's scientific intellect and ability to pilot aircraft unlike the other crew members. In order to find a new home while Earth decays, Cooper must decide to either stay, or risk never seeing his children again in order to save the human race by finding another habitable planet.", "Christopher Nolan", 169, "Sci-fi", "https://m.media-amazon.com/images/M/MV5BYzdjMDAxZGItMjI2My00ODA1LTlkNzItOWFjMDU5ZDJlYWY3XkEyXkFqcGc@._V1_FMjpg_UY3600_.jpg", 8.7f, new DateOnly(2014, 11, 7), "When Earth becomes uninhabitable in the future, a farmer and ex-NASA pilot, Joseph Cooper, is tasked to pilot a spacecraft, along with a team of researchers, to find a new planet for humans.", "Interstellar" },
                    { new Guid("69941e20-653e-4ddf-a9ef-7a98f601ba61"), "Lindsay Lohan stars as Cady Heron, a 16 year old homeschooled girl who not only makes the mistake of falling for Aaron Samuels (Jonathan Bennett), the ex-boyfriend of queenbee Regina George (Rachel McAdams), but also unintentionally joins The Plastics, led by Regina herself. Join Cady as she learns that high school life can and will be really tough.", "Mark Waters", 97, "Comedy", "https://m.media-amazon.com/images/M/MV5BMjE1MDQ4MjI1OV5BMl5BanBnXkFtZTcwNzcwODAzMw@@._V1_FMjpg_UY2048_.jpg", 7.1f, new DateOnly(2004, 4, 30), "Cady Heron is a hit with The Plastics, the A-list girl clique at her new school, until she makes the mistake of falling for Aaron Samuels, the ex-boyfriend of alpha Plastic Regina George.", "Mean Girls" },
                    { new Guid("6ea110b0-5980-49ec-9812-bdc05ca854be"), "Marvel's \"Doctor Strange\" follows the story of the talented neurosurgeon Doctor Stephen Strange who, after a tragic car accident, must put ego aside and learn the secrets of a hidden world of mysticism and alternate dimensions. Based in New York City's Greenwich Village, Doctor Strange must act as an intermediary between the real world and what lies beyond, utilising a vast array of metaphysical abilities and artifacts to protect the Marvel Cinematic Universe.", "Scott Derrickson", 115, "Superhero", "https://m.media-amazon.com/images/M/MV5BNjgwNzAzNjk1Nl5BMl5BanBnXkFtZTgwMzQ2NjI1OTE@._V1_FMjpg_UY2048_.jpg", 7.5f, new DateOnly(2016, 11, 4), "While on a journey of physical and spiritual healing, a brilliant neurosurgeon is drawn into the world of the mystic arts.", "Doctor Strange" },
                    { new Guid("6f6779da-99ae-44d9-a61a-43ebe5f0fd77"), "Set within a year after the events of Batman Begins (2005), Batman, Lieutenant James Gordon, and new District Attorney Harvey Dent successfully begin to round up the criminals that plague Gotham City, until a mysterious and sadistic criminal mastermind known only as \"The Joker\" appears in Gotham, creating a new wave of chaos. Batman's struggle against The Joker becomes deeply personal, forcing him to \"confront everything he believes\" and improve his technology to stop him. A love triangle develops between Bruce Wayne, Dent, and Rachel Dawes.", "Christopher Nolan", 152, "Action", "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_FMjpg_UY2048_.jpg", 9.1f, new DateOnly(2008, 7, 18), "When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness.", "The Dark Knight" },
                    { new Guid("700ebda0-232e-4b1c-9be2-bf6a99893d6d"), "In 1982, a massive star ship bearing a bedraggled alien population, nicknamed \"The Prawns,\" appeared over Johannesburg, South Africa. Twenty-eight years later, the initial welcome by the human population has faded. The refugee camp where the aliens were located has deteriorated into a militarized ghetto called District 9, where they are confined and exploited in squalor. In 2010, the munitions corporation, Multi-National United, is contracted to forcibly evict the population with operative Wikus van der Merwe in charge. In this operation, Wikus is exposed to a strange alien chemical and must rely on the help of his only two new 'Prawn' friends.", "Neill Blomkamp", 112, "Sci-fi", "https://m.media-amazon.com/images/M/MV5BMTM4OTI1OTM5NF5BMl5BanBnXkFtZTcwMzk5MTU1Mg@@._V1_FMjpg_UX973_.jpg", 7.9f, new DateOnly(2009, 8, 14), "In a future Earth in which aliens are isolated in a remote ghetto, a government agent finds himself banished there.", "District 9" },
                    { new Guid("70a5373e-e526-4766-9194-e6d1a536485c"), "In 1971, Carolyn and Roger Perron move their family into a dilapidated Rhode Island farm house and soon strange things start happening around it with escalating nightmarish terror. In desperation, Carolyn contacts the noted paranormal investigators, Ed and Lorraine Warren, to examine the house. What the Warrens discover is a whole area steeped in a satanic haunting that is now targeting the Perron family wherever they go. To stop this evil, the Warrens will have to call upon all their skills and spiritual strength to defeat this spectral menace at its source that threatens to destroy everyone involved.", "James Wan", 112, "Horror", "https://m.media-amazon.com/images/M/MV5BMTM3NjA1NDMyMV5BMl5BanBnXkFtZTcwMDQzNDMzOQ@@._V1_FMjpg_UX1200_.jpg", 7.5f, new DateOnly(2013, 7, 19), "Paranormal investigators Ed and Lorraine Warren work to help a family terrorized by a dark presence in their farmhouse.", "The Conjuring" },
                    { new Guid("75a766dd-73cd-4a3b-81ef-738e4b72a23d"), "Tony Stark. Genius, billionaire, playboy, philanthropist. Son of legendary inventor and weapons contractor Howard Stark. When Tony Stark is assigned to give a weapons presentation to an Iraqi unit led by Lt. Col. James Rhodes, he's given a ride on enemy lines. That ride ends badly when Stark's Humvee that he's riding in is attacked by enemy combatants. He survives - barely - with a chest full of shrapnel and a car battery attached to his heart. In order to survive he comes up with a way to miniaturize the battery and figures out that the battery can power something else. Thus Iron Man is born. He uses the primitive device to escape from the cave in Iraq. Once back home, he then begins work on perfecting the Iron Man suit. But the man who was put in charge of Stark Industries has plans of his own to take over Tony's technology for other matters.", "Jon Favreau", 126, "Superhero", "https://m.media-amazon.com/images/M/MV5BMTczNTI2ODUwOF5BMl5BanBnXkFtZTcwMTU0NTIzMw@@._V1_FMjpg_UY2048_.jpg", 7.9f, new DateOnly(2008, 5, 2), "After being held captive in an Afghan cave, billionaire engineer Tony Stark creates a unique weaponized suit of armor to fight evil.", "Iron Man" },
                    { new Guid("78e7000a-1425-4340-938a-cf4a5bac6775"), "James Bond (Daniel Craig) goes on his first mission as a 00. Le Chiffre (Mads Mikkelsen) is a banker to the world's terrorists. He is participating in a poker game at Montenegro, where he must win back his money, in order to stay safe amongst the terrorist market. The boss of MI6, known simply as \"M\" (Dame Judi Dench) sends Bond, along with Vesper Lynd (Eva Green) to attend this game and prevent Le Chiffre from winning. Bond, using help from Felix Leiter (Jeffrey Wright), Rene Mathis (Giancarlo Giannini), and having Vesper pose as his partner, enters the most important poker game in his already dangerous career. But if Bond defeats Le Chiffre, will he and Vesper Lynd remain safe?", "Martin Campbell", 144, "Action", "https://m.media-amazon.com/images/M/MV5BMWQ1ZDM4NDktMWY0NC00MjcxLWJlMDMtNmE2MGVhYzRjMWQ0XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", 8f, new DateOnly(2006, 11, 17), "After earning a licence to kill, secret agent James Bond sets out on his first mission as 007. Bond must defeat a private banker funding terrorists in a high-stakes game of poker at Casino Royale, in Montenegro.", "Casino Royale" },
                    { new Guid("794c142d-386f-4a8a-8290-adf396a07f6a"), "NIGHTCRAWLER is a thriller set in the nocturnal underbelly of contemporary Los Angeles. Jake Gyllenhaal stars as Lou Bloom, a driven young man desperate for work who discovers the high-speed world of L.A. crime journalism. Finding a group of freelance camera crews who film crashes, fires, murder and other mayhem, Lou muscles into the cut-throat, dangerous realm of nightcrawling - where each police siren wail equals a possible windfall and victims are converted into dollars and cents. Aided by Rene Russo as Nina, a veteran of the blood-sport that is local TV news, Lou blurs the line between observer and participant to become the star of his own story.", "Dan Gilroy", 117, "Thriller", "https://m.media-amazon.com/images/M/MV5BYjMwMmI5MWQtOTU4OS00OTAyLTg0OTYtNmQ5YzExZTQ3ZWJhXkEyXkFqcGc@._V1_FMjpg_UX650_.jpg", 7.8f, new DateOnly(2014, 10, 31), "A petty thief desperate for work muscles into the world of crime journalism and becomes the star of his own story as he blurs the line between observer and participant.", "Nightcrawler" },
                    { new Guid("7c1f4dea-492d-446f-ba11-aa0794b54350"), "A socially inept clown for hire - Arthur Fleck aspires to be a stand up comedian among his small job working dressed as a clown holding a sign for advertising. He takes care of his mother, Penny Fleck, and as he learns more about his mental illness, he learns more about his past. Dealing with all the negativity and bullying from society, he heads downwards on a spiral, in turn showing how his alter ego, \"Joker,\" came to be.", "Todd Phillips", 122, "Drama", "https://m.media-amazon.com/images/M/MV5BNzY3OWQ5NDktNWQ2OC00ZjdlLThkMmItMDhhNDk3NTFiZGU4XkEyXkFqcGc@._V1_FMjpg_UY4096_.jpg", 8.3f, new DateOnly(2019, 10, 4), "Arthur Fleck, a party clown and a failed stand-up comedian, leads an impoverished life with his ailing mother. However, when society shuns him and brands him as a freak, he decides to embrace the life of chaos in Gotham City.", "Joker" },
                    { new Guid("7c9e4721-3564-4a95-952b-37e8a5eff337"), "Rachel Keller is a journalist investigating a videotape that may have killed four teenagers (including her niece). There is an urban legend about this tape: the viewer will die seven days after watching it. If the legend is correct, Rachel will have to run against time to save her son's and her own life.", "Gore Verbinski", 115, "Horror", "https://m.media-amazon.com/images/M/MV5BNDA2NTg2NjE4Ml5BMl5BanBnXkFtZTYwMjYxMDg5._V1_FMjpg_UX485_.jpg", 7.1f, new DateOnly(2002, 10, 18), "A journalist must investigate a mysterious videotape which seems to cause the death of anyone one week to the day after they view it.", "The Ring" },
                    { new Guid("86e3b9d0-b465-4b7e-95a4-f1da2a66ada2"), "Mathematician John Nash rises to prominence at Princeton with his groundbreaking theories in game theory. While achieving academic success, he begins experiencing paranoid delusions and hallucinations, straining his relationships with his wife Alicia and colleagues. Nash struggles with schizophrenia, gradually learning to distinguish reality from illusion while continuing his work. The film explores genius, mental illness, love, and perseverance, showing the challenges of balancing personal struggles with professional achievement.", "Ron Howard", 135, "Drama", "https://m.media-amazon.com/images/M/MV5BYjgzNjFkMmItOGJhNi00NWM3LWJlYTUtNDExMGQ3ZTI3NjJkXkEyXkFqcGc@._V1_FMjpg_UY2943_.jpg", 8.2f, new DateOnly(2001, 12, 21), "A mathematical genius, John Nash made an astonishing discovery early in his career and stood on the brink of international acclaim. But Nash soon found himself on a harrowing journey of self-discovery.", "A Beautiful Mind" },
                    { new Guid("885e7b27-c1c2-4ab8-8a6c-f676ecec60df"), "An ancient Ring thought lost for centuries has been found, and through a strange twist of fate has been given to a small Hobbit named Frodo. When Gandalf discovers the Ring is in fact the One Ring of the Dark Lord Sauron, Frodo must make an epic quest to Mount Doom in order to destroy it. However, he does not go alone. He is joined by Gandalf, Legolas the elf, Gimli the Dwarf, Aragorn, Boromir, and his three Hobbit friends Merry, Pippin, and Samwise. Through mountains, snow, darkness, forests, rivers and plains, facing evil and danger at every corner the Fellowship of the Ring must go. Their quest to destroy the One Ring is the only hope for the end of the Dark Lords reign.", "Peter Jackson", 178, "Fantasy", "https://m.media-amazon.com/images/M/MV5BMzEwYTg2NTMtMTUzYy00ZjE4LThmMjEtZDUyZWM4NzE5MGE5XkEyXkFqcGc@._V1_FMjpg_UY2835_.jpg", 8.9f, new DateOnly(2001, 12, 19), "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.", "The Lord of the Rings: The Fellowship of the Ring" },
                    { new Guid("88b25038-308e-4253-82c0-4a57151ad908"), "Caleb, a 26 year old programmer at the world's largest internet company, wins a competition to spend a week at a private mountain retreat belonging to Nathan, the reclusive CEO of the company. But when Caleb arrives at the remote location he finds that he will have to participate in a strange and fascinating experiment in which he must interact with the world's first true artificial intelligence, housed in the body of a beautiful robot girl.", "Alex Garland", 108, "Sci-fi", "https://m.media-amazon.com/images/M/MV5BMTUxNzc0OTIxMV5BMl5BanBnXkFtZTgwNDI3NzU2NDE@._V1_FMjpg_UX1012_.jpg", 7.7f, new DateOnly(2015, 4, 24), "A young programmer is selected to participate in a ground-breaking experiment in synthetic intelligence by evaluating the human qualities of a highly advanced humanoid A.I.", "Ex Machina" },
                    { new Guid("91e01bcd-a47d-48d9-b79d-8ed6c4886699"), "On a fall night in 2003, Harvard undergrad and computer programming genius Mark Zuckerberg sits down at his computer and heatedly begins working on a new idea. In a fury of blogging and programming, what begins in his dorm room soon becomes a global social network and a revolution in communication. A mere six years and 500 million friends later, Mark Zuckerberg is the youngest billionaire in history... but for this entrepreneur, success leads to both personal and legal complications.", "David Fincher", 120, "Drama", "https://m.media-amazon.com/images/M/MV5BMjlkNTE5ZTUtNGEwNy00MGVhLThmZjMtZjU1NDE5Zjk1NDZkXkEyXkFqcGc@._V1_FMjpg_UX675_.jpg", 7.8f, new DateOnly(2010, 10, 1), "As Harvard student Mark Zuckerberg creates the social networking site that would become known as Facebook, he is sued by the twins who claimed he stole their idea and by the co-founder who was later squeezed out of the business.", "The Social Network" },
                    { new Guid("93d7a78d-d7aa-43d0-8d7d-91a22b7c7619"), "After the devastating events of Avengers: Infinity War (2018), the universe is in ruins due to the efforts of the Mad Titan, Thanos. With the help of remaining allies, the Avengers must assemble once more in order to undo Thanos's actions and undo the chaos to the universe, no matter what consequences may be in store, and no matter who they face...", "Russo Brothers", 181, "Superhero", "https://m.media-amazon.com/images/M/MV5BMTc5MDE2ODcwNV5BMl5BanBnXkFtZTgwMzI2NzQ2NzM@._V1_FMjpg_UY2048_.jpg", 8.4f, new DateOnly(2019, 4, 26), "After the devastating events of Avengers: Infinity War (2018), the universe is in ruins. With the help of remaining allies, the Avengers assemble once more in order to reverse Thanos' actions and restore balance to the universe.", "Avengers: Endgame" },
                    { new Guid("97448f10-b164-4880-82ed-a1ac239d0afd"), "Nineteen-year-old Andrew Nieman wants to be the greatest jazz drummer in the world, in a league with Buddy Rich. This goal is despite not coming from a pedigree of greatest, musical or otherwise, with Jim, his high-school-teacher father, being a failed writer. Andrew is starting his first year at Shaffer Conservatory of Music, the best music school in the United States. At Shaffer, being the best means being accepted to study under Terence Fletcher and being asked to play in his studio band, which represents the school at jazz competitions. Based on their less than positive first meeting, Andrew is surprised that Fletcher asks him to join the band, albeit in the alternate drummer position which he is more than happy to do initially. Andrew quickly learns that Fletcher operates on fear and intimidation, never settling for what he considers less than the best each and every time. Being the best in Fletcher's mind does not only entail playing well, but knowing that you're playing well and if not what you're doing wrong. His modus operandi creates an atmosphere of fear and of every man or woman for him/herself within the band. Regardless, Andrew works hard to be the best. He has to figure out his life priorities and what he is willing to sacrifice to be the best. The other question becomes how much emotional abuse he will endure by Fletcher to reach that greatness, which he may believe he can only achieve with the avenues opened up by Fletcher.", "Damien Chazelle", 107, "Drama", "https://m.media-amazon.com/images/M/MV5BMDFjOWFkYzktYzhhMC00NmYyLTkwY2EtYjViMDhmNzg0OGFkXkEyXkFqcGc@._V1_FMjpg_UY5333_.jpg", 8.5f, new DateOnly(2014, 10, 10), "A promising young drummer enrolls at a cut-throat music conservatory where his dreams of greatness are mentored by an instructor who will stop at nothing to realize a student's potential.", "Whiplash" },
                    { new Guid("97951c83-8686-45c8-be13-a0b0f79539a5"), "Peter Parker's secret identity is revealed to the entire world. Desperate for help, Peter turns to Doctor Strange to make the world forget that he is Spider-Man. The spell goes horribly wrong and shatters the multiverse, bringing in monstrous villains that could destroy the world.", "Jon Watts", 148, "Superhero", "https://m.media-amazon.com/images/M/MV5BMmFiZGZjMmEtMTA0Ni00MzA2LTljMTYtZGI2MGJmZWYzZTQ2XkEyXkFqcGc@._V1_FMjpg_UY2100_.jpg", 8.1f, new DateOnly(2021, 12, 17), "With Spider-Man's identity now revealed, Peter asks Doctor Strange for help. When a spell goes wrong, dangerous foes from other worlds start to appear.", "Spider-Man: No Way Home" },
                    { new Guid("9d0944ab-9bfa-4345-8ee6-6f52787b19c4"), "Bilbo Baggins is swept into a quest to reclaim the lost Dwarf Kingdom of Erebor from the fearsome dragon Smaug. Approached out of the blue by the wizard Gandalf the Grey, Bilbo finds himself joining a company of thirteen dwarves led by the legendary warrior, Thorin Oakenshield. Their journey will take them into the Wild; through treacherous lands swarming with Goblins and Orcs, deadly Wargs and Giant Spiders, Shapeshifters and Sorcerers. Although their goal lies to the East and the wastelands of the Lonely Mountain first they must escape the goblin tunnels, where Bilbo meets the creature that will change his life forever ... Gollum. Here, alone with Gollum, on the shores of an underground lake, the unassuming Bilbo Baggins not only discovers depths of guile and courage that surprise even him, he also gains possession of Gollum's \"precious\" ring that holds unexpected and useful qualities ... A simple, gold ring that is tied to the fate of all Middle-earth in ways Bilbo cannot begin to know.", "Peter Jackson", 169, "Fantasy", "https://m.media-amazon.com/images/M/MV5BMTcwNTE4MTUxMl5BMl5BanBnXkFtZTcwMDIyODM4OA@@._V1_FMjpg_UY2048_.jpg", 7.8f, new DateOnly(2012, 12, 14), "A reluctant Hobbit, Bilbo Baggins, sets out to the Lonely Mountain with a spirited group of dwarves to reclaim their mountain home and the gold within it from the dragon Smaug.", "The Hobbit: An Unexpected Journey" },
                    { new Guid("9d52bd23-4ee9-499d-8789-0d860eef65a3"), "Harry and Lloyd are two good friends who happen to be really stupid. The duo set out on a cross country trip from Providence to Aspen, Colorado to return a briefcase full of money to its rightful owner, a beautiful woman named Mary Swanson. After a trip of one mishap after another, the duo eventually make it to Aspen. But the two soon realize that Mary and her briefcase are the least of their problems.", "Peter Farrelly", 107, "Comedy", "https://m.media-amazon.com/images/M/MV5BYTQxZmNhNTgtZjBlOC00MWQ0LThkOTktNzMyNDBlZDg4ZmJjXkEyXkFqcGc@._V1_FMjpg_UX350_.jpg", 7.3f, new DateOnly(1994, 12, 16), "After a woman leaves a briefcase at the airport terminal, a dumb limo driver and his dumber friend set out on a hilarious cross-country road trip to Aspen to return it.", "Dumb and Dumber" },
                    { new Guid("9dcd678b-7dee-47d1-aff7-567156607a86"), "A serial killer in the San Francisco Bay Area taunts police with his letters and cryptic messages. We follow the investigators and reporters in this lightly fictionalized account of the true 1970s' case as they search for the murderer, becoming obsessed with the case. Based on Robert Graysmith's book, the movie's focus is the lives and careers of the detectives and newspaper people.", "David Fincher", 157, "Thriller", "https://m.media-amazon.com/images/M/MV5BNDFkMTRkZmQtM2I0NC00NjJjLWJlMDctNTNiZWYxYzhjZDZiXkEyXkFqcGc@._V1_FMjpg_UY2867_.jpg", 7.7f, new DateOnly(2007, 3, 2), "Between 1968 and 1983, a San Francisco cartoonist becomes an amateur detective obsessed with tracking down the Zodiac Killer, an unidentified individual who terrorizes Northern California with a killing spree.", "Zodiac" },
                    { new Guid("9e1126ac-ddca-4012-9204-8d0480e417d1"), "Dom Cobb is a skilled thief, the absolute best in the dangerous art of extraction, stealing valuable secrets from deep within the subconscious during the dream state, when the mind is at its most vulnerable. Cobb's rare ability has made him a coveted player in this treacherous new world of corporate espionage, but it has also made him an international fugitive and cost him everything he has ever loved. Now Cobb is being offered a chance at redemption. One last job could give him his life back but only if he can accomplish the impossible, inception. Instead of the perfect heist, Cobb and his team of specialists have to pull off the reverse: their task is not to steal an idea, but to plant one. If they succeed, it could be the perfect crime. But no amount of careful planning or expertise can prepare the team for the dangerous enemy that seems to predict their every move. An enemy that only Cobb could have seen coming.", "Christopher Nolan", 148, "Sci-fi", "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_FMjpg_UX700_.jpg", 8.8f, new DateOnly(2010, 7, 16), "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO, but his tragic past may doom the project and his team to disaster.", "Inception" },
                    { new Guid("a4a49163-f174-4a42-9f88-1f1b30325ef5"), "57 years after Ellen Ripley had a close encounter with the reptilian alien creature from the first movie, she is called back, this time, to help a group of highly trained colonial marines fight off against the sinister extraterrestrials. But this time, the aliens have taken over a space colony on the moon LV-426. When the colonial marines are called upon to search the deserted space colony, they later find out that they are up against more than what they bargained for. Using specially modified machine guns and enough firepower, it's either fight or die as the space marines battle against the aliens.", "James Cameron", 137, "Sci-fi", "https://m.media-amazon.com/images/M/MV5BZjIyNGJhYzYtN2I1My00OTVhLWEyMzItZTVjNDMzOTVkYWViXkEyXkFqcGc@._V1_FMjpg_UY2260_.jpg", 8.4f, new DateOnly(1986, 7, 18), "Decades after surviving the Nostromo incident, Ellen Ripley is sent out to re-establish contact with a terraforming colony but finds herself battling the Alien Queen and her offspring.", "Aliens" },
                    { new Guid("a6600fb9-7a83-44fa-827e-03dd66e62e9a"), "Maximus is a powerful Roman general, loved by the people and the aging Emperor, Marcus Aurelius. Before his death, the Emperor chooses Maximus to be his heir over his own son, Commodus, and a power struggle leaves Maximus and his family condemned to death. The powerful general is captured and put into the Gladiator games until he dies. The only desire that fuels him now is the chance to rise to the top so that he will be able to look into the eyes of the man who will feel his revenge.", "Ridley Scott", 155, "Action", "https://m.media-amazon.com/images/M/MV5BYWQ4YmNjYjEtOWE1Zi00Y2U4LWI4NTAtMTU0MjkxNWQ1ZmJiXkEyXkFqcGc@._V1_FMjpg_UY2599_.jpg", 8.5f, new DateOnly(2000, 5, 5), "A former Roman General sets out to exact vengeance against the corrupt emperor who murdered his family and sent him into slavery.", "Gladiator" },
                    { new Guid("a7061bb8-f59a-4ab7-ad3c-dce86b7ccbdc"), "Seth and Evan are best friends, inseparable, navigating the last weeks of high school. Usually shunned by the popular kids, Seth and Evan luck into an invitation to a party, and spend a long day, with the help of their nerdy friend Fogell, trying to score enough alcohol to lubricate the party and inebriate two girls, Jules and Becca, so they can kick-start their sex lives and go off to college with a summer full of experience and new skills. Their quest is complicated by Fogell's falling in with two inept cops who both slow and assist the plan. If they do get the liquor to the party, what then? Is sex the only rite of passage at hand?", "Greg Mottola", 113, "Comedy", "https://m.media-amazon.com/images/M/MV5BNjk0MzdlZGEtNTRkOC00ZDRiLWJkYjAtMzUzYTRiNzk1YTViXkEyXkFqcGc@._V1_FMjpg_UY2940_.jpg", 7.6f, new DateOnly(2007, 8, 17), "Two co-dependent high school seniors are forced to deal with separation anxiety after their plan to stage a booze-soaked party goes awry.", "Superbad" },
                    { new Guid("a7b10c31-a060-4436-bef3-4b08014e794e"), "In the Battle of Thermopylae of 480 BC an alliance of Greek city-states fought the invading Persian army in the mountain pass of Thermopylae. Vastly outnumbered, the Greeks held back the enemy in one of the most famous last stands of history. Persian King Xerxes led a Army of well over 100,000 (Persian king Xerxes before war has about 170,000 army) men to Greece and was confronted by 300 Spartans, 700 Thespians, and 400 Thebans. Xerxes waited for 10 days for King Leonidas to surrender or withdraw but left with no options he pushed forward. After 3 days of battle all the Greeks were killed. The Spartan defeat was not the one expected, as a local shepherd, named Ephialtes, defected to the Persians and informed Xerxes that the separate path through Thermopylae, which the Persians could use to outflank the Greeks, was not as heavily guarded as they thought.", "Zack Snyder", 117, "Action", "https://m.media-amazon.com/images/M/MV5BMjc4OTc0ODgwNV5BMl5BanBnXkFtZTcwNjM1ODE0MQ@@._V1_FMjpg_UY2880_.jpg", 7.6f, new DateOnly(2007, 3, 9), "In the ancient battle of Thermopylae, King Leonidas and 300 Spartans fight against Xerxes and his massive Persian army.", "300" },
                    { new Guid("acc9eaf0-be41-4f4c-a4f2-4bee8da3e4a0"), "On Elm Street, Nancy Thompson and a group of her friends (comprising Tina Gray, Rod Lane and Glen Lantz) are being tormented by a clawed killer in their dreams named Fred Krueger. Nancy must think quickly, as Fred tries to pick them off one by one. When he has you in your sleep, who is there to save you?", "Wes Craven", 91, "Horror", "https://m.media-amazon.com/images/M/MV5BNTZmN2VlMWMtMTdlMi00NDBhLWIyODMtODEwMzM0ODMwMWYwXkEyXkFqcGc@._V1_FMjpg_UX780_.jpg", 7.4f, new DateOnly(1984, 11, 9), "Teenager Nancy Thompson must uncover the dark truth concealed by her parents after she and her friends become targets of the spirit of a serial killer with a bladed glove in their dreams, in which if they die, it kills them in real life.", "A Nightmare on Elm Street" },
                    { new Guid("af12ea31-878c-43ce-95ac-bb3d54f277f4"), "In the dystopian world of 2027 London, humans have been incapable of reproducing for unknown reasons, meaning the imminent extinction of the species. Britain is the one remaining civilized society on the planet, which has resulted in people wanting to migrate there, so it has become a police state to handle the immigrants, who are placed into refugee camps. Lowly government bureaucrat Theo Faron, once an activist, is approached by the Fishes, deemed a terrorist group, led by his ex-wife Julian Taylor, whom he hasn't seen in almost 20 years, since their marriage disintegrated after their infant son Dylan's death during the 2008 flu pandemic. Although the Fishes did use terrorist means in their on-going revolution against the state in the fight for immigrant rights, Julian vows that they now garner support solely by speaking to the people, and she wants Theo to use his connections to get transit papers for a young immigrant woman named Kee who needs to get to the coast. Although initially reluctant to do it because of the difficulty, Theo is able to grant Julian this favor, however with the change that he now needs to accompany Kee on her journey. As Theo and Kee progress on that journey, Theo learns more and more about what's going on, including the reason that Kee needs to get to the coast, the fact that no one in the group knows if their end destination even exists, and that his and Kee's lives are in greater danger than he believed when they started the journey. But Theo's sole mission becomes to help Kee at any cost for the survival of the species.", "Alfonso Cuarón", 109, "Sci-fi", "https://m.media-amazon.com/images/M/MV5BMDNkNmNiYzYtYWY0YS00NWEwLTgwMWUtYjM0M2E4Nzk3MzhmXkEyXkFqcGc@._V1_FMjpg_UY1953_.jpg", 7.9f, new DateOnly(2006, 12, 25), "In 2027, in a chaotic world in which women have somehow become infertile, a former activist agrees to help transport a miraculously pregnant woman to a sanctuary at sea.", "Children of Men" },
                    { new Guid("b0e94565-1376-46f0-b5c4-2aedc6d30ce7"), "Bruce Nolan, a television reporter in Buffalo, NY, is discontented with almost everything in life despite his popularity and the love of his girlfriend Grace. At the end of the worst day of his life, Bruce angrily ridicules and rages against God and God responds. God appears in human form and, endowing Bruce with divine powers, challenges Bruce to take on the big job to see if he can do it any better.", "Tom Shadyac", 101, "Comedy", "https://m.media-amazon.com/images/M/MV5BZWM2ZjA2OTctZmRhMy00ZDIzLTkwZGQtYTRlNmQwZWZmMDBlXkEyXkFqcGc@._V1_FMjpg_UY1895_.jpg", 6.8f, new DateOnly(2003, 5, 23), "A whiny news reporter is given the chance to step into God's shoes.", "Bruce Almighty" },
                    { new Guid("b235003d-d473-464d-a300-7049e31d0a6d"), "In the Town of Derry, the local kids are disappearing one by one. In a place known as 'The Barrens', a group of seven kids are united by their horrifying and strange encounters with an evil clown and their determination to kill It.", "Andy Muschietti", 135, "Horror", "https://m.media-amazon.com/images/M/MV5BMjIzZWM4NjktMjZjZS00ZTA3LWJhODEtNzE1MWFkNDEzODVlXkEyXkFqcGc@._V1_FMjpg_UY4096_.jpg", 7.3f, new DateOnly(2017, 9, 8), "In the summer of 1989, a group of bullied kids band together to destroy a shape-shifting monster, which disguises itself as a clown and preys on the children of Derry, their small Maine town.", "It" },
                    { new Guid("bd56340e-eea7-4e83-9b69-6ede4a939bd8"), "The final confrontation between the forces of good and evil fighting for control of the future of Middle-earth. Frodo and Sam reach Mordor in their quest to destroy the One Ring, while Aragorn leads the forces of good against Sauron's evil army at the stone city of Minas Tirith.", "Peter Jackson", 201, "Fantasy", "https://m.media-amazon.com/images/M/MV5BMTZkMjBjNWMtZGI5OC00MGU0LTk4ZTItODg2NWM3NTVmNWQ4XkEyXkFqcGc@._V1_FMjpg_UX800_.jpg", 9f, new DateOnly(2003, 12, 17), "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.", "The Lord of the Rings: The Return of the King" },
                    { new Guid("c2159ffd-c180-4a04-8499-62c1886a4ac9"), "Chronicles the experiences of a formerly successful banker as a prisoner in the gloomy jailhouse of Shawshank after being found guilty of a crime he did not commit. The film portrays the man's unique way of dealing with his new, torturous life; along the way he befriends a number of fellow prisoners, most notably a wise long-term inmate named Red.", "Frank Darabont", 142, "Drama", "https://m.media-amazon.com/images/M/MV5BMDAyY2FhYjctNDc5OS00MDNlLThiMGUtY2UxYWVkNGY2ZjljXkEyXkFqcGc@._V1_FMjpg_UX1200_.jpg", 9.3f, new DateOnly(1994, 9, 23), "A wrongfully convicted banker forms a close friendship with a hardened convict over a quarter century while retaining his humanity through simple acts of compassion.", "The Shawshank Redemption" },
                    { new Guid("c441109b-5d90-4b44-847f-ec113694e334"), "Forrest Gump is a simple man with a low I.Q. but good intentions. He is running through childhood with his best and only friend Jenny. His 'mama' teaches him the ways of life and leaves him to choose his destiny. Forrest joins the army for service in Vietnam, finding new friends called Dan and Bubba, he wins medals, creates a famous shrimp fishing fleet, inspires people to jog, starts a ping-pong craze, creates the smiley, writes bumper stickers and songs, donates to people and meets the president several times. However, this is all irrelevant to Forrest who can only think of his childhood sweetheart Jenny Curran, who has messed up her life. Although in the end all he wants to prove is that anyone can love anyone.", "Robert Zemeckis", 142, "Drama", "https://m.media-amazon.com/images/M/MV5BNDYwNzVjMTItZmU5YS00YjQ5LTljYjgtMjY2NDVmYWMyNWFmXkEyXkFqcGc@._V1_FMjpg_UX558_.jpg", 8.8f, new DateOnly(1994, 7, 6), "The history of the United States from the 1950s to the '70s unfolds from the perspective of an Alabama man with an IQ of 75, who yearns to be reunited with his childhood sweetheart.", "Forrest Gump" },
                    { new Guid("c4987c3e-6ee2-49f5-8caa-bb515b019e8b"), "A visiting actress in Washington, D.C., notices dramatic and dangerous changes in the behavior and physical makeup of her 12 year-old daughter. Meanwhile, a young priest at nearby Georgetown University begins to doubt his faith while dealing with his mother's terminal sickness. A frail, elderly priest recognizes the necessity for a show-down with an old demonic enemy.", "William Friedkin", 122, "Horror", "https://m.media-amazon.com/images/M/MV5BZjg3YjE4ZjAtYTdmYS00ZTBkLWE1ZjgtNzAzODUwNzRiYjlmXkEyXkFqcGc@._V1_FMjpg_UY2239_.jpg", 8.1f, new DateOnly(1973, 12, 26), "When a mysterious entity possesses a young girl, her mother seeks the help of two Catholic priests to save her life.", "The Exorcist" },
                    { new Guid("c6c210c2-c80b-474e-9d97-2751200097ae"), "The continuing quest of Frodo and the Fellowship to destroy the One Ring. Frodo and Sam discover they are being followed by the mysterious Gollum. Aragorn, the Elf archer Legolas, and Gimli the Dwarf encounter the besieged Rohan kingdom, whose once great King Theoden has fallen under Saruman's deadly spell.", "Peter Jackson", 179, "Fantasy", "https://m.media-amazon.com/images/M/MV5BMGQxMDdiOWUtYjc1Ni00YzM1LWE2NjMtZTg3Y2JkMjEzMTJjXkEyXkFqcGc@._V1_FMjpg_UX964_.jpg", 8.8f, new DateOnly(2002, 12, 18), "While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron's new ally, Saruman, and his hordes of Isengard.", "The Lord of the Rings: The Two Towers" },
                    { new Guid("c6d7d61d-0ab2-4789-85fe-053e438cfe2a"), "In rural Texas, welder and hunter Llewelyn Moss (Josh Brolin) discovers the remains of several drug runners who have all killed each other in an exchange gone violently wrong. Rather than report the discovery to the police, Moss decides to simply take the two million dollars present for himself. This puts the psychopathic killer, Anton Chigurh (Javier Bardem), on his trail as he dispassionately murders nearly every rival, bystander and even employer in his pursuit of his quarry and the money. As Moss desperately attempts to keep one step ahead, the blood from this hunt begins to flow behind him with relentlessly growing intensity as Chigurh closes in. Meanwhile, the laconic Sheriff Ed Tom Bell (Tommy Lee Jones) blithely oversees the investigation even as he struggles to face the sheer enormity of the crimes he is attempting to thwart.", "Coen Brothers", 122, "Thriller", "https://m.media-amazon.com/images/M/MV5BMjA5Njk3MjM4OV5BMl5BanBnXkFtZTcwMTc5MTE1MQ@@._V1_FMjpg_UX555_.jpg", 8.2f, new DateOnly(2007, 11, 9), "Violence and mayhem ensue after a hunter stumbles upon the aftermath of a drug deal gone wrong and over two million dollars in cash near the Rio Grande.", "No Country for Old Men" },
                    { new Guid("cb0c0fb5-1799-4ad4-99f3-d78c0a1e21cf"), "In 2029 the mutant population has shrunk significantly due to genetically modified plants designed to reduce mutant powers and the X-Men have disbanded. Logan, whose power to self-heal is dwindling, has surrendered himself to alcohol and now earns a living as a chauffeur. He takes care of the ailing old Professor X whom he keeps hidden away. One day, a female stranger asks Logan to drive a girl named Laura to the Canadian border. At first he refuses, but the Professor has been waiting for a long time for her to appear. Laura possesses an extraordinary fighting prowess and is in many ways like Wolverine. She is pursued by sinister figures working for a powerful corporation; this is because they made her, with Logan's DNA. A decrepit Logan is forced to ask himself if he can or even wants to put his remaining powers to good use. It would appear that in the near-future, the times in which they were able put the world to rights with razor sharp claws and telepathic powers are now over.", "James Mangold", 137, "Superhero", "https://m.media-amazon.com/images/M/MV5BM2JjODdkMGMtNmY2YS00OGM2LThiY2YtZGYyNzE4Nzc2ODA0XkEyXkFqcGc@._V1_FMjpg_UX520_.jpg", 8.1f, new DateOnly(2017, 3, 3), "In a future where mutants are nearly extinct, an elderly and weary Logan leads a quiet life. But when Laura, a mutant child pursued by scientists, comes to him for help, he must get her to safety.", "Logan" },
                    { new Guid("cb8a9632-001b-464e-905c-2a0062f1bcaf"), "Harry Potter (Daniel Radcliffe) is having a tough time with his relatives (yet again). He runs away after using magic to inflate Uncle Vernon's (Richard Griffiths') sister Marge (Pam Ferris), who was being offensive towards Harry's parents. Initially scared for using magic outside the school, he is pleasantly surprised that he won't be penalized after all. However, he soon learns that a dangerous criminal and Voldemort's trusted aide Sirius Black (Gary Oldman) has escaped from Azkaban Prison and wants to kill Harry to avenge the Dark Lord. To worsen the conditions for Harry, vile creatures called Dementors are appointed to guard the school gates and inexplicably happen to have the most horrible effect on him. Little does Harry know that by the end of this year, many holes in his past (whatever he knows of it) will be filled up and he will have a clearer vision of what the future has in store.", "Alfonso Cuarón", 142, "Fantasy", "https://m.media-amazon.com/images/M/MV5BMTY4NTIwODg0N15BMl5BanBnXkFtZTcwOTc0MjEzMw@@._V1_FMjpg_UY2048_.jpg", 7.9f, new DateOnly(2004, 6, 4), "Harry Potter, Ron and Hermione return to Hogwarts School of Witchcraft and Wizardry for their third year of study, where they delve into the mystery surrounding an escaped prisoner who poses a dangerous threat to the young wizard.", "Harry Potter and the Prisoner of Azkaban" },
                    { new Guid("d04029bd-e8d4-4e65-ac84-094d766d8306"), "In 1970s San Diego, journalism was a well respected profession and people actually cared about what they saw on TV. And the top rated anchor man in the city is Ron Burgundy. He enjoys his run at the top, and has for the last five years. And his news team is equally as good as he is. Professional jock and former professional baseball player Champ Kind handles the sports, the curiously dim witted Brick Tamland - who's a few channels short of a cable subscription - handles the weather, and ladies' man Brian Fantana - whose collection of fine scents would be in the Guinness Book Of Records - handles the on-field reporting. But now all that is about to change forever. The TV station Burgundy works for, Channel 4, has embraced diversity and has hired a beautiful new female anchor named Veronica Corningstone. While Ron Burgundy and the rest of the Channel 4 news team enjoys fighting with competitors, drinking, and flirting with the ladies, Veronica quietly climbs her way to the top. And Veronica's success drives Ron Burgundy crazy. So much that Veronica's meddling causes Ron to get demoted and ultimately lose his job with Channel 6. Now left with nothing, Ron must find a way to get back to the top - and that involves a story about a rare Chinese panda giving birth on US soil. Will Ron be the one to report the story on a national level?", "Adam McKay", 94, "Comedy", "https://m.media-amazon.com/images/M/MV5BMTQ2MzYwMzk5Ml5BMl5BanBnXkFtZTcwOTI4NzUyMw@@._V1_FMjpg_UY2048_.jpg", 7.1f, new DateOnly(2004, 7, 9), "In the 1970s, an anchorman's stint as San Diego's top-rated newsreader is challenged when an ambitious newswoman becomes his co-anchor.", "Anchorman: The Legend of Ron Burgundy" },
                    { new Guid("d19b2756-5235-4f96-9577-7281f1d36d38"), "Based on Stephen King's 1996 novel of the same name. Stars Tom Hanks as a death row corrections officer during the U.S. Great Depression who witnesses supernatural events that occur after an enigmatic inmate (Michael Clarke Duncan) is brought to his facility.", "Frank Darabont", 189, "Drama", "https://m.media-amazon.com/images/M/MV5BMTUxMzQyNjA5MF5BMl5BanBnXkFtZTYwOTU2NTY3._V1_FMjpg_UX500_.jpg", 8.6f, new DateOnly(1999, 12, 10), "A death row guard learns that a gentle giant in his charge possesses a mysterious gift.", "The Green Mile" },
                    { new Guid("d5a8997f-b046-436f-aada-c06dd2ca0f1c"), "Mikael Blomkvist is a disgraced journalist who is asked by a wealthy industrialist to write a biography on his family. But what he really wants Blomkvist to do is to find out what happened to his niece, who went missing 40 years ago. At first Blomkvist isn't interested, until the man offers to help him clear his name. Blomkvist begins by talking to the man's relatives who were there when the girl went missing, but some of them are not forthcoming. Blomkvist eventually believes that her disappearance might have something to do with some serial killings that took place 20 years before she disappeared, so he asks for a research assistant. The industrialist's man suggests Lisbeth Salander, a talented hacker who does background checks for them and who even did one on Blomkvist. When he sees her report, he's impressed and asks her to work with him and she does. She's anti-social but is extremely efficient.", "David Fincher", 158, "Thriller", "https://m.media-amazon.com/images/M/MV5BMTczNDk4NTQ0OV5BMl5BanBnXkFtZTcwNDAxMDgxNw@@._V1_FMjpg_UY2048_.jpg", 7.8f, new DateOnly(2011, 12, 21), "Journalist Mikael Blomkvist is aided in his search for a woman who has been missing for 40 years by hacker Lisbeth Salander.", "The Girl with the Dragon Tattoo" },
                    { new Guid("d5e2cd4f-959d-4a19-becf-404713d46271"), "Imprisoned on the other side of the universe, the mighty Thor finds himself in a deadly gladiatorial contest that puts him against The Incredible Hulk, his former ally and fellow Avenger. Thor's quest for survival leads him in a race against time to prevent the all-powerful Hela from destroying his home world and the Asgardian civilization.", "Taika Waititi", 130, "Superhero", "https://m.media-amazon.com/images/M/MV5BMjMyNDkzMzI1OF5BMl5BanBnXkFtZTgwODcxODg5MjI@._V1_FMjpg_UY2048_.jpg", 7.9f, new DateOnly(2017, 11, 3), "Imprisoned on the planet Sakaar, Thor must race against time to return to Asgard and stop Ragnarök, the destruction of his world, at the hands of the powerful and ruthless villain Hela.", "Thor: Ragnarok" },
                    { new Guid("d6bf3fb7-df18-4e5c-bce4-1f7cf55b8848"), "With the untimely death of his beloved wife still bitter in his mouth, John Wick, the expert former assassin, receives one final gift from her--a precious keepsake to help John find a new meaning in life now that she is gone. But when the arrogant Russian mob prince, Iosef Tarasov, and his men pay Wick a rather unwelcome visit to rob him of his prized 1969 Mustang and his wife's present, the legendary hitman will be forced to unearth his meticulously concealed identity. Blind with revenge, John will immediately unleash a carefully orchestrated maelstrom of destruction against the sophisticated kingpin, Viggo Tarasov, and his family, who are fully aware of his lethal capacity. Now, only blood can quench the boogeyman's thirst for retribution.", "Chad Stahelski", 101, "Action", "https://m.media-amazon.com/images/M/MV5BMTU2NjA1ODgzMF5BMl5BanBnXkFtZTgwMTM2MTI4MjE@._V1_FMjpg_UY2048_.jpg", 7.5f, new DateOnly(2014, 10, 24), "John Wick is a former hitman grieving the loss of his true love. When his home is broken into, robbed, and his dog killed, he is forced to return to action to exact revenge.", "John Wick" },
                    { new Guid("d83ca8b1-f2da-4aa3-b5b8-a35ec94d20c4"), "Angelenos Doug Billings and Tracy Garner are about to get married. Two days before the wedding, the four men in the wedding party - Doug, Doug's two best buddies Phil Wenneck and Stu Price, and Tracy's brother Alan Garner - hop into Tracy's father's beloved Mercedes convertible for a 24-hour stag party to Las Vegas. Phil, a married high school teacher, has the same maturity level as his students when he's with his pals. Stu, a dentist, is worried about everything, especially what his controlling girlfriend Melissa thinks. Because she disapproves of traditional male bonding rituals, Stu has to lie to her about the stag, he telling her that they are going on a wine tasting tour in the Napa Valley. Regardless, he intends on eventually marrying her, against the advice and wishes of his friends. And Alan seems to be unaware of what are considered the social graces of the western world. The morning after their arrival in Las Vegas, they awaken in their hotel suite each with the worst hangover. None remembers what happened in the past twelve or so hours. The suite is in shambles. And certain things are in the suite that shouldn't be, and certain things that should be in the suite are missing. Probably the most important in the latter category is Doug. As Phil, Stu and Alan try to find Doug using only what little pieces of information they have at hand, they go on a journey of discovery of how certain things got into the suite and what happened to the missing items. However they are on a race for time as if they can't find Doug in the next few hours, they are going to have to explain to Tracy why they are not yet back in Los Angeles. And even worse, they may not find Doug at all before the wedding.", "Todd Phillips", 100, "Comedy", "https://m.media-amazon.com/images/M/MV5BYmIyODg0N2EtYjg5NC00NjdlLWFkZTgtMmE0NzI4ZGM5ODk1XkEyXkFqcGc@._V1_FMjpg_UX681_.jpg", 7.7f, new DateOnly(2009, 6, 5), "Three buddies wake up from a bachelor party in Las Vegas with no memory of the previous night and the bachelor missing. They must make their way around the city in order to find their friend in time for his wedding.", "The Hangover" },
                    { new Guid("daed155e-81be-42e0-8d7a-dc2db09eb148"), "F.B.I. trainee Clarice Starling (Jodie Foster) works hard to advance her career, while trying to hide or put behind her West Virginia roots, of which if some knew, would automatically classify her as being backward or white trash. After graduation, she aspires to work in the agency's Behavioral Science Unit under the leadership of Jack Crawford (Scott Glenn). While she is still a trainee, Crawford asks her to question Dr. Hannibal Lecter (Sir Anthony Hopkins), a psychiatrist imprisoned, thus far, for eight years in maximum security isolation for being a serial killer who cannibalized his victims. Clarice is able to figure out the assignment is to pick Lecter's brains to help them solve another serial murder case, that of someone coined by the media as \"Buffalo Bill\" (Ted Levine), who has so far killed five victims, all located in the eastern U.S., all young women, who are slightly overweight (especially around the hips), all who were drowned in natural bodies of water, and all who were stripped of large swaths of skin. She also figures that Crawford chose her, as a woman, to be able to trigger some emotional response from Lecter. After speaking to Lecter for the first time, she realizes that everything with him will be a psychological game, with her often having to read between the very cryptic lines he provides. She has to decide how much she will play along, as his request in return for talking to him is to expose herself emotionally to him. The case takes a more dire turn when a sixth victim is discovered, this one from who they are able to retrieve a key piece of evidence, if Lecter is being forthright as to its meaning. A potential seventh victim is high profile Catherine Martin (Brooke Smith), the daughter of Senator Ruth Martin (Diane Baker), which places greater scrutiny on the case as they search for a hopefully still alive Catherine. Who may factor into what happens is Dr. Frederick Chilton (Anthony Heald), the warden at the prison, an opportunist who sees the higher profile with Catherine, meaning a higher profile for himself if he can insert himself successfully into the proceedings.", "Jonathan Demme", 118, "Thriller", "https://m.media-amazon.com/images/M/MV5BNDdhOGJhYzctYzYwZC00YmI2LWI0MjctYjg4ODdlMDExYjBlXkEyXkFqcGc@._V1_FMjpg_UY2968_.jpg", 8.6f, new DateOnly(1991, 2, 14), "A young F.B.I. cadet must receive the help of an incarcerated and manipulative cannibal killer to help catch another serial killer, a madman who skins his victims.", "The Silence of the Lambs" },
                    { new Guid("e02b1783-545f-4c73-8374-768e6cfbf4c4"), "The Godfather \"Don\" Vito Corleone is the head of the Corleone mafia family in New York. He is at the event of his daughter's wedding. Michael, Vito's youngest son and a decorated WWII Marine is also present at the wedding. Michael seems to be uninterested in being a part of the family business. Vito is a powerful man, and is kind to all those who give him respect but is ruthless against those who do not. But when a powerful and treacherous rival wants to sell drugs and needs the Don's influence for the same, Vito refuses to do it. What follows is a clash between Vito's fading old values and the new ways which may cause Michael to do the thing he was most reluctant in doing and wage a mob war against all the other mafia families which could tear the Corleone family apart.", "Francis Ford Coppola", 175, "Drama", "https://m.media-amazon.com/images/M/MV5BNGEwYjgwOGQtYjg5ZS00Njc1LTk2ZGEtM2QwZWQ2NjdhZTE5XkEyXkFqcGc@._V1_FMjpg_UY1982_.jpg", 9.2f, new DateOnly(1972, 3, 24), "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", "The Godfather" },
                    { new Guid("e131229c-a516-492d-898d-635a5b6c95e4"), "In 1954, up-and-coming U.S. marshal Teddy Daniels is assigned to investigate the disappearance of a patient from Boston's Shutter Island Ashecliffe Hospital. He's been pushing for an assignment on the island for personal reasons, but before long he thinks he's been brought there as part of a twisted plot by hospital doctors whose radical treatments range from unethical to illegal to downright sinister. Teddy's shrewd investigating skills soon provide a promising lead, but the hospital refuses him access to records he suspects would break the case wide open. As a hurricane cuts off communication with the mainland, more dangerous criminals \"escape\" in the confusion, and the puzzling, improbable clues multiply, Teddy begins to doubt everything - his memory, his partner, even his own sanity.", "Martin Scorsese", 138, "Thriller", "https://m.media-amazon.com/images/M/MV5BN2FjNWExYzEtY2YzOC00YjNlLTllMTQtNmIwM2Q1YzBhOWM1XkEyXkFqcGc@._V1_FMjpg_UY3000_.jpg", 8.2f, new DateOnly(2010, 2, 19), "Two US marshals are sent to a mental institution on an inhospitable island in order to investigate the disappearance of a patient.", "Shutter Island" },
                    { new Guid("e9626460-ec88-4203-99b7-d918105fef03"), "Timid bank clerk, Stanley Ipkiss (Jim Carrey). Unfortunately, he's too gentle, and is unable to handle confrontations. After one of the worst days, he finds a mask which depicts Loki, the Norse god of mischief. When he puts it on, he becomes his inner, self: a cartoon wild man. After Ipkiss's alter ego indirectly kills the friend of small time crime boss, Dorian Tyrel (Peter Greene),he wants the green-faced goon destroyed.", "Chuck Russell", 101, "Comedy", "https://m.media-amazon.com/images/M/MV5BNGNmNjI0ZmMtMzI5MC00ZjUyLWFlZDEtYjUyMGZlN2E3N2E2XkEyXkFqcGc@._V1_FMjpg_UX1009_.jpg", 7f, new DateOnly(1994, 7, 29), "Bank clerk Stanley Ipkiss is transformed into a manic superhero when he wears a mysterious mask.", "The Mask" },
                    { new Guid("e96c3640-af75-4342-bf73-2c249993f934"), "In the distant future, the commercial spaceship \"Nostromo\" crew is on its way home when the crew picks up a distress call from a distant moon. The crew must investigate, and the spaceship descends on the small planetoid afterwards. After a rough landing, three crew members leave the spaceship to explore the area on the planetoid. At the same time, the ship's computer deciphers the message. When the crew realizes it is not alone on the spaceship, they must deal with the consequences.", "Ridley Scott", 117, "Sci-fi", "https://m.media-amazon.com/images/M/MV5BN2NhMDk2MmEtZDQzOC00MmY5LThhYzAtMDdjZGFjOGZjMjdjXkEyXkFqcGc@._V1_FMjpg_UY2225_.jpg", 8.5f, new DateOnly(1979, 5, 25), "After investigating a mysterious transmission of unknown origin, the crew of a commercial spacecraft encounters a deadly lifeform.", "Alien" },
                    { new Guid("f01bf412-3480-4c18-9b6f-418f947c1ba2"), "Thomas A. Anderson is a man living two lives. By day he is an average computer programmer and by night a hacker known as Neo. Neo has always questioned his reality, but the truth is far beyond his imagination. Neo finds himself targeted by the police when he is contacted by Morpheus, a legendary computer hacker branded a terrorist by the government. As a rebel against the machines, Neo must confront the agents: super-powerful computer programs devoted to stopping Neo and the entire human rebellion.", "The Wachowskis", 136, "Action", "https://m.media-amazon.com/images/M/MV5BZjVkOGM1ZTctZGZmOC00MTM0LWFjYjctNjg2MTg1YTM4N2VlXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", 8.7f, new DateOnly(1999, 3, 31), "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.", "The Matrix" },
                    { new Guid("f0744c2c-c60f-4ae2-9227-beb769c6bb74"), "An apocalyptic story set in the furthest reaches of our planet, in a stark desert landscape where humanity is broken, and almost everyone is crazed fighting for the necessities of life. Within this world exist two rebels on the run who just might be able to restore order. There's Max, a man of action and a man of few words, who seeks peace of mind following the loss of his wife and child in the aftermath of the chaos. And Furiosa, a woman of action and a woman who believes her path to survival may be achieved if she can make it across the desert back to her childhood homeland.", "George Miller", 120, "Action", "https://m.media-amazon.com/images/M/MV5BZDRkODJhOTgtOTc1OC00NTgzLTk4NjItNDgxZDY4YjlmNDY2XkEyXkFqcGc@._V1_FMjpg_UX675_.jpg", 8.1f, new DateOnly(2015, 5, 15), "In a post-apocalyptic wasteland, a woman rebels against a tyrannical ruler in search for her homeland with the aid of a group of female prisoners, a psychotic worshipper and a drifter named Max.", "Mad Max: Fury Road" },
                    { new Guid("f1ff0736-167e-464c-98b3-66361a5952bb"), "A nameless first-person narrator attends support groups in an attempt to subdue his emotional state and relieve his insomniac state. When he meets Marla, another fake attendee of support groups, his life seems to become a little more bearable. However, when he associates himself with Tyler he is dragged into an underground fight club and soap-making scheme. Together the two men spiral out of control and engage in competitive rivalry for love and power.", "David Fincher", 139, "Drama", "https://m.media-amazon.com/images/M/MV5BOTgyOGQ1NDItNGU3Ny00MjU3LTg2YWEtNmEyYjBiMjI1Y2M5XkEyXkFqcGc@._V1_FMjpg_UX1066_.jpg", 8.8f, new DateOnly(1999, 10, 15), "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.", "Fight Club" },
                    { new Guid("f2661055-d0cd-4e35-ada5-bd9369ecc094"), "Brimming with excitement and hope for a fresh start, Josh and Renai Lambert move into their new home with their three children. But the couple's bliss is short-lived. As a mysterious accident leaves their boy, Dalton, in a science-defying coma for months, blood-chilling occurrences in the house can only mean one thing: something evil has set its sights on robbing the Lamberts of what they hold dear. With sickness replacing happiness, experienced paranormal investigator Elise Rainier agrees to infiltrate The Further, the dark realm of lost spirits, to search for the Lamberts' missing son. However, after the life-altering experience in Insidious: The Last Key (2018), Elise is more exposed to all-consuming darkness. As answers demand courage and faith, could Dalton's shackled soul be trapped behind the ominous red-lacquered door?", "James Wan", 103, "Horror", "https://m.media-amazon.com/images/M/MV5BODNiNTM3MTMtZGRmYi00OTUxLTkxOWYtMTcxYzU1ZTdlMjIwXkEyXkFqcGc@._V1_FMjpg_UX819_.jpg", 6.8f, new DateOnly(2010, 9, 14), "A family looks to prevent evil spirits from trapping their comatose child in a realm called The Further.", "Insidious" }
                });

            migrationBuilder.InsertData(
                table: "movies_actors",
                columns: new[] { "actor_id", "movie_id", "character_name" },
                values: new object[,]
                {
                    { new Guid("32ac45d4-37c1-4f8c-9c9c-20e9cea6a21d"), new Guid("00641073-88cb-471e-bea0-8e6601494d09"), "Carter" },
                    { new Guid("846cc4c2-430e-42e8-b9a8-f3369310563a"), new Guid("00641073-88cb-471e-bea0-8e6601494d09"), "Lee" },
                    { new Guid("e337f1ec-b22c-4ddf-8b5e-bd5afa946129"), new Guid("00641073-88cb-471e-bea0-8e6601494d09"), "Consul Han" },
                    { new Guid("655b7c4a-7bde-4498-82b2-46288064039f"), new Guid("07d1c2e1-a2e2-4ee5-873f-b101cc613a25"), "Dick Hallorann" },
                    { new Guid("9186ec1d-7199-439e-b062-a103f1371d54"), new Guid("07d1c2e1-a2e2-4ee5-873f-b101cc613a25"), "Wendy Torrance" },
                    { new Guid("cf61c4ca-a860-4e52-848a-4014f336afc9"), new Guid("07d1c2e1-a2e2-4ee5-873f-b101cc613a25"), "Jack Torrance" },
                    { new Guid("1856d962-d4cb-491a-a94e-072cfa5662bd"), new Guid("12010e19-dd0f-4195-b3c6-7dc6702c8a32"), "Holly Gennaro McClane" },
                    { new Guid("a2a8ed1f-aa12-411b-a221-2d2cdd7d5f2e"), new Guid("12010e19-dd0f-4195-b3c6-7dc6702c8a32"), "Hans Gruber" },
                    { new Guid("c897ed9b-a2ac-4e31-8fa4-8c26cc33c652"), new Guid("12010e19-dd0f-4195-b3c6-7dc6702c8a32"), "John McClane" },
                    { new Guid("a5f19f18-702b-49cb-8e8a-634045a81baa"), new Guid("13f91c44-a819-49c8-8ed3-3c003171ddc3"), "Colonel Weber" },
                    { new Guid("c9ee97ea-de38-4ce6-add4-ebc54fd7d92a"), new Guid("13f91c44-a819-49c8-8ed3-3c003171ddc3"), "Louise Banks" },
                    { new Guid("ff728ce9-28c4-4e30-9e50-bd0e7fba3b39"), new Guid("13f91c44-a819-49c8-8ed3-3c003171ddc3"), "Ian Donnelly" },
                    { new Guid("0dc023ca-c84f-4c6b-a1c3-ed3ca625b7bd"), new Guid("23fb559e-9a66-4423-af07-b97d9de649fe"), "William Somerset" },
                    { new Guid("51bab7d6-b37f-40b4-b787-5f6cb30af6f4"), new Guid("23fb559e-9a66-4423-af07-b97d9de649fe"), "Tracy Mills" },
                    { new Guid("8441360b-3bb9-4f58-86c1-02dd3f04072a"), new Guid("23fb559e-9a66-4423-af07-b97d9de649fe"), "David Mills" },
                    { new Guid("1acc5129-33a7-4b35-b00b-f350c34c0b83"), new Guid("2a90d8b6-82d8-4581-9fa7-ecaa5832dc26"), "Hermione Granger" },
                    { new Guid("82d8d010-92a5-4189-b947-d56faf569ba6"), new Guid("2a90d8b6-82d8-4581-9fa7-ecaa5832dc26"), "Ron Weasley" },
                    { new Guid("950268ca-c69a-41f4-81c3-7cd61c42a9e1"), new Guid("2a90d8b6-82d8-4581-9fa7-ecaa5832dc26"), "Harry Potter" },
                    { new Guid("339a12ea-c0b1-4c15-81eb-189212eda79d"), new Guid("2fad653d-7cde-4b92-a5e8-a3928570f756"), "Ofelia" },
                    { new Guid("4f53bb1c-0f91-48bc-9876-5dfd7ab74ebb"), new Guid("2fad653d-7cde-4b92-a5e8-a3928570f756"), "Captain Vidal" },
                    { new Guid("93088ce9-c00a-4ea4-9cd6-2ac02db77c7d"), new Guid("2fad653d-7cde-4b92-a5e8-a3928570f756"), "Mercedes" },
                    { new Guid("084b109f-15d5-473a-9baa-ab748f461af5"), new Guid("34b8a65e-15f2-424a-b164-600afe23f814"), "Rose DeWitt Bukater" },
                    { new Guid("9d666c80-52f7-4e34-8871-245c0911979e"), new Guid("34b8a65e-15f2-424a-b164-600afe23f814"), "Cal Hockley" },
                    { new Guid("a5381bf5-482b-4f12-9d17-d10e8fcb6fc1"), new Guid("34b8a65e-15f2-424a-b164-600afe23f814"), "Jack Dawson" },
                    { new Guid("bec8cce9-b5a4-4a5d-8a39-ebac11c6448e"), new Guid("368e82a0-da8c-4d1b-90b0-749f12faecfa"), "Peter Graham" },
                    { new Guid("eaf447ef-beea-4eaa-a94c-00acd311ef42"), new Guid("368e82a0-da8c-4d1b-90b0-749f12faecfa"), "Charlie Graham" },
                    { new Guid("fd960aa9-8876-4dff-9d99-94c1c3738c04"), new Guid("368e82a0-da8c-4d1b-90b0-749f12faecfa"), "Annie Graham" },
                    { new Guid("12cf4f78-7a6f-4421-b158-9df0034694e1"), new Guid("377d6f6f-4aeb-4046-9ded-dfaf7e8d59a5"), "Vanessa" },
                    { new Guid("a9f10213-5b0f-42cb-b282-0daa96bb1519"), new Guid("377d6f6f-4aeb-4046-9ded-dfaf7e8d59a5"), "Ajax" },
                    { new Guid("e175c472-5291-47de-832d-003b3aa6527a"), new Guid("377d6f6f-4aeb-4046-9ded-dfaf7e8d59a5"), "Wade Wilson" },
                    { new Guid("08d54a07-c4a3-4467-8c2d-2791ccc3cb86"), new Guid("3a981e02-9650-4cc4-ba2f-978979789984"), "Thomas Leroy" },
                    { new Guid("990f0803-c80f-40cf-9d02-910e3d46a962"), new Guid("3a981e02-9650-4cc4-ba2f-978979789984"), "Lily" },
                    { new Guid("f2dfcabe-52e1-4e25-84f2-054cc9f9a772"), new Guid("3a981e02-9650-4cc4-ba2f-978979789984"), "Nina Sayers" },
                    { new Guid("b32c87ff-b412-42d3-bbc1-521841443d40"), new Guid("40009b98-ece3-42b4-8c7d-a10b4dda5b38"), "Detective Loki" },
                    { new Guid("b391372d-3bfd-48e4-be60-c343cc4b4f3f"), new Guid("40009b98-ece3-42b4-8c7d-a10b4dda5b38"), "Keller Dover" },
                    { new Guid("f3d34bfd-85e1-4dec-bc22-5f4eca6c9fc2"), new Guid("40009b98-ece3-42b4-8c7d-a10b4dda5b38"), "Alex Jones" },
                    { new Guid("138ce271-e924-4e54-930e-0d8c04d0fc77"), new Guid("43268f2d-7bfb-4c62-b49d-b868b1fc2568"), "Dean Armitage" },
                    { new Guid("e0fb708c-3052-473c-9f03-29f855010c16"), new Guid("43268f2d-7bfb-4c62-b49d-b868b1fc2568"), "Rose Armitage" },
                    { new Guid("ed9b74af-8587-4aff-abd4-8957e4eb1ca7"), new Guid("43268f2d-7bfb-4c62-b49d-b868b1fc2568"), "Chris Washington" },
                    { new Guid("13ec26d4-e9fc-4def-ae21-f93ab8d4d6b6"), new Guid("441db5ba-a442-43f9-8e18-363cf678f5d2"), "Yvaine" },
                    { new Guid("ca837102-6e0b-4bc6-a39c-d35bbc3dfa80"), new Guid("441db5ba-a442-43f9-8e18-363cf678f5d2"), "Tristan Thorn" },
                    { new Guid("dc2957ed-c6dc-40c6-8dcb-8e93bdd8ba03"), new Guid("441db5ba-a442-43f9-8e18-363cf678f5d2"), "Lamia" },
                    { new Guid("0415474f-6528-4602-9803-b387d67b5b5d"), new Guid("4ab20a27-63b5-42ee-a9de-aef4b0866153"), "Lucy Pevensie" },
                    { new Guid("1a536677-8b72-42dc-b7ec-506ab25c501f"), new Guid("4ab20a27-63b5-42ee-a9de-aef4b0866153"), "White Witch" },
                    { new Guid("3c550829-e360-4a0f-947f-b8510e01718a"), new Guid("4ab20a27-63b5-42ee-a9de-aef4b0866153"), "Mr. Tumnus" },
                    { new Guid("158a9d99-77ae-46ca-8818-65ab53540d11"), new Guid("4d91f3a2-6c96-4a58-90f7-bbea29063a5f"), "Laurie Strode" },
                    { new Guid("3b9bf0a1-5001-4946-a64f-fbfe3a6f73a1"), new Guid("4d91f3a2-6c96-4a58-90f7-bbea29063a5f"), "Dr. Sam Loomis" },
                    { new Guid("e4a264bc-0a02-4720-917c-fca59bb573ff"), new Guid("4d91f3a2-6c96-4a58-90f7-bbea29063a5f"), "The Shape" },
                    { new Guid("aec03985-5285-415c-b7c2-1245a6751576"), new Guid("4e35a624-d5db-4900-b43e-c0f9b7d28590"), "Marv" },
                    { new Guid("d70a393d-94ed-424f-ad8f-b0a041617c52"), new Guid("4e35a624-d5db-4900-b43e-c0f9b7d28590"), "Harry" },
                    { new Guid("fed28090-372d-456f-9a1e-c207058ac144"), new Guid("4e35a624-d5db-4900-b43e-c0f9b7d28590"), "Kevin McCallister" },
                    { new Guid("25538521-d4f1-4ca8-ba20-1628c98b6930"), new Guid("50219472-6180-4b85-a5ac-fdf4079ccf58"), "Amy Dunne" },
                    { new Guid("310706f7-2d9a-4e5a-8e2f-5214084fd26d"), new Guid("50219472-6180-4b85-a5ac-fdf4079ccf58"), "Nick Dunne" },
                    { new Guid("545d9868-b224-46c4-9b60-21271dc2adc2"), new Guid("50219472-6180-4b85-a5ac-fdf4079ccf58"), "Desi Collings" },
                    { new Guid("bc65dca2-6946-4eeb-841d-add7c0fd0376"), new Guid("512d850d-0dad-429a-a2f8-5a492651e8d5"), "Bane" },
                    { new Guid("cac1fee0-fd3a-47f8-b629-cb9b65d68b2c"), new Guid("512d850d-0dad-429a-a2f8-5a492651e8d5"), "Selina" },
                    { new Guid("d1bdcd3f-a8be-4044-96b4-26a0745585e9"), new Guid("512d850d-0dad-429a-a2f8-5a492651e8d5"), "Bruce Wayne" },
                    { new Guid("6547e436-757f-4cb1-a179-f337b0922121"), new Guid("5247d8b6-6f31-4995-86c9-4196332328a0"), "Ethan Hunt" },
                    { new Guid("70705055-5ce6-4a88-a3ba-5e031ae9b786"), new Guid("5247d8b6-6f31-4995-86c9-4196332328a0"), "Ilsa Faust" },
                    { new Guid("cee50ddf-38c4-40fb-91a3-02bfc7bee4aa"), new Guid("5247d8b6-6f31-4995-86c9-4196332328a0"), "August Walker" },
                    { new Guid("01258edc-1458-4035-af5c-19fde8c99a1d"), new Guid("59d62ca3-2be7-4ef6-bfbc-362b4ff49fac"), "Nakia" },
                    { new Guid("447f0422-0955-41e1-9b47-f2b09a8a474c"), new Guid("59d62ca3-2be7-4ef6-bfbc-362b4ff49fac"), "T'Challa" },
                    { new Guid("5b20c518-2ac0-4dbb-9e2f-db4d9f0bb879"), new Guid("59d62ca3-2be7-4ef6-bfbc-362b4ff49fac"), "Killmonger" },
                    { new Guid("2c4f6a03-d0b1-4e0e-8e5a-d824d9ffa7c7"), new Guid("5b248551-840b-4632-8aaf-3e1b16252d65"), "Teddy Sanders" },
                    { new Guid("40f67ef1-8703-42e9-94af-f65e1a2ef186"), new Guid("5b248551-840b-4632-8aaf-3e1b16252d65"), "Melissa Lewis" },
                    { new Guid("bdb9ef82-f830-4d22-96ea-7128d9fd92b7"), new Guid("5b248551-840b-4632-8aaf-3e1b16252d65"), "Mark Watney" },
                    { new Guid("26d5c98a-347d-49b0-9268-2029a7f0ee98"), new Guid("5c3f62e1-a6ca-4286-9cb3-5cbc0afc3d8b"), "Peter Quill" },
                    { new Guid("a7c020f2-1864-4e0a-98a5-4d3b03f6eee7"), new Guid("5c3f62e1-a6ca-4286-9cb3-5cbc0afc3d8b"), "Gamora" },
                    { new Guid("bfad936e-bf67-4b44-8a27-88606204e79e"), new Guid("5c3f62e1-a6ca-4286-9cb3-5cbc0afc3d8b"), "Drax" },
                    { new Guid("453399e4-7c51-46d3-aeae-99eb8f06fef9"), new Guid("614bf670-e4d2-4b35-a208-c84a6c75c764"), "Sarah Connor" },
                    { new Guid("bfc71005-46f5-4f0e-a05d-eb99293367d5"), new Guid("614bf670-e4d2-4b35-a208-c84a6c75c764"), "John Connor" },
                    { new Guid("d85eed69-92c7-4bcb-b978-9c2179a19f6c"), new Guid("614bf670-e4d2-4b35-a208-c84a6c75c764"), "The Terminator" },
                    { new Guid("5f3878b6-e371-4be2-afcb-10906290b75a"), new Guid("623d306a-95f7-48f7-9f09-aa298685ac3b"), "Captain Jack Sparrow" },
                    { new Guid("858afe84-3e5a-451b-bd2d-eda7f38e8467"), new Guid("623d306a-95f7-48f7-9f09-aa298685ac3b"), "Elizabeth Swann" },
                    { new Guid("e2100a6d-cc7d-47c9-9927-72082d1b3843"), new Guid("623d306a-95f7-48f7-9f09-aa298685ac3b"), "Will Turner" },
                    { new Guid("36e4bf12-895e-44a2-b635-e9e7930c0997"), new Guid("63c3517c-d626-4181-a444-0adeeb056878"), "Rick Deckard" },
                    { new Guid("b479a3b8-5eba-43f0-a77c-797fc760ab1f"), new Guid("63c3517c-d626-4181-a444-0adeeb056878"), "K" },
                    { new Guid("dae9df12-f329-45e4-b256-a7e9646e838d"), new Guid("63c3517c-d626-4181-a444-0adeeb056878"), "Joi" },
                    { new Guid("a1c457e5-d6b5-4fce-81a1-e570ebca481a"), new Guid("66275523-30e6-48e0-8c65-dab3d3fb12f8"), "Brennan Huff" },
                    { new Guid("d31a1794-c533-4a9a-85a9-d90e3390c8dd"), new Guid("66275523-30e6-48e0-8c65-dab3d3fb12f8"), "Nancy Huff" },
                    { new Guid("e1d47d6f-e0e3-4214-b4f7-21b37d6db88d"), new Guid("66275523-30e6-48e0-8c65-dab3d3fb12f8"), "Dale Doback" },
                    { new Guid("00cdc0aa-e696-4628-b8cc-ec84f4a6dc06"), new Guid("6851194f-61a0-4df1-8e89-2030ca47fe24"), "Cooper" },
                    { new Guid("40f67ef1-8703-42e9-94af-f65e1a2ef186"), new Guid("6851194f-61a0-4df1-8e89-2030ca47fe24"), "Murph" },
                    { new Guid("cac1fee0-fd3a-47f8-b629-cb9b65d68b2c"), new Guid("6851194f-61a0-4df1-8e89-2030ca47fe24"), "Brand" },
                    { new Guid("84982976-ae90-4237-9520-d6239df1458d"), new Guid("69941e20-653e-4ddf-a9ef-7a98f601ba61"), "Cady Heron" },
                    { new Guid("9af1c7b4-2511-48e0-8868-fc0dab590d71"), new Guid("69941e20-653e-4ddf-a9ef-7a98f601ba61"), "Regina George" },
                    { new Guid("f3b65829-46e4-4143-b39b-86136de26b7f"), new Guid("69941e20-653e-4ddf-a9ef-7a98f601ba61"), "Karen Smith" },
                    { new Guid("1a536677-8b72-42dc-b7ec-506ab25c501f"), new Guid("6ea110b0-5980-49ec-9812-bdc05ca854be"), "The Ancient One" },
                    { new Guid("bb729c83-9964-434b-97b7-66c7665aa3da"), new Guid("6ea110b0-5980-49ec-9812-bdc05ca854be"), "Mordo" },
                    { new Guid("bbf4da5f-54e3-4659-b179-978e5f6ab285"), new Guid("6ea110b0-5980-49ec-9812-bdc05ca854be"), "Dr. Stephen Strange" },
                    { new Guid("50cafa2b-71bd-4ea8-8eb0-a5ee95eff467"), new Guid("6f6779da-99ae-44d9-a61a-43ebe5f0fd77"), "Joker" },
                    { new Guid("6fd39241-45d7-4435-beeb-6ef22cc912de"), new Guid("6f6779da-99ae-44d9-a61a-43ebe5f0fd77"), "Harvey Dent" },
                    { new Guid("d1bdcd3f-a8be-4044-96b4-26a0745585e9"), new Guid("6f6779da-99ae-44d9-a61a-43ebe5f0fd77"), "Bruce Wayne" },
                    { new Guid("468fc8fc-00b2-4740-b025-f465bc99c283"), new Guid("700ebda0-232e-4b1c-9be2-bf6a99893d6d"), "Wikus van de Merwe" },
                    { new Guid("480a5aa3-2618-4777-8d6c-764b0bac7a6b"), new Guid("700ebda0-232e-4b1c-9be2-bf6a99893d6d"), "Christopher Johnson" },
                    { new Guid("7c412653-3c11-4b3a-8118-22a6c219f54c"), new Guid("700ebda0-232e-4b1c-9be2-bf6a99893d6d"), "Koobus Venter" },
                    { new Guid("179a8c49-2ace-4cc3-bef6-0d76f135c1ec"), new Guid("70a5373e-e526-4766-9194-e6d1a536485c"), "Lorraine Warren" },
                    { new Guid("2f276480-e052-4120-85d6-7f5fb2a0141f"), new Guid("70a5373e-e526-4766-9194-e6d1a536485c"), "Ed Warren" },
                    { new Guid("95ce32f0-7a46-4e31-8459-cd6ee973dba9"), new Guid("70a5373e-e526-4766-9194-e6d1a536485c"), "Carolyn Perron" },
                    { new Guid("2f5d38f8-9375-4e62-bde1-801bc44f2908"), new Guid("75a766dd-73cd-4a3b-81ef-738e4b72a23d"), "Obadiah Stane" },
                    { new Guid("51bab7d6-b37f-40b4-b787-5f6cb30af6f4"), new Guid("75a766dd-73cd-4a3b-81ef-738e4b72a23d"), "Pepper Potts" },
                    { new Guid("d875ff93-4c8d-4470-9c2e-66209c6d63f2"), new Guid("75a766dd-73cd-4a3b-81ef-738e4b72a23d"), "Tony Stark" },
                    { new Guid("00085ee6-52df-4585-967b-408c7ba486be"), new Guid("78e7000a-1425-4340-938a-cf4a5bac6775"), "James Bond" },
                    { new Guid("086a28bc-461c-4360-90e6-d34634bc7930"), new Guid("78e7000a-1425-4340-938a-cf4a5bac6775"), "Le Chiffre" },
                    { new Guid("c7483292-2173-429e-bf47-be27c5dc820b"), new Guid("78e7000a-1425-4340-938a-cf4a5bac6775"), "Vesper Lynd" },
                    { new Guid("8ba7acf6-a509-48fe-92c0-c8c0528569fd"), new Guid("794c142d-386f-4a8a-8290-adf396a07f6a"), "Rick" },
                    { new Guid("9c39c7a7-3897-494b-a8b5-970dd50d88b6"), new Guid("794c142d-386f-4a8a-8290-adf396a07f6a"), "Nina Romina" },
                    { new Guid("b32c87ff-b412-42d3-bbc1-521841443d40"), new Guid("794c142d-386f-4a8a-8290-adf396a07f6a"), "Louis Bloom" },
                    { new Guid("09ad1d06-e8a1-406e-890b-d744e67ffa76"), new Guid("7c1f4dea-492d-446f-ba11-aa0794b54350"), "Murray Franklin" },
                    { new Guid("176400ce-53cf-4576-a2ed-432f78a43240"), new Guid("7c1f4dea-492d-446f-ba11-aa0794b54350"), "Arthur Fleck" },
                    { new Guid("dc4a4b36-d647-43f9-b215-1a6024cc712f"), new Guid("7c1f4dea-492d-446f-ba11-aa0794b54350"), "Sophie Dumond" },
                    { new Guid("1cea7dbe-d8be-44bc-bdcc-2ebfa35e8c9f"), new Guid("7c9e4721-3564-4a95-952b-37e8a5eff337"), "Noah Clay" },
                    { new Guid("afaa9921-7f23-482b-b344-19e43274db30"), new Guid("7c9e4721-3564-4a95-952b-37e8a5eff337"), "Aidan Keller" },
                    { new Guid("baf8a9c9-d344-4e6f-b802-a85dad91ffb9"), new Guid("7c9e4721-3564-4a95-952b-37e8a5eff337"), "Rachel Keller" },
                    { new Guid("29ac4686-bfcd-49dc-8646-876522ab6472"), new Guid("86e3b9d0-b465-4b7e-95a4-f1da2a66ada2"), "William Parcher" },
                    { new Guid("5d7cdba3-e8dc-4f19-a8a3-8992aec07fae"), new Guid("86e3b9d0-b465-4b7e-95a4-f1da2a66ada2"), "John Nash" },
                    { new Guid("b30648a8-3bfe-43be-bc09-65caf669fb09"), new Guid("86e3b9d0-b465-4b7e-95a4-f1da2a66ada2"), "Alicia Nash" },
                    { new Guid("4b7fe159-069a-4c8f-8bd3-09ed79a4c5ae"), new Guid("885e7b27-c1c2-4ab8-8a6c-f676ecec60df"), "Frodo Baggins" },
                    { new Guid("d1fb6849-f352-4e51-a01c-e98b0f67fc40"), new Guid("885e7b27-c1c2-4ab8-8a6c-f676ecec60df"), "Aragorn" },
                    { new Guid("f03b85c5-d584-4d0b-8d38-d7356f469375"), new Guid("885e7b27-c1c2-4ab8-8a6c-f676ecec60df"), "Gandalf" },
                    { new Guid("2bb629f1-e03a-4c92-b265-6ba6f3674026"), new Guid("88b25038-308e-4253-82c0-4a57151ad908"), "Ava" },
                    { new Guid("879fffcf-e8fe-4a4a-bab5-da42fc4d1256"), new Guid("88b25038-308e-4253-82c0-4a57151ad908"), "Caleb Smith" },
                    { new Guid("ea2f8e0d-eb55-4452-90a1-f810474cbe7f"), new Guid("88b25038-308e-4253-82c0-4a57151ad908"), "Nathan Bateman" },
                    { new Guid("263f806e-5bb0-4cc5-bdc1-a6130e3a6ae7"), new Guid("91e01bcd-a47d-48d9-b79d-8ed6c4886699"), "Sean Parker" },
                    { new Guid("44907d33-053a-47f7-ac1b-a2fddbbea5cc"), new Guid("91e01bcd-a47d-48d9-b79d-8ed6c4886699"), "Mark Zuckerberg" },
                    { new Guid("8d806e2a-9b9e-407e-bfde-d95afc6f0c04"), new Guid("91e01bcd-a47d-48d9-b79d-8ed6c4886699"), "Eduardo Saverin" },
                    { new Guid("925ac384-48c7-4eac-96fd-36bf2b9f6bd4"), new Guid("93d7a78d-d7aa-43d0-8d7d-91a22b7c7619"), "Steve Rogers" },
                    { new Guid("d875ff93-4c8d-4470-9c2e-66209c6d63f2"), new Guid("93d7a78d-d7aa-43d0-8d7d-91a22b7c7619"), "Tony Stark" },
                    { new Guid("dfe14619-506f-4f09-9a8e-8bf0fdaa4e83"), new Guid("93d7a78d-d7aa-43d0-8d7d-91a22b7c7619"), "Natasha Romanoff" },
                    { new Guid("0863f099-87d9-4590-8a19-083384c1aa91"), new Guid("97448f10-b164-4880-82ed-a1ac239d0afd"), "Andrew Neiman" },
                    { new Guid("34ed4fe5-d30b-4edc-a00f-f75f019d46a3"), new Guid("97448f10-b164-4880-82ed-a1ac239d0afd"), "Terence Fletcher" },
                    { new Guid("3c328dc2-54a1-4a48-8962-6e7f903f2162"), new Guid("97448f10-b164-4880-82ed-a1ac239d0afd"), "Jim Neiman" },
                    { new Guid("50e895bc-e9e1-445b-a99c-6615bd33437a"), new Guid("97951c83-8686-45c8-be13-a0b0f79539a5"), "Peter Parker" },
                    { new Guid("7c144da1-9cb5-498f-9f04-8d6d5418455e"), new Guid("97951c83-8686-45c8-be13-a0b0f79539a5"), "MJ" },
                    { new Guid("bbf4da5f-54e3-4659-b179-978e5f6ab285"), new Guid("97951c83-8686-45c8-be13-a0b0f79539a5"), "Doctor Strange" },
                    { new Guid("96c08023-9ed3-46dd-a016-facb34a4bef9"), new Guid("9d0944ab-9bfa-4345-8ee6-6f52787b19c4"), "Bilbo Baggins" },
                    { new Guid("f03b85c5-d584-4d0b-8d38-d7356f469375"), new Guid("9d0944ab-9bfa-4345-8ee6-6f52787b19c4"), "Gandalf" },
                    { new Guid("f5faf27e-6f57-4035-a94e-1055cd927ed1"), new Guid("9d0944ab-9bfa-4345-8ee6-6f52787b19c4"), "Thorin Oakenshield" },
                    { new Guid("2c4f6a03-d0b1-4e0e-8e5a-d824d9ffa7c7"), new Guid("9d52bd23-4ee9-499d-8789-0d860eef65a3"), "Harry Dunne" },
                    { new Guid("362cae35-adc0-4ad9-8ff5-8a6603edf315"), new Guid("9d52bd23-4ee9-499d-8789-0d860eef65a3"), "Lloyd Christmas" },
                    { new Guid("bf824b1f-8c4d-4be3-9566-dee5b7e512b0"), new Guid("9d52bd23-4ee9-499d-8789-0d860eef65a3"), "Mary Swanson" },
                    { new Guid("18638236-cb2e-4892-befc-cf0068444068"), new Guid("9dcd678b-7dee-47d1-aff7-567156607a86"), "Inspector David Toschi" },
                    { new Guid("b32c87ff-b412-42d3-bbc1-521841443d40"), new Guid("9dcd678b-7dee-47d1-aff7-567156607a86"), "Robert Graysmith" },
                    { new Guid("d875ff93-4c8d-4470-9c2e-66209c6d63f2"), new Guid("9dcd678b-7dee-47d1-aff7-567156607a86"), "Paul Avery" },
                    { new Guid("09b7ed63-7445-4c20-b6cf-271ddb9e4c96"), new Guid("9e1126ac-ddca-4012-9204-8d0480e417d1"), "Arthur" },
                    { new Guid("59d617f1-c06c-4dd0-8b8b-ad0fd2615135"), new Guid("9e1126ac-ddca-4012-9204-8d0480e417d1"), "Ariadne" },
                    { new Guid("a5381bf5-482b-4f12-9d17-d10e8fcb6fc1"), new Guid("9e1126ac-ddca-4012-9204-8d0480e417d1"), "Cobb" },
                    { new Guid("1b39c2ef-208c-4e08-b668-a533d279d528"), new Guid("a4a49163-f174-4a42-9f88-1f1b30325ef5"), "Ripley" },
                    { new Guid("a8360aca-2aa9-49da-925b-af9deaa40978"), new Guid("a4a49163-f174-4a42-9f88-1f1b30325ef5"), "Newt" },
                    { new Guid("c55c41c7-9a4d-40d2-b2fc-57eb139bf902"), new Guid("a4a49163-f174-4a42-9f88-1f1b30325ef5"), "Corporal Hicks" },
                    { new Guid("176400ce-53cf-4576-a2ed-432f78a43240"), new Guid("a6600fb9-7a83-44fa-827e-03dd66e62e9a"), "Commodus" },
                    { new Guid("5d7cdba3-e8dc-4f19-a8a3-8992aec07fae"), new Guid("a6600fb9-7a83-44fa-827e-03dd66e62e9a"), "Maximus" },
                    { new Guid("ceaeb56b-d490-44c9-961c-06e8af100ba6"), new Guid("a6600fb9-7a83-44fa-827e-03dd66e62e9a"), "Lucilla" },
                    { new Guid("0a1a093a-54e3-454d-86f9-73523144b49d"), new Guid("a7061bb8-f59a-4ab7-ad3c-dce86b7ccbdc"), "Evan" },
                    { new Guid("1251c5c5-0fdd-40c1-89d7-0e10b338300c"), new Guid("a7061bb8-f59a-4ab7-ad3c-dce86b7ccbdc"), "Seth" },
                    { new Guid("be6e3a70-0dd5-4da8-8534-4a208c09a614"), new Guid("a7061bb8-f59a-4ab7-ad3c-dce86b7ccbdc"), "Fogell" },
                    { new Guid("0dd7a860-af97-4fe5-86ca-d7b6a171e506"), new Guid("a7b10c31-a060-4436-bef3-4b08014e794e"), "Dilios" },
                    { new Guid("101916e7-e588-499f-829a-daa2793c23e8"), new Guid("a7b10c31-a060-4436-bef3-4b08014e794e"), "King Leonidas" },
                    { new Guid("3998723a-ebb9-4e63-a96b-8575e5345e5b"), new Guid("a7b10c31-a060-4436-bef3-4b08014e794e"), "Queen Gorgo" },
                    { new Guid("3de01bc3-0480-4a01-8593-ddfb1849ff9b"), new Guid("acc9eaf0-be41-4f4c-a4f2-4bee8da3e4a0"), "Nancy Thompson" },
                    { new Guid("65970305-4fc7-4890-9f0b-5063affce076"), new Guid("acc9eaf0-be41-4f4c-a4f2-4bee8da3e4a0"), "Lt. Donald Thompson" },
                    { new Guid("bc2dd711-8eac-439d-9353-dd355849ed8e"), new Guid("acc9eaf0-be41-4f4c-a4f2-4bee8da3e4a0"), "Freddy Krueger" },
                    { new Guid("3dacabea-76fa-48d7-8b12-4095bacbd787"), new Guid("af12ea31-878c-43ce-95ac-bb3d54f277f4"), "Jasper" },
                    { new Guid("d9963534-1f06-4a69-bf13-8e735e7c9e9f"), new Guid("af12ea31-878c-43ce-95ac-bb3d54f277f4"), "Theo Faron" },
                    { new Guid("f0c4a679-e5fd-4329-811c-0735cff97711"), new Guid("af12ea31-878c-43ce-95ac-bb3d54f277f4"), "Julian" },
                    { new Guid("0dc023ca-c84f-4c6b-a1c3-ed3ca625b7bd"), new Guid("b0e94565-1376-46f0-b5c4-2aedc6d30ce7"), "God" },
                    { new Guid("362cae35-adc0-4ad9-8ff5-8a6603edf315"), new Guid("b0e94565-1376-46f0-b5c4-2aedc6d30ce7"), "Bruce Nolan" },
                    { new Guid("bd607b66-67f7-4fa5-8798-56fecc7d83e8"), new Guid("b0e94565-1376-46f0-b5c4-2aedc6d30ce7"), "Grace Connelly" },
                    { new Guid("1c76e80e-212e-49c2-bb82-d3cb7bb8a9ca"), new Guid("b235003d-d473-464d-a300-7049e31d0a6d"), "Bill Denbrough" },
                    { new Guid("8904c86f-88c7-4575-9c5a-70d83a4a53db"), new Guid("b235003d-d473-464d-a300-7049e31d0a6d"), "Beverly Marsh" },
                    { new Guid("f42cbe69-d1a1-45bd-9a93-8aaa606744ca"), new Guid("b235003d-d473-464d-a300-7049e31d0a6d"), "Pennywise" },
                    { new Guid("4b7fe159-069a-4c8f-8bd3-09ed79a4c5ae"), new Guid("bd56340e-eea7-4e83-9b69-6ede4a939bd8"), "Frodo Baggins" },
                    { new Guid("b96f5e3e-e5c2-4005-93ba-14a6db7078b9"), new Guid("bd56340e-eea7-4e83-9b69-6ede4a939bd8"), "Samwise Gamgee" },
                    { new Guid("d1fb6849-f352-4e51-a01c-e98b0f67fc40"), new Guid("bd56340e-eea7-4e83-9b69-6ede4a939bd8"), "Aragorn" },
                    { new Guid("0dc023ca-c84f-4c6b-a1c3-ed3ca625b7bd"), new Guid("c2159ffd-c180-4a04-8499-62c1886a4ac9"), "Ellis Boyd 'Red' Redding" },
                    { new Guid("12b4e8b1-deee-4931-baa3-bc4d5f3efb9b"), new Guid("c2159ffd-c180-4a04-8499-62c1886a4ac9"), "Andy Dufresne" },
                    { new Guid("5429c902-48d3-4dec-beac-49f37ff0b08d"), new Guid("c2159ffd-c180-4a04-8499-62c1886a4ac9"), "Warden Norton" },
                    { new Guid("1d4c8ea4-7f11-453b-8be8-e2218e767055"), new Guid("c441109b-5d90-4b44-847f-ec113694e334"), "Lieutenant Dan Taylor" },
                    { new Guid("ad15e2ca-4491-413c-a95b-8b2cc8935c4c"), new Guid("c441109b-5d90-4b44-847f-ec113694e334"), "Forrest Gump" },
                    { new Guid("ba291cbf-a1f6-4a18-bfa8-fb2a3c299e6f"), new Guid("c441109b-5d90-4b44-847f-ec113694e334"), "Jenny Curran" },
                    { new Guid("15aa84fd-f77a-483b-9499-7efa823c269c"), new Guid("c4987c3e-6ee2-49f5-8caa-bb515b019e8b"), "Chris MacNeil" },
                    { new Guid("76039504-7ee7-4356-a79d-161486a5b162"), new Guid("c4987c3e-6ee2-49f5-8caa-bb515b019e8b"), "Regan" },
                    { new Guid("b6564219-9a09-4767-b494-e9fd622084b0"), new Guid("c4987c3e-6ee2-49f5-8caa-bb515b019e8b"), "Father Merrin" },
                    { new Guid("4b7fe159-069a-4c8f-8bd3-09ed79a4c5ae"), new Guid("c6c210c2-c80b-474e-9d97-2751200097ae"), "Frodo Baggins" },
                    { new Guid("d1fb6849-f352-4e51-a01c-e98b0f67fc40"), new Guid("c6c210c2-c80b-474e-9d97-2751200097ae"), "Aragorn" },
                    { new Guid("f03b85c5-d584-4d0b-8d38-d7356f469375"), new Guid("c6c210c2-c80b-474e-9d97-2751200097ae"), "Gandalf" },
                    { new Guid("556360a7-3f73-48c6-b971-52ff34371b93"), new Guid("c6d7d61d-0ab2-4789-85fe-053e438cfe2a"), "Ed Tom Bell" },
                    { new Guid("9af80152-7958-47f9-8f8a-b1394b62bc12"), new Guid("c6d7d61d-0ab2-4789-85fe-053e438cfe2a"), "Anton Chigurh" },
                    { new Guid("9ff68d83-fc39-4081-ae3f-06ef755711d3"), new Guid("c6d7d61d-0ab2-4789-85fe-053e438cfe2a"), "Llewelyn Moss" },
                    { new Guid("8044275d-432e-4e99-a403-bc47b7208011"), new Guid("cb0c0fb5-1799-4ad4-99f3-d78c0a1e21cf"), "Charles" },
                    { new Guid("b391372d-3bfd-48e4-be60-c343cc4b4f3f"), new Guid("cb0c0fb5-1799-4ad4-99f3-d78c0a1e21cf"), "Logan" },
                    { new Guid("b6a14c4f-815e-4be4-b6b3-b69717718c8d"), new Guid("cb0c0fb5-1799-4ad4-99f3-d78c0a1e21cf"), "Laura" },
                    { new Guid("1acc5129-33a7-4b35-b00b-f350c34c0b83"), new Guid("cb8a9632-001b-464e-905c-2a0062f1bcaf"), "Hermione Granger" },
                    { new Guid("950268ca-c69a-41f4-81c3-7cd61c42a9e1"), new Guid("cb8a9632-001b-464e-905c-2a0062f1bcaf"), "Harry Potter" },
                    { new Guid("95a09f9f-98a1-4a0b-a409-6a357ceb9930"), new Guid("cb8a9632-001b-464e-905c-2a0062f1bcaf"), "Sirius Black" },
                    { new Guid("10ba4f1b-fb6f-4040-a38a-1de45d9d7605"), new Guid("d04029bd-e8d4-4e65-ac84-094d766d8306"), "Brick Tamland" },
                    { new Guid("8b3378bc-3e09-4921-9466-7bf8b3108211"), new Guid("d04029bd-e8d4-4e65-ac84-094d766d8306"), "Veronica Corningstone" },
                    { new Guid("a1c457e5-d6b5-4fce-81a1-e570ebca481a"), new Guid("d04029bd-e8d4-4e65-ac84-094d766d8306"), "Ron Burgundy" },
                    { new Guid("29843c4b-6c08-4a57-9b36-95264eba65bd"), new Guid("d19b2756-5235-4f96-9577-7281f1d36d38"), "Brutus 'Brutal' Howell" },
                    { new Guid("61cfb611-b7b6-4a63-8edc-7183a7a2dc35"), new Guid("d19b2756-5235-4f96-9577-7281f1d36d38"), "John Coffey" },
                    { new Guid("ad15e2ca-4491-413c-a95b-8b2cc8935c4c"), new Guid("d19b2756-5235-4f96-9577-7281f1d36d38"), "Paul Edgecomb" },
                    { new Guid("00085ee6-52df-4585-967b-408c7ba486be"), new Guid("d5a8997f-b046-436f-aada-c06dd2ca0f1c"), "Mikael Blomkvist" },
                    { new Guid("57ad6e92-9f65-4871-b922-11600447149c"), new Guid("d5a8997f-b046-436f-aada-c06dd2ca0f1c"), "Lisbeth Salander" },
                    { new Guid("f8124011-adb0-4454-9da7-91f0e182fa33"), new Guid("d5a8997f-b046-436f-aada-c06dd2ca0f1c"), "Henrik Vanger" },
                    { new Guid("1f7c2d4c-cfb4-47ca-ba0e-575c6e5b1ae2"), new Guid("d5e2cd4f-959d-4a19-becf-404713d46271"), "Loki" },
                    { new Guid("2e7678ba-e51a-402a-ae90-6585b837ea90"), new Guid("d5e2cd4f-959d-4a19-becf-404713d46271"), "Thor" },
                    { new Guid("3fa7c993-1327-4a37-87f6-0020d90dbfea"), new Guid("d5e2cd4f-959d-4a19-becf-404713d46271"), "Hela" },
                    { new Guid("43c89467-ac0e-4e79-9f8e-929848c36d6a"), new Guid("d6bf3fb7-df18-4e5c-bce4-1f7cf55b8848"), "Iosef Tarasov" },
                    { new Guid("64ea884a-b2a5-46ae-9532-ce5d559ead97"), new Guid("d6bf3fb7-df18-4e5c-bce4-1f7cf55b8848"), "Viggo Tarasov" },
                    { new Guid("cda5b584-c19f-48e5-9e4b-787bbbd441ff"), new Guid("d6bf3fb7-df18-4e5c-bce4-1f7cf55b8848"), "Winston" },
                    { new Guid("d246a339-8c96-4ee4-9377-c6110d1ebaef"), new Guid("d6bf3fb7-df18-4e5c-bce4-1f7cf55b8848"), "John Wick" },
                    { new Guid("0f0f48ae-983b-48b1-a574-a8dc4f6ace0b"), new Guid("d83ca8b1-f2da-4aa3-b5b8-a35ec94d20c4"), "Alan Garner" },
                    { new Guid("483c83dc-0645-46ea-80a7-2f227b5f80cf"), new Guid("d83ca8b1-f2da-4aa3-b5b8-a35ec94d20c4"), "Stu Price" },
                    { new Guid("f9e3238a-97a1-4718-ab92-31d5236547b3"), new Guid("d83ca8b1-f2da-4aa3-b5b8-a35ec94d20c4"), "Phil Wenneck" },
                    { new Guid("0f312b1b-a6cd-4ed2-afe9-6b493205c424"), new Guid("daed155e-81be-42e0-8d7a-dc2db09eb148"), "Dr. Hannibal Lecter" },
                    { new Guid("d1c69566-30fd-47b2-9128-b7aadd4722a1"), new Guid("daed155e-81be-42e0-8d7a-dc2db09eb148"), "Clarice Starling" },
                    { new Guid("fcece400-14b5-481a-b5d7-fe67bf28f913"), new Guid("daed155e-81be-42e0-8d7a-dc2db09eb148"), "Jack Crawford" },
                    { new Guid("38ebb771-b41b-43c4-ae42-d5da412e04d9"), new Guid("e02b1783-545f-4c73-8374-768e6cfbf4c4"), "Don Vito Corleone" },
                    { new Guid("4123086b-dc4f-4e51-81fa-f64a6fc7f7bd"), new Guid("e02b1783-545f-4c73-8374-768e6cfbf4c4"), "Michael Corleone" },
                    { new Guid("cfde46c5-342f-4560-85d2-493f082e0a01"), new Guid("e02b1783-545f-4c73-8374-768e6cfbf4c4"), "Sonny Corleone" },
                    { new Guid("18638236-cb2e-4892-befc-cf0068444068"), new Guid("e131229c-a516-492d-898d-635a5b6c95e4"), "Chuck Aule" },
                    { new Guid("a5381bf5-482b-4f12-9d17-d10e8fcb6fc1"), new Guid("e131229c-a516-492d-898d-635a5b6c95e4"), "Teddy Daniels" },
                    { new Guid("de41865b-5b44-43f7-9275-495898638232"), new Guid("e131229c-a516-492d-898d-635a5b6c95e4"), "Dr. Cawley" },
                    { new Guid("362cae35-adc0-4ad9-8ff5-8a6603edf315"), new Guid("e9626460-ec88-4203-99b7-d918105fef03"), "Stanley Ipkiss" },
                    { new Guid("411fdf1d-ff3a-490c-86ac-ef8252b5c0fa"), new Guid("e9626460-ec88-4203-99b7-d918105fef03"), "Tina Carlyle" },
                    { new Guid("ef1f2981-782a-40c7-b0dc-5e6a85bb7055"), new Guid("e9626460-ec88-4203-99b7-d918105fef03"), "Lt. Kellaway" },
                    { new Guid("1b39c2ef-208c-4e08-b668-a533d279d528"), new Guid("e96c3640-af75-4342-bf73-2c249993f934"), "Ripley" },
                    { new Guid("a41a0cad-77db-47cc-a5a0-0d57342a9b65"), new Guid("e96c3640-af75-4342-bf73-2c249993f934"), "Dallas" },
                    { new Guid("c3891de0-0cda-41bc-a2ae-e957df3d0f1a"), new Guid("e96c3640-af75-4342-bf73-2c249993f934"), "Kane" },
                    { new Guid("8dcde184-4ee9-4ac3-8a01-e8827834d161"), new Guid("f01bf412-3480-4c18-9b6f-418f947c1ba2"), "Trinity" },
                    { new Guid("d246a339-8c96-4ee4-9377-c6110d1ebaef"), new Guid("f01bf412-3480-4c18-9b6f-418f947c1ba2"), "Neo" },
                    { new Guid("f80c0da1-8be6-4a46-a578-edfce3af270d"), new Guid("f01bf412-3480-4c18-9b6f-418f947c1ba2"), "Morpheus" },
                    { new Guid("af0ea72b-6f8f-4db0-afa7-2ea8c7859c30"), new Guid("f0744c2c-c60f-4ae2-9227-beb769c6bb74"), "Nux" },
                    { new Guid("bc65dca2-6946-4eeb-841d-add7c0fd0376"), new Guid("f0744c2c-c60f-4ae2-9227-beb769c6bb74"), "Max Rockatansky" },
                    { new Guid("cf615463-d189-4221-b69d-373d9ecbe762"), new Guid("f0744c2c-c60f-4ae2-9227-beb769c6bb74"), "Imperator Furiosa" },
                    { new Guid("539b371e-f3ec-4d09-8add-4072cd23d277"), new Guid("f1ff0736-167e-464c-98b3-66361a5952bb"), "Marla Singer" },
                    { new Guid("8441360b-3bb9-4f58-86c1-02dd3f04072a"), new Guid("f1ff0736-167e-464c-98b3-66361a5952bb"), "Tyler Durden" },
                    { new Guid("a14ff11b-23f0-402f-ad77-15bdf9eb5a8d"), new Guid("f1ff0736-167e-464c-98b3-66361a5952bb"), "The Narrator" },
                    { new Guid("1fc801b0-0633-4cff-97fe-c6068014dfa4"), new Guid("f2661055-d0cd-4e35-ada5-bd9369ecc094"), "Lorraine Lambert" },
                    { new Guid("2f276480-e052-4120-85d6-7f5fb2a0141f"), new Guid("f2661055-d0cd-4e35-ada5-bd9369ecc094"), "Josh Lambert" },
                    { new Guid("e52850d9-f3a4-4d46-a265-3667403ac2e9"), new Guid("f2661055-d0cd-4e35-ada5-bd9369ecc094"), "Renai Lambert" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("32ac45d4-37c1-4f8c-9c9c-20e9cea6a21d"), new Guid("00641073-88cb-471e-bea0-8e6601494d09") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("846cc4c2-430e-42e8-b9a8-f3369310563a"), new Guid("00641073-88cb-471e-bea0-8e6601494d09") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("e337f1ec-b22c-4ddf-8b5e-bd5afa946129"), new Guid("00641073-88cb-471e-bea0-8e6601494d09") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("655b7c4a-7bde-4498-82b2-46288064039f"), new Guid("07d1c2e1-a2e2-4ee5-873f-b101cc613a25") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("9186ec1d-7199-439e-b062-a103f1371d54"), new Guid("07d1c2e1-a2e2-4ee5-873f-b101cc613a25") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("cf61c4ca-a860-4e52-848a-4014f336afc9"), new Guid("07d1c2e1-a2e2-4ee5-873f-b101cc613a25") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("1856d962-d4cb-491a-a94e-072cfa5662bd"), new Guid("12010e19-dd0f-4195-b3c6-7dc6702c8a32") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("a2a8ed1f-aa12-411b-a221-2d2cdd7d5f2e"), new Guid("12010e19-dd0f-4195-b3c6-7dc6702c8a32") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("c897ed9b-a2ac-4e31-8fa4-8c26cc33c652"), new Guid("12010e19-dd0f-4195-b3c6-7dc6702c8a32") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("a5f19f18-702b-49cb-8e8a-634045a81baa"), new Guid("13f91c44-a819-49c8-8ed3-3c003171ddc3") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("c9ee97ea-de38-4ce6-add4-ebc54fd7d92a"), new Guid("13f91c44-a819-49c8-8ed3-3c003171ddc3") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("ff728ce9-28c4-4e30-9e50-bd0e7fba3b39"), new Guid("13f91c44-a819-49c8-8ed3-3c003171ddc3") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("0dc023ca-c84f-4c6b-a1c3-ed3ca625b7bd"), new Guid("23fb559e-9a66-4423-af07-b97d9de649fe") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("51bab7d6-b37f-40b4-b787-5f6cb30af6f4"), new Guid("23fb559e-9a66-4423-af07-b97d9de649fe") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("8441360b-3bb9-4f58-86c1-02dd3f04072a"), new Guid("23fb559e-9a66-4423-af07-b97d9de649fe") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("1acc5129-33a7-4b35-b00b-f350c34c0b83"), new Guid("2a90d8b6-82d8-4581-9fa7-ecaa5832dc26") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("82d8d010-92a5-4189-b947-d56faf569ba6"), new Guid("2a90d8b6-82d8-4581-9fa7-ecaa5832dc26") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("950268ca-c69a-41f4-81c3-7cd61c42a9e1"), new Guid("2a90d8b6-82d8-4581-9fa7-ecaa5832dc26") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("339a12ea-c0b1-4c15-81eb-189212eda79d"), new Guid("2fad653d-7cde-4b92-a5e8-a3928570f756") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("4f53bb1c-0f91-48bc-9876-5dfd7ab74ebb"), new Guid("2fad653d-7cde-4b92-a5e8-a3928570f756") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("93088ce9-c00a-4ea4-9cd6-2ac02db77c7d"), new Guid("2fad653d-7cde-4b92-a5e8-a3928570f756") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("084b109f-15d5-473a-9baa-ab748f461af5"), new Guid("34b8a65e-15f2-424a-b164-600afe23f814") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("9d666c80-52f7-4e34-8871-245c0911979e"), new Guid("34b8a65e-15f2-424a-b164-600afe23f814") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("a5381bf5-482b-4f12-9d17-d10e8fcb6fc1"), new Guid("34b8a65e-15f2-424a-b164-600afe23f814") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("bec8cce9-b5a4-4a5d-8a39-ebac11c6448e"), new Guid("368e82a0-da8c-4d1b-90b0-749f12faecfa") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("eaf447ef-beea-4eaa-a94c-00acd311ef42"), new Guid("368e82a0-da8c-4d1b-90b0-749f12faecfa") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("fd960aa9-8876-4dff-9d99-94c1c3738c04"), new Guid("368e82a0-da8c-4d1b-90b0-749f12faecfa") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("12cf4f78-7a6f-4421-b158-9df0034694e1"), new Guid("377d6f6f-4aeb-4046-9ded-dfaf7e8d59a5") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("a9f10213-5b0f-42cb-b282-0daa96bb1519"), new Guid("377d6f6f-4aeb-4046-9ded-dfaf7e8d59a5") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("e175c472-5291-47de-832d-003b3aa6527a"), new Guid("377d6f6f-4aeb-4046-9ded-dfaf7e8d59a5") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("08d54a07-c4a3-4467-8c2d-2791ccc3cb86"), new Guid("3a981e02-9650-4cc4-ba2f-978979789984") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("990f0803-c80f-40cf-9d02-910e3d46a962"), new Guid("3a981e02-9650-4cc4-ba2f-978979789984") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("f2dfcabe-52e1-4e25-84f2-054cc9f9a772"), new Guid("3a981e02-9650-4cc4-ba2f-978979789984") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("b32c87ff-b412-42d3-bbc1-521841443d40"), new Guid("40009b98-ece3-42b4-8c7d-a10b4dda5b38") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("b391372d-3bfd-48e4-be60-c343cc4b4f3f"), new Guid("40009b98-ece3-42b4-8c7d-a10b4dda5b38") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("f3d34bfd-85e1-4dec-bc22-5f4eca6c9fc2"), new Guid("40009b98-ece3-42b4-8c7d-a10b4dda5b38") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("138ce271-e924-4e54-930e-0d8c04d0fc77"), new Guid("43268f2d-7bfb-4c62-b49d-b868b1fc2568") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("e0fb708c-3052-473c-9f03-29f855010c16"), new Guid("43268f2d-7bfb-4c62-b49d-b868b1fc2568") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("ed9b74af-8587-4aff-abd4-8957e4eb1ca7"), new Guid("43268f2d-7bfb-4c62-b49d-b868b1fc2568") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("13ec26d4-e9fc-4def-ae21-f93ab8d4d6b6"), new Guid("441db5ba-a442-43f9-8e18-363cf678f5d2") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("ca837102-6e0b-4bc6-a39c-d35bbc3dfa80"), new Guid("441db5ba-a442-43f9-8e18-363cf678f5d2") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("dc2957ed-c6dc-40c6-8dcb-8e93bdd8ba03"), new Guid("441db5ba-a442-43f9-8e18-363cf678f5d2") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("0415474f-6528-4602-9803-b387d67b5b5d"), new Guid("4ab20a27-63b5-42ee-a9de-aef4b0866153") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("1a536677-8b72-42dc-b7ec-506ab25c501f"), new Guid("4ab20a27-63b5-42ee-a9de-aef4b0866153") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("3c550829-e360-4a0f-947f-b8510e01718a"), new Guid("4ab20a27-63b5-42ee-a9de-aef4b0866153") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("158a9d99-77ae-46ca-8818-65ab53540d11"), new Guid("4d91f3a2-6c96-4a58-90f7-bbea29063a5f") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("3b9bf0a1-5001-4946-a64f-fbfe3a6f73a1"), new Guid("4d91f3a2-6c96-4a58-90f7-bbea29063a5f") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("e4a264bc-0a02-4720-917c-fca59bb573ff"), new Guid("4d91f3a2-6c96-4a58-90f7-bbea29063a5f") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("aec03985-5285-415c-b7c2-1245a6751576"), new Guid("4e35a624-d5db-4900-b43e-c0f9b7d28590") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("d70a393d-94ed-424f-ad8f-b0a041617c52"), new Guid("4e35a624-d5db-4900-b43e-c0f9b7d28590") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("fed28090-372d-456f-9a1e-c207058ac144"), new Guid("4e35a624-d5db-4900-b43e-c0f9b7d28590") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("25538521-d4f1-4ca8-ba20-1628c98b6930"), new Guid("50219472-6180-4b85-a5ac-fdf4079ccf58") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("310706f7-2d9a-4e5a-8e2f-5214084fd26d"), new Guid("50219472-6180-4b85-a5ac-fdf4079ccf58") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("545d9868-b224-46c4-9b60-21271dc2adc2"), new Guid("50219472-6180-4b85-a5ac-fdf4079ccf58") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("bc65dca2-6946-4eeb-841d-add7c0fd0376"), new Guid("512d850d-0dad-429a-a2f8-5a492651e8d5") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("cac1fee0-fd3a-47f8-b629-cb9b65d68b2c"), new Guid("512d850d-0dad-429a-a2f8-5a492651e8d5") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("d1bdcd3f-a8be-4044-96b4-26a0745585e9"), new Guid("512d850d-0dad-429a-a2f8-5a492651e8d5") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("6547e436-757f-4cb1-a179-f337b0922121"), new Guid("5247d8b6-6f31-4995-86c9-4196332328a0") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("70705055-5ce6-4a88-a3ba-5e031ae9b786"), new Guid("5247d8b6-6f31-4995-86c9-4196332328a0") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("cee50ddf-38c4-40fb-91a3-02bfc7bee4aa"), new Guid("5247d8b6-6f31-4995-86c9-4196332328a0") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("01258edc-1458-4035-af5c-19fde8c99a1d"), new Guid("59d62ca3-2be7-4ef6-bfbc-362b4ff49fac") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("447f0422-0955-41e1-9b47-f2b09a8a474c"), new Guid("59d62ca3-2be7-4ef6-bfbc-362b4ff49fac") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("5b20c518-2ac0-4dbb-9e2f-db4d9f0bb879"), new Guid("59d62ca3-2be7-4ef6-bfbc-362b4ff49fac") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("2c4f6a03-d0b1-4e0e-8e5a-d824d9ffa7c7"), new Guid("5b248551-840b-4632-8aaf-3e1b16252d65") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("40f67ef1-8703-42e9-94af-f65e1a2ef186"), new Guid("5b248551-840b-4632-8aaf-3e1b16252d65") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("bdb9ef82-f830-4d22-96ea-7128d9fd92b7"), new Guid("5b248551-840b-4632-8aaf-3e1b16252d65") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("26d5c98a-347d-49b0-9268-2029a7f0ee98"), new Guid("5c3f62e1-a6ca-4286-9cb3-5cbc0afc3d8b") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("a7c020f2-1864-4e0a-98a5-4d3b03f6eee7"), new Guid("5c3f62e1-a6ca-4286-9cb3-5cbc0afc3d8b") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("bfad936e-bf67-4b44-8a27-88606204e79e"), new Guid("5c3f62e1-a6ca-4286-9cb3-5cbc0afc3d8b") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("453399e4-7c51-46d3-aeae-99eb8f06fef9"), new Guid("614bf670-e4d2-4b35-a208-c84a6c75c764") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("bfc71005-46f5-4f0e-a05d-eb99293367d5"), new Guid("614bf670-e4d2-4b35-a208-c84a6c75c764") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("d85eed69-92c7-4bcb-b978-9c2179a19f6c"), new Guid("614bf670-e4d2-4b35-a208-c84a6c75c764") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("5f3878b6-e371-4be2-afcb-10906290b75a"), new Guid("623d306a-95f7-48f7-9f09-aa298685ac3b") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("858afe84-3e5a-451b-bd2d-eda7f38e8467"), new Guid("623d306a-95f7-48f7-9f09-aa298685ac3b") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("e2100a6d-cc7d-47c9-9927-72082d1b3843"), new Guid("623d306a-95f7-48f7-9f09-aa298685ac3b") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("36e4bf12-895e-44a2-b635-e9e7930c0997"), new Guid("63c3517c-d626-4181-a444-0adeeb056878") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("b479a3b8-5eba-43f0-a77c-797fc760ab1f"), new Guid("63c3517c-d626-4181-a444-0adeeb056878") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("dae9df12-f329-45e4-b256-a7e9646e838d"), new Guid("63c3517c-d626-4181-a444-0adeeb056878") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("a1c457e5-d6b5-4fce-81a1-e570ebca481a"), new Guid("66275523-30e6-48e0-8c65-dab3d3fb12f8") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("d31a1794-c533-4a9a-85a9-d90e3390c8dd"), new Guid("66275523-30e6-48e0-8c65-dab3d3fb12f8") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("e1d47d6f-e0e3-4214-b4f7-21b37d6db88d"), new Guid("66275523-30e6-48e0-8c65-dab3d3fb12f8") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("00cdc0aa-e696-4628-b8cc-ec84f4a6dc06"), new Guid("6851194f-61a0-4df1-8e89-2030ca47fe24") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("40f67ef1-8703-42e9-94af-f65e1a2ef186"), new Guid("6851194f-61a0-4df1-8e89-2030ca47fe24") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("cac1fee0-fd3a-47f8-b629-cb9b65d68b2c"), new Guid("6851194f-61a0-4df1-8e89-2030ca47fe24") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("84982976-ae90-4237-9520-d6239df1458d"), new Guid("69941e20-653e-4ddf-a9ef-7a98f601ba61") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("9af1c7b4-2511-48e0-8868-fc0dab590d71"), new Guid("69941e20-653e-4ddf-a9ef-7a98f601ba61") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("f3b65829-46e4-4143-b39b-86136de26b7f"), new Guid("69941e20-653e-4ddf-a9ef-7a98f601ba61") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("1a536677-8b72-42dc-b7ec-506ab25c501f"), new Guid("6ea110b0-5980-49ec-9812-bdc05ca854be") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("bb729c83-9964-434b-97b7-66c7665aa3da"), new Guid("6ea110b0-5980-49ec-9812-bdc05ca854be") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("bbf4da5f-54e3-4659-b179-978e5f6ab285"), new Guid("6ea110b0-5980-49ec-9812-bdc05ca854be") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("50cafa2b-71bd-4ea8-8eb0-a5ee95eff467"), new Guid("6f6779da-99ae-44d9-a61a-43ebe5f0fd77") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("6fd39241-45d7-4435-beeb-6ef22cc912de"), new Guid("6f6779da-99ae-44d9-a61a-43ebe5f0fd77") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("d1bdcd3f-a8be-4044-96b4-26a0745585e9"), new Guid("6f6779da-99ae-44d9-a61a-43ebe5f0fd77") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("468fc8fc-00b2-4740-b025-f465bc99c283"), new Guid("700ebda0-232e-4b1c-9be2-bf6a99893d6d") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("480a5aa3-2618-4777-8d6c-764b0bac7a6b"), new Guid("700ebda0-232e-4b1c-9be2-bf6a99893d6d") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("7c412653-3c11-4b3a-8118-22a6c219f54c"), new Guid("700ebda0-232e-4b1c-9be2-bf6a99893d6d") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("179a8c49-2ace-4cc3-bef6-0d76f135c1ec"), new Guid("70a5373e-e526-4766-9194-e6d1a536485c") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("2f276480-e052-4120-85d6-7f5fb2a0141f"), new Guid("70a5373e-e526-4766-9194-e6d1a536485c") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("95ce32f0-7a46-4e31-8459-cd6ee973dba9"), new Guid("70a5373e-e526-4766-9194-e6d1a536485c") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("2f5d38f8-9375-4e62-bde1-801bc44f2908"), new Guid("75a766dd-73cd-4a3b-81ef-738e4b72a23d") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("51bab7d6-b37f-40b4-b787-5f6cb30af6f4"), new Guid("75a766dd-73cd-4a3b-81ef-738e4b72a23d") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("d875ff93-4c8d-4470-9c2e-66209c6d63f2"), new Guid("75a766dd-73cd-4a3b-81ef-738e4b72a23d") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("00085ee6-52df-4585-967b-408c7ba486be"), new Guid("78e7000a-1425-4340-938a-cf4a5bac6775") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("086a28bc-461c-4360-90e6-d34634bc7930"), new Guid("78e7000a-1425-4340-938a-cf4a5bac6775") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("c7483292-2173-429e-bf47-be27c5dc820b"), new Guid("78e7000a-1425-4340-938a-cf4a5bac6775") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("8ba7acf6-a509-48fe-92c0-c8c0528569fd"), new Guid("794c142d-386f-4a8a-8290-adf396a07f6a") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("9c39c7a7-3897-494b-a8b5-970dd50d88b6"), new Guid("794c142d-386f-4a8a-8290-adf396a07f6a") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("b32c87ff-b412-42d3-bbc1-521841443d40"), new Guid("794c142d-386f-4a8a-8290-adf396a07f6a") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("09ad1d06-e8a1-406e-890b-d744e67ffa76"), new Guid("7c1f4dea-492d-446f-ba11-aa0794b54350") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("176400ce-53cf-4576-a2ed-432f78a43240"), new Guid("7c1f4dea-492d-446f-ba11-aa0794b54350") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("dc4a4b36-d647-43f9-b215-1a6024cc712f"), new Guid("7c1f4dea-492d-446f-ba11-aa0794b54350") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("1cea7dbe-d8be-44bc-bdcc-2ebfa35e8c9f"), new Guid("7c9e4721-3564-4a95-952b-37e8a5eff337") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("afaa9921-7f23-482b-b344-19e43274db30"), new Guid("7c9e4721-3564-4a95-952b-37e8a5eff337") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("baf8a9c9-d344-4e6f-b802-a85dad91ffb9"), new Guid("7c9e4721-3564-4a95-952b-37e8a5eff337") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("29ac4686-bfcd-49dc-8646-876522ab6472"), new Guid("86e3b9d0-b465-4b7e-95a4-f1da2a66ada2") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("5d7cdba3-e8dc-4f19-a8a3-8992aec07fae"), new Guid("86e3b9d0-b465-4b7e-95a4-f1da2a66ada2") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("b30648a8-3bfe-43be-bc09-65caf669fb09"), new Guid("86e3b9d0-b465-4b7e-95a4-f1da2a66ada2") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("4b7fe159-069a-4c8f-8bd3-09ed79a4c5ae"), new Guid("885e7b27-c1c2-4ab8-8a6c-f676ecec60df") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("d1fb6849-f352-4e51-a01c-e98b0f67fc40"), new Guid("885e7b27-c1c2-4ab8-8a6c-f676ecec60df") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("f03b85c5-d584-4d0b-8d38-d7356f469375"), new Guid("885e7b27-c1c2-4ab8-8a6c-f676ecec60df") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("2bb629f1-e03a-4c92-b265-6ba6f3674026"), new Guid("88b25038-308e-4253-82c0-4a57151ad908") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("879fffcf-e8fe-4a4a-bab5-da42fc4d1256"), new Guid("88b25038-308e-4253-82c0-4a57151ad908") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("ea2f8e0d-eb55-4452-90a1-f810474cbe7f"), new Guid("88b25038-308e-4253-82c0-4a57151ad908") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("263f806e-5bb0-4cc5-bdc1-a6130e3a6ae7"), new Guid("91e01bcd-a47d-48d9-b79d-8ed6c4886699") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("44907d33-053a-47f7-ac1b-a2fddbbea5cc"), new Guid("91e01bcd-a47d-48d9-b79d-8ed6c4886699") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("8d806e2a-9b9e-407e-bfde-d95afc6f0c04"), new Guid("91e01bcd-a47d-48d9-b79d-8ed6c4886699") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("925ac384-48c7-4eac-96fd-36bf2b9f6bd4"), new Guid("93d7a78d-d7aa-43d0-8d7d-91a22b7c7619") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("d875ff93-4c8d-4470-9c2e-66209c6d63f2"), new Guid("93d7a78d-d7aa-43d0-8d7d-91a22b7c7619") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("dfe14619-506f-4f09-9a8e-8bf0fdaa4e83"), new Guid("93d7a78d-d7aa-43d0-8d7d-91a22b7c7619") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("0863f099-87d9-4590-8a19-083384c1aa91"), new Guid("97448f10-b164-4880-82ed-a1ac239d0afd") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("34ed4fe5-d30b-4edc-a00f-f75f019d46a3"), new Guid("97448f10-b164-4880-82ed-a1ac239d0afd") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("3c328dc2-54a1-4a48-8962-6e7f903f2162"), new Guid("97448f10-b164-4880-82ed-a1ac239d0afd") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("50e895bc-e9e1-445b-a99c-6615bd33437a"), new Guid("97951c83-8686-45c8-be13-a0b0f79539a5") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("7c144da1-9cb5-498f-9f04-8d6d5418455e"), new Guid("97951c83-8686-45c8-be13-a0b0f79539a5") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("bbf4da5f-54e3-4659-b179-978e5f6ab285"), new Guid("97951c83-8686-45c8-be13-a0b0f79539a5") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("96c08023-9ed3-46dd-a016-facb34a4bef9"), new Guid("9d0944ab-9bfa-4345-8ee6-6f52787b19c4") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("f03b85c5-d584-4d0b-8d38-d7356f469375"), new Guid("9d0944ab-9bfa-4345-8ee6-6f52787b19c4") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("f5faf27e-6f57-4035-a94e-1055cd927ed1"), new Guid("9d0944ab-9bfa-4345-8ee6-6f52787b19c4") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("2c4f6a03-d0b1-4e0e-8e5a-d824d9ffa7c7"), new Guid("9d52bd23-4ee9-499d-8789-0d860eef65a3") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("362cae35-adc0-4ad9-8ff5-8a6603edf315"), new Guid("9d52bd23-4ee9-499d-8789-0d860eef65a3") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("bf824b1f-8c4d-4be3-9566-dee5b7e512b0"), new Guid("9d52bd23-4ee9-499d-8789-0d860eef65a3") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("18638236-cb2e-4892-befc-cf0068444068"), new Guid("9dcd678b-7dee-47d1-aff7-567156607a86") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("b32c87ff-b412-42d3-bbc1-521841443d40"), new Guid("9dcd678b-7dee-47d1-aff7-567156607a86") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("d875ff93-4c8d-4470-9c2e-66209c6d63f2"), new Guid("9dcd678b-7dee-47d1-aff7-567156607a86") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("09b7ed63-7445-4c20-b6cf-271ddb9e4c96"), new Guid("9e1126ac-ddca-4012-9204-8d0480e417d1") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("59d617f1-c06c-4dd0-8b8b-ad0fd2615135"), new Guid("9e1126ac-ddca-4012-9204-8d0480e417d1") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("a5381bf5-482b-4f12-9d17-d10e8fcb6fc1"), new Guid("9e1126ac-ddca-4012-9204-8d0480e417d1") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("1b39c2ef-208c-4e08-b668-a533d279d528"), new Guid("a4a49163-f174-4a42-9f88-1f1b30325ef5") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("a8360aca-2aa9-49da-925b-af9deaa40978"), new Guid("a4a49163-f174-4a42-9f88-1f1b30325ef5") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("c55c41c7-9a4d-40d2-b2fc-57eb139bf902"), new Guid("a4a49163-f174-4a42-9f88-1f1b30325ef5") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("176400ce-53cf-4576-a2ed-432f78a43240"), new Guid("a6600fb9-7a83-44fa-827e-03dd66e62e9a") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("5d7cdba3-e8dc-4f19-a8a3-8992aec07fae"), new Guid("a6600fb9-7a83-44fa-827e-03dd66e62e9a") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("ceaeb56b-d490-44c9-961c-06e8af100ba6"), new Guid("a6600fb9-7a83-44fa-827e-03dd66e62e9a") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("0a1a093a-54e3-454d-86f9-73523144b49d"), new Guid("a7061bb8-f59a-4ab7-ad3c-dce86b7ccbdc") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("1251c5c5-0fdd-40c1-89d7-0e10b338300c"), new Guid("a7061bb8-f59a-4ab7-ad3c-dce86b7ccbdc") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("be6e3a70-0dd5-4da8-8534-4a208c09a614"), new Guid("a7061bb8-f59a-4ab7-ad3c-dce86b7ccbdc") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("0dd7a860-af97-4fe5-86ca-d7b6a171e506"), new Guid("a7b10c31-a060-4436-bef3-4b08014e794e") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("101916e7-e588-499f-829a-daa2793c23e8"), new Guid("a7b10c31-a060-4436-bef3-4b08014e794e") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("3998723a-ebb9-4e63-a96b-8575e5345e5b"), new Guid("a7b10c31-a060-4436-bef3-4b08014e794e") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("3de01bc3-0480-4a01-8593-ddfb1849ff9b"), new Guid("acc9eaf0-be41-4f4c-a4f2-4bee8da3e4a0") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("65970305-4fc7-4890-9f0b-5063affce076"), new Guid("acc9eaf0-be41-4f4c-a4f2-4bee8da3e4a0") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("bc2dd711-8eac-439d-9353-dd355849ed8e"), new Guid("acc9eaf0-be41-4f4c-a4f2-4bee8da3e4a0") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("3dacabea-76fa-48d7-8b12-4095bacbd787"), new Guid("af12ea31-878c-43ce-95ac-bb3d54f277f4") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("d9963534-1f06-4a69-bf13-8e735e7c9e9f"), new Guid("af12ea31-878c-43ce-95ac-bb3d54f277f4") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("f0c4a679-e5fd-4329-811c-0735cff97711"), new Guid("af12ea31-878c-43ce-95ac-bb3d54f277f4") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("0dc023ca-c84f-4c6b-a1c3-ed3ca625b7bd"), new Guid("b0e94565-1376-46f0-b5c4-2aedc6d30ce7") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("362cae35-adc0-4ad9-8ff5-8a6603edf315"), new Guid("b0e94565-1376-46f0-b5c4-2aedc6d30ce7") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("bd607b66-67f7-4fa5-8798-56fecc7d83e8"), new Guid("b0e94565-1376-46f0-b5c4-2aedc6d30ce7") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("1c76e80e-212e-49c2-bb82-d3cb7bb8a9ca"), new Guid("b235003d-d473-464d-a300-7049e31d0a6d") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("8904c86f-88c7-4575-9c5a-70d83a4a53db"), new Guid("b235003d-d473-464d-a300-7049e31d0a6d") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("f42cbe69-d1a1-45bd-9a93-8aaa606744ca"), new Guid("b235003d-d473-464d-a300-7049e31d0a6d") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("4b7fe159-069a-4c8f-8bd3-09ed79a4c5ae"), new Guid("bd56340e-eea7-4e83-9b69-6ede4a939bd8") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("b96f5e3e-e5c2-4005-93ba-14a6db7078b9"), new Guid("bd56340e-eea7-4e83-9b69-6ede4a939bd8") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("d1fb6849-f352-4e51-a01c-e98b0f67fc40"), new Guid("bd56340e-eea7-4e83-9b69-6ede4a939bd8") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("0dc023ca-c84f-4c6b-a1c3-ed3ca625b7bd"), new Guid("c2159ffd-c180-4a04-8499-62c1886a4ac9") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("12b4e8b1-deee-4931-baa3-bc4d5f3efb9b"), new Guid("c2159ffd-c180-4a04-8499-62c1886a4ac9") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("5429c902-48d3-4dec-beac-49f37ff0b08d"), new Guid("c2159ffd-c180-4a04-8499-62c1886a4ac9") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("1d4c8ea4-7f11-453b-8be8-e2218e767055"), new Guid("c441109b-5d90-4b44-847f-ec113694e334") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("ad15e2ca-4491-413c-a95b-8b2cc8935c4c"), new Guid("c441109b-5d90-4b44-847f-ec113694e334") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("ba291cbf-a1f6-4a18-bfa8-fb2a3c299e6f"), new Guid("c441109b-5d90-4b44-847f-ec113694e334") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("15aa84fd-f77a-483b-9499-7efa823c269c"), new Guid("c4987c3e-6ee2-49f5-8caa-bb515b019e8b") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("76039504-7ee7-4356-a79d-161486a5b162"), new Guid("c4987c3e-6ee2-49f5-8caa-bb515b019e8b") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("b6564219-9a09-4767-b494-e9fd622084b0"), new Guid("c4987c3e-6ee2-49f5-8caa-bb515b019e8b") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("4b7fe159-069a-4c8f-8bd3-09ed79a4c5ae"), new Guid("c6c210c2-c80b-474e-9d97-2751200097ae") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("d1fb6849-f352-4e51-a01c-e98b0f67fc40"), new Guid("c6c210c2-c80b-474e-9d97-2751200097ae") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("f03b85c5-d584-4d0b-8d38-d7356f469375"), new Guid("c6c210c2-c80b-474e-9d97-2751200097ae") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("556360a7-3f73-48c6-b971-52ff34371b93"), new Guid("c6d7d61d-0ab2-4789-85fe-053e438cfe2a") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("9af80152-7958-47f9-8f8a-b1394b62bc12"), new Guid("c6d7d61d-0ab2-4789-85fe-053e438cfe2a") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("9ff68d83-fc39-4081-ae3f-06ef755711d3"), new Guid("c6d7d61d-0ab2-4789-85fe-053e438cfe2a") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("8044275d-432e-4e99-a403-bc47b7208011"), new Guid("cb0c0fb5-1799-4ad4-99f3-d78c0a1e21cf") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("b391372d-3bfd-48e4-be60-c343cc4b4f3f"), new Guid("cb0c0fb5-1799-4ad4-99f3-d78c0a1e21cf") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("b6a14c4f-815e-4be4-b6b3-b69717718c8d"), new Guid("cb0c0fb5-1799-4ad4-99f3-d78c0a1e21cf") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("1acc5129-33a7-4b35-b00b-f350c34c0b83"), new Guid("cb8a9632-001b-464e-905c-2a0062f1bcaf") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("950268ca-c69a-41f4-81c3-7cd61c42a9e1"), new Guid("cb8a9632-001b-464e-905c-2a0062f1bcaf") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("95a09f9f-98a1-4a0b-a409-6a357ceb9930"), new Guid("cb8a9632-001b-464e-905c-2a0062f1bcaf") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("10ba4f1b-fb6f-4040-a38a-1de45d9d7605"), new Guid("d04029bd-e8d4-4e65-ac84-094d766d8306") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("8b3378bc-3e09-4921-9466-7bf8b3108211"), new Guid("d04029bd-e8d4-4e65-ac84-094d766d8306") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("a1c457e5-d6b5-4fce-81a1-e570ebca481a"), new Guid("d04029bd-e8d4-4e65-ac84-094d766d8306") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("29843c4b-6c08-4a57-9b36-95264eba65bd"), new Guid("d19b2756-5235-4f96-9577-7281f1d36d38") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("61cfb611-b7b6-4a63-8edc-7183a7a2dc35"), new Guid("d19b2756-5235-4f96-9577-7281f1d36d38") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("ad15e2ca-4491-413c-a95b-8b2cc8935c4c"), new Guid("d19b2756-5235-4f96-9577-7281f1d36d38") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("00085ee6-52df-4585-967b-408c7ba486be"), new Guid("d5a8997f-b046-436f-aada-c06dd2ca0f1c") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("57ad6e92-9f65-4871-b922-11600447149c"), new Guid("d5a8997f-b046-436f-aada-c06dd2ca0f1c") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("f8124011-adb0-4454-9da7-91f0e182fa33"), new Guid("d5a8997f-b046-436f-aada-c06dd2ca0f1c") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("1f7c2d4c-cfb4-47ca-ba0e-575c6e5b1ae2"), new Guid("d5e2cd4f-959d-4a19-becf-404713d46271") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("2e7678ba-e51a-402a-ae90-6585b837ea90"), new Guid("d5e2cd4f-959d-4a19-becf-404713d46271") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("3fa7c993-1327-4a37-87f6-0020d90dbfea"), new Guid("d5e2cd4f-959d-4a19-becf-404713d46271") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("43c89467-ac0e-4e79-9f8e-929848c36d6a"), new Guid("d6bf3fb7-df18-4e5c-bce4-1f7cf55b8848") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("64ea884a-b2a5-46ae-9532-ce5d559ead97"), new Guid("d6bf3fb7-df18-4e5c-bce4-1f7cf55b8848") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("cda5b584-c19f-48e5-9e4b-787bbbd441ff"), new Guid("d6bf3fb7-df18-4e5c-bce4-1f7cf55b8848") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("d246a339-8c96-4ee4-9377-c6110d1ebaef"), new Guid("d6bf3fb7-df18-4e5c-bce4-1f7cf55b8848") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("0f0f48ae-983b-48b1-a574-a8dc4f6ace0b"), new Guid("d83ca8b1-f2da-4aa3-b5b8-a35ec94d20c4") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("483c83dc-0645-46ea-80a7-2f227b5f80cf"), new Guid("d83ca8b1-f2da-4aa3-b5b8-a35ec94d20c4") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("f9e3238a-97a1-4718-ab92-31d5236547b3"), new Guid("d83ca8b1-f2da-4aa3-b5b8-a35ec94d20c4") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("0f312b1b-a6cd-4ed2-afe9-6b493205c424"), new Guid("daed155e-81be-42e0-8d7a-dc2db09eb148") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("d1c69566-30fd-47b2-9128-b7aadd4722a1"), new Guid("daed155e-81be-42e0-8d7a-dc2db09eb148") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("fcece400-14b5-481a-b5d7-fe67bf28f913"), new Guid("daed155e-81be-42e0-8d7a-dc2db09eb148") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("38ebb771-b41b-43c4-ae42-d5da412e04d9"), new Guid("e02b1783-545f-4c73-8374-768e6cfbf4c4") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("4123086b-dc4f-4e51-81fa-f64a6fc7f7bd"), new Guid("e02b1783-545f-4c73-8374-768e6cfbf4c4") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("cfde46c5-342f-4560-85d2-493f082e0a01"), new Guid("e02b1783-545f-4c73-8374-768e6cfbf4c4") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("18638236-cb2e-4892-befc-cf0068444068"), new Guid("e131229c-a516-492d-898d-635a5b6c95e4") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("a5381bf5-482b-4f12-9d17-d10e8fcb6fc1"), new Guid("e131229c-a516-492d-898d-635a5b6c95e4") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("de41865b-5b44-43f7-9275-495898638232"), new Guid("e131229c-a516-492d-898d-635a5b6c95e4") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("362cae35-adc0-4ad9-8ff5-8a6603edf315"), new Guid("e9626460-ec88-4203-99b7-d918105fef03") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("411fdf1d-ff3a-490c-86ac-ef8252b5c0fa"), new Guid("e9626460-ec88-4203-99b7-d918105fef03") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("ef1f2981-782a-40c7-b0dc-5e6a85bb7055"), new Guid("e9626460-ec88-4203-99b7-d918105fef03") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("1b39c2ef-208c-4e08-b668-a533d279d528"), new Guid("e96c3640-af75-4342-bf73-2c249993f934") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("a41a0cad-77db-47cc-a5a0-0d57342a9b65"), new Guid("e96c3640-af75-4342-bf73-2c249993f934") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("c3891de0-0cda-41bc-a2ae-e957df3d0f1a"), new Guid("e96c3640-af75-4342-bf73-2c249993f934") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("8dcde184-4ee9-4ac3-8a01-e8827834d161"), new Guid("f01bf412-3480-4c18-9b6f-418f947c1ba2") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("d246a339-8c96-4ee4-9377-c6110d1ebaef"), new Guid("f01bf412-3480-4c18-9b6f-418f947c1ba2") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("f80c0da1-8be6-4a46-a578-edfce3af270d"), new Guid("f01bf412-3480-4c18-9b6f-418f947c1ba2") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("af0ea72b-6f8f-4db0-afa7-2ea8c7859c30"), new Guid("f0744c2c-c60f-4ae2-9227-beb769c6bb74") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("bc65dca2-6946-4eeb-841d-add7c0fd0376"), new Guid("f0744c2c-c60f-4ae2-9227-beb769c6bb74") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("cf615463-d189-4221-b69d-373d9ecbe762"), new Guid("f0744c2c-c60f-4ae2-9227-beb769c6bb74") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("539b371e-f3ec-4d09-8add-4072cd23d277"), new Guid("f1ff0736-167e-464c-98b3-66361a5952bb") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("8441360b-3bb9-4f58-86c1-02dd3f04072a"), new Guid("f1ff0736-167e-464c-98b3-66361a5952bb") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("a14ff11b-23f0-402f-ad77-15bdf9eb5a8d"), new Guid("f1ff0736-167e-464c-98b3-66361a5952bb") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("1fc801b0-0633-4cff-97fe-c6068014dfa4"), new Guid("f2661055-d0cd-4e35-ada5-bd9369ecc094") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("2f276480-e052-4120-85d6-7f5fb2a0141f"), new Guid("f2661055-d0cd-4e35-ada5-bd9369ecc094") });

            migrationBuilder.DeleteData(
                table: "movies_actors",
                keyColumns: new[] { "actor_id", "movie_id" },
                keyValues: new object[] { new Guid("e52850d9-f3a4-4d46-a265-3667403ac2e9"), new Guid("f2661055-d0cd-4e35-ada5-bd9369ecc094") });

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("00085ee6-52df-4585-967b-408c7ba486be"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("00cdc0aa-e696-4628-b8cc-ec84f4a6dc06"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("01258edc-1458-4035-af5c-19fde8c99a1d"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("0415474f-6528-4602-9803-b387d67b5b5d"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("084b109f-15d5-473a-9baa-ab748f461af5"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("0863f099-87d9-4590-8a19-083384c1aa91"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("086a28bc-461c-4360-90e6-d34634bc7930"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("08d54a07-c4a3-4467-8c2d-2791ccc3cb86"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("09ad1d06-e8a1-406e-890b-d744e67ffa76"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("09b7ed63-7445-4c20-b6cf-271ddb9e4c96"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("0a1a093a-54e3-454d-86f9-73523144b49d"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("0dc023ca-c84f-4c6b-a1c3-ed3ca625b7bd"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("0dd7a860-af97-4fe5-86ca-d7b6a171e506"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("0f0f48ae-983b-48b1-a574-a8dc4f6ace0b"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("0f312b1b-a6cd-4ed2-afe9-6b493205c424"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("101916e7-e588-499f-829a-daa2793c23e8"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("10ba4f1b-fb6f-4040-a38a-1de45d9d7605"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("1251c5c5-0fdd-40c1-89d7-0e10b338300c"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("12b4e8b1-deee-4931-baa3-bc4d5f3efb9b"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("12cf4f78-7a6f-4421-b158-9df0034694e1"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("138ce271-e924-4e54-930e-0d8c04d0fc77"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("13ec26d4-e9fc-4def-ae21-f93ab8d4d6b6"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("158a9d99-77ae-46ca-8818-65ab53540d11"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("15aa84fd-f77a-483b-9499-7efa823c269c"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("176400ce-53cf-4576-a2ed-432f78a43240"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("179a8c49-2ace-4cc3-bef6-0d76f135c1ec"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("1856d962-d4cb-491a-a94e-072cfa5662bd"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("18638236-cb2e-4892-befc-cf0068444068"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("1a536677-8b72-42dc-b7ec-506ab25c501f"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("1acc5129-33a7-4b35-b00b-f350c34c0b83"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("1b39c2ef-208c-4e08-b668-a533d279d528"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("1c76e80e-212e-49c2-bb82-d3cb7bb8a9ca"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("1cea7dbe-d8be-44bc-bdcc-2ebfa35e8c9f"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("1d4c8ea4-7f11-453b-8be8-e2218e767055"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("1f7c2d4c-cfb4-47ca-ba0e-575c6e5b1ae2"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("1fc801b0-0633-4cff-97fe-c6068014dfa4"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("25538521-d4f1-4ca8-ba20-1628c98b6930"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("263f806e-5bb0-4cc5-bdc1-a6130e3a6ae7"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("26d5c98a-347d-49b0-9268-2029a7f0ee98"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("29843c4b-6c08-4a57-9b36-95264eba65bd"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("29ac4686-bfcd-49dc-8646-876522ab6472"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("2bb629f1-e03a-4c92-b265-6ba6f3674026"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("2c4f6a03-d0b1-4e0e-8e5a-d824d9ffa7c7"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("2e7678ba-e51a-402a-ae90-6585b837ea90"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("2f276480-e052-4120-85d6-7f5fb2a0141f"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("2f5d38f8-9375-4e62-bde1-801bc44f2908"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("310706f7-2d9a-4e5a-8e2f-5214084fd26d"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("32ac45d4-37c1-4f8c-9c9c-20e9cea6a21d"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("339a12ea-c0b1-4c15-81eb-189212eda79d"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("34ed4fe5-d30b-4edc-a00f-f75f019d46a3"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("362cae35-adc0-4ad9-8ff5-8a6603edf315"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("36e4bf12-895e-44a2-b635-e9e7930c0997"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("38ebb771-b41b-43c4-ae42-d5da412e04d9"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("3998723a-ebb9-4e63-a96b-8575e5345e5b"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("3b9bf0a1-5001-4946-a64f-fbfe3a6f73a1"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("3c328dc2-54a1-4a48-8962-6e7f903f2162"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("3c550829-e360-4a0f-947f-b8510e01718a"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("3dacabea-76fa-48d7-8b12-4095bacbd787"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("3de01bc3-0480-4a01-8593-ddfb1849ff9b"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("3fa7c993-1327-4a37-87f6-0020d90dbfea"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("40f67ef1-8703-42e9-94af-f65e1a2ef186"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("411fdf1d-ff3a-490c-86ac-ef8252b5c0fa"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("4123086b-dc4f-4e51-81fa-f64a6fc7f7bd"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("43c89467-ac0e-4e79-9f8e-929848c36d6a"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("447f0422-0955-41e1-9b47-f2b09a8a474c"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("44907d33-053a-47f7-ac1b-a2fddbbea5cc"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("453399e4-7c51-46d3-aeae-99eb8f06fef9"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("468fc8fc-00b2-4740-b025-f465bc99c283"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("480a5aa3-2618-4777-8d6c-764b0bac7a6b"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("483c83dc-0645-46ea-80a7-2f227b5f80cf"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("4b7fe159-069a-4c8f-8bd3-09ed79a4c5ae"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("4f53bb1c-0f91-48bc-9876-5dfd7ab74ebb"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("50cafa2b-71bd-4ea8-8eb0-a5ee95eff467"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("50e895bc-e9e1-445b-a99c-6615bd33437a"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("51bab7d6-b37f-40b4-b787-5f6cb30af6f4"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("539b371e-f3ec-4d09-8add-4072cd23d277"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("5429c902-48d3-4dec-beac-49f37ff0b08d"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("545d9868-b224-46c4-9b60-21271dc2adc2"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("556360a7-3f73-48c6-b971-52ff34371b93"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("57ad6e92-9f65-4871-b922-11600447149c"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("59d617f1-c06c-4dd0-8b8b-ad0fd2615135"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("5b20c518-2ac0-4dbb-9e2f-db4d9f0bb879"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("5d7cdba3-e8dc-4f19-a8a3-8992aec07fae"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("5f3878b6-e371-4be2-afcb-10906290b75a"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("61cfb611-b7b6-4a63-8edc-7183a7a2dc35"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("64ea884a-b2a5-46ae-9532-ce5d559ead97"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("6547e436-757f-4cb1-a179-f337b0922121"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("655b7c4a-7bde-4498-82b2-46288064039f"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("65970305-4fc7-4890-9f0b-5063affce076"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("6fd39241-45d7-4435-beeb-6ef22cc912de"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("70705055-5ce6-4a88-a3ba-5e031ae9b786"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("76039504-7ee7-4356-a79d-161486a5b162"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("7c144da1-9cb5-498f-9f04-8d6d5418455e"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("7c412653-3c11-4b3a-8118-22a6c219f54c"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("8044275d-432e-4e99-a403-bc47b7208011"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("82d8d010-92a5-4189-b947-d56faf569ba6"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("8441360b-3bb9-4f58-86c1-02dd3f04072a"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("846cc4c2-430e-42e8-b9a8-f3369310563a"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("84982976-ae90-4237-9520-d6239df1458d"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("858afe84-3e5a-451b-bd2d-eda7f38e8467"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("879fffcf-e8fe-4a4a-bab5-da42fc4d1256"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("8904c86f-88c7-4575-9c5a-70d83a4a53db"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("8b3378bc-3e09-4921-9466-7bf8b3108211"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("8ba7acf6-a509-48fe-92c0-c8c0528569fd"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("8d806e2a-9b9e-407e-bfde-d95afc6f0c04"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("8dcde184-4ee9-4ac3-8a01-e8827834d161"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("9186ec1d-7199-439e-b062-a103f1371d54"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("925ac384-48c7-4eac-96fd-36bf2b9f6bd4"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("93088ce9-c00a-4ea4-9cd6-2ac02db77c7d"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("950268ca-c69a-41f4-81c3-7cd61c42a9e1"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("95a09f9f-98a1-4a0b-a409-6a357ceb9930"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("95ce32f0-7a46-4e31-8459-cd6ee973dba9"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("96c08023-9ed3-46dd-a016-facb34a4bef9"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("990f0803-c80f-40cf-9d02-910e3d46a962"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("9af1c7b4-2511-48e0-8868-fc0dab590d71"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("9af80152-7958-47f9-8f8a-b1394b62bc12"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("9c39c7a7-3897-494b-a8b5-970dd50d88b6"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("9d666c80-52f7-4e34-8871-245c0911979e"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("9ff68d83-fc39-4081-ae3f-06ef755711d3"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("a14ff11b-23f0-402f-ad77-15bdf9eb5a8d"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("a1c457e5-d6b5-4fce-81a1-e570ebca481a"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("a2a8ed1f-aa12-411b-a221-2d2cdd7d5f2e"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("a41a0cad-77db-47cc-a5a0-0d57342a9b65"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("a5381bf5-482b-4f12-9d17-d10e8fcb6fc1"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("a5f19f18-702b-49cb-8e8a-634045a81baa"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("a7c020f2-1864-4e0a-98a5-4d3b03f6eee7"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("a8360aca-2aa9-49da-925b-af9deaa40978"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("a9f10213-5b0f-42cb-b282-0daa96bb1519"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("ad15e2ca-4491-413c-a95b-8b2cc8935c4c"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("aec03985-5285-415c-b7c2-1245a6751576"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("af0ea72b-6f8f-4db0-afa7-2ea8c7859c30"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("afaa9921-7f23-482b-b344-19e43274db30"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("b30648a8-3bfe-43be-bc09-65caf669fb09"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("b32c87ff-b412-42d3-bbc1-521841443d40"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("b391372d-3bfd-48e4-be60-c343cc4b4f3f"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("b479a3b8-5eba-43f0-a77c-797fc760ab1f"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("b6564219-9a09-4767-b494-e9fd622084b0"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("b6a14c4f-815e-4be4-b6b3-b69717718c8d"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("b96f5e3e-e5c2-4005-93ba-14a6db7078b9"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("ba291cbf-a1f6-4a18-bfa8-fb2a3c299e6f"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("baf8a9c9-d344-4e6f-b802-a85dad91ffb9"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("bb729c83-9964-434b-97b7-66c7665aa3da"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("bbf4da5f-54e3-4659-b179-978e5f6ab285"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("bc2dd711-8eac-439d-9353-dd355849ed8e"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("bc65dca2-6946-4eeb-841d-add7c0fd0376"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("bd607b66-67f7-4fa5-8798-56fecc7d83e8"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("bdb9ef82-f830-4d22-96ea-7128d9fd92b7"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("be6e3a70-0dd5-4da8-8534-4a208c09a614"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("bec8cce9-b5a4-4a5d-8a39-ebac11c6448e"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("bf824b1f-8c4d-4be3-9566-dee5b7e512b0"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("bfad936e-bf67-4b44-8a27-88606204e79e"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("bfc71005-46f5-4f0e-a05d-eb99293367d5"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("c3891de0-0cda-41bc-a2ae-e957df3d0f1a"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("c55c41c7-9a4d-40d2-b2fc-57eb139bf902"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("c7483292-2173-429e-bf47-be27c5dc820b"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("c897ed9b-a2ac-4e31-8fa4-8c26cc33c652"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("c9ee97ea-de38-4ce6-add4-ebc54fd7d92a"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("ca837102-6e0b-4bc6-a39c-d35bbc3dfa80"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("cac1fee0-fd3a-47f8-b629-cb9b65d68b2c"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("cda5b584-c19f-48e5-9e4b-787bbbd441ff"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("ceaeb56b-d490-44c9-961c-06e8af100ba6"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("cee50ddf-38c4-40fb-91a3-02bfc7bee4aa"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("cf615463-d189-4221-b69d-373d9ecbe762"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("cf61c4ca-a860-4e52-848a-4014f336afc9"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("cfde46c5-342f-4560-85d2-493f082e0a01"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("d1bdcd3f-a8be-4044-96b4-26a0745585e9"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("d1c69566-30fd-47b2-9128-b7aadd4722a1"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("d1fb6849-f352-4e51-a01c-e98b0f67fc40"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("d246a339-8c96-4ee4-9377-c6110d1ebaef"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("d31a1794-c533-4a9a-85a9-d90e3390c8dd"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("d70a393d-94ed-424f-ad8f-b0a041617c52"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("d85eed69-92c7-4bcb-b978-9c2179a19f6c"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("d875ff93-4c8d-4470-9c2e-66209c6d63f2"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("d9963534-1f06-4a69-bf13-8e735e7c9e9f"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("dae9df12-f329-45e4-b256-a7e9646e838d"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("dc2957ed-c6dc-40c6-8dcb-8e93bdd8ba03"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("dc4a4b36-d647-43f9-b215-1a6024cc712f"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("de41865b-5b44-43f7-9275-495898638232"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("dfe14619-506f-4f09-9a8e-8bf0fdaa4e83"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("e0fb708c-3052-473c-9f03-29f855010c16"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("e175c472-5291-47de-832d-003b3aa6527a"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("e1d47d6f-e0e3-4214-b4f7-21b37d6db88d"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("e2100a6d-cc7d-47c9-9927-72082d1b3843"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("e337f1ec-b22c-4ddf-8b5e-bd5afa946129"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("e4a264bc-0a02-4720-917c-fca59bb573ff"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("e52850d9-f3a4-4d46-a265-3667403ac2e9"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("ea2f8e0d-eb55-4452-90a1-f810474cbe7f"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("eaf447ef-beea-4eaa-a94c-00acd311ef42"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("ed9b74af-8587-4aff-abd4-8957e4eb1ca7"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("ef1f2981-782a-40c7-b0dc-5e6a85bb7055"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("f03b85c5-d584-4d0b-8d38-d7356f469375"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("f0c4a679-e5fd-4329-811c-0735cff97711"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("f2dfcabe-52e1-4e25-84f2-054cc9f9a772"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("f3b65829-46e4-4143-b39b-86136de26b7f"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("f3d34bfd-85e1-4dec-bc22-5f4eca6c9fc2"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("f42cbe69-d1a1-45bd-9a93-8aaa606744ca"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("f5faf27e-6f57-4035-a94e-1055cd927ed1"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("f80c0da1-8be6-4a46-a578-edfce3af270d"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("f8124011-adb0-4454-9da7-91f0e182fa33"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("f9e3238a-97a1-4718-ab92-31d5236547b3"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("fcece400-14b5-481a-b5d7-fe67bf28f913"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("fd960aa9-8876-4dff-9d99-94c1c3738c04"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("fed28090-372d-456f-9a1e-c207058ac144"));

            migrationBuilder.DeleteData(
                table: "actors",
                keyColumn: "id",
                keyValue: new Guid("ff728ce9-28c4-4e30-9e50-bd0e7fba3b39"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("00641073-88cb-471e-bea0-8e6601494d09"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("07d1c2e1-a2e2-4ee5-873f-b101cc613a25"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("12010e19-dd0f-4195-b3c6-7dc6702c8a32"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("13f91c44-a819-49c8-8ed3-3c003171ddc3"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("23fb559e-9a66-4423-af07-b97d9de649fe"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("2a90d8b6-82d8-4581-9fa7-ecaa5832dc26"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("2fad653d-7cde-4b92-a5e8-a3928570f756"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("34b8a65e-15f2-424a-b164-600afe23f814"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("368e82a0-da8c-4d1b-90b0-749f12faecfa"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("377d6f6f-4aeb-4046-9ded-dfaf7e8d59a5"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("3a981e02-9650-4cc4-ba2f-978979789984"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("40009b98-ece3-42b4-8c7d-a10b4dda5b38"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("43268f2d-7bfb-4c62-b49d-b868b1fc2568"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("441db5ba-a442-43f9-8e18-363cf678f5d2"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("4ab20a27-63b5-42ee-a9de-aef4b0866153"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("4d91f3a2-6c96-4a58-90f7-bbea29063a5f"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("4e35a624-d5db-4900-b43e-c0f9b7d28590"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("50219472-6180-4b85-a5ac-fdf4079ccf58"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("512d850d-0dad-429a-a2f8-5a492651e8d5"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("5247d8b6-6f31-4995-86c9-4196332328a0"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("59d62ca3-2be7-4ef6-bfbc-362b4ff49fac"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("5b248551-840b-4632-8aaf-3e1b16252d65"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("5c3f62e1-a6ca-4286-9cb3-5cbc0afc3d8b"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("614bf670-e4d2-4b35-a208-c84a6c75c764"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("623d306a-95f7-48f7-9f09-aa298685ac3b"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("63c3517c-d626-4181-a444-0adeeb056878"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("66275523-30e6-48e0-8c65-dab3d3fb12f8"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("6851194f-61a0-4df1-8e89-2030ca47fe24"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("69941e20-653e-4ddf-a9ef-7a98f601ba61"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("6ea110b0-5980-49ec-9812-bdc05ca854be"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("6f6779da-99ae-44d9-a61a-43ebe5f0fd77"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("700ebda0-232e-4b1c-9be2-bf6a99893d6d"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("70a5373e-e526-4766-9194-e6d1a536485c"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("75a766dd-73cd-4a3b-81ef-738e4b72a23d"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("78e7000a-1425-4340-938a-cf4a5bac6775"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("794c142d-386f-4a8a-8290-adf396a07f6a"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("7c1f4dea-492d-446f-ba11-aa0794b54350"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("7c9e4721-3564-4a95-952b-37e8a5eff337"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("86e3b9d0-b465-4b7e-95a4-f1da2a66ada2"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("885e7b27-c1c2-4ab8-8a6c-f676ecec60df"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("88b25038-308e-4253-82c0-4a57151ad908"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("91e01bcd-a47d-48d9-b79d-8ed6c4886699"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("93d7a78d-d7aa-43d0-8d7d-91a22b7c7619"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("97448f10-b164-4880-82ed-a1ac239d0afd"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("97951c83-8686-45c8-be13-a0b0f79539a5"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("9d0944ab-9bfa-4345-8ee6-6f52787b19c4"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("9d52bd23-4ee9-499d-8789-0d860eef65a3"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("9dcd678b-7dee-47d1-aff7-567156607a86"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("9e1126ac-ddca-4012-9204-8d0480e417d1"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("a4a49163-f174-4a42-9f88-1f1b30325ef5"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("a6600fb9-7a83-44fa-827e-03dd66e62e9a"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("a7061bb8-f59a-4ab7-ad3c-dce86b7ccbdc"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("a7b10c31-a060-4436-bef3-4b08014e794e"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("acc9eaf0-be41-4f4c-a4f2-4bee8da3e4a0"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("af12ea31-878c-43ce-95ac-bb3d54f277f4"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("b0e94565-1376-46f0-b5c4-2aedc6d30ce7"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("b235003d-d473-464d-a300-7049e31d0a6d"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("bd56340e-eea7-4e83-9b69-6ede4a939bd8"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("c2159ffd-c180-4a04-8499-62c1886a4ac9"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("c441109b-5d90-4b44-847f-ec113694e334"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("c4987c3e-6ee2-49f5-8caa-bb515b019e8b"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("c6c210c2-c80b-474e-9d97-2751200097ae"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("c6d7d61d-0ab2-4789-85fe-053e438cfe2a"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("cb0c0fb5-1799-4ad4-99f3-d78c0a1e21cf"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("cb8a9632-001b-464e-905c-2a0062f1bcaf"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("d04029bd-e8d4-4e65-ac84-094d766d8306"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("d19b2756-5235-4f96-9577-7281f1d36d38"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("d5a8997f-b046-436f-aada-c06dd2ca0f1c"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("d5e2cd4f-959d-4a19-becf-404713d46271"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("d6bf3fb7-df18-4e5c-bce4-1f7cf55b8848"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("d83ca8b1-f2da-4aa3-b5b8-a35ec94d20c4"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("daed155e-81be-42e0-8d7a-dc2db09eb148"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("e02b1783-545f-4c73-8374-768e6cfbf4c4"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("e131229c-a516-492d-898d-635a5b6c95e4"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("e9626460-ec88-4203-99b7-d918105fef03"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("e96c3640-af75-4342-bf73-2c249993f934"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("f01bf412-3480-4c18-9b6f-418f947c1ba2"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("f0744c2c-c60f-4ae2-9227-beb769c6bb74"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("f1ff0736-167e-464c-98b3-66361a5952bb"));

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: new Guid("f2661055-d0cd-4e35-ada5-bd9369ecc094"));
        }
    }
}
