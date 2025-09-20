using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void hide()
    {
        _isHidden = true;
    }

    public void show()
    {
        _isHidden = false;
    }

    public bool isHidden()
    {
        return _isHidden;
    }

    public string GetDisplayString()
    {
        if (_isHidden != true)
        {
            return _text;
        }
        else
        {
            string hideLetters = "";

            foreach (char letter in _text)
            {
                hideLetters += "_";
            }

            return hideLetters;
        }
    }
}

