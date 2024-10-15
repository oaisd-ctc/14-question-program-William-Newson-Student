using System;
public class Program
{
    public static string? name;
    public static string? age;
    public static string? eyeColor;
    public static string? hairColor;
    public static string? shoeSize;
    public static string? favoriteColor;
    public static string? favoriteTVorMovie;
    public static string? favoriteTeacher;
    public static string? favoriteClass;
    public static string? favoriteHoliday;
    public static string? favoriteSeason;
    public static string? dreamJob;
    public static string? numberOfSiblings;
    public static int ageIn5Years;
    public static void Main(string[] args)
    {
        AskName();
        AskAge();
        AskEyeColor();
        AskHairColor();
        AskShoeSize();
        AskFavoriteColor();
        AskFavoriteTvShow();
        AskFavoriteTeacher();
        AskFavoriteClass();
        AskFavoriteHoliday();
        AskFavoriteSeason();
        AskDreamJob();
        CalculateAgeIn5Years(age);
        AskNumberOfSiblings();

        DisplaySummaryMessage();
    }

    public static void AskName()
    {
        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
    }
    public static void AskAge()   
    {
        Console.WriteLine("How old are you?");
        age = Console.ReadLine();
    }
    public static void AskEyeColor()
    {
        Console.WriteLine("What color are your eyes?");
        eyeColor = Console.ReadLine();
    }
    public static void AskHairColor()
    {
        Console.WriteLine("What color is your hair?");
        hairColor = Console.ReadLine();
    }
    public static void AskShoeSize()
    {
        Console.WriteLine("What's your shoe size?");
        shoeSize = Console.ReadLine();
    }
    public static void AskFavoriteColor()
    {
        Console.WriteLine("What's your favorite color");
        favoriteColor = Console.ReadLine();
    }
    public static void AskFavoriteTvShow()
    {
        Console.WriteLine("What's your favorite Tv-Show or movie?");
        favoriteTVorMovie = Console.ReadLine();
    }
    public static void AskFavoriteTeacher()
    {
        Console.WriteLine("What's your favorite teacher?");
        favoriteTeacher = Console.ReadLine();
    }
    public static void AskFavoriteClass()
    {
        Console.WriteLine("What's your favorite class?");
        favoriteClass = Console.ReadLine();
    }
    public static void AskFavoriteHoliday()
    {
        Console.WriteLine("What's your favorite holiday?");
        favoriteHoliday = Console.ReadLine();
    }
    public static void AskFavoriteSeason()
    {
        Console.WriteLine("What's your favorite season?");
        favoriteSeason = Console.ReadLine();
    }
    public static void AskDreamJob()
    {
        Console.WriteLine("What's your dream job?");
        dreamJob = Console.ReadLine();
    }
    public static void CalculateAgeIn5Years(string age)
    {
        ageIn5Years = int.Parse(age);
    }
    public static void AskNumberOfSiblings()
    {
        Console.WriteLine("How many siblings do you have?");
        numberOfSiblings = Console.ReadLine();
    }
    public static void DisplaySummaryMessage()
    {
        Console.WriteLine("I have a friend named " + name + "; they are " + age + " years old. Their eye color is " + eyeColor + "; they have a shoe size of " + shoeSize + "; their favorite color is " + favoriteColor + ". Their favorite TV show or movie is " + favoriteTVorMovie + ". Their favorite teacher is " + favoriteTeacher + ". Their favorite class is " + favoriteClass + ". Their favorite  holiday is " + favoriteHoliday + ", and their favorite season is " + favoriteSeason + ". Their dream job is " + dreamJob + ", and in 5 years they will be " + (ageIn5Years + 5) + " years old. and they have " + numberOfSiblings + " siblings.");
    }

}
