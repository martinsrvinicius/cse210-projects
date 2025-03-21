using System.Collections.Generic;

public class Scripture
{

    private List<Word> _words = new List<Word>();
    private Reference _reference;	

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            _words.Add(new Word(words[i]));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
       
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + "\n";
        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }
        return result;
    }

    public bool IsCompleteHidden()
    {
        foreach (Word word in _words)
        {
         
        }
        return true;
    }

}