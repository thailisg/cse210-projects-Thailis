using System;


public class Entry
{
    public string _prompt;
    public string _input;
    public string _date;

    public Entry(string _prompt, string _input)
    {
        _prompt = _prompt;
        _input = _input;
        _date = DateTime.Now.ToString("YYYY-MM-dd");
    }
    public void Display()
    {


    }
}