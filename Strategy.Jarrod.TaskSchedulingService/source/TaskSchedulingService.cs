using System.Collections.Generic;

namespace Strategy.Jarrod
{
    /// <summary>
    /// Context
    /// </summary>
    public class TaskSchedulingService
    {
        public ICollection<ScheduledTask> ScheduleTasks(ICollection<UnscheduledTask> unscheduledTasks)
        {
            var scheduledTasks = new List<ScheduledTask>();

            foreach (var task in unscheduledTasks)
            {
                var taskScheduler = TaskSchedulerFactory.Create(task);
                var scheduledTask = taskScheduler.Schedule(task);
                scheduledTasks.Add(scheduledTask);
            }

            return scheduledTasks;
        }
    }
}
