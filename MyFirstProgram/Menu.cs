
namespace MyFirstProgram
{
    internal class Menu
    {
        GameEngine engine = new();
       internal void ShowMenu(string name, DateTime date)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Hello {name}. It's {date.DayOfWeek}. This is your math's game. That's great that you're working on improving yourself\n");
            Console.WriteLine("Press any key to show the menu");
            Console.ReadLine();
            Console.WriteLine("\n");

            var isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine($@"What game would you like to play today? Choose from the options below:
V - View Previous Games
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");
                Console.WriteLine("---------------------------------------------");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.GetGames();
                        break;
                    case "a":
                        Console.Clear();
                        var difficultyChoiceAddition = Helpers.DifficultySelection();                      
                        switch (difficultyChoiceAddition)
                        {
                            case "e":
                                engine.AdditionGameEasy("Addition game - Easy");
                                break;
                            case "m":
                                engine.AdditionGameMedium("Addition game - Medium");
                                break;
                            case "h":
                                engine.AdditionGameHard("Addition game - Hard");
                                break;
                        }
                        break;                      
                    case "s":
                        Console.Clear();
                        var difficultyChoiceSubtraction = Helpers.DifficultySelection();
                        switch (difficultyChoiceSubtraction)
                        {
                            case "e":
                                engine.SubtractionGameEasy("Subtraction game - Easy");
                                break;
                            case "m":
                                engine.SubtractionGameMedium("Subtraction game - Medium");
                                break;
                            case "h":
                                engine.SubtractionGameHard("Subtraction game - Hard");
                                break;
                        }
                        break;
                    case "m":
                        Console.Clear();
                        var difficultyChoiceMultiplication = Helpers.DifficultySelection();
                        switch (difficultyChoiceMultiplication)
                        {
                            case "e":
                                engine.MultiplicationGameEasy("Multiplication game - Easy");
                                break;
                            case "m":
                                engine.MultiplicationGameMedium("Multiplication game - Medium");
                                break;
                            case "h":
                                engine.MultiplicationGameHard("Multiplication game - Hard");
                                break;
                        }
                    break;
                    case "d":
                        Console.Clear();
                        var difficultyChoiceDivision = Helpers.DifficultySelection();
                        switch (difficultyChoiceDivision)
                        {
                            case "e":
                                engine.DivisionGameEasy("Division game - Easy");
                                break;
                            case "m":
                                engine.DivisionGameMedium("Division game - Medium");
                                break;
                            case "h":
                                engine.DivisionGameHard("Division game - Hard");
                                break;
                        }
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        Environment.Exit(1);
                        break;
                }
            } while (isGameOn);
        }
    }
}
