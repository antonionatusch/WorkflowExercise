namespace NewWorkflow;

public class SendEmail : IActivity
{
    public void Execute()
    {
        Console.WriteLine("Sending encoding notification email...");
    }
}