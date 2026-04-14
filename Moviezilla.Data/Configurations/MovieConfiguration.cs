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
            Description = "In the Battle of Thermopylae of 480 BC an alliance of Greek city-states fought the invading Persian army in the mountain pass of Thermopylae. Vastly outnumbered, the Greeks held back the enemy in one of the most famous last stands of history. Persian King Xerxes led a Army of well over 100,000 (Persian king Xerxes before war has about 170,000 army) men to Greece and was confronted by 300 Spartans, 700 Thespians, and 400 Thebans. Xerxes waited for 10 days for King Leonidas to surrender or withdraw but left with no options he pushed forward. After 3 days of battle all the Greeks were killed. The Spartan defeat was not the one expected, as a local shepherd, named Ephialtes, defected to the Persians and informed Xerxes that the separate path through Thermopylae, which the Persians could use to outflank the Greeks, was not as heavily guarded as they thought.\n",
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
            Description = "Angelenos Doug Billings and Tracy Garner are about to get married. Two days before the wedding, the four men in the wedding party - Doug, Doug's two best buddies Phil Wenneck and Stu Price, and Tracy's brother Alan Garner - hop into Tracy's father's beloved Mercedes convertible for a 24-hour stag party to Las Vegas. Phil, a married high school teacher, has the same maturity level as his students when he's with his pals. Stu, a dentist, is worried about everything, especially what his controlling girlfriend Melissa thinks. Because she disapproves of traditional male bonding rituals, Stu has to lie to her about the stag, he telling her that they are going on a wine tasting tour in the Napa Valley. Regardless, he intends on eventually marrying her, against the advice and wishes of his friends. And Alan seems to be unaware of what are considered the social graces of the western world. The morning after their arrival in Las Vegas, they awaken in their hotel suite each with the worst hangover. None remembers what happened in the past twelve or so hours. The suite is in shambles. And certain things are in the suite that shouldn't be, and certain things that should be in the suite are missing. Probably the most important in the latter category is Doug. As Phil, Stu and Alan try to find Doug using only what little pieces of information they have at hand, they go on a journey of discovery of how certain things got into the suite and what happened to the missing items. However they are on a race for time as if they can't find Doug in the next few hours, they are going to have to explain to Tracy why they are not yet back in Los Angeles. And even worse, they may not find Doug at all before the wedding.\n",
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
            Description = "Harry and Lloyd are two good friends who happen to be really stupid. The duo set out on a cross country trip from Providence to Aspen, Colorado to return a briefcase full of money to its rightful owner, a beautiful woman named Mary Swanson. After a trip of one mishap after another, the duo eventually make it to Aspen. But the two soon realize that Mary and her briefcase are the least of their problems.\n",
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
            Description = "Lindsay Lohan stars as Cady Heron, a 16 year old homeschooled girl who not only makes the mistake of falling for Aaron Samuels (Jonathan Bennett), the ex-boyfriend of queenbee Regina George (Rachel McAdams), but also unintentionally joins The Plastics, led by Regina herself. Join Cady as she learns that high school life can and will be really tough.\n",
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
            Description = "Cultures clash and tempers flares as the two cops named Detective Inspector Lee a Hong Kong Detective and Detective James Carter LAPD, a big-mouthed work-alone Los Angeles cop who are from different worlds discovers one thing in common: they can't stand each other. With time running out, they must join forces to catch the criminals and save the eleven-year-old Chinese girl of the Chinese consul named Soo Yung.\n",
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
            Description = "F.B.I. trainee Clarice Starling (Jodie Foster) works hard to advance her career, while trying to hide or put behind her West Virginia roots, of which if some knew, would automatically classify her as being backward or white trash. After graduation, she aspires to work in the agency's Behavioral Science Unit under the leadership of Jack Crawford (Scott Glenn). While she is still a trainee, Crawford asks her to question Dr. Hannibal Lecter (Sir Anthony Hopkins), a psychiatrist imprisoned, thus far, for eight years in maximum security isolation for being a serial killer who cannibalized his victims. Clarice is able to figure out the assignment is to pick Lecter's brains to help them solve another serial murder case, that of someone coined by the media as \"Buffalo Bill\" (Ted Levine), who has so far killed five victims, all located in the eastern U.S., all young women, who are slightly overweight (especially around the hips), all who were drowned in natural bodies of water, and all who were stripped of large swaths of skin. She also figures that Crawford chose her, as a woman, to be able to trigger some emotional response from Lecter. After speaking to Lecter for the first time, she realizes that everything with him will be a psychological game, with her often having to read between the very cryptic lines he provides. She has to decide how much she will play along, as his request in return for talking to him is to expose herself emotionally to him. The case takes a more dire turn when a sixth victim is discovered, this one from who they are able to retrieve a key piece of evidence, if Lecter is being forthright as to its meaning. A potential seventh victim is high profile Catherine Martin (Brooke Smith), the daughter of Senator Ruth Martin (Diane Baker), which places greater scrutiny on the case as they search for a hopefully still alive Catherine. Who may factor into what happens is Dr. Frederick Chilton (Anthony Heald), the warden at the prison, an opportunist who sees the higher profile with Catherine, meaning a higher profile for himself if he can insert himself successfully into the proceedings.\n",
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
            Description = "How far would you go to protect your family? Keller Dover is facing every parent's worst nightmare. His six-year-old daughter, Anna, is missing, together with her young friend, Joy, and as minutes turn to hours, panic sets in. The only lead is a dilapidated RV that had earlier been parked on their street. Heading the investigation, Detective Loki arrests its driver, Alex Jones, but a lack of evidence forces his release. As the police pursue multiple leads and pressure mounts, knowing his child's life is at stake the frantic Dover decides he has no choice but to take matters into his own hands. But just how far will this desperate father go to protect his family?\n",
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
            Description = "NIGHTCRAWLER is a thriller set in the nocturnal underbelly of contemporary Los Angeles. Jake Gyllenhaal stars as Lou Bloom, a driven young man desperate for work who discovers the high-speed world of L.A. crime journalism. Finding a group of freelance camera crews who film crashes, fires, murder and other mayhem, Lou muscles into the cut-throat, dangerous realm of nightcrawling - where each police siren wail equals a possible windfall and victims are converted into dollars and cents. Aided by Rene Russo as Nina, a veteran of the blood-sport that is local TV news, Lou blurs the line between observer and participant to become the star of his own story.\n",
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
            Description = "Forrest Gump is a simple man with a low I.Q. but good intentions. He is running through childhood with his best and only friend Jenny. His 'mama' teaches him the ways of life and leaves him to choose his destiny. Forrest joins the army for service in Vietnam, finding new friends called Dan and Bubba, he wins medals, creates a famous shrimp fishing fleet, inspires people to jog, starts a ping-pong craze, creates the smiley, writes bumper stickers and songs, donates to people and meets the president several times. However, this is all irrelevant to Forrest who can only think of his childhood sweetheart Jenny Curran, who has messed up her life. Although in the end all he wants to prove is that anyone can love anyone.\n",
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
            Description = "A nameless first-person narrator attends support groups in an attempt to subdue his emotional state and relieve his insomniac state. When he meets Marla, another fake attendee of support groups, his life seems to become a little more bearable. However, when he associates himself with Tyler he is dragged into an underground fight club and soap-making scheme. Together the two men spiral out of control and engage in competitive rivalry for love and power.\n",
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
            Description = "The Godfather \"Don\" Vito Corleone is the head of the Corleone mafia family in New York. He is at the event of his daughter's wedding. Michael, Vito's youngest son and a decorated WWII Marine is also present at the wedding. Michael seems to be uninterested in being a part of the family business. Vito is a powerful man, and is kind to all those who give him respect but is ruthless against those who do not. But when a powerful and treacherous rival wants to sell drugs and needs the Don's influence for the same, Vito refuses to do it. What follows is a clash between Vito's fading old values and the new ways which may cause Michael to do the thing he was most reluctant in doing and wage a mob war against all the other mafia families which could tear the Corleone family apart.\n",
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
            Description = "Mathematician John Nash rises to prominence at Princeton with his groundbreaking theories in game theory. While achieving academic success, he begins experiencing paranoid delusions and hallucinations, straining his relationships with his wife Alicia and colleagues. Nash struggles with schizophrenia, gradually learning to distinguish reality from illusion while continuing his work. The film explores genius, mental illness, love, and perseverance, showing the challenges of balancing personal struggles with professional achievement.\n",
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
            Description = "Nineteen-year-old Andrew Nieman wants to be the greatest jazz drummer in the world, in a league with Buddy Rich. This goal is despite not coming from a pedigree of greatest, musical or otherwise, with Jim, his high-school-teacher father, being a failed writer. Andrew is starting his first year at Shaffer Conservatory of Music, the best music school in the United States. At Shaffer, being the best means being accepted to study under Terence Fletcher and being asked to play in his studio band, which represents the school at jazz competitions. Based on their less than positive first meeting, Andrew is surprised that Fletcher asks him to join the band, albeit in the alternate drummer position which he is more than happy to do initially. Andrew quickly learns that Fletcher operates on fear and intimidation, never settling for what he considers less than the best each and every time. Being the best in Fletcher's mind does not only entail playing well, but knowing that you're playing well and if not what you're doing wrong. His modus operandi creates an atmosphere of fear and of every man or woman for him/herself within the band. Regardless, Andrew works hard to be the best. He has to figure out his life priorities and what he is willing to sacrifice to be the best. The other question becomes how much emotional abuse he will endure by Fletcher to reach that greatness, which he may believe he can only achieve with the avenues opened up by Fletcher.\n",
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
            Description = "A socially inept clown for hire - Arthur Fleck aspires to be a stand up comedian among his small job working dressed as a clown holding a sign for advertising. He takes care of his mother, Penny Fleck, and as he learns more about his mental illness, he learns more about his past. Dealing with all the negativity and bullying from society, he heads downwards on a spiral, in turn showing how his alter ego, \"Joker,\" came to be.\n",
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