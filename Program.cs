// See https://aka.ms/new-console-template for more information

Console.Write("Hello Word!");

Console.Write("You need to enter your name: ");
var name = Console.ReadLine();

var currentDate = DateTime.Now;
Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");

Console.WriteLine("You need to enter your birthday");
Console.Write($"{Environment.NewLine}Nhap ngay sinh: ");
string day = Console.ReadLine();

Console.WriteLine($"Your information:\n Name:{name} \t Birthday: {day}");

Console.Write($"{Environment.NewLine}Press any key to exit...");
Console.ReadKey(true);
/*class Dragon
{
    int _health;
    bool _isWinged;
    string _elemental;
    float _elementalResistance;
};


public class Program
{
    public static void Main()
    {

    }
};*/

