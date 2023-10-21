using System;

internal class Program {

    private static void Main(string[] args) {

        int credit = 1000;

        Console.WriteLine("Welcome to CasinoRoyale!\n");
        Console.WriteLine("Bet options: \n green = 1 \n red = 2 \n black = 3 \n even = 4 \n odd = 5 \n first row = 6 \n second row = 7 \n third row = 8 \n");

        while (credit > 0) {
            Console.WriteLine("_____________________________________");
            Console.WriteLine("Your credit is: " + credit);
            Console.Write("\nPlace your wager: ");
            int wage = Convert.ToInt32(Console.ReadLine());

            if (wage > credit) {
                Console.WriteLine("You don't have that much credits. Your current credits are: " + credit);
            } else if (wage < 1) {
                Console.WriteLine("Your wager must be 1 credit or more. Please try again.");
            } else {
                Console.Write("Please pick your bet option: "); 
                int bet = Convert.ToInt32(Console.ReadLine()); Console.Write("\n");

                if (bet >= 1 && bet <= 8) {
                    credit = calcBet(bet, credit, wage);
                } else {
                    Console.WriteLine("Please try again. Pick an option between 1 and 8.");
                }
            }
        }
        Console.WriteLine("You have no more credits. Thanks for playing at CasinoRoyale!\n_____________________________________");
    }

    private static int calcBet(int bet, int credit, int wage) {

        int[] red = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
        int[] black = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
        int[] even = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 };
        int[] odd = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35 };
        int[] firstRow = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        int[] secondRow = { 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
        int[] thirdRow = { 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
        int green = 37;

        int tempCredit = credit;
        int rouletteResult = rollTheRoulette(); // Rullar rouletten och sparar resultatet

        switch (bet) {
            case 1: // GREEN BET RESULT
                if (rouletteResult == green) {
                    Console.WriteLine("The ball landed on green. You won " + wage * 36 + " credits!");
                    tempCredit += wage * 36;
                } else {
                    Console.WriteLine("The ball did not land on green. You lost " + wage + " credits.");
                    tempCredit -= wage;
                } return tempCredit;

            case 2: // RED BET RESULT
                if (red.Contains(rouletteResult)) {
                    Console.WriteLine("The ball landed on a red number. You won " + wage + " credits!");
                    tempCredit += wage;
                } else {
                    Console.WriteLine("The ball did not land on a red number. You lost " + wage + " credits.");
                    tempCredit -= wage;
                } return tempCredit;

            case 3: // BLACK BET RESULT
                if (black.Contains(rouletteResult)) {
                    Console.WriteLine("The ball landed on a black number. You won " + wage + " credits!");
                    tempCredit += wage;
                } else {
                    Console.WriteLine("The ball did not land on a black number. You lost " + wage + " credits.");
                    tempCredit -= wage;
                } return tempCredit;

            case 4: // EVEN BET RESULT
                if (even.Contains(rouletteResult)) {
                    Console.WriteLine("The ball landed on an even number. You won " + wage + " credits!");
                    tempCredit += wage;
                } else {
                    Console.WriteLine("The ball did not land on an even number. You lost " + wage + " credits.");
                    tempCredit -= wage;
                } return tempCredit;

            case 5: // ODD BET RESULT
                if (odd.Contains(rouletteResult)) {
                    Console.WriteLine("The ball landed on an odd number. You won " + wage + " credits!");
                    tempCredit += wage;
                } else {
                    Console.WriteLine("The ball did not land on an odd number. You lost " + wage + " credits.");
                    tempCredit -= wage;
                } return tempCredit;
            case 6: // FIRST ROW BET RESULT
                if (firstRow.Contains(rouletteResult)) {
                    Console.WriteLine("The ball landed on the first row. You won " + wage * 3 + " credits!");
                    tempCredit += wage * 3;
                } else {
                    Console.WriteLine("The ball did not land on the first row. You lost " + wage + " credits.");
                    tempCredit -= wage;
                } return tempCredit;

            case 7: // SECOND ROW BET RESULT
                if (secondRow.Contains(rouletteResult)) {
                    Console.WriteLine("The ball landed on the second row. You won " + wage * 3 + " credits!");
                    tempCredit += wage * 3;
                } else {
                    Console.WriteLine("The ball did not land on the second row. You lost " + wage + " credits.");
                    tempCredit -= wage;
                } return tempCredit;

            case 8: // THIRD ROW BET RESULT
                if (thirdRow.Contains(rouletteResult)) {
                    Console.WriteLine("The ball landed on the third row. You won " + wage * 3 + " credits!");
                    tempCredit += wage * 3;
                } else {
                    Console.WriteLine("The ball did not land on the third row. You lost " + wage + " credits.");
                    tempCredit -= wage;
                } return tempCredit;

            default: Console.WriteLine("Please try again. Pick an option between 1 and 8."); // Om användaren slår in felaktig bet option
                return 0;
        }
    }
    private static int rollTheRoulette() { // Rullar rouletten och returnerar ett nummer mellan 1 till 38

        Random rnd = new Random();
        int num = rnd.Next(1, 38);
        return num;
    }
}