﻿namespace NewWorkflow;

public class CallWebService : IActivity
{
    public void Execute()
    {
        Console.WriteLine("Calling web service, queuing video for encoding...");
    }
}