using System.Collections.Generic;

namespace Strategy.Jarrod
{
    public class TaskSchedulingService
    {
        public ICollection<ScheduledTask> ScheduleTasks(ICollection<UnscheduledTask> unscheduledTasks)
        {
            var scheduledTasks = new List<ScheduledTask>();

            foreach (var task in unscheduledTasks)
            {
                var taskScheduler = new TodayTaskScheduler();
                var scheduledTask = taskScheduler.Schedule(task);
                scheduledTasks.Add(scheduledTask);
            }

            return scheduledTasks;
        }
    }
}
