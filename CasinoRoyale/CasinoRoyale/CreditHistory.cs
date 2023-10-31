namespace CasinoRoyale
{
    class CreditHistory
    {
        public static void printCreditHistory(List<int> creditHistory)
        {
            Console.WriteLine("Your bet history\n");
            foreach (int credits in creditHistory)
            {
                Console.WriteLine("Your new credit balance became: " + credits);
            }
        }
    }
}
