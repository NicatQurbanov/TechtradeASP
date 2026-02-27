Random random = new Random();
string? readResult;
Console.WriteLine("Would you like to play? (Y/N)");
readResult = Console.ReadLine();
if (ShouldPlay(readResult.ToLower()))
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = random.Next(5);
        var roll = random.Next(1,7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");
        readResult = Console.ReadLine();
        play = ShouldPlay(readResult.ToLower());
    }
}

string WinOrLose(int target, int roll)
{
    if (target > roll)
        return "You lose!";
    else
        return "You win!";
}

bool ShouldPlay(string input)
{
    if (input == "y")
        return true;
    else if (input == "n")
        return false;
    return false;
}