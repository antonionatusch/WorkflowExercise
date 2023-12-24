namespace NewWorkflow;

public class WorkFlowEngine
{
    public void Run(IWorkflow workflow)
    {
        foreach (IActivity activity in workflow.GetActivities())
        {
            activity.Execute();
        }
    }
}