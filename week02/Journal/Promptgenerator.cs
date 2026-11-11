using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>();
     private Random _random = new Random();

    public PromptGenerator()
    {
        _prompts.Add("What was the best part of your day?");
        _prompts.Add("What was the most challenging part of your day?");
        _prompts.Add("What are you grateful for today?");
        _prompts.Add("What did you learn today?");
        _prompts.Add("What made you happy today?");
        _prompts.Add("What did you do for yourself today?");
        _prompts.Add("What did you do for someone else today?");
        _prompts.Add("What was the most interesting thing you saw today?");
        _prompts.Add("What was the most surprising thing that happened today?");
    }

     public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}