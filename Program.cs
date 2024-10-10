using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("What is your name?: ");
        string? Name = Console.ReadLine();

        Console.WriteLine("What is your age?: ");
        int? Age = int.Parse(Console.ReadLine());

        Console.WriteLine("What is your Eye color?: ");
        string? EyeColor = Console.ReadLine();

        Console.WriteLine("What is your Hair color?: ");
        string? HairColor = Console.ReadLine();

        Console.WriteLine("What is your Shoe Size?: ");
        float? ShoeSize = float.Parse(Console.ReadLine());

        Console.WriteLine("What is your favorite color?: ");
        string? FavColor = Console.ReadLine();

        Console.WriteLine("What is your favorite show?: ");
        string? FavShow = Console.ReadLine();

        Console.WriteLine("who is your favorite teacher?: ");
        string? FavTeacher = Console.ReadLine();

        Console.WriteLine("What is your favorite class?: ");
        string? FavClass = Console.ReadLine();

        Console.WriteLine("What is your favorite holiday?: ");
        string? FavDay = Console.ReadLine();

        Console.WriteLine("What is your favorite season?: ");
        string? FavSeason = Console.ReadLine();

        Console.WriteLine("What is your Dream Job?: ");
        string? DreamJob = Console.ReadLine();

        Console.WriteLine("How many siblings do you have?: ");
        int? SiblingNun = int.Parse(Console.ReadLine());

        int? Age5 = Age + 5;

        Console.WriteLine("My freinds name is " + Name + ". " + Name + " is " + Age + "-years old. " + Name + "'s eye color is " + EyeColor + " and his hair color is " + HairColor + ". he has a shoe size of " + ShoeSize + ". the following is his favorite things: color: " + FavColor + " Piece of media: " + FavShow + " class: " + FavClass + " holiday: " + FavDay + " and season: " + FavSeason + ". " + Name + "'s Dream job is " + DreamJob + " and in 5 years they will be " + Age5 + "-years old." + " and they have " + SiblingNun + " siblings.");
    }
}
