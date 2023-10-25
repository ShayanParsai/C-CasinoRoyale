
namespace CasinoRoyale
{
    class Program
    {
        private static void Main(string[] args)
        {
            int credit = 1000;
            Console.WriteLine("Welcome to CasinoRoyale!\n");
            Console.WriteLine("Bet options: \n Green = 1 \n Red = 2 \n Black = 3 \n Even = 4 \n " +
                "Odd = 5 \n First Row = 6 \n Second Row = 7 \n Third Row = 8 \n Dice Game = 9 \n");
            
            while (credit > 0)
            {
                Console.WriteLine("_____________________________________\n");
                Console.WriteLine("Your credit is: " + credit);
                Console.Write("\nPlace your wager: ");
                int wage = Convert.ToInt32(Console.ReadLine());

                if (wage > credit)
                {
                    Console.WriteLine("You don't have that much credits. Your current credits are: " + credit);
                }
                else if (wage < 1)
                {
                    Console.WriteLine("Your wager must be 1 credit or more. Please try again.");
                }
                else
                {
                    Console.Write("Please pick your bet option: ");
                    int bet = Convert.ToInt32(Console.ReadLine()); Console.Write("\n");

                    if (bet >= 1 && bet <= 8)
                    {
                        credit = CasinoMath.playRoulette(bet, credit, wage); // Använder playRoulette som ligger i CasinoMath.cs
                    }
                    else if (bet == 9)
                    {
                        credit = CasinoMath.playDice(credit, wage); // Använder playDice som ligger i CasinoMath.cs
                    }
                    else
                    {
                        Console.WriteLine("Please try again. Pick an option between 1 and 9.");
                    }
                }
                if (credit <= 0) // Ifall användarens credits tar slut
                { 
                    Console.WriteLine("_____________________________________\nYou ran out of credits!\n");
                    Console.Write("Do you want to deposit another 1000 Credits? (1 = Yes / 2 = No): ");
                    int playAgain = Convert.ToInt32(Console.ReadLine());
                    if (playAgain == 1)
                    {
                        credit += 1000;
                        Console.WriteLine("\nYou have refilled your credits, welcome back to CasinoRoyale!\n");
                        Console.WriteLine("Bet options: \n Green = 1 \n Red = 2 \n Black = 3 \n Even = 4 \n " +
                            "Odd = 5 \n First Row = 6 \n Second Row = 7 \n Third Row = 8 \n Dice Game = 9 \n");
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