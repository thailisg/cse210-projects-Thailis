using System;
using System.Collections.Generic;


public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    Random random = new Random();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        string[] wordSeparate = text.Split(" ");

        foreach (string word2 in wordSeparate)
        {
            _words.Add(new Word(word2));
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        int wordsHidden = 0;

        while (wordsHidden < numberToHide && !IsCompletelyHidden()) {

            int index = random.Next(_words.Count);
            if (_words[index].isHidden() == false)
            {
                _words[index].hide();
                wordsHidden++;
            }
        
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayString() + " ";
        }

        return scriptureText. Trim();

    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.isHidden() == false)
            {
                return false;
            }
            
        }
        return true;
    }

}