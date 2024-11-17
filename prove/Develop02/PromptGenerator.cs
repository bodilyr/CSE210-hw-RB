public class PromptGenerator
{
    public List<string> _prompts;
    public Random _random;

    public PromptGenerator()
    {
      _prompts = new List<string>
        {
            "Write about something that made you smile today.",
            "Which friend would you choose to be stranded with on a desert island and why?",
            "When you close your eyes and try to relax, what image do you use to calm you - details!",
            "What animal is your spirit animal and why?",
            "It is raining a soft, gentle rain.  Do you stay inside, grab an umbrella, or dance in the rain?  Why?",
            "Write about your dream vacation (place, people, food, etc)."
        };

         _random = new Random();
    }
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
