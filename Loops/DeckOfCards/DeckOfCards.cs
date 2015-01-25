namespace DeckOfCards
{
    using System;
    class DeckOfCards
    {
        static void Main(string[] args)
        {
            for (int card = 0; card < 13; card++)
            {
                for (int suit = 0; suit < 4; suit++)
                {
                    Console.Write(((Cards)card)
                                    .ToString()
                                    .TrimStart('_')
                                    .PadLeft(2) 
                                    + " of " + (Suits)suit);
                    if (suit != 3) Console.Write(", ");
                }
                Console.WriteLine();
            }
        }
    }
}
