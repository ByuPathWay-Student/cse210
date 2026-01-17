using System.Runtime.Intrinsics.Arm;

public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        List<string> promptList = new List<string>() {"What is something that made you happy today?","What is something that made you sad today?","what is something you accomplished today?","What did you do about a problem today?","Did you accomplish as much as you wanted today? Why or why not?","What was the best thing you ate today?","Did you create anything today?","Was there something that made you excited today?","What was something that happened that made you laugh?","What was the weather like today? How did it make you feel?"};
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(0,promptList.Count);
        string prompt = promptList[index];
        return prompt;
    }
}