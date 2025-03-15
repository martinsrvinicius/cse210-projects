//Vinicius Ricardo Martins
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        //Extra requirements:
        //1- Function to save CSV
        //2- Function to load from CSV
        PromptGenerator p = new PromptGenerator();
        Journal j = new Journal();
        Console.WriteLine("Welcome to the Journal Program");
        int userAction = 0;
        do
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Save CSV");
            Console.WriteLine("6. Load CSV");
            Console.WriteLine("7. Quit");
            Console.WriteLine("What would you like to do?");

            int.TryParse(Console.ReadLine(), out userAction);

            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            Entry e = new Entry();



            switch (userAction)
            {
                case 1:
                    e._promptText = p.GetRandomPrompt();
                    Console.Write($"{e._promptText} ");
                    e._entryText = Console.ReadLine();
                    e._date = dateText;

                    j.AddEntry(e);
                    break;
                case 2:
                    j.DisplayAll();
                    break;
                case 3:
                    Console.WriteLine("What is the filename? ");
                    string fileNameToOpen = Console.ReadLine();
                    j.LoadFromFile(fileNameToOpen);
                    break;
                case 4:
                    Console.WriteLine("What is the filename? ");
                    string fileNameToSave = Console.ReadLine();
                    j.SaveToFile(fileNameToSave);
                    break;
                case 5:
                    //1-Added function to save CSV file
                    Console.WriteLine("What is the CSV filename? ");
                    string csvFileName = Console.ReadLine();
                    j.SaveToCSV(csvFileName);
                    break;
                case 6:
                    //2-Added function to load from CSV file
                    Console.WriteLine("What is the CSV filename? ");
                    string loadlCsvFileName = Console.ReadLine();
                    j.LoadFromCSV(loadlCsvFileName);
                    break;
            }
        } while (userAction != 7);


    }
}