namespace CasinoRoyale
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<int> creditHistoryList = new();
            int credits = 1000;

            Console.WriteLine("Welcome to CasinoRoyale!\n");
            Console.WriteLine("Options: \n\n ROULETTE\n Green = 1 \n Red = 2 \n Black = 3 \n Even = 4 \n Odd = 5 \n First Row = 6 \n Second Row = 7 " +
                "\n Third Row = 8 \n\n DICE GAME\n Play Dice = 9 \n\n OTHER OPTIONS\n Show bet history = 10 \n Exit/Withdraw credits = 11 \n");

            while (credits > 0)
            {
                Console.WriteLine("_____________________________________\n");
                Console.WriteLine("Your credit is: " + credits);
                Console.Write("\nPlace your wager: ");
                int wage = Convert.ToInt32(Console.ReadLine());

                if (wage > credits)
                {
                    Console.WriteLine("\nYou don't have that much credits. Your current credits are: " + credits);
                }
                else if (wage < 1)
                {
                    Console.WriteLine("\nYour wager must be 1 credit or more. Please try again.");
                }
                else
                {
                    Console.Write("Please pick your Option: ");
                    int option = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n_____________________________________\n");

                    switch (option)
                    {
                        case 1: case 2: case 3: case 4: case 5: case 6: case 7: case 8:
                            credits = CasinoMath.playRoulette(option, credits, wage); // Uses playRoulette in CasinoMath.cs
                            creditHistoryList.Add(credits);
                            break;

                        case 9:
                            credits = CasinoMath.playDice(credits, wage); // uses playDice in CasinoMath.cs
                            creditHistoryList.Add(credits);
                            break;

                        case 10:
                            CreditHistory.printCreditHistory(creditHistoryList); // Prints out the list of creditHistory
                            break;

                        case 11:
                            Console.WriteLine("\nYou withdrew " + credits + " credits, thanks for playing CasinoRoyale\n"); // Ends program
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid option. Please pick an option between 1 and 11."); // If player picks invalid option
                            break;
                    }
                }
                if (credits <= 0) // When player reaches 0 credits
                {
                    Console.WriteLine("_____________________________________\nYou ran out of credits!\n");
                    Console.Write("Do you want to deposit another 1000 Credits? (1 = Yes / 2 = No): ");
                    int playAgain = Convert.ToInt32(Console.ReadLine());
                    if (playAgain == 1)
                    {
                        credits += 1000;
                        creditHistoryList.Add(credits);
                        Console.Clear();
                        Console.WriteLine("\nYou have refilled your credits, welcome back to CasinoRoyale!\n");
                        Console.WriteLine("Options: \n\n ROULETTE\n Green = 1 \n Red = 2 \n Black = 3 \n Even = 4 \n Odd = 5 \n First Row = 6 \n Second Row = 7 " +
                            "\n Third Row = 8 \n\n DICE GAME\n Play Dice = 9 \n\n OTHER OPTIONS\n Show bet history = 10 \n Exit/Withdraw credits = 11 \n");
                    }
                    else
                    {
                        Console.WriteLine("\nThanks for playing at CasinoRoyale!\n");
                    }
                }
            }
        }
    }
}