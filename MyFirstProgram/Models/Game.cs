namespace MyFirstProgram.Models;

internal class Game
{
    internal DateTime Date { get; set; }

    internal int Score { get; set; }

    internal GameType Type { get; set; }
}

internal enum GameType
{
    AdditionEasy,
    AdditionMedium,
    AdditionHard,
    SubtractionEasy,
    SubtractionMedium,
    SubtractionHard,
    MultiplicationEasy,
    MultiplicationMedium,
    MultiplicationHard,
    DivisionEasy,
    DivisionMedium,
    DivisionHard
}