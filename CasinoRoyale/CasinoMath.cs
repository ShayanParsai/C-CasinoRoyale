
namespace CasinoRoyale
{
    class CasinoMath
    {
        private static Random rnd = new();

        public static int playDice(int credit, int wage)
        {
            int tempCredit = credit;
            int playerRoll = rnd.Next(1, 7);
            int oponentRoll = rnd.Next(1, 7);
            Console.WriteLine("\nYou rolled: " + playerRoll + "\nYour opponent rolled: " + oponentRoll + "\n");

            if (playerRoll > oponentRoll) 
            {
                Console.WriteLine("You won " + wage + " Credits");
                tempCredit += wage;
            } 
            else if (oponentRoll > playerRoll) 
            {
                Console.WriteLine("You lost " + wage + " Credits");
                tempCredit -= wage;
            }
            else
            {
                Console.WriteLine("\nEVEN! There was no changes to you credits");
            }
            return tempCredit;
        }

        public static int playRoulette(int bet, int credit, int wage)
        {
            int tempCredit = credit;
            int rouletteResult = rnd.Next(0, 37);

            switch (bet)
            {
                case 1: // GREEN BET RESULT
                    if (rouletteResult == 0)
                    {
                        Console.WriteLine("The ball landed on green. You won " + wage * 35 + " credits!");
                        tempCredit += wage * 35;
                    }
                    else
                    {
                        Console.WriteLine("The ball did not land on green. You lost " + wage + " credits.");
                        tempCredit -= wage;
                    }
                    return tempCredit;

                case 2: // RED BET RESULT
                    int[] red = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
                    if (red.Contains(rouletteResult))
                    {
                        Console.WriteLine("The ball landed on a red number. You won " + wage + " credits!");
                        tempCredit += wage;
                    }
                    else
                    {
                        Console.WriteLine("The ball did not land on a red number. You lost " + wage + " credits.");
                        tempCredit -= wage;
                    }
                    return tempCredit;

                case 3: // BLACK BET RESULT
                    int[] black = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
                    if (black.Contains(rouletteResult))
                    {
                        Console.WriteLine("The ball landed on a black number. You won " + wage + " credits!");
                        tempCredit += wage;
                    }
                    else
                    {
                        Console.WriteLine("The ball did not land on a black number. You lost " + wage + " credits.");
                        tempCredit -= wage;
                    }
                    return tempCredit;

                case 4: // EVEN BET RESULT
                    if (rouletteResult % 2 == 0)
                    {
                        Console.WriteLine("The ball landed on an even number. You won " + wage + " credits!");
                        tempCredit += wage;
                    }
                    else
                    {
                        Console.WriteLine("The ball did not land on an even number. You lost " + wage + " credits.");
                        tempCredit -= wage;
                    }
                    return tempCredit;

                case 5: // ODD BET RESULT
                    if (rouletteResult % 2 != 0)
                    {
                        Console.WriteLine("The ball landed on an odd number. You won " + wage + " credits!");
                        tempCredit += wage;
                    }
                    else
                    {
                        Console.WriteLine("The ball did not land on an odd number. You lost " + wage + " credits.");
                        tempCredit -= wage;
                    }
                    return tempCredit;
                case 6: // FIRST ROW BET RESULT
                    if (rouletteResult > 0 && rouletteResult < 13)
                    {
                        Console.WriteLine("The ball landed on the first row. You won " + wage * 3 + " credits!");
                        tempCredit += wage * 3;
                    }
                    else
                    {
                        Console.WriteLine("The ball did not land on the first row. You lost " + wage + " credits.");
                        tempCredit -= wage;
                    }
                    return tempCredit;

                case 7: // SECOND ROW BET RESULT
                    if (rouletteResult > 12 && rouletteResult < 25)
                    {
                        Console.WriteLine("The ball landed on the second row. You won " + wage * 3 + " credits!");
                        tempCredit += wage * 3;
                    }
                    else
                    {
                        Console.WriteLine("The ball did not land on the second row. You lost " + wage + " credits.");
                        tempCredit -= wage;
                    }
                    return tempCredit;

                case 8: // THIRD ROW BET RESULT
                    if (rouletteResult > 24)
                    {
                        Console.WriteLine("The ball landed on the third row. You won " + wage * 3 + " credits!");
                        tempCredit += wage * 3;
                    }
                    else
                    {
                        Console.WriteLine("The ball did not land on the third row. You lost " + wage + " credits.");
                        tempCredit -= wage;
                    }
                    return tempCredit;

                default:
                    Console.WriteLine("Please try again. Pick an option between 1 and 8."); // Om användaren slår in felaktig bet option
                    return 0;
            }
        }
    }
}
