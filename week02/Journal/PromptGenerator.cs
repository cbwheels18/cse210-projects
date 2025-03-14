using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
            "What are three things you're grateful for today?",
            "What is your ideal day from start to finish?",
            "If you could meet your future self what questions would you ask?",
            "When did you feel truly at peace today and if not why not?",
            "What is one goal you’re working toward and why is it important to you?",
            "What are your strengths and how do you use them in your daily life?",
            "How do you handle stress and what coping mechanisms work best for you?",
            "What is a challenge you're currently facing and how are you approaching it?",
            "What would you write to your past self about a significant turning point in your life?",
            "What makes you feel most alive, and how can you do more of that?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        
        return randomPrompt;
    }
}
