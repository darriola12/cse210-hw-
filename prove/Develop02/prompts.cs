using System;

public class Prompt
{
    List<string> promtList;
    Random random;

    public Prompt()
    {
        promtList = new List<string>
        {
            "If I had one thing I could do over today, what would it be?",
            "Having a good day? Tell me about it!",
            "Have you finish your duties? How was that day of yours?",
            "Let's add an entry to the journal!",
            "What are you grateful for today?",
            "What was your favorite part of the day?",
            "This program was challenging to code, what was your hardest part of the day today?",
            "Who was the most interesting person I"
        };
        random = new Random();
    }
    public string GetRamdon()
    {
        int index = random.Next(promtList.Count);
        return promtList[index];
        

    }


}