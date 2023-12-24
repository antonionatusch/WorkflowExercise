namespace NewWorkflow;

public interface IWorkflow
{
    void Add(IActivity activity);
    void Remove(IActivity activity);
    IEnumerable<IActivity> GetActivities();
}