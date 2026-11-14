using System;

class Program
{
    public static void Main(string[] args)
    {
        List<Scripture> library = new List<Scripture>();
        library.Add(new Scripture(
            new Reference("John", 3, 16),
         "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."));

        library.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
         "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."));

        library.Add(new Scripture(
            new Reference("Philippians", 4, 13),
         "I can do all things through Christ who strengthens me."));

        Random random = new Random();
        Scripture scripture = library[random.Next(library.Count)];

        int wordsToHideEachRound = 3;
        bool keepGoing = true;

        while (keepGoing)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                keepGoing = false;
            }
            else
            {
                Console.Write("Press enter to continue or type 'quit' to finish: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    keepGoing = false;
                }
                else
                {
                    scripture.HideRandomWords(wordsToHideEachRound);
                }
            }
        }
    }   

}