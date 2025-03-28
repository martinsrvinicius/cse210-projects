/*Vinicius Ricardo Martins*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.WriteLine();
       
       // Reference reference = new Reference("Proverbs", 3, 5,6);
       //Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        Scripture scripture = new Scripture();
        
        //Exceeding requirements: Reading from JSON
        scripture.ReadFromJSON("Scriptures.json");
        scripture.GetDisplayReferenceList();

        Console.WriteLine("Type the number from the list: ");
        string type = Console.ReadLine();
        while(type == "")
        {
            Console.WriteLine("Invalid! Type a number: ");
            type = Console.ReadLine();
        }
        scripture.SetNewScripture(int.Parse(type));
        int level = 1;
        Console.WriteLine();

    while (type != "quit")
    {
        if(scripture.IsCompleteHidden())
        {
            Console.WriteLine("All words are hidden! Good luck!");
            Console.WriteLine();
            return;
        }
        string displayScripture = scripture.GetDisplayText();
        Console.WriteLine(displayScripture);
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        type = Console.ReadLine();
        Console.Clear();
        scripture.HideRandomWords(level);
        level ++;

   
    };

    }
}