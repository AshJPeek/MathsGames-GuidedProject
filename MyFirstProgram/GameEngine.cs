
using MyFirstProgram.Models;

namespace MyFirstProgram
{
    internal class GameEngine
    {
        internal void AdditionGameEasy(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.AdditionEasy);
        }
        internal void AdditionGameMedium(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                firstNumber = random.Next(10, 99);
                secondNumber = random.Next(10, 99);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, GameType.AdditionMedium);
        }
        internal void AdditionGameHard(string message)
        {
            Console.Clear();
           Console.WriteLine(message);

            var random = new Random();
            var score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                firstNumber = random.Next(100, 999);
                secondNumber = random.Next(100, 999);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, GameType.AdditionHard);


        }

        internal void SubtractionGameEasy(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, GameType.SubtractionEasy);
        }
        internal void SubtractionGameMedium(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                firstNumber = random.Next(10, 99);
                secondNumber = random.Next(10, 99);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, GameType.SubtractionMedium);
        }
        internal void SubtractionGameHard(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                firstNumber = random.Next(100, 999);
                secondNumber = random.Next(100, 999);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, GameType.SubtractionHard);
        }
        internal void MultiplicationGameEasy(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var result = Console.ReadLine();
                
                result = Helpers.ValidateResult(result);


                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, GameType.MultiplicationEasy);
        }
        internal void MultiplicationGameMedium(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(10, 25);

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);


                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, GameType.MultiplicationMedium);
        }
        internal void MultiplicationGameHard(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                firstNumber = random.Next(5, 15);
                secondNumber = random.Next(5, 25);

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);


                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, GameType.MultiplicationHard);
        }

        internal void DivisionGameEasy(string message)
        {
            var score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var divisionNumbers = Helpers.GetDivisionNumbersEasy();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, GameType.DivisionEasy);
        }
        internal void DivisionGameMedium(string message)
        {
            var score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var divisionNumbers = Helpers.GetDivisionNumbersMedium();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, GameType.DivisionMedium);
        }
        internal void DivisionGameHard(string message)
        {
            var score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var divisionNumbers = Helpers.GetDivisionNumbersHard();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, GameType.DivisionHard);
        }
    }
}
