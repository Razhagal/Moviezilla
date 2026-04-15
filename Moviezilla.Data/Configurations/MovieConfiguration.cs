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
            .Property(m => m.Rating)
            .IsRequired()
            .HasDefaultValue(RatingMinValue);
        
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

        builder
            .ToTable(t => t.HasCheckConstraint(
                $"ck_{nameof(Movie).ToLower()}_{nameof(Movie.Rating).ToLower()}",
                $"{nameof(Movie.Rating).ToLower()} >= {RatingMinValue} AND {nameof(Movie.Rating).ToLower()} <= {RatingMaxValue}"
            ));
        
        builder
            .ToTable(t => t.HasCheckConstraint(
                $"ck_{nameof(Movie).ToLower()}_{nameof(Movie.Duration).ToLower()}",
                $"{nameof(Movie.Duration).ToLower()} >= {DurationMin}"
            ));

        builder
            .HasData(SeedMovies());
    }

    private static List<Movie> SeedMovies() =>
    [
        new Movie()
        {
            Id = new Guid("f0744c2c-c60f-4ae2-9227-beb769c6bb74"),
            Title = "Mad Max: Fury Road",
            Genre = "Action",
            Rating = 8.1f,
            Description = "An apocalyptic story set in the furthest reaches of our planet, in a stark desert landscape where humanity is broken, and almost everyone is crazed fighting for the necessities of life. Within this world exist two rebels on the run who just might be able to restore order. There's Max, a man of action and a man of few words, who seeks peace of mind following the loss of his wife and child in the aftermath of the chaos. And Furiosa, a woman of action and a woman who believes her path to survival may be achieved if she can make it across the desert back to her childhood homeland.",
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
            Rating = 8.2f,
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
            Rating = 7.5f,
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
            Rating = 8.5f,
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
            Rating = 9.1f,
            Description = "Set within a year after the events of Batman Begins (2005), Batman, Lieutenant James Gordon, and new District Attorney Harvey Dent successfully begin to round up the criminals that plague Gotham City, until a mysterious and sadistic criminal mastermind known only as \"The Joker\" appears in Gotham, creating a new wave of chaos. Batman's struggle against The Joker becomes deeply personal, forcing him to \"confront everything he believes\" and improve his technology to stop him. A love triangle develops between Bruce Wayne, Dent, and Rachel Dawes.",
            ShortDescription = "When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness.",
            ReleaseDate = new DateOnly(2008, 7, 18),
            DirectorName = "Christopher Nolan",
            Duration = 152,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_FMjpg_UY2048_.jpg"
        },
        new Movie()
        {
            Id = new Guid("f01bf412-3480-4c18-9b6f-418f947c1ba2"),
            Title = "The Matrix",
            Genre = "Action",
            Rating = 8.7f,
            Description = "Thomas A. Anderson is a man living two lives. By day he is an average computer programmer and by night a hacker known as Neo. Neo has always questioned his reality, but the truth is far beyond his imagination. Neo finds himself targeted by the police when he is contacted by Morpheus, a legendary computer hacker branded a terrorist by the government. As a rebel against the machines, Neo must confront the agents: super-powerful computer programs devoted to stopping Neo and the entire human rebellion.",
            ShortDescription = "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.",
            ReleaseDate = new DateOnly(1999, 3, 31),
            DirectorName = "The Wachowskis",
            Duration = 136,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BZjVkOGM1ZTctZGZmOC00MTM0LWFjYjctNjg2MTg1YTM4N2VlXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg"
        },
        new Movie()
        {
            Id = new Guid("614bf670-e4d2-4b35-a208-c84a6c75c764"),
            Title = "Terminator 2: Judgment Day",
            Genre = "Action",
            Rating = 8.6f,
            Description = "Over ten years have passed since the first machine called The Terminator tried to kill Sarah Connor and her unborn son, John. The man who will become the future leader of the human resistance against the Machines is now a healthy young boy. However, another Terminator, called the T-1000, is sent back through time by the self-aware computer system, Skynet. This new Terminator is more advanced and more powerful than its predecessor and its mission is to kill John Connor when he's still a child. However, Sarah and John do not have to face the threat of the T-1000 alone. Another Terminator (identical to the same model that tried and failed to kill Sarah Connor in 1984) is also sent back through time to protect them. While John teaches the Terminator about humanity, Sarah tries to prevent the creation of Skynet and the Machines.",
            ShortDescription = "A cyborg from the future, identical to the one who failed to kill Sarah Connor, must now protect her ten-year-old son John from an even more advanced and powerful cyborg.",
            ReleaseDate = new DateOnly(1991, 7, 3),
            DirectorName = "James Cameron",
            Duration = 137,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMWM3MDE3ZmYtMGQ3MC00NTMzLThjMGItOWQxM2YzNTI4YTE4XkEyXkFqcGc@._V1_FMjpg_UY2500_.jpg"
        },
        new Movie()
        {
            Id = new Guid("78e7000a-1425-4340-938a-cf4a5bac6775"),
            Title = "Casino Royale",
            Genre = "Action",
            Rating = 8.0f,
            Description = "James Bond (Daniel Craig) goes on his first mission as a 00. Le Chiffre (Mads Mikkelsen) is a banker to the world's terrorists. He is participating in a poker game at Montenegro, where he must win back his money, in order to stay safe amongst the terrorist market. The boss of MI6, known simply as \"M\" (Dame Judi Dench) sends Bond, along with Vesper Lynd (Eva Green) to attend this game and prevent Le Chiffre from winning. Bond, using help from Felix Leiter (Jeffrey Wright), Rene Mathis (Giancarlo Giannini), and having Vesper pose as his partner, enters the most important poker game in his already dangerous career. But if Bond defeats Le Chiffre, will he and Vesper Lynd remain safe?",
            ShortDescription = "After earning a licence to kill, secret agent James Bond sets out on his first mission as 007. Bond must defeat a private banker funding terrorists in a high-stakes game of poker at Casino Royale, in Montenegro.",
            ReleaseDate = new DateOnly(2006, 11, 17),
            DirectorName = "Martin Campbell",
            Duration = 144,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMWQ1ZDM4NDktMWY0NC00MjcxLWJlMDMtNmE2MGVhYzRjMWQ0XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg"
        },
        new Movie()
        {
            Id = new Guid("5247d8b6-6f31-4995-86c9-4196332328a0"),
            Title = "Mission: Impossible – Fallout",
            Genre = "Action",
            Rating = 7.7f,
            Description = "Two years after Ethan Hunt had successfully captured Solomon Lane, the remnants of the Syndicate have reformed into another organization called the Apostles. Under the leadership of a mysterious fundamentalist known only as John Lark, the organization is planning on acquiring three plutonium cores. Ethan and his team are sent to Berlin to intercept them, but the mission fails when Ethan saves Luther and the Apostles escape with the plutonium. With CIA agent August Walker joining the team, Ethan and his allies must now find the plutonium cores before it's too late.",
            ShortDescription = "A group of terrorists plans to detonate three plutonium cores for a simultaneous nuclear attack on different cities. Ethan Hunt, along with his IMF team, sets out to stop the carnage.",
            ReleaseDate = new DateOnly(2018, 7, 27),
            DirectorName = "Christopher McQuarrie",
            Duration = 147,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BZGEzYjgxYmEtODY2My00NGM2LTlkOTEtNjMzY2Y4Yzg4MTJmXkEyXkFqcGc@._V1_FMjpg_UX726_.jpg"
        },
        new Movie()
        {
            Id = new Guid("a7b10c31-a060-4436-bef3-4b08014e794e"),
            Title = "300",
            Genre = "Action",
            Rating = 7.6f,
            Description = "In the Battle of Thermopylae of 480 BC an alliance of Greek city-states fought the invading Persian army in the mountain pass of Thermopylae. Vastly outnumbered, the Greeks held back the enemy in one of the most famous last stands of history. Persian King Xerxes led a Army of well over 100,000 (Persian king Xerxes before war has about 170,000 army) men to Greece and was confronted by 300 Spartans, 700 Thespians, and 400 Thebans. Xerxes waited for 10 days for King Leonidas to surrender or withdraw but left with no options he pushed forward. After 3 days of battle all the Greeks were killed. The Spartan defeat was not the one expected, as a local shepherd, named Ephialtes, defected to the Persians and informed Xerxes that the separate path through Thermopylae, which the Persians could use to outflank the Greeks, was not as heavily guarded as they thought.",
            ShortDescription = "In the ancient battle of Thermopylae, King Leonidas and 300 Spartans fight against Xerxes and his massive Persian army.",
            ReleaseDate = new DateOnly(2007, 3, 9),
            DirectorName = "Zack Snyder",
            Duration = 117,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjc4OTc0ODgwNV5BMl5BanBnXkFtZTcwNjM1ODE0MQ@@._V1_FMjpg_UY2880_.jpg"
        },
        new Movie()
        {
            Id = new Guid("d83ca8b1-f2da-4aa3-b5b8-a35ec94d20c4"),
            Title = "The Hangover",
            Genre = "Comedy",
            Rating = 7.7f,
            Description = "Angelenos Doug Billings and Tracy Garner are about to get married. Two days before the wedding, the four men in the wedding party - Doug, Doug's two best buddies Phil Wenneck and Stu Price, and Tracy's brother Alan Garner - hop into Tracy's father's beloved Mercedes convertible for a 24-hour stag party to Las Vegas. Phil, a married high school teacher, has the same maturity level as his students when he's with his pals. Stu, a dentist, is worried about everything, especially what his controlling girlfriend Melissa thinks. Because she disapproves of traditional male bonding rituals, Stu has to lie to her about the stag, he telling her that they are going on a wine tasting tour in the Napa Valley. Regardless, he intends on eventually marrying her, against the advice and wishes of his friends. And Alan seems to be unaware of what are considered the social graces of the western world. The morning after their arrival in Las Vegas, they awaken in their hotel suite each with the worst hangover. None remembers what happened in the past twelve or so hours. The suite is in shambles. And certain things are in the suite that shouldn't be, and certain things that should be in the suite are missing. Probably the most important in the latter category is Doug. As Phil, Stu and Alan try to find Doug using only what little pieces of information they have at hand, they go on a journey of discovery of how certain things got into the suite and what happened to the missing items. However they are on a race for time as if they can't find Doug in the next few hours, they are going to have to explain to Tracy why they are not yet back in Los Angeles. And even worse, they may not find Doug at all before the wedding.",
            ShortDescription = "Three buddies wake up from a bachelor party in Las Vegas with no memory of the previous night and the bachelor missing. They must make their way around the city in order to find their friend in time for his wedding.",
            ReleaseDate = new DateOnly(2009, 6, 5),
            DirectorName = "Todd Phillips",
            Duration = 100,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BYmIyODg0N2EtYjg5NC00NjdlLWFkZTgtMmE0NzI4ZGM5ODk1XkEyXkFqcGc@._V1_FMjpg_UX681_.jpg"
        },
        new Movie()
        {
            Id = new Guid("a7061bb8-f59a-4ab7-ad3c-dce86b7ccbdc"),
            Title = "Superbad",
            Genre = "Comedy",
            Rating = 7.6f,
            Description = "Seth and Evan are best friends, inseparable, navigating the last weeks of high school. Usually shunned by the popular kids, Seth and Evan luck into an invitation to a party, and spend a long day, with the help of their nerdy friend Fogell, trying to score enough alcohol to lubricate the party and inebriate two girls, Jules and Becca, so they can kick-start their sex lives and go off to college with a summer full of experience and new skills. Their quest is complicated by Fogell's falling in with two inept cops who both slow and assist the plan. If they do get the liquor to the party, what then? Is sex the only rite of passage at hand?",
            ShortDescription = "Two co-dependent high school seniors are forced to deal with separation anxiety after their plan to stage a booze-soaked party goes awry.",
            ReleaseDate = new DateOnly(2007, 8, 17),
            DirectorName = "Greg Mottola",
            Duration = 113,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNjk0MzdlZGEtNTRkOC00ZDRiLWJkYjAtMzUzYTRiNzk1YTViXkEyXkFqcGc@._V1_FMjpg_UY2940_.jpg"
        },
        new Movie()
        {
            Id = new Guid("9d52bd23-4ee9-499d-8789-0d860eef65a3"),
            Title = "Dumb and Dumber",
            Genre = "Comedy",
            Rating = 7.3f,
            Description = "Harry and Lloyd are two good friends who happen to be really stupid. The duo set out on a cross country trip from Providence to Aspen, Colorado to return a briefcase full of money to its rightful owner, a beautiful woman named Mary Swanson. After a trip of one mishap after another, the duo eventually make it to Aspen. But the two soon realize that Mary and her briefcase are the least of their problems.",
            ShortDescription = "After a woman leaves a briefcase at the airport terminal, a dumb limo driver and his dumber friend set out on a hilarious cross-country road trip to Aspen to return it.",
            ReleaseDate = new DateOnly(1994, 12, 16),
            DirectorName = "Peter Farrelly",
            Duration = 107,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BYTQxZmNhNTgtZjBlOC00MWQ0LThkOTktNzMyNDBlZDg4ZmJjXkEyXkFqcGc@._V1_FMjpg_UX350_.jpg"
        },
        new Movie()
        {
            Id = new Guid("69941e20-653e-4ddf-a9ef-7a98f601ba61"),
            Title = "Mean Girls",
            Genre = "Comedy",
            Rating = 7.1f,
            Description = "Lindsay Lohan stars as Cady Heron, a 16 year old homeschooled girl who not only makes the mistake of falling for Aaron Samuels (Jonathan Bennett), the ex-boyfriend of queenbee Regina George (Rachel McAdams), but also unintentionally joins The Plastics, led by Regina herself. Join Cady as she learns that high school life can and will be really tough.",
            ShortDescription = "Cady Heron is a hit with The Plastics, the A-list girl clique at her new school, until she makes the mistake of falling for Aaron Samuels, the ex-boyfriend of alpha Plastic Regina George.",
            ReleaseDate = new DateOnly(2004, 4, 30),
            DirectorName = "Mark Waters",
            Duration = 97,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjE1MDQ4MjI1OV5BMl5BanBnXkFtZTcwNzcwODAzMw@@._V1_FMjpg_UY2048_.jpg"
        },
        new Movie()
        {
            Id = new Guid("4e35a624-d5db-4900-b43e-c0f9b7d28590"),
            Title = "Home Alone",
            Genre = "Comedy",
            Rating = 7.8f,
            Description = "It is Christmas time and the McCallister family is preparing for a vacation in Paris, France. But the youngest in the family, Kevin (Macaulay Culkin), got into a scuffle with his older brother Buzz (Devin Ratray) and was sent to his room, which is on the third floor of his house. Then, the next morning, while the rest of the family was in a rush to make it to the airport on time, they completely forgot about Kevin, who now has the house all to himself. Being home alone was fun for Kevin, having a pizza all to himself, jumping on his parents' bed, and making a mess. Then, Kevin discovers about two burglars, Harry (Joe Pesci) and Marv (Daniel Stern), about to rob his house on Christmas Eve. Kevin acts quickly by wiring his own house with makeshift booby traps to stop the burglars and to bring them to justice.",
            ShortDescription = "An eight-year-old troublemaker, mistakenly left home alone, must defend his home against a pair of burglars on Christmas Eve.",
            ReleaseDate = new DateOnly(1990, 11, 16),
            DirectorName = "Chris Columbus",
            Duration = 103,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNzNmNmQ2ZDEtMTc1MS00NjNiLThlMGUtZmQxNTg1Nzg5NWMzXkEyXkFqcGc@._V1_FMjpg_UY1985_.jpg"
        },
        new Movie()
        {
            Id = new Guid("66275523-30e6-48e0-8c65-dab3d3fb12f8"),
            Title = "Step Brothers",
            Genre = "Comedy",
            Rating = 6.9f,
            Description = "Brennan Huff and Dale Doback are both about 40 when Brennan's mom and Dale's dad marry. The sons still live with the parents so they must now share a room. Initial antipathy threatens the household's peace and the parents' relationship. Dad lays down the law: both slackers have a month to find a job. Out of the job search and their love of music comes a pact that leads to friendship but more domestic disarray compounded by the boys' sleepwalking. Hovering nearby are Brennan's successful brother and his lonely wife: the brother wants to help sell his step-father's house, the wife wants Dale's attention, and the newlyweds want to retire and sail the seven seas. Can harmony come from the discord?",
            ShortDescription = "Two aimless middle-aged losers still living at home are forced against their will to become roommates when their parents marry.",
            ReleaseDate = new DateOnly(2008, 7, 25),
            DirectorName = "Adam McKay",
            Duration = 98,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BYWNiOGZkOTgtNGMzMC00MDg5LTliM2UtN2VjMDI3N2ViOWE5XkEyXkFqcGc@._V1_FMjpg_UX1079_.jpg"
        },
        new Movie()
        {
            Id = new Guid("d04029bd-e8d4-4e65-ac84-094d766d8306"),
            Title = "Anchorman: The Legend of Ron Burgundy",
            Genre = "Comedy",
            Rating = 7.1f,
            Description = "In 1970s San Diego, journalism was a well respected profession and people actually cared about what they saw on TV. And the top rated anchor man in the city is Ron Burgundy. He enjoys his run at the top, and has for the last five years. And his news team is equally as good as he is. Professional jock and former professional baseball player Champ Kind handles the sports, the curiously dim witted Brick Tamland - who's a few channels short of a cable subscription - handles the weather, and ladies' man Brian Fantana - whose collection of fine scents would be in the Guinness Book Of Records - handles the on-field reporting. But now all that is about to change forever. The TV station Burgundy works for, Channel 4, has embraced diversity and has hired a beautiful new female anchor named Veronica Corningstone. While Ron Burgundy and the rest of the Channel 4 news team enjoys fighting with competitors, drinking, and flirting with the ladies, Veronica quietly climbs her way to the top. And Veronica's success drives Ron Burgundy crazy. So much that Veronica's meddling causes Ron to get demoted and ultimately lose his job with Channel 6. Now left with nothing, Ron must find a way to get back to the top - and that involves a story about a rare Chinese panda giving birth on US soil. Will Ron be the one to report the story on a national level?",
            ShortDescription = "In the 1970s, an anchorman's stint as San Diego's top-rated newsreader is challenged when an ambitious newswoman becomes his co-anchor.",
            ReleaseDate = new DateOnly(2004, 7, 9),
            DirectorName = "Adam McKay",
            Duration = 94,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTQ2MzYwMzk5Ml5BMl5BanBnXkFtZTcwOTI4NzUyMw@@._V1_FMjpg_UY2048_.jpg"
        },
        new Movie()
        {
            Id = new Guid("e9626460-ec88-4203-99b7-d918105fef03"),
            Title = "The Mask",
            Genre = "Comedy",
            Rating = 7.0f,
            Description = "Timid bank clerk, Stanley Ipkiss (Jim Carrey). Unfortunately, he's too gentle, and is unable to handle confrontations. After one of the worst days, he finds a mask which depicts Loki, the Norse god of mischief. When he puts it on, he becomes his inner, self: a cartoon wild man. After Ipkiss's alter ego indirectly kills the friend of small time crime boss, Dorian Tyrel (Peter Greene),he wants the green-faced goon destroyed.",
            ShortDescription = "Bank clerk Stanley Ipkiss is transformed into a manic superhero when he wears a mysterious mask.",
            ReleaseDate = new DateOnly(1994, 7, 29),
            DirectorName = "Chuck Russell",
            Duration = 101,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNGNmNjI0ZmMtMzI5MC00ZjUyLWFlZDEtYjUyMGZlN2E3N2E2XkEyXkFqcGc@._V1_FMjpg_UX1009_.jpg"
        },
        new Movie()
        {
            Id = new Guid("00641073-88cb-471e-bea0-8e6601494d09"),
            Title = "Rush Hour",
            Genre = "Comedy",
            Rating = 7.1f,
            Description = "Cultures clash and tempers flares as the two cops named Detective Inspector Lee a Hong Kong Detective and Detective James Carter LAPD, a big-mouthed work-alone Los Angeles cop who are from different worlds discovers one thing in common: they can't stand each other. With time running out, they must join forces to catch the criminals and save the eleven-year-old Chinese girl of the Chinese consul named Soo Yung.",
            ShortDescription = "A loyal and dedicated Hong Kong Inspector teams up with a reckless and loudmouthed L.A.P.D. detective to rescue the Chinese Consul's kidnapped daughter, while trying to arrest a dangerous crime lord along the way.",
            ReleaseDate = new DateOnly(1998, 9, 18),
            DirectorName = "Brett Ratner",
            Duration = 98,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMGZiMzViNmEtNTNlZi00MzFmLTk5NTEtNDE2OTUzNmNlMTY4XkEyXkFqcGc@._V1_FMjpg_UX850_.jpg"
        },
        new Movie()
        {
            Id = new Guid("b0e94565-1376-46f0-b5c4-2aedc6d30ce7"),
            Title = "Bruce Almighty",
            Genre = "Comedy",
            Rating = 6.8f,
            Description = "Bruce Nolan, a television reporter in Buffalo, NY, is discontented with almost everything in life despite his popularity and the love of his girlfriend Grace. At the end of the worst day of his life, Bruce angrily ridicules and rages against God and God responds. God appears in human form and, endowing Bruce with divine powers, challenges Bruce to take on the big job to see if he can do it any better.",
            ShortDescription = "A whiny news reporter is given the chance to step into God's shoes.",
            ReleaseDate = new DateOnly(2003, 5, 23),
            DirectorName = "Tom Shadyac",
            Duration = 101,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BZWM2ZjA2OTctZmRhMy00ZDIzLTkwZGQtYTRlNmQwZWZmMDBlXkEyXkFqcGc@._V1_FMjpg_UY1895_.jpg"
        },
        new Movie()
        {
            Id = new Guid("23fb559e-9a66-4423-af07-b97d9de649fe"),
            Title = "Se7en",
            Genre = "Thriller",
            Rating = 8.6f,
            Description = "Taking place in a nameless city, Se7en follows the story of two homicide detectives tracking down a sadistic serial killer who chooses his victims according to the seven deadly sins. Brad Pitt stars as Detective David Mills, a hopeful but naive rookie who finds himself partnered with veteran Detective William Somerset (Morgan Freeman). Together they trace the killer's every step, witnessing the aftermath of his horrific crimes one by one as the victims pile up in rapid succession, all the while moving closer to a gruesome fate neither of them could have predicted.",
            ShortDescription = "Two detectives try to track down a serial killer who chooses his victims based on the Seven Deadly Sins.",
            ReleaseDate = new DateOnly(1995, 9, 22),
            DirectorName = "David Fincher",
            Duration = 127,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BY2IzNzMxZjctZjUxZi00YzAxLTk3ZjMtODFjODdhMDU5NDM1XkEyXkFqcGc@._V1_FMjpg_UY2815_.jpg"
        },
        new Movie()
        {
            Id = new Guid("50219472-6180-4b85-a5ac-fdf4079ccf58"),
            Title = "Gone Girl",
            Genre = "Thriller",
            Rating = 8.1f,
            Description = "On the occasion of his fifth wedding anniversary, Nick Dunne reports that his wife, Amy, has gone missing. Under pressure from the police and a growing media frenzy, Nick's portrait of a blissful union begins to crumble. Soon his lies, deceits and strange behavior have everyone asking the same dark question: Did Nick Dunne kill his wife?",
            ShortDescription = "The husband of a missing woman becomes the main suspect in her disappearance.",
            ReleaseDate = new DateOnly(2014, 10, 3),
            DirectorName = "David Fincher",
            Duration = 149,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTk0MDQ3MzAzOV5BMl5BanBnXkFtZTgwNzU1NzE3MjE@._V1_FMjpg_UY2048_.jpg"
        },
        new Movie()
        {
            Id = new Guid("daed155e-81be-42e0-8d7a-dc2db09eb148"),
            Title = "The Silence of the Lambs",
            Genre = "Thriller",
            Rating = 8.6f,
            Description = "F.B.I. trainee Clarice Starling (Jodie Foster) works hard to advance her career, while trying to hide or put behind her West Virginia roots, of which if some knew, would automatically classify her as being backward or white trash. After graduation, she aspires to work in the agency's Behavioral Science Unit under the leadership of Jack Crawford (Scott Glenn). While she is still a trainee, Crawford asks her to question Dr. Hannibal Lecter (Sir Anthony Hopkins), a psychiatrist imprisoned, thus far, for eight years in maximum security isolation for being a serial killer who cannibalized his victims. Clarice is able to figure out the assignment is to pick Lecter's brains to help them solve another serial murder case, that of someone coined by the media as \"Buffalo Bill\" (Ted Levine), who has so far killed five victims, all located in the eastern U.S., all young women, who are slightly overweight (especially around the hips), all who were drowned in natural bodies of water, and all who were stripped of large swaths of skin. She also figures that Crawford chose her, as a woman, to be able to trigger some emotional response from Lecter. After speaking to Lecter for the first time, she realizes that everything with him will be a psychological game, with her often having to read between the very cryptic lines he provides. She has to decide how much she will play along, as his request in return for talking to him is to expose herself emotionally to him. The case takes a more dire turn when a sixth victim is discovered, this one from who they are able to retrieve a key piece of evidence, if Lecter is being forthright as to its meaning. A potential seventh victim is high profile Catherine Martin (Brooke Smith), the daughter of Senator Ruth Martin (Diane Baker), which places greater scrutiny on the case as they search for a hopefully still alive Catherine. Who may factor into what happens is Dr. Frederick Chilton (Anthony Heald), the warden at the prison, an opportunist who sees the higher profile with Catherine, meaning a higher profile for himself if he can insert himself successfully into the proceedings.",
            ShortDescription = "A young F.B.I. cadet must receive the help of an incarcerated and manipulative cannibal killer to help catch another serial killer, a madman who skins his victims.",
            ReleaseDate = new DateOnly(1991, 2, 14),
            DirectorName = "Jonathan Demme",
            Duration = 118,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNDdhOGJhYzctYzYwZC00YmI2LWI0MjctYjg4ODdlMDExYjBlXkEyXkFqcGc@._V1_FMjpg_UY2968_.jpg"
        },
        new Movie()
        {
            Id = new Guid("e131229c-a516-492d-898d-635a5b6c95e4"),
            Title = "Shutter Island",
            Genre = "Thriller",
            Rating = 8.2f,
            Description = "In 1954, up-and-coming U.S. marshal Teddy Daniels is assigned to investigate the disappearance of a patient from Boston's Shutter Island Ashecliffe Hospital. He's been pushing for an assignment on the island for personal reasons, but before long he thinks he's been brought there as part of a twisted plot by hospital doctors whose radical treatments range from unethical to illegal to downright sinister. Teddy's shrewd investigating skills soon provide a promising lead, but the hospital refuses him access to records he suspects would break the case wide open. As a hurricane cuts off communication with the mainland, more dangerous criminals \"escape\" in the confusion, and the puzzling, improbable clues multiply, Teddy begins to doubt everything - his memory, his partner, even his own sanity.",
            ShortDescription = "Two US marshals are sent to a mental institution on an inhospitable island in order to investigate the disappearance of a patient.",
            ReleaseDate = new DateOnly(2010, 2, 19),
            DirectorName = "Martin Scorsese",
            Duration = 138,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BN2FjNWExYzEtY2YzOC00YjNlLTllMTQtNmIwM2Q1YzBhOWM1XkEyXkFqcGc@._V1_FMjpg_UY3000_.jpg"
        },
        new Movie()
        {
            Id = new Guid("40009b98-ece3-42b4-8c7d-a10b4dda5b38"),
            Title = "Prisoners",
            Genre = "Thriller",
            Rating = 8.2f,
            Description = "How far would you go to protect your family? Keller Dover is facing every parent's worst nightmare. His six-year-old daughter, Anna, is missing, together with her young friend, Joy, and as minutes turn to hours, panic sets in. The only lead is a dilapidated RV that had earlier been parked on their street. Heading the investigation, Detective Loki arrests its driver, Alex Jones, but a lack of evidence forces his release. As the police pursue multiple leads and pressure mounts, knowing his child's life is at stake the frantic Dover decides he has no choice but to take matters into his own hands. But just how far will this desperate father go to protect his family?",
            ShortDescription = "A desperate father takes the law into his own hands after police fail to find two kidnapped girls.",
            ReleaseDate = new DateOnly(2013, 9, 20),
            DirectorName = "Denis Villeneuve",
            Duration = 153,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTg0NTIzMjQ1NV5BMl5BanBnXkFtZTcwNDc3MzM5OQ@@._V1_FMjpg_UY2048_.jpg"
        },
        new Movie()
        {
            Id = new Guid("9dcd678b-7dee-47d1-aff7-567156607a86"),
            Title = "Zodiac",
            Genre = "Thriller",
            Rating = 7.7f,
            Description = "A serial killer in the San Francisco Bay Area taunts police with his letters and cryptic messages. We follow the investigators and reporters in this lightly fictionalized account of the true 1970s' case as they search for the murderer, becoming obsessed with the case. Based on Robert Graysmith's book, the movie's focus is the lives and careers of the detectives and newspaper people.",
            ShortDescription = "Between 1968 and 1983, a San Francisco cartoonist becomes an amateur detective obsessed with tracking down the Zodiac Killer, an unidentified individual who terrorizes Northern California with a killing spree.",
            ReleaseDate = new DateOnly(2007, 3, 2),
            DirectorName = "David Fincher",
            Duration = 157,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNDFkMTRkZmQtM2I0NC00NjJjLWJlMDctNTNiZWYxYzhjZDZiXkEyXkFqcGc@._V1_FMjpg_UY2867_.jpg"
        },
        new Movie()
        {
            Id = new Guid("794c142d-386f-4a8a-8290-adf396a07f6a"),
            Title = "Nightcrawler",
            Genre = "Thriller",
            Rating = 7.8f,
            Description = "NIGHTCRAWLER is a thriller set in the nocturnal underbelly of contemporary Los Angeles. Jake Gyllenhaal stars as Lou Bloom, a driven young man desperate for work who discovers the high-speed world of L.A. crime journalism. Finding a group of freelance camera crews who film crashes, fires, murder and other mayhem, Lou muscles into the cut-throat, dangerous realm of nightcrawling - where each police siren wail equals a possible windfall and victims are converted into dollars and cents. Aided by Rene Russo as Nina, a veteran of the blood-sport that is local TV news, Lou blurs the line between observer and participant to become the star of his own story.",
            ShortDescription = "A petty thief desperate for work muscles into the world of crime journalism and becomes the star of his own story as he blurs the line between observer and participant.",
            ReleaseDate = new DateOnly(2014, 10, 31),
            DirectorName = "Dan Gilroy",
            Duration = 117,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BYjMwMmI5MWQtOTU4OS00OTAyLTg0OTYtNmQ5YzExZTQ3ZWJhXkEyXkFqcGc@._V1_FMjpg_UX650_.jpg"
        },
        new Movie()
        {
            Id = new Guid("d5a8997f-b046-436f-aada-c06dd2ca0f1c"),
            Title = "The Girl with the Dragon Tattoo",
            Genre = "Thriller",
            Rating = 7.8f,
            Description = "Mikael Blomkvist is a disgraced journalist who is asked by a wealthy industrialist to write a biography on his family. But what he really wants Blomkvist to do is to find out what happened to his niece, who went missing 40 years ago. At first Blomkvist isn't interested, until the man offers to help him clear his name. Blomkvist begins by talking to the man's relatives who were there when the girl went missing, but some of them are not forthcoming. Blomkvist eventually believes that her disappearance might have something to do with some serial killings that took place 20 years before she disappeared, so he asks for a research assistant. The industrialist's man suggests Lisbeth Salander, a talented hacker who does background checks for them and who even did one on Blomkvist. When he sees her report, he's impressed and asks her to work with him and she does. She's anti-social but is extremely efficient.",
            ShortDescription = "Journalist Mikael Blomkvist is aided in his search for a woman who has been missing for 40 years by hacker Lisbeth Salander.",
            ReleaseDate = new DateOnly(2011, 12, 21),
            DirectorName = "David Fincher",
            Duration = 158,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTczNDk4NTQ0OV5BMl5BanBnXkFtZTcwNDAxMDgxNw@@._V1_FMjpg_UY2048_.jpg"
        },
        new Movie()
        {
            Id = new Guid("3a981e02-9650-4cc4-ba2f-978979789984"),
            Title = "Black Swan",
            Genre = "Thriller",
            Rating = 8.0f,
            Description = "Nina (Portman) is a ballerina in a New York City ballet company whose life, like all those in her profession, is completely consumed with dance. She lives with her obsessive former ballerina mother Erica (Hershey) who exerts a suffocating control over her. When artistic director Thomas Leroy (Cassel) decides to replace prima ballerina Beth MacIntyre (Ryder) for the opening production of their new season, Swan Lake, Nina is his first choice. But Nina has competition: a new dancer, Lily (Kunis), who impresses Leroy as well. Swan Lake requires a dancer who can play both the White Swan with innocence and grace, and the Black Swan, who represents guile and sensuality. Nina fits the White Swan role perfectly but Lily is the personification of the Black Swan. As the two young dancers expand their rivalry into a twisted friendship, Nina begins to get more in touch with her dark side - a recklessness that threatens to destroy her.",
            ShortDescription = "Nina is a talented but unstable ballerina on the verge of stardom. Pushed to the breaking point by her artistic director and a seductive rival, Nina's grip on reality slips, plunging her into a waking nightmare.",
            ReleaseDate = new DateOnly(2010, 12, 17),
            DirectorName = "Darren Aronofsky",
            Duration = 108,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNzY2NzI4OTE5MF5BMl5BanBnXkFtZTcwMjMyNDY4Mw@@._V1_FMjpg_UY2048_.jpg"
        },
        new Movie()
        {
            Id = new Guid("c6d7d61d-0ab2-4789-85fe-053e438cfe2a"),
            Title = "No Country for Old Men",
            Genre = "Thriller",
            Rating = 8.2f,
            Description = "In rural Texas, welder and hunter Llewelyn Moss (Josh Brolin) discovers the remains of several drug runners who have all killed each other in an exchange gone violently wrong. Rather than report the discovery to the police, Moss decides to simply take the two million dollars present for himself. This puts the psychopathic killer, Anton Chigurh (Javier Bardem), on his trail as he dispassionately murders nearly every rival, bystander and even employer in his pursuit of his quarry and the money. As Moss desperately attempts to keep one step ahead, the blood from this hunt begins to flow behind him with relentlessly growing intensity as Chigurh closes in. Meanwhile, the laconic Sheriff Ed Tom Bell (Tommy Lee Jones) blithely oversees the investigation even as he struggles to face the sheer enormity of the crimes he is attempting to thwart.",
            ShortDescription = "Violence and mayhem ensue after a hunter stumbles upon the aftermath of a drug deal gone wrong and over two million dollars in cash near the Rio Grande.",
            ReleaseDate = new DateOnly(2007, 11, 9),
            DirectorName = "Coen Brothers",
            Duration = 122,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjA5Njk3MjM4OV5BMl5BanBnXkFtZTcwMTc5MTE1MQ@@._V1_FMjpg_UX555_.jpg"
        },
        new Movie()
        {
            Id = new Guid("c2159ffd-c180-4a04-8499-62c1886a4ac9"),
            Title = "The Shawshank Redemption",
            Genre = "Drama",
            Rating = 9.3f,
            Description = "Chronicles the experiences of a formerly successful banker as a prisoner in the gloomy jailhouse of Shawshank after being found guilty of a crime he did not commit. The film portrays the man's unique way of dealing with his new, torturous life; along the way he befriends a number of fellow prisoners, most notably a wise long-term inmate named Red.",
            ShortDescription = "A wrongfully convicted banker forms a close friendship with a hardened convict over a quarter century while retaining his humanity through simple acts of compassion.",
            ReleaseDate = new DateOnly(1994, 9, 23),
            DirectorName = "Frank Darabont",
            Duration = 142,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMDAyY2FhYjctNDc5OS00MDNlLThiMGUtY2UxYWVkNGY2ZjljXkEyXkFqcGc@._V1_FMjpg_UX1200_.jpg"
        },
        new Movie()
        {
            Id = new Guid("c441109b-5d90-4b44-847f-ec113694e334"),
            Title = "Forrest Gump",
            Genre = "Drama",
            Rating = 8.8f,
            Description = "Forrest Gump is a simple man with a low I.Q. but good intentions. He is running through childhood with his best and only friend Jenny. His 'mama' teaches him the ways of life and leaves him to choose his destiny. Forrest joins the army for service in Vietnam, finding new friends called Dan and Bubba, he wins medals, creates a famous shrimp fishing fleet, inspires people to jog, starts a ping-pong craze, creates the smiley, writes bumper stickers and songs, donates to people and meets the president several times. However, this is all irrelevant to Forrest who can only think of his childhood sweetheart Jenny Curran, who has messed up her life. Although in the end all he wants to prove is that anyone can love anyone.",
            ShortDescription = "The history of the United States from the 1950s to the '70s unfolds from the perspective of an Alabama man with an IQ of 75, who yearns to be reunited with his childhood sweetheart.",
            ReleaseDate = new DateOnly(1994, 7, 6),
            DirectorName = "Robert Zemeckis",
            Duration = 142,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNDYwNzVjMTItZmU5YS00YjQ5LTljYjgtMjY2NDVmYWMyNWFmXkEyXkFqcGc@._V1_FMjpg_UX558_.jpg"
        },
        new Movie()
        {
            Id = new Guid("f1ff0736-167e-464c-98b3-66361a5952bb"),
            Title = "Fight Club",
            Genre = "Drama",
            Rating = 8.8f,
            Description = "A nameless first-person narrator attends support groups in an attempt to subdue his emotional state and relieve his insomniac state. When he meets Marla, another fake attendee of support groups, his life seems to become a little more bearable. However, when he associates himself with Tyler he is dragged into an underground fight club and soap-making scheme. Together the two men spiral out of control and engage in competitive rivalry for love and power.",
            ShortDescription = "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.",
            ReleaseDate = new DateOnly(1999, 10, 15),
            DirectorName = "David Fincher",
            Duration = 139,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BOTgyOGQ1NDItNGU3Ny00MjU3LTg2YWEtNmEyYjBiMjI1Y2M5XkEyXkFqcGc@._V1_FMjpg_UX1066_.jpg"
        },
        new Movie()
        {
            Id = new Guid("e02b1783-545f-4c73-8374-768e6cfbf4c4"),
            Title = "The Godfather",
            Genre = "Drama",
            Rating = 9.2f,
            Description = "The Godfather \"Don\" Vito Corleone is the head of the Corleone mafia family in New York. He is at the event of his daughter's wedding. Michael, Vito's youngest son and a decorated WWII Marine is also present at the wedding. Michael seems to be uninterested in being a part of the family business. Vito is a powerful man, and is kind to all those who give him respect but is ruthless against those who do not. But when a powerful and treacherous rival wants to sell drugs and needs the Don's influence for the same, Vito refuses to do it. What follows is a clash between Vito's fading old values and the new ways which may cause Michael to do the thing he was most reluctant in doing and wage a mob war against all the other mafia families which could tear the Corleone family apart.",
            ShortDescription = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
            ReleaseDate = new DateOnly(1972, 3, 24),
            DirectorName = "Francis Ford Coppola",
            Duration = 175,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNGEwYjgwOGQtYjg5ZS00Njc1LTk2ZGEtM2QwZWQ2NjdhZTE5XkEyXkFqcGc@._V1_FMjpg_UY1982_.jpg"
        },
        new Movie()
        {
            Id = new Guid("86e3b9d0-b465-4b7e-95a4-f1da2a66ada2"),
            Title = "A Beautiful Mind",
            Genre = "Drama",
            Rating = 8.2f,
            Description = "Mathematician John Nash rises to prominence at Princeton with his groundbreaking theories in game theory. While achieving academic success, he begins experiencing paranoid delusions and hallucinations, straining his relationships with his wife Alicia and colleagues. Nash struggles with schizophrenia, gradually learning to distinguish reality from illusion while continuing his work. The film explores genius, mental illness, love, and perseverance, showing the challenges of balancing personal struggles with professional achievement.",
            ShortDescription = "A mathematical genius, John Nash made an astonishing discovery early in his career and stood on the brink of international acclaim. But Nash soon found himself on a harrowing journey of self-discovery.",
            ReleaseDate = new DateOnly(2001, 12, 21),
            DirectorName = "Ron Howard",
            Duration = 135,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BYjgzNjFkMmItOGJhNi00NWM3LWJlYTUtNDExMGQ3ZTI3NjJkXkEyXkFqcGc@._V1_FMjpg_UY2943_.jpg"
        },
        new Movie()
        {
            Id = new Guid("d19b2756-5235-4f96-9577-7281f1d36d38"),
            Title = "The Green Mile",
            Genre = "Drama",
            Rating = 8.6f,
            Description = "Based on Stephen King's 1996 novel of the same name. Stars Tom Hanks as a death row corrections officer during the U.S. Great Depression who witnesses supernatural events that occur after an enigmatic inmate (Michael Clarke Duncan) is brought to his facility.",
            ShortDescription = "A death row guard learns that a gentle giant in his charge possesses a mysterious gift.",
            ReleaseDate = new DateOnly(1999, 12, 10),
            DirectorName = "Frank Darabont",
            Duration = 189,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTUxMzQyNjA5MF5BMl5BanBnXkFtZTYwOTU2NTY3._V1_FMjpg_UX500_.jpg"
        },
        new Movie()
        {
            Id = new Guid("34b8a65e-15f2-424a-b164-600afe23f814"),
            Title = "Titanic",
            Genre = "Drama",
            Rating = 8.0f,
            Description = "84 years later, a 100 year-old woman named Rose DeWitt Bukater tells the story to her granddaughter Lizzy Calvert, Brock Lovett, Lewis Bodine, Bobby Buell and Anatoly Mikailavich on the Keldysh about her life set in April 10th 1912, on a ship called Titanic when young Rose boards the departing ship with the upper-class passengers and her mother, Ruth DeWitt Bukater, and her fiancé, Caledon Hockley. Meanwhile, a drifter and artist named Jack Dawson and his best friend Fabrizio De Rossi win third-class tickets to the ship in a game. And she explains the whole story from departure until the death of Titanic on its first and last voyage April 15th, 1912 at 2:20 in the morning.",
            ShortDescription = "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic.",
            ReleaseDate = new DateOnly(1997, 12, 19),
            DirectorName = "James Cameron",
            Duration = 195,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BYzYyN2FiZmUtYWYzMy00MzViLWJkZTMtOGY1ZjgzNWMwN2YxXkEyXkFqcGc@._V1_FMjpg_UY3000_.jpg"
        },
        new Movie()
        {
            Id = new Guid("97448f10-b164-4880-82ed-a1ac239d0afd"),
            Title = "Whiplash",
            Genre = "Drama",
            Rating = 8.5f,
            Description = "Nineteen-year-old Andrew Nieman wants to be the greatest jazz drummer in the world, in a league with Buddy Rich. This goal is despite not coming from a pedigree of greatest, musical or otherwise, with Jim, his high-school-teacher father, being a failed writer. Andrew is starting his first year at Shaffer Conservatory of Music, the best music school in the United States. At Shaffer, being the best means being accepted to study under Terence Fletcher and being asked to play in his studio band, which represents the school at jazz competitions. Based on their less than positive first meeting, Andrew is surprised that Fletcher asks him to join the band, albeit in the alternate drummer position which he is more than happy to do initially. Andrew quickly learns that Fletcher operates on fear and intimidation, never settling for what he considers less than the best each and every time. Being the best in Fletcher's mind does not only entail playing well, but knowing that you're playing well and if not what you're doing wrong. His modus operandi creates an atmosphere of fear and of every man or woman for him/herself within the band. Regardless, Andrew works hard to be the best. He has to figure out his life priorities and what he is willing to sacrifice to be the best. The other question becomes how much emotional abuse he will endure by Fletcher to reach that greatness, which he may believe he can only achieve with the avenues opened up by Fletcher.",
            ShortDescription = "A promising young drummer enrolls at a cut-throat music conservatory where his dreams of greatness are mentored by an instructor who will stop at nothing to realize a student's potential.",
            ReleaseDate = new DateOnly(2014, 10, 10),
            DirectorName = "Damien Chazelle",
            Duration = 107,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMDFjOWFkYzktYzhhMC00NmYyLTkwY2EtYjViMDhmNzg0OGFkXkEyXkFqcGc@._V1_FMjpg_UY5333_.jpg"
        },
        new Movie()
        {
            Id = new Guid("91e01bcd-a47d-48d9-b79d-8ed6c4886699"),
            Title = "The Social Network",
            Genre = "Drama",
            Rating = 7.8f,
            Description = "On a fall night in 2003, Harvard undergrad and computer programming genius Mark Zuckerberg sits down at his computer and heatedly begins working on a new idea. In a fury of blogging and programming, what begins in his dorm room soon becomes a global social network and a revolution in communication. A mere six years and 500 million friends later, Mark Zuckerberg is the youngest billionaire in history... but for this entrepreneur, success leads to both personal and legal complications.",
            ShortDescription = "As Harvard student Mark Zuckerberg creates the social networking site that would become known as Facebook, he is sued by the twins who claimed he stole their idea and by the co-founder who was later squeezed out of the business.",
            ReleaseDate = new DateOnly(2010, 10, 1),
            DirectorName = "David Fincher",
            Duration = 120,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjlkNTE5ZTUtNGEwNy00MGVhLThmZjMtZjU1NDE5Zjk1NDZkXkEyXkFqcGc@._V1_FMjpg_UX675_.jpg"
        },
        new Movie()
        {
            Id = new Guid("7c1f4dea-492d-446f-ba11-aa0794b54350"),
            Title = "Joker",
            Genre = "Drama",
            Rating = 8.3f,
            Description = "A socially inept clown for hire - Arthur Fleck aspires to be a stand up comedian among his small job working dressed as a clown holding a sign for advertising. He takes care of his mother, Penny Fleck, and as he learns more about his mental illness, he learns more about his past. Dealing with all the negativity and bullying from society, he heads downwards on a spiral, in turn showing how his alter ego, \"Joker,\" came to be.",
            ShortDescription = "Arthur Fleck, a party clown and a failed stand-up comedian, leads an impoverished life with his ailing mother. However, when society shuns him and brands him as a freak, he decides to embrace the life of chaos in Gotham City.",
            ReleaseDate = new DateOnly(2019, 10, 4),
            DirectorName = "Todd Phillips",
            Duration = 122,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNzY3OWQ5NDktNWQ2OC00ZjdlLThkMmItMDhhNDk3NTFiZGU4XkEyXkFqcGc@._V1_FMjpg_UY4096_.jpg"
        },
        new Movie()
        {
            Id = new Guid("c4987c3e-6ee2-49f5-8caa-bb515b019e8b"),
            Title = "The Exorcist",
            Genre = "Horror",
            Rating = 8.1f,
            Description = "A visiting actress in Washington, D.C., notices dramatic and dangerous changes in the behavior and physical makeup of her 12 year-old daughter. Meanwhile, a young priest at nearby Georgetown University begins to doubt his faith while dealing with his mother's terminal sickness. A frail, elderly priest recognizes the necessity for a show-down with an old demonic enemy.",
            ShortDescription = "When a mysterious entity possesses a young girl, her mother seeks the help of two Catholic priests to save her life.",
            ReleaseDate = new DateOnly(1973, 12, 26),
            DirectorName = "William Friedkin",
            Duration = 122,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BZjg3YjE4ZjAtYTdmYS00ZTBkLWE1ZjgtNzAzODUwNzRiYjlmXkEyXkFqcGc@._V1_FMjpg_UY2239_.jpg"
        },
        new Movie()
        {
            Id = new Guid("368e82a0-da8c-4d1b-90b0-749f12faecfa"),
            Title = "Hereditary",
            Genre = "Horror",
            Rating = 7.3f,
            Description = "When Ellen, the matriarch of the Graham family, passes away, her daughter's family begins to unravel cryptic and increasingly terrifying secrets about their ancestry. The more they discover, the more they find themselves trying to outrun the sinister fate they seem to have inherited. Making his feature debut, writer-director Ari Aster unleashes a nightmare vision of a domestic breakdown that exhibits the craft and precision of a nascent auteur, transforming a familial tragedy into something ominous and deeply disquieting, and pushing the horror movie into chilling new terrain with its shattering portrait of heritage gone to hell.",
            ShortDescription = "A grieving family is haunted by tragic and disturbing occurrences.",
            ReleaseDate = new DateOnly(2018, 6, 8),
            DirectorName = "Ari Aster",
            Duration = 127,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNTEyZGQwODctYWJjZi00NjFmLTg3YmEtMzlhNjljOGZhMWMyXkEyXkFqcGc@._V1_FMjpg_UY3000_.jpg"
        },
        new Movie()
        {
            Id = new Guid("70a5373e-e526-4766-9194-e6d1a536485c"),
            Title = "The Conjuring",
            Genre = "Horror",
            Rating = 7.5f,
            Description = "In 1971, Carolyn and Roger Perron move their family into a dilapidated Rhode Island farm house and soon strange things start happening around it with escalating nightmarish terror. In desperation, Carolyn contacts the noted paranormal investigators, Ed and Lorraine Warren, to examine the house. What the Warrens discover is a whole area steeped in a satanic haunting that is now targeting the Perron family wherever they go. To stop this evil, the Warrens will have to call upon all their skills and spiritual strength to defeat this spectral menace at its source that threatens to destroy everyone involved.",
            ShortDescription = "Paranormal investigators Ed and Lorraine Warren work to help a family terrorized by a dark presence in their farmhouse.",
            ReleaseDate = new DateOnly(2013, 7, 19),
            DirectorName = "James Wan",
            Duration = 112,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTM3NjA1NDMyMV5BMl5BanBnXkFtZTcwMDQzNDMzOQ@@._V1_FMjpg_UX1200_.jpg"
        },
        new Movie()
        {
            Id = new Guid("acc9eaf0-be41-4f4c-a4f2-4bee8da3e4a0"),
            Title = "A Nightmare on Elm Street",
            Genre = "Horror",
            Rating = 7.4f,
            Description = "On Elm Street, Nancy Thompson and a group of her friends (comprising Tina Gray, Rod Lane and Glen Lantz) are being tormented by a clawed killer in their dreams named Fred Krueger. Nancy must think quickly, as Fred tries to pick them off one by one. When he has you in your sleep, who is there to save you?",
            ShortDescription = "Teenager Nancy Thompson must uncover the dark truth concealed by her parents after she and her friends become targets of the spirit of a serial killer with a bladed glove in their dreams, in which if they die, it kills them in real life.",
            ReleaseDate = new DateOnly(1984, 11, 9),
            DirectorName = "Wes Craven",
            Duration = 91,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNTZmN2VlMWMtMTdlMi00NDBhLWIyODMtODEwMzM0ODMwMWYwXkEyXkFqcGc@._V1_FMjpg_UX780_.jpg"
        }, 
        new Movie()
        {
            Id = new Guid("43268f2d-7bfb-4c62-b49d-b868b1fc2568"),
            Title = "Get Out",
            Genre = "Horror",
            Rating = 7.8f,
            Description = "Chris and his girlfriend Rose go upstate to visit her parents for the weekend. At first, Chris reads the family's overly accommodating behavior as nervous attempts to deal with their daughter's interracial relationship, but as the weekend progresses, a series of increasingly disturbing discoveries lead him to a truth that he never could have imagined.",
            ShortDescription = "A young African-American visits his white girlfriend's parents for the weekend, where his simmering uneasiness about their reception of him eventually reaches a boiling point.",
            ReleaseDate = new DateOnly(2017, 2, 24),
            DirectorName = "Jordan Peele",
            Duration = 104,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjUxMDQwNjcyNl5BMl5BanBnXkFtZTgwNzcwMzc0MTI@._V1_FMjpg_UY2048_.jpg"
        },
        new Movie()
        {
            Id = new Guid("b235003d-d473-464d-a300-7049e31d0a6d"),
            Title = "It",
            Genre = "Horror",
            Rating = 7.3f,
            Description = "In the Town of Derry, the local kids are disappearing one by one. In a place known as 'The Barrens', a group of seven kids are united by their horrifying and strange encounters with an evil clown and their determination to kill It.",
            ShortDescription = "In the summer of 1989, a group of bullied kids band together to destroy a shape-shifting monster, which disguises itself as a clown and preys on the children of Derry, their small Maine town.",
            ReleaseDate = new DateOnly(2017, 9, 8),
            DirectorName = "Andy Muschietti",
            Duration = 135,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjIzZWM4NjktMjZjZS00ZTA3LWJhODEtNzE1MWFkNDEzODVlXkEyXkFqcGc@._V1_FMjpg_UY4096_.jpg"
        },
        new Movie()
        {
            Id = new Guid("7c9e4721-3564-4a95-952b-37e8a5eff337"),
            Title = "The Ring",
            Genre = "Horror",
            Rating = 7.1f,
            Description = "Rachel Keller is a journalist investigating a videotape that may have killed four teenagers (including her niece). There is an urban legend about this tape: the viewer will die seven days after watching it. If the legend is correct, Rachel will have to run against time to save her son's and her own life.",
            ShortDescription = "A journalist must investigate a mysterious videotape which seems to cause the death of anyone one week to the day after they view it.",
            ReleaseDate = new DateOnly(2002, 10, 18),
            DirectorName = "Gore Verbinski",
            Duration = 115,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNDA2NTg2NjE4Ml5BMl5BanBnXkFtZTYwMjYxMDg5._V1_FMjpg_UX485_.jpg"
        },
        new Movie()
        {
            Id = new Guid("4d91f3a2-6c96-4a58-90f7-bbea29063a5f"),
            Title = "Halloween",
            Genre = "Horror",
            Rating = 7.7f,
            Description = "The year is 1963, the night: Halloween. Police are called to 43 Lampkin Ln. only to discover that 15-year-old Judith Myers has been stabbed to death by her 6-year-old brother, Michael. After being institutionalized for 15 years, Myers breaks out on the night before Halloween. No one knows, nor wants to find out, what will happen on October 31st 1978, besides Myers' psychiatrist, Dr. Loomis. He knows Michael is coming back to Haddonfield, but by the time the town realizes it, it'll be too late for many people.",
            ShortDescription = "Fifteen years after murdering his sister on Halloween night 1963, Michael Myers escapes from a mental hospital and returns to the small town of Haddonfield, Illinois, to kill again.",
            ReleaseDate = new DateOnly(1978, 10, 25),
            DirectorName = "John Carpenter",
            Duration = 91,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMzZiNTdiYTgtYjNkMS00MmJmLWEwZGQtNmY0NGJkMGE0YmYzXkEyXkFqcGc@._V1_FMjpg_UX580_.jpg"
        },
        new Movie()
        {
            Id = new Guid("07d1c2e1-a2e2-4ee5-873f-b101cc613a25"),
            Title = "The Shining",
            Genre = "Horror",
            Rating = 8.4f,
            Description = "After landing a job as an off-season caretaker, Jack Torrance, an aspiring author and recovering alcoholic, drags his wife Wendy and gifted son Danny to snow-covered Colorado's secluded Overlook Hotel. However, writer's block prevents Jack from pursuing a new writing career. Everything has its time, however. First, the manager must give Jack a grand tour. Then, Mr Hallorann, the facility's aging chef, chats with Danny about rare psychic gifts. The mysterious employee also warns the boy about the cavernous hotel's abandoned rooms. Room 237, especially, is off-limits. That's all very well, but Jack is gradually losing his mind. After all, strange occurrences and blood-chilling visions have trapped the family in a silent gargantuan prison hammered by endless snowstorms. And now, incessant voices inside Jack's head demand sacrifice. However, is Jack capable of murder?",
            ShortDescription = "A family heads to an isolated hotel for the winter, where a sinister presence influences the father into violence. At the same time, his psychic son sees horrifying forebodings from both the past and the future.",
            ReleaseDate = new DateOnly(1980, 5, 23),
            DirectorName = "Stanley Kubrick",
            Duration = 146,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BYjZiZDIxMjctZTk0NS00YTE1LTg5NGYtOTZkOTNkZDAzZjkwXkEyXkFqcGc@._V1_FMjpg_UX1080_.jpg"
        },
        new Movie()
        {
            Id = new Guid("f2661055-d0cd-4e35-ada5-bd9369ecc094"),
            Title = "Insidious",
            Genre = "Horror",
            Rating = 6.8f,
            Description = "Brimming with excitement and hope for a fresh start, Josh and Renai Lambert move into their new home with their three children. But the couple's bliss is short-lived. As a mysterious accident leaves their boy, Dalton, in a science-defying coma for months, blood-chilling occurrences in the house can only mean one thing: something evil has set its sights on robbing the Lamberts of what they hold dear. With sickness replacing happiness, experienced paranormal investigator Elise Rainier agrees to infiltrate The Further, the dark realm of lost spirits, to search for the Lamberts' missing son. However, after the life-altering experience in Insidious: The Last Key (2018), Elise is more exposed to all-consuming darkness. As answers demand courage and faith, could Dalton's shackled soul be trapped behind the ominous red-lacquered door?",
            ShortDescription = "A family looks to prevent evil spirits from trapping their comatose child in a realm called The Further.",
            ReleaseDate = new DateOnly(2010, 9, 14),
            DirectorName = "James Wan",
            Duration = 103,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BODNiNTM3MTMtZGRmYi00OTUxLTkxOWYtMTcxYzU1ZTdlMjIwXkEyXkFqcGc@._V1_FMjpg_UX819_.jpg"
        },
        new Movie()
        {
            Id = new Guid("93d7a78d-d7aa-43d0-8d7d-91a22b7c7619"),
            Title = "Avengers: Endgame",
            Genre = "Superhero",
            Rating = 8.4f,
            Description = "After the devastating events of Avengers: Infinity War (2018), the universe is in ruins due to the efforts of the Mad Titan, Thanos. With the help of remaining allies, the Avengers must assemble once more in order to undo Thanos's actions and undo the chaos to the universe, no matter what consequences may be in store, and no matter who they face...",
            ShortDescription = "After the devastating events of Avengers: Infinity War (2018), the universe is in ruins. With the help of remaining allies, the Avengers assemble once more in order to reverse Thanos' actions and restore balance to the universe.",
            ReleaseDate = new DateOnly(2019, 4, 26),
            DirectorName = "Russo Brothers",
            Duration = 181,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTc5MDE2ODcwNV5BMl5BanBnXkFtZTgwMzI2NzQ2NzM@._V1_FMjpg_UY2048_.jpg"
        },
        new Movie()
        {
            Id = new Guid("97951c83-8686-45c8-be13-a0b0f79539a5"),
            Title = "Spider-Man: No Way Home",
            Genre = "Superhero",
            Rating = 8.1f,
            Description = "Peter Parker's secret identity is revealed to the entire world. Desperate for help, Peter turns to Doctor Strange to make the world forget that he is Spider-Man. The spell goes horribly wrong and shatters the multiverse, bringing in monstrous villains that could destroy the world.",
            ShortDescription = "With Spider-Man's identity now revealed, Peter asks Doctor Strange for help. When a spell goes wrong, dangerous foes from other worlds start to appear.",
            ReleaseDate = new DateOnly(2021, 12, 17),
            DirectorName = "Jon Watts",
            Duration = 148,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMmFiZGZjMmEtMTA0Ni00MzA2LTljMTYtZGI2MGJmZWYzZTQ2XkEyXkFqcGc@._V1_FMjpg_UY2100_.jpg"
        },
        new Movie()
        {
            Id = new Guid("59d62ca3-2be7-4ef6-bfbc-362b4ff49fac"),
            Title = "Black Panther",
            Genre = "Superhero",
            Rating = 7.3f,
            Description = "After the events of Captain America: Civil War, Prince T'Challa returns home to the reclusive, technologically advanced African nation of Wakanda to serve as his country's new king. However, T'Challa soon finds that he is challenged for the throne from factions within his own country. When two foes conspire to destroy Wakanda, the hero known as Black Panther must team up with C.I.A. agent Everett K. Ross and members of the Dora Milaje, Wakandan special forces, to prevent Wakanda from being dragged into a world war.",
            ShortDescription = "T'Challa, heir to the hidden but advanced kingdom of Wakanda, must step forward to lead his people into a new future and must confront a challenger from his country's past.",
            ReleaseDate = new DateOnly(2018, 2, 16),
            DirectorName = "Ryan Coogler",
            Duration = 134,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTg1MTY2MjYzNV5BMl5BanBnXkFtZTgwMTc4NTMwNDI@._V1_FMjpg_UY2048_.jpg"
        },
        new Movie()
        {
            Id = new Guid("cb0c0fb5-1799-4ad4-99f3-d78c0a1e21cf"),
            Title = "Logan",
            Genre = "Superhero",
            Rating = 8.1f,
            Description = "In 2029 the mutant population has shrunk significantly due to genetically modified plants designed to reduce mutant powers and the X-Men have disbanded. Logan, whose power to self-heal is dwindling, has surrendered himself to alcohol and now earns a living as a chauffeur. He takes care of the ailing old Professor X whom he keeps hidden away. One day, a female stranger asks Logan to drive a girl named Laura to the Canadian border. At first he refuses, but the Professor has been waiting for a long time for her to appear. Laura possesses an extraordinary fighting prowess and is in many ways like Wolverine. She is pursued by sinister figures working for a powerful corporation; this is because they made her, with Logan's DNA. A decrepit Logan is forced to ask himself if he can or even wants to put his remaining powers to good use. It would appear that in the near-future, the times in which they were able put the world to rights with razor sharp claws and telepathic powers are now over.",
            ShortDescription = "In a future where mutants are nearly extinct, an elderly and weary Logan leads a quiet life. But when Laura, a mutant child pursued by scientists, comes to him for help, he must get her to safety.",
            ReleaseDate = new DateOnly(2017, 3, 3),
            DirectorName = "James Mangold",
            Duration = 137,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BM2JjODdkMGMtNmY2YS00OGM2LThiY2YtZGYyNzE4Nzc2ODA0XkEyXkFqcGc@._V1_FMjpg_UX520_.jpg"
        },
        new Movie()
        {
            Id = new Guid("75a766dd-73cd-4a3b-81ef-738e4b72a23d"),
            Title = "Iron Man",
            Genre = "Superhero",
            Rating = 7.9f,
            Description = "Tony Stark. Genius, billionaire, playboy, philanthropist. Son of legendary inventor and weapons contractor Howard Stark. When Tony Stark is assigned to give a weapons presentation to an Iraqi unit led by Lt. Col. James Rhodes, he's given a ride on enemy lines. That ride ends badly when Stark's Humvee that he's riding in is attacked by enemy combatants. He survives - barely - with a chest full of shrapnel and a car battery attached to his heart. In order to survive he comes up with a way to miniaturize the battery and figures out that the battery can power something else. Thus Iron Man is born. He uses the primitive device to escape from the cave in Iraq. Once back home, he then begins work on perfecting the Iron Man suit. But the man who was put in charge of Stark Industries has plans of his own to take over Tony's technology for other matters.",
            ShortDescription = "After being held captive in an Afghan cave, billionaire engineer Tony Stark creates a unique weaponized suit of armor to fight evil.",
            ReleaseDate = new DateOnly(2008, 5, 2),
            DirectorName = "Jon Favreau",
            Duration = 126,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTczNTI2ODUwOF5BMl5BanBnXkFtZTcwMTU0NTIzMw@@._V1_FMjpg_UY2048_.jpg"
        },
        new Movie()
        {
            Id = new Guid("512d850d-0dad-429a-a2f8-5a492651e8d5"),
            Title = "The Dark Knight Rises",
            Genre = "Superhero",
            Rating = 8.4f,
            Description = "Despite his tarnished reputation after the events of The Dark Knight (2008), in which he took the rap for Dent's crimes, Batman feels compelled to intervene to assist the city and its Police force, which is struggling to cope with Bane's plans to destroy the city.",
            ShortDescription = "Bane, an imposing terrorist, attacks Gotham City and disrupts its eight-year-long period of peace. This forces Bruce Wayne to come out of hiding and don the cape and cowl of Batman again.",
            ReleaseDate = new DateOnly(2012, 7, 20),
            DirectorName = "Christopher Nolan",
            Duration = 164,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTk4ODQzNDY3Ml5BMl5BanBnXkFtZTcwODA0NTM4Nw@@._V1_FMjpg_UX486_.jpg"
        },
        new Movie()
        {
            Id = new Guid("377d6f6f-4aeb-4046-9ded-dfaf7e8d59a5"),
            Title = "Deadpool",
            Genre = "Superhero",
            Rating = 8.0f,
            Description = "This is the origin story of former Special Forces operative turned mercenary Wade Wilson, who after being subjected to a rogue experiment that leaves him with accelerated healing powers, adopts the alter ego Deadpool. Armed with his new abilities and a dark, twisted sense of humor, Deadpool hunts down the man who nearly destroyed his life.",
            ShortDescription = "A wisecracking mercenary gets experimented on and becomes immortal yet hideously scarred, and sets out to track down the man who ruined his looks.",
            ReleaseDate = new DateOnly(2016, 2, 12),
            DirectorName = "Tim Miller",
            Duration = 108,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNzY3ZWU5NGQtOTViNC00ZWVmLTliNjAtNzViNzlkZWQ4YzQ4XkEyXkFqcGc@._V1_FMjpg_UY3000_.jpg"
        },
        new Movie()
        {
            Id = new Guid("6ea110b0-5980-49ec-9812-bdc05ca854be"),
            Title = "Doctor Strange",
            Genre = "Superhero",
            Rating = 7.5f,
            Description = "Marvel's \"Doctor Strange\" follows the story of the talented neurosurgeon Doctor Stephen Strange who, after a tragic car accident, must put ego aside and learn the secrets of a hidden world of mysticism and alternate dimensions. Based in New York City's Greenwich Village, Doctor Strange must act as an intermediary between the real world and what lies beyond, utilising a vast array of metaphysical abilities and artifacts to protect the Marvel Cinematic Universe.",
            ShortDescription = "While on a journey of physical and spiritual healing, a brilliant neurosurgeon is drawn into the world of the mystic arts.",
            ReleaseDate = new DateOnly(2016, 11, 4),
            DirectorName = "Scott Derrickson",
            Duration = 115,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNjgwNzAzNjk1Nl5BMl5BanBnXkFtZTgwMzQ2NjI1OTE@._V1_FMjpg_UY2048_.jpg"
        },
        new Movie()
        {
            Id = new Guid("d5e2cd4f-959d-4a19-becf-404713d46271"),
            Title = "Thor: Ragnarok",
            Genre = "Superhero",
            Rating = 7.9f,
            Description = "Imprisoned on the other side of the universe, the mighty Thor finds himself in a deadly gladiatorial contest that puts him against The Incredible Hulk, his former ally and fellow Avenger. Thor's quest for survival leads him in a race against time to prevent the all-powerful Hela from destroying his home world and the Asgardian civilization.",
            ShortDescription = "Imprisoned on the planet Sakaar, Thor must race against time to return to Asgard and stop Ragnarök, the destruction of his world, at the hands of the powerful and ruthless villain Hela.",
            ReleaseDate = new DateOnly(2017, 11, 3),
            DirectorName = "Taika Waititi",
            Duration = 130,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjMyNDkzMzI1OF5BMl5BanBnXkFtZTgwODcxODg5MjI@._V1_FMjpg_UY2048_.jpg"
        },
        new Movie()
        {
            Id = new Guid("5c3f62e1-a6ca-4286-9cb3-5cbc0afc3d8b"),
            Title = "Guardians of the Galaxy",
            Genre = "Superhero",
            Rating = 8.0f,
            Description = "After stealing a mysterious orb in the far reaches of outer space, Peter Quill from Earth is now the main target of a manhunt led by the villain known as Ronan the Accuser. To help fight Ronan and his team and save the galaxy from his power, Quill creates a team of space heroes known as the \"Guardians of the Galaxy\" to save the galaxy.",
            ShortDescription = "A group of intergalactic criminals must pull together to stop a fanatical warrior with plans to purge the universe.",
            ReleaseDate = new DateOnly(2014, 8, 1),
            DirectorName = "James Gunn",
            Duration = 121,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BM2ZmNjQ2MzAtNDlhNi00MmQyLWJhZDMtNmJiMjFlOWY4MzcxXkEyXkFqcGc@._V1_FMjpg_UX1012_.jpg"
        },
        new Movie()
        {
            Id = new Guid("885e7b27-c1c2-4ab8-8a6c-f676ecec60df"),
            Title = "The Lord of the Rings: The Fellowship of the Ring",
            Genre = "Fantasy",
            Rating = 8.9f,
            Description = "An ancient Ring thought lost for centuries has been found, and through a strange twist of fate has been given to a small Hobbit named Frodo. When Gandalf discovers the Ring is in fact the One Ring of the Dark Lord Sauron, Frodo must make an epic quest to Mount Doom in order to destroy it. However, he does not go alone. He is joined by Gandalf, Legolas the elf, Gimli the Dwarf, Aragorn, Boromir, and his three Hobbit friends Merry, Pippin, and Samwise. Through mountains, snow, darkness, forests, rivers and plains, facing evil and danger at every corner the Fellowship of the Ring must go. Their quest to destroy the One Ring is the only hope for the end of the Dark Lords reign.",
            ShortDescription = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
            ReleaseDate = new DateOnly(2001, 12, 19),
            DirectorName = "Peter Jackson",
            Duration = 178,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMzEwYTg2NTMtMTUzYy00ZjE4LThmMjEtZDUyZWM4NzE5MGE5XkEyXkFqcGc@._V1_FMjpg_UY2835_.jpg"
        },
        new Movie()
        {
            Id = new Guid("c6c210c2-c80b-474e-9d97-2751200097ae"),
            Title = "The Lord of the Rings: The Two Towers",
            Genre = "Fantasy",
            Rating = 8.8f,
            Description = "The continuing quest of Frodo and the Fellowship to destroy the One Ring. Frodo and Sam discover they are being followed by the mysterious Gollum. Aragorn, the Elf archer Legolas, and Gimli the Dwarf encounter the besieged Rohan kingdom, whose once great King Theoden has fallen under Saruman's deadly spell.",
            ShortDescription = "While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron's new ally, Saruman, and his hordes of Isengard.",
            ReleaseDate = new DateOnly(2002, 12, 18),
            DirectorName = "Peter Jackson",
            Duration = 179,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMGQxMDdiOWUtYjc1Ni00YzM1LWE2NjMtZTg3Y2JkMjEzMTJjXkEyXkFqcGc@._V1_FMjpg_UX964_.jpg"
        },
        new Movie()
        {
            Id = new Guid("bd56340e-eea7-4e83-9b69-6ede4a939bd8"),
            Title = "The Lord of the Rings: The Return of the King",
            Genre = "Fantasy",
            Rating = 9.0f,
            Description = "The final confrontation between the forces of good and evil fighting for control of the future of Middle-earth. Frodo and Sam reach Mordor in their quest to destroy the One Ring, while Aragorn leads the forces of good against Sauron's evil army at the stone city of Minas Tirith.",
            ShortDescription = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
            ReleaseDate = new DateOnly(2003, 12, 17),
            DirectorName = "Peter Jackson",
            Duration = 201,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTZkMjBjNWMtZGI5OC00MGU0LTk4ZTItODg2NWM3NTVmNWQ4XkEyXkFqcGc@._V1_FMjpg_UX800_.jpg"
        },
        new Movie()
        {
            Id = new Guid("2a90d8b6-82d8-4581-9fa7-ecaa5832dc26"),
            Title = "Harry Potter and the Sorcerer's Stone",    
            Genre = "Fantasy",
            Rating = 7.7f,
            Description = "This is the tale of Harry Potter (Daniel Radcliffe), an ordinary eleven-year-old boy serving as a sort of slave for his aunt and uncle who learns that he is actually a wizard and has been invited to attend the Hogwarts School for Witchcraft and Wizardry. Harry is snatched away from his mundane existence by Rubeus Hagrid (Robbie Coltrane), the groundskeeper for Hogwarts, and quickly thrown into a world completely foreign to both him and the viewer. Famous for an incident that happened at his birth, Harry makes friends easily at his new school. He soon finds, however, that the wizarding world is far more dangerous for him than he would have imagined, and he quickly learns that not all wizards are ones to be trusted.",
            ShortDescription = "An orphaned boy enrolls in a school of wizardry, where he learns the truth about himself, his family and the terrible evil that haunts the magical world.",
            ReleaseDate = new DateOnly(2001, 11, 16),
            DirectorName = "Chris Columbus",
            Duration = 152,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNTU1MzgyMDMtMzBlZS00YzczLThmYWEtMjU3YmFlOWEyMjE1XkEyXkFqcGc@._V1_FMjpg_UY2902_.jpg"
        },
        new Movie()
        {
            Id = new Guid("cb8a9632-001b-464e-905c-2a0062f1bcaf"),
            Title = "Harry Potter and the Prisoner of Azkaban",
            Genre = "Fantasy",
            Rating = 7.9f,
            Description = "Harry Potter (Daniel Radcliffe) is having a tough time with his relatives (yet again). He runs away after using magic to inflate Uncle Vernon's (Richard Griffiths') sister Marge (Pam Ferris), who was being offensive towards Harry's parents. Initially scared for using magic outside the school, he is pleasantly surprised that he won't be penalized after all. However, he soon learns that a dangerous criminal and Voldemort's trusted aide Sirius Black (Gary Oldman) has escaped from Azkaban Prison and wants to kill Harry to avenge the Dark Lord. To worsen the conditions for Harry, vile creatures called Dementors are appointed to guard the school gates and inexplicably happen to have the most horrible effect on him. Little does Harry know that by the end of this year, many holes in his past (whatever he knows of it) will be filled up and he will have a clearer vision of what the future has in store.",
            ShortDescription = "Harry Potter, Ron and Hermione return to Hogwarts School of Witchcraft and Wizardry for their third year of study, where they delve into the mystery surrounding an escaped prisoner who poses a dangerous threat to the young wizard.",
            ReleaseDate = new DateOnly(2004, 6, 4),
            DirectorName = "Alfonso Cuarón",
            Duration = 142,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTY4NTIwODg0N15BMl5BanBnXkFtZTcwOTc0MjEzMw@@._V1_FMjpg_UY2048_.jpg"
        },
        new Movie()
        {
            Id = new Guid("2fad653d-7cde-4b92-a5e8-a3928570f756"),
            Title = "Pan's Labyrinth",
            Genre = "Fantasy",
            Rating = 8.2f,
            Description = "In 1944 Falangist Spain, a girl, fascinated with fairy-tales, is sent along with her pregnant mother to live with her new stepfather, a ruthless captain of the Spanish army. During the night, she meets a fairy who takes her to an old faun in the center of the labyrinth. He tells her she's a princess, but must prove her royalty by surviving three gruesome tasks. If she fails, she will never prove herself to be the true princess and will never see her real father, the king, again.",
            ShortDescription = "In 1944 Francoist Spain, an imaginative young girl meets a faun who tells her she's a princess and that she must prove her worthiness by completing three dangerous tasks.",
            ReleaseDate = new DateOnly(2006, 12, 29),
            DirectorName = "Guillermo del Toro",
            Duration = 118,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BOTc1NTAxMWItMWFlNy00MmU2LTkwMTMtNzMwOTg5OTQ5YTFiXkEyXkFqcGc@._V1_FMjpg_UY2892_.jpg"
        },
        new Movie()
        {
            Id = new Guid("9d0944ab-9bfa-4345-8ee6-6f52787b19c4"),
            Title = "The Hobbit: An Unexpected Journey",
            Genre = "Fantasy",
            Rating = 7.8f,
            Description = "Bilbo Baggins is swept into a quest to reclaim the lost Dwarf Kingdom of Erebor from the fearsome dragon Smaug. Approached out of the blue by the wizard Gandalf the Grey, Bilbo finds himself joining a company of thirteen dwarves led by the legendary warrior, Thorin Oakenshield. Their journey will take them into the Wild; through treacherous lands swarming with Goblins and Orcs, deadly Wargs and Giant Spiders, Shapeshifters and Sorcerers. Although their goal lies to the East and the wastelands of the Lonely Mountain first they must escape the goblin tunnels, where Bilbo meets the creature that will change his life forever ... Gollum. Here, alone with Gollum, on the shores of an underground lake, the unassuming Bilbo Baggins not only discovers depths of guile and courage that surprise even him, he also gains possession of Gollum's \"precious\" ring that holds unexpected and useful qualities ... A simple, gold ring that is tied to the fate of all Middle-earth in ways Bilbo cannot begin to know.",
            ShortDescription = "A reluctant Hobbit, Bilbo Baggins, sets out to the Lonely Mountain with a spirited group of dwarves to reclaim their mountain home and the gold within it from the dragon Smaug.",
            ReleaseDate = new DateOnly(2012, 12, 14),
            DirectorName = "Peter Jackson",
            Duration = 169,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTcwNTE4MTUxMl5BMl5BanBnXkFtZTcwMDIyODM4OA@@._V1_FMjpg_UY2048_.jpg"
        },
        new Movie()
        {
            Id = new Guid("623d306a-95f7-48f7-9f09-aa298685ac3b"),
            Title = "Pirates of the Caribbean: The Curse of the Black Pearl",
            Genre = "Fantasy",
            Rating = 8.1f,
            Description = "This swash-buckling tale follows the quest of Captain Jack Sparrow, a savvy pirate, and Will Turner, a resourceful blacksmith, as they search for Elizabeth Swann. Elizabeth, the daughter of the governor and the love of Will's life, has been kidnapped by the feared Captain Barbossa. Little do they know, but the fierce and clever Barbossa has been cursed. He, along with his large crew, are under an ancient curse, doomed for eternity to neither live, nor die. That is, unless a blood sacrifice is made.",
            ShortDescription = "An intrepid blacksmith teams up with an eccentric pirate captain to save his love from an undead pirate crew.",
            ReleaseDate = new DateOnly(2003, 7, 9),
            DirectorName = "Gore Verbinski",
            Duration = 143,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNDhlMzEyNzItMTA5Mi00YWRhLThlNTktYTQyMTA0MDIyNDEyXkEyXkFqcGc@._V1_FMjpg_UX671_.jpg"
        },
        new Movie()
        {
            Id = new Guid("4ab20a27-63b5-42ee-a9de-aef4b0866153"),
            Title = "The Chronicles of Narnia: The Lion, the Witch and the Wardrobe",
            Genre = "Fantasy",
            Rating = 6.9f,
            Description = "Four children from the same family have to leave their town because of the bombings of WWII. A woman and a professor take the children to their house. While playing a game of hide-and-seek, the youngest member of the family, Lucy, finds a wardrobe to hide in. She travels back and back into the wardrobe and finds a place named Narnia. After going in twice, the four children go in together for the last time. They battle wolves, meet talking animals, encounter an evil white witch and meet a magnificent lion named Aslan. Will this be the end of their journey to Narnia or will they stay?",
            ShortDescription = "Four siblings wind up entering the magical land of Narnia. Once there, they discover a world inhabited by fantastical creatures and find themselves in a battle to defeat a witch.",
            ReleaseDate = new DateOnly(2005, 12, 9),
            DirectorName = "Andrew Adamson",
            Duration = 143,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTc0NTUwMTU5OV5BMl5BanBnXkFtZTcwNjAwNzQzMw@@._V1_FMjpg_UY2048_.jpg"
        },
        new Movie()
        {
            Id = new Guid("441db5ba-a442-43f9-8e18-363cf678f5d2"),
            Title = "Stardust",
            Genre = "Fantasy",
            Rating = 7.6f,
            Description = "The passage from this world to the fantasy kingdom of Stormhold is through a breach in a wall beside an English village. In the 1800s, a boy becomes a man when he ventures through the breach in pursuit of a fallen star, to prove his love for the village beauty. The star is no lump of rock, it's a maiden, Yvaine. Tristan, the youth, is not the only one looking for her: three witches, led by Lamia, want her heart to make them young; and, the sons of the dead king of Stormhold want her because she holds a ruby that will give one of them title to the throne. Assisting Tristan are his mother, the victim of a spell, and a cross-dressing pirate of the skies. Will Tristan win his true love?",
            ShortDescription = "In a countryside town bordering on a magical land, a young man makes a promise to his beloved that he'll retrieve a fallen star by venturing into the magical realm.",
            ReleaseDate = new DateOnly(2007, 8, 10),
            DirectorName = "Matthew Vaughn",
            Duration = 127,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjkyMTE1OTYwNF5BMl5BanBnXkFtZTcwMDIxODYzMw@@._V1_FMjpg_UY2048_.jpg"
        },
        new Movie()
        {
            Id = new Guid("9e1126ac-ddca-4012-9204-8d0480e417d1"),
            Title = "Inception",
            Genre = "Sci-fi",
            Rating = 8.8f,
            Description = "Dom Cobb is a skilled thief, the absolute best in the dangerous art of extraction, stealing valuable secrets from deep within the subconscious during the dream state, when the mind is at its most vulnerable. Cobb's rare ability has made him a coveted player in this treacherous new world of corporate espionage, but it has also made him an international fugitive and cost him everything he has ever loved. Now Cobb is being offered a chance at redemption. One last job could give him his life back but only if he can accomplish the impossible, inception. Instead of the perfect heist, Cobb and his team of specialists have to pull off the reverse: their task is not to steal an idea, but to plant one. If they succeed, it could be the perfect crime. But no amount of careful planning or expertise can prepare the team for the dangerous enemy that seems to predict their every move. An enemy that only Cobb could have seen coming.",
            ShortDescription = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO, but his tragic past may doom the project and his team to disaster.",
            ReleaseDate = new DateOnly(2010, 7, 16),
            DirectorName = "Christopher Nolan",
            Duration = 148,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_FMjpg_UX700_.jpg"
        },
        new Movie()
        {
            Id = new Guid("6851194f-61a0-4df1-8e89-2030ca47fe24"),
            Title = "Interstellar",
            Genre = "Sci-fi",
            Rating = 8.7f,
            Description = "In the near future around the American Midwest, Cooper, an ex-science engineer and pilot, is tied to his farming land with his daughter Murph and son Tom. As devastating sandstorms ravage Earth's crops, the people of Earth realize their life here is coming to an end as food begins to run out. Eventually stumbling upon a N.A.S.A. base 6 hours from Cooper's home, he is asked to go on a daring mission with a few other scientists into a wormhole because of Cooper's scientific intellect and ability to pilot aircraft unlike the other crew members. In order to find a new home while Earth decays, Cooper must decide to either stay, or risk never seeing his children again in order to save the human race by finding another habitable planet.",
            ShortDescription = "When Earth becomes uninhabitable in the future, a farmer and ex-NASA pilot, Joseph Cooper, is tasked to pilot a spacecraft, along with a team of researchers, to find a new planet for humans.",
            ReleaseDate = new DateOnly(2014, 11, 7),
            DirectorName = "Christopher Nolan",
            Duration = 169,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BYzdjMDAxZGItMjI2My00ODA1LTlkNzItOWFjMDU5ZDJlYWY3XkEyXkFqcGc@._V1_FMjpg_UY3600_.jpg"
        },
        new Movie()
        {
            Id = new Guid("63c3517c-d626-4181-a444-0adeeb056878"),
            Title = "Blade Runner 2049",
            Genre = "Sci-fi",
            Rating = 8.0f,
            Description = "Thirty years after the events of Blade Runner (1982), a new Blade Runner, L.A.P.D. Officer \"K\" (Ryan Gosling), unearths a long-buried secret that has the potential to plunge what's left of society into chaos. K's discovery leads him on a quest to find Rick Deckard (Harrison Ford), a former L.A.P.D. Blade Runner, who has been missing for thirty years.",
            ShortDescription = "Young Blade Runner K's discovery of a long-buried secret leads him to track down former Blade Runner Rick Deckard, who's been missing for thirty years.",
            ReleaseDate = new DateOnly(2017, 10, 6),
            DirectorName = "Denis Villeneuve",
            Duration = 164,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNzA1Njg4NzYxOV5BMl5BanBnXkFtZTgwODk5NjU3MzI@._V1_FMjpg_UY2048_.jpg"
        },
        new Movie()
        {
            Id = new Guid("e96c3640-af75-4342-bf73-2c249993f934"),
            Title = "Alien",
            Genre = "Sci-fi",
            Rating = 8.5f,
            Description = "In the distant future, the commercial spaceship \"Nostromo\" crew is on its way home when the crew picks up a distress call from a distant moon. The crew must investigate, and the spaceship descends on the small planetoid afterwards. After a rough landing, three crew members leave the spaceship to explore the area on the planetoid. At the same time, the ship's computer deciphers the message. When the crew realizes it is not alone on the spaceship, they must deal with the consequences.",
            ShortDescription = "After investigating a mysterious transmission of unknown origin, the crew of a commercial spacecraft encounters a deadly lifeform.",
            ReleaseDate = new DateOnly(1979, 5, 25),
            DirectorName = "Ridley Scott",
            Duration = 117,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BN2NhMDk2MmEtZDQzOC00MmY5LThhYzAtMDdjZGFjOGZjMjdjXkEyXkFqcGc@._V1_FMjpg_UY2225_.jpg"
        },
        new Movie()
        {
            Id = new Guid("a4a49163-f174-4a42-9f88-1f1b30325ef5"),
            Title = "Aliens",
            Genre = "Sci-fi",
            Rating = 8.4f,
            Description = "57 years after Ellen Ripley had a close encounter with the reptilian alien creature from the first movie, she is called back, this time, to help a group of highly trained colonial marines fight off against the sinister extraterrestrials. But this time, the aliens have taken over a space colony on the moon LV-426. When the colonial marines are called upon to search the deserted space colony, they later find out that they are up against more than what they bargained for. Using specially modified machine guns and enough firepower, it's either fight or die as the space marines battle against the aliens.",
            ShortDescription = "Decades after surviving the Nostromo incident, Ellen Ripley is sent out to re-establish contact with a terraforming colony but finds herself battling the Alien Queen and her offspring.",
            ReleaseDate = new DateOnly(1986, 7, 18),
            DirectorName = "James Cameron",
            Duration = 137,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BZjIyNGJhYzYtN2I1My00OTVhLWEyMzItZTVjNDMzOTVkYWViXkEyXkFqcGc@._V1_FMjpg_UY2260_.jpg"
        },
        new Movie()
        {
            Id = new Guid("13f91c44-a819-49c8-8ed3-3c003171ddc3"),
            Title = "Arrival",
            Genre = "Sci-fi",
            Rating = 7.9f,
            Description = "Linguistics professor Louise Banks leads an elite team of investigators when gigantic spaceships touchdown in 12 locations around the world. As nations teeter on the verge of global war, Banks and her crew must race against time to find a way to communicate with the extraterrestrial visitors. Hoping to unravel the mystery, she takes a chance that could threaten her life and quite possibly all of mankind.",
            ShortDescription = "Linguist Louise Banks leads a team of investigators when gigantic spaceships touch down around the world. As nations teeter on the verge of global war, Banks and her crew must find a way to communicate with the extraterrestrial visitors.",
            ReleaseDate = new DateOnly(2016, 11, 11),
            DirectorName = "Denis Villeneuve",
            Duration = 116,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTExMzU0ODcxNDheQTJeQWpwZ15BbWU4MDE1OTI4MzAy._V1_FMjpg_UY2048_.jpg"
        },
        new Movie()
        {
            Id = new Guid("5b248551-840b-4632-8aaf-3e1b16252d65"),
            Title = "The Martian",
            Genre = "Sci-fi",
            Rating = 8.0f,
            Description = "During a manned mission to Mars, Astronaut Mark Watney is presumed dead after a fierce storm and left behind by his crew. But Watney has survived and finds himself stranded and alone on the hostile planet. With only meager supplies, he must draw upon his ingenuity, wit and spirit to subsist and find a way to signal to Earth that he is alive. Millions of miles away, NASA and a team of international scientists work tirelessly to bring \"the Martian\" home, while his crewmates concurrently plot a daring, if not impossible, rescue mission. As these stories of incredible bravery unfold, the world comes together to root for Watney's safe return.",
            ShortDescription = "An astronaut becomes stranded on Mars after his team assumes him dead, and must rely on his ingenuity to find a way to signal to Earth that he is alive and can survive until a potential rescue.",
            ReleaseDate = new DateOnly(2015, 10, 2),
            DirectorName = "Ridley Scott",
            Duration = 144,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTc2MTQ3MDA1Nl5BMl5BanBnXkFtZTgwODA3OTI4NjE@._V1_FMjpg_UX865_.jpg"
        },
        new Movie()
        {
            Id = new Guid("700ebda0-232e-4b1c-9be2-bf6a99893d6d"),
            Title = "District 9",
            Genre = "Sci-fi",
            Rating = 7.9f,
            Description = "In 1982, a massive star ship bearing a bedraggled alien population, nicknamed \"The Prawns,\" appeared over Johannesburg, South Africa. Twenty-eight years later, the initial welcome by the human population has faded. The refugee camp where the aliens were located has deteriorated into a militarized ghetto called District 9, where they are confined and exploited in squalor. In 2010, the munitions corporation, Multi-National United, is contracted to forcibly evict the population with operative Wikus van der Merwe in charge. In this operation, Wikus is exposed to a strange alien chemical and must rely on the help of his only two new 'Prawn' friends.",
            ShortDescription = "In a future Earth in which aliens are isolated in a remote ghetto, a government agent finds himself banished there.",
            ReleaseDate = new DateOnly(2009, 8, 14),
            DirectorName = "Neill Blomkamp",
            Duration = 112,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTM4OTI1OTM5NF5BMl5BanBnXkFtZTcwMzk5MTU1Mg@@._V1_FMjpg_UX973_.jpg"
        },
        new Movie()
        {
            Id = new Guid("af12ea31-878c-43ce-95ac-bb3d54f277f4"),
            Title = "Children of Men",
            Genre = "Sci-fi",
            Rating = 7.9f,
            Description = "In the dystopian world of 2027 London, humans have been incapable of reproducing for unknown reasons, meaning the imminent extinction of the species. Britain is the one remaining civilized society on the planet, which has resulted in people wanting to migrate there, so it has become a police state to handle the immigrants, who are placed into refugee camps. Lowly government bureaucrat Theo Faron, once an activist, is approached by the Fishes, deemed a terrorist group, led by his ex-wife Julian Taylor, whom he hasn't seen in almost 20 years, since their marriage disintegrated after their infant son Dylan's death during the 2008 flu pandemic. Although the Fishes did use terrorist means in their on-going revolution against the state in the fight for immigrant rights, Julian vows that they now garner support solely by speaking to the people, and she wants Theo to use his connections to get transit papers for a young immigrant woman named Kee who needs to get to the coast. Although initially reluctant to do it because of the difficulty, Theo is able to grant Julian this favor, however with the change that he now needs to accompany Kee on her journey. As Theo and Kee progress on that journey, Theo learns more and more about what's going on, including the reason that Kee needs to get to the coast, the fact that no one in the group knows if their end destination even exists, and that his and Kee's lives are in greater danger than he believed when they started the journey. But Theo's sole mission becomes to help Kee at any cost for the survival of the species.",
            ShortDescription = "In 2027, in a chaotic world in which women have somehow become infertile, a former activist agrees to help transport a miraculously pregnant woman to a sanctuary at sea.",
            ReleaseDate = new DateOnly(2006, 12, 25),
            DirectorName = "Alfonso Cuarón",
            Duration = 109,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMDNkNmNiYzYtYWY0YS00NWEwLTgwMWUtYjM0M2E4Nzk3MzhmXkEyXkFqcGc@._V1_FMjpg_UY1953_.jpg"
        },
        new Movie()
        {
            Id = new Guid("88b25038-308e-4253-82c0-4a57151ad908"),
            Title = "Ex Machina",
            Genre = "Sci-fi",
            Rating = 7.7f,
            Description = "Caleb, a 26 year old programmer at the world's largest internet company, wins a competition to spend a week at a private mountain retreat belonging to Nathan, the reclusive CEO of the company. But when Caleb arrives at the remote location he finds that he will have to participate in a strange and fascinating experiment in which he must interact with the world's first true artificial intelligence, housed in the body of a beautiful robot girl.",
            ShortDescription = "A young programmer is selected to participate in a ground-breaking experiment in synthetic intelligence by evaluating the human qualities of a highly advanced humanoid A.I.",
            ReleaseDate = new DateOnly(2015, 4, 24),
            DirectorName = "Alex Garland",
            Duration = 108,
            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTUxNzc0OTIxMV5BMl5BanBnXkFtZTgwNDI3NzU2NDE@._V1_FMjpg_UX1012_.jpg"
        }
    ];
}