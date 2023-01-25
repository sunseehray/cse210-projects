using System;
class PromptGenerator
{
    List<string> promptList = new List<string> {
            "Reflect on a time when you overcame a challenge.",
            "Write about a person who has had a significant impact on your life.",
            "Describe a place that holds special meaning to you.",
            "Write about a goal you are currently working towards.",
            "Reflect on a decision you made that you now regret.",
            "Write about a memorable experience you had while traveling.",
            "Describe a person you admire and explain why.",
            "Reflect on a time when you learned a valuable lesson.",
            "Write about a hobby or interest that brings you joy.",
            "Reflect on a specific moment in your life that made you feel grateful."
        };
    public string GeneratePrompt()
    {
        Random rand = new Random();
        int randomNumber = rand.Next(0,9);
        string prompt = promptList[randomNumber];
        return prompt;
    }
}
