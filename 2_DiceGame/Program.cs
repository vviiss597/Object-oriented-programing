Console.WriteLine("Dice Game!");
Console.WriteLine("======================");

Console.WriteLine("Press any key to roll the dice...");
Console.ReadKey();

void RollDice()
{
    Random rand = new Random();
    int you = rand.Next(1, 7);  // (1, 7]
    int computer = rand.Next(1, 7);

    Console.WriteLine("You rolled: " +you);
    Console.WriteLine("Computer rolled: " + computer);

    if (you > computer)
    {
        Console.WriteLine("You Win!!");
    }
    else if (you < computer)
    {
        Console.WriteLine("Computer Wins.");
    }
    else
    {
        Console.WriteLine("It's a tie.");
        Console.WriteLine("Let's roll again!");
        Console.WriteLine("=======================");
        Console.WriteLine("Press any key to roll the dice...");
        Console.ReadKey();
        RollDice();
    }
}

RollDice();