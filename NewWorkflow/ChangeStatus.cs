namespace NewWorkflow;

public class ChangeStatus : IActivity
{
    public void Execute()
    {
        Console.WriteLine("Changing video status to \"Processing\"...");
    }
}