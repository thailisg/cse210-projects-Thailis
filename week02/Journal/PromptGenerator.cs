using System;
using System.Collections.Generic;
using System.IO;

public class PromptGenerator
{
    public Random random = new Random();

    public List<string> _prompts = new List<string>
    {
        "What made you happy today?",
        "Did you do all your homework?",
        "What's your emotion today? Let it out!",
        "Write down your chores so you don't forget them.",
        "What did you eat today? Did you like it?"
    };

    public string GetRandomPrompt()
    {
        int indexPrompt = random.Next(_prompts.Count);
        return _prompts[indexPrompt];
    }
}
