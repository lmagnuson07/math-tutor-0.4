using System;

namespace MathTutor0._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize 
            string input = "", operatorString = "";
            char menuChoice = 'z', charCalc = ' ', operatorChar = ' ', tryAnotherProgram = 'u', charInputMenuChoice = ' ', tryAgain = 'z';

            Console.WriteLine("Math Tutor - Version 0.4");
            Console.WriteLine("------------------------");

            // gather inputs 
            while (menuChoice != 'x' && menuChoice != 'X')
            {
                while (tryAnotherProgram != 'u')
                {
                    Console.WriteLine("Would you like to try another math problem? (y/n)");
                    input = Console.ReadLine();
                    try
                    {
                        charInputMenuChoice = Convert.ToChar(input);
                        tryAnotherProgram = 'u';
                    }
                    catch (FormatException ex)
                    {
                        tryAnotherProgram = 'q';
                        charInputMenuChoice = 'q';
                    }
                    switch (charInputMenuChoice)
                    {
                        case 'y':
                            {
                                tryAnotherProgram = 'u';
                                tryAgain = 'z';
                                break;
                            }
                        case 'n':
                            {
                                tryAnotherProgram = 'u';
                                tryAgain = 'q';
                                menuChoice = 'x';
                                break;
                            }
                        case 'q':
                            {
                                Console.WriteLine("Invalid input type, try again");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid input, try again");
                                break;
                            }
                    }
                }
                switch (tryAgain)
                {
                    case 'z':
                        {
                            Console.WriteLine("a) Addition\ns) Subtraction\nm) Multiplication\nd) Division\nx) Exit Program\nEnter a letter for your choice:");

                            input = Console.ReadLine();
                            try
                            {
                                menuChoice = Convert.ToChar(input);
                                menuChoice = Char.ToLower(menuChoice);
                            }
                            catch (FormatException)
                            {
                                menuChoice = 'z';
                            }
                            break;
                        }
                }

                switch (menuChoice)
                {
                    case 'a':
                        {
                            operatorString = "Addition";
                            charCalc = 'a';
                            operatorChar = '+';
                            tryAnotherProgram = 'p';
                            Console.WriteLine("{0} problems:", operatorString);
                            calculationType(operatorString, charCalc, operatorChar);
                            break;
                        }
                    case 's':
                        {
                            operatorString = "Subtraction";
                            charCalc = 's';
                            operatorChar = '-';
                            tryAnotherProgram = 'p';
                            Console.WriteLine("{0} problems:", operatorString);
                            calculationType(operatorString, charCalc, operatorChar);
                            break;
                        }
                    case 'm':
                        {
                            operatorString = "Multiplication";
                            charCalc = 'm';
                            operatorChar = '*';
                            tryAnotherProgram = 'p';
                            Console.WriteLine("{0} problems:", operatorString);
                            calculationType(operatorString, charCalc, operatorChar);
                            break;
                        }
                    case 'd':
                        {
                            operatorString = "Division";
                            charCalc = 'd';
                            operatorChar = '/';
                            tryAnotherProgram = 'p';
                            Console.WriteLine("{0} problems:", operatorString);
                            calculationType(operatorString, charCalc, operatorChar);
                            break;
                        }
                    case 'x':
                        {
                            Console.WriteLine("Thanks for using Math Tutor!");
                            Console.ReadLine();
                            break;
                        }
                    case 'z':
                        {
                            Console.WriteLine("Invalid entry, please only enter one character");
                            Console.ReadLine();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid entry, please try again");
                            Console.ReadLine();
                            break;
                        }
                }
            }
            Console.WriteLine("Have a nice day");
        }
        // calculation method
        static void calculationType(string operatorString, char charCalc, char operatorChar)
        {
            // initialize
            // two random numbers, and the result of the addition
            string input = "";
            int programLoop = 0, question = 0;
            while (programLoop != 1)
            {
                char charInputLoop = 'q', charInputLoopTwo = 'q', charInput = 'w', charInputTwo = 'l';
                const int MIN = 1, MAX = 100;
                int guessLoop = -89, wrongLoop = -79, wrongLoopTwo = -69, attempts = 1;
                double randomOne = 0, randomTwo = 0, result = 0, guess = 0;
                question++;
                Random gen = new Random();
                randomOne = gen.Next(MIN, MAX);
                randomTwo = gen.Next(MIN, MAX);
                switch (charCalc)
                {
                    case 'a':
                        {
                            result = randomOne + randomTwo;
                            break;
                        }
                    case 's':
                        {
                            result = randomOne - randomTwo;
                            result = Math.Round(result, 2);
                            break;
                        }
                    case 'm':
                        {
                            result = randomOne * randomTwo;
                            break;
                        }
                    case 'd':
                        {
                            result = randomOne / randomTwo;
                            result = Math.Round(result, 2);
                            break;
                        }
                }

                // gather input 
                // user guess. Display the answer if the user enters an integer
                // Repeat guess if invalid data type entered 
                do
                {
                    wrongLoop = -89;
                    wrongLoopTwo = -69;
                    while (guessLoop != -88)
                    {
                        Console.WriteLine("Question #{0}: What is, to the nearest hundredth, {1} {2} {3} = ?", question, randomOne, operatorChar, randomTwo);
                        input = Console.ReadLine();
                        try
                        {
                            guess = Convert.ToDouble(input);
                            guessLoop = -88;
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine("Invalid input! You must enter an integer value for the answer.");
                            guessLoop = -89;
                        }
                    }
                    // output
                    // If the guess was correct or not, and the answer 
                    if (result == guess)
                    {
                        Console.WriteLine("Correct! You got the answer in {0} attempts", attempts);
                    }
                    else
                    {
                        attempts++;
                        while (wrongLoop != -78)
                        {
                            charInputLoopTwo = 'q';
                            Console.WriteLine("Incorrect! Would you like to try again? (y/n)");
                            while (charInputLoopTwo != 'k')
                            {

                                input = Console.ReadLine();
                                try
                                {
                                    charInputTwo = Convert.ToChar(input);
                                    charInputTwo = Char.ToLower(charInputTwo);
                                    charInputLoopTwo = 'k';
                                }
                                catch (FormatException ex)
                                {
                                    Console.WriteLine("Invalid, type y to continue, n to exit");
                                    charInputLoopTwo = 'q';
                                }
                            }
                            switch (charInputTwo)
                            {
                                case 'n':
                                    {
                                        Console.WriteLine("The correct answer was {0}. Press enter to continue", result);
                                        Console.ReadLine();
                                        wrongLoopTwo = -69;
                                        guessLoop = -88;
                                        wrongLoop = -78;
                                        break;
                                    }
                                case 'y':
                                    {
                                        wrongLoopTwo = -68;
                                        wrongLoop = -78;
                                        guessLoop = -89;
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Invalid, please type y to continue, n to exit");
                                        break;
                                    }
                            }
                        }
                    }
                } while (wrongLoopTwo == -68);

                while (charInputLoop != 'p')
                {
                    Console.WriteLine("Would you like to try another problem? (y/n)");
                    input = Console.ReadLine();
                    try
                    {
                        charInput = Convert.ToChar(input);
                        charInputLoop = 'p';
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Invalid input! Press 'y' to try another problem\nPress 'n' to exit");
                        charInputLoop = 'q';
                    }
                }
                charInput = Char.ToLower(charInput);
                switch (charInput)
                {
                    case 'n':
                        {
                            programLoop = 1;
                            break;
                        }
                }
            }
        }
    }
}