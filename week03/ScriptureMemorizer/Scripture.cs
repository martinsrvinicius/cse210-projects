using System.Text.Json.Nodes;

public class Scripture
{

    private List<Word> _words = new List<Word>();
    private Reference _reference;
    private List<Reference> _referenceList = new List<Reference>();
    private List<string> _scriptureList = new List<string>();


    public Scripture()
    {
    }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            Word newWord = new Word(words[i]);
            _words.Add(newWord);
        }
    }

  

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            Random randomNumber = new Random();
            int randomIndex = randomNumber.Next(0, _words.Count);
            _words[randomIndex].Hide();
        }
    }

   
public string GetDisplayText()
    {
        string displayText = "";
        foreach (Word word in _words)
        {
            string stringMask = "";
            if(word.IsHidden())
            {
                for(int i=0; i < word.getText().Length; i++) 
                {
                    stringMask += '_';
                }
                displayText += stringMask + " ";
            }
            else
            {
                displayText += word.getText() + " ";
            }
        }
        return _reference.GetDisplayText() + " " + displayText;
    }

    public bool IsCompleteHidden()
    {
        foreach (Word word in _words)
        {
            if(!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

//Exceeding requirements: Reading from JSON
    public void ReadFromJSON(string filePath)
    {
        if (File.Exists(filePath))
        {
            string fileContent = File.ReadAllText(filePath);
            try
            {
                JsonArray jsonArray = JsonNode.Parse(fileContent).AsArray();
                foreach (var item in jsonArray)
                {
                        Reference reference = new Reference(
                            item["reference"]["book"].ToString(),
                            int.Parse(item["reference"]["chapter"].ToString()),
                            int.Parse(item["reference"]["verse"].ToString()),
                            int.Parse(item["reference"]["endVerse"].ToString())
                        );

                        _referenceList.Add(reference);
                        _scriptureList.Add( item["text"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error parsing JSON: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine($"File not found: {filePath}");
        }
    }

//Exceeding requirements
    public void SetNewScripture(int idx)
    {
        _reference = _referenceList[idx];
        string[] words = _scriptureList[idx].Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            Word newWord = new Word(words[i]);
            _words.Add(newWord);
        }
    }

    public void GetDisplayReferenceList()
    {
        Console.WriteLine("List Of Scriptures:");

        List<string> displayScriptures = new List<string>();
        for(int i=0; i < _referenceList.Count; i++)
        {
            int opt = i;
            string text =  _referenceList[i].GetDisplayText();
            displayScriptures.Add(opt.ToString() + " - " + text);
            Console.WriteLine(opt.ToString() + " - " + text);
        }
    }


}