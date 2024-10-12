using System.Collections.Generic;
public class PromptGenerator
{
    // attributes
    public List<string> _prompts;

    // behaviors
    public string GeneratePrompt()
    {
        Random randomGenerator = new Random();
        int promptIndex = randomGenerator.Next(0, _prompts.Count);

        string newPrompt = _prompts[promptIndex];
        return newPrompt;
    }
}