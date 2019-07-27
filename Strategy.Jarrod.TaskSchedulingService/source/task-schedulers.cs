namespace Strategy.Jarrod
{
    /// <summary>
    /// Strategy
    /// </summary>
    public interface ITaskScheduler
    {
        ScheduledTask Schedule(UnscheduledTask unscheduledTask);
    }

    /// <summary>
    /// Concrete Strategy
    /// </summary>
    public class TuesdayTaskScheduler : ITaskScheduler
    {
        public ScheduledTask Schedule(UnscheduledTask unscheduledTask) =>
            new ScheduledTask() { ScheduledDate = PseudoDate.Tuesday };
    }

    /// <summary>
    /// Concrete Strategy
    /// </summary>
    public class ImmediatelyTaskScheduler : ITaskScheduler
    {
        public ScheduledTask Schedule(UnscheduledTask unscheduledTask) =>
            new ScheduledTask() { ScheduledDate = PseudoDate.Immediately };
    }
}
