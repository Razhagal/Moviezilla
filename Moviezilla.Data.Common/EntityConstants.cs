namespace Moviezilla.Data.Common;

public static class EntityConstants
{
    public static class Movie
    {
        public const int TitleMinLength = 2;
        public const int TitleMaxLength = 100;
        public const int GenreMinLength = 3;
        public const int GenreMaxLength = 50;
        public const int DirectorNameMinLength = 2;
        public const int DirectorNameMaxLength = 100;
        public const int DescriptionMinLength = 10;
        public const int DescriptionMaxLength = 1000;
        public const int ShortDescriptionMinLength = 10;
        public const int ShortDescriptionMaxLength = 250;
        public const int DurationMin = 1;
        public const int DurationMax = 900;
        public const int ImageUrlMaxLength = 2048;
        public const string ReleaseDateFormat = "yyyy-MM-dd";
    }

    public static class Actor
    {
        public const int NameMinLength = 2;
        public const int NameMaxLength = 100;
        public const int BiographyMaxLength = 1500;
        public const int ImageUrlMaxLength = 2048;
    }
}