using System;
using System.Collections.Generic;

namespace Strategy.Jarrod
{
    public class TaskSchedulerFactory
    {
        private static Dictionary<PseudoCriteria, Func<ITaskScheduler>> taskSchedulers =
            new Dictionary<PseudoCriteria, Func<ITaskScheduler>>()
            { 
                { PseudoCriteria.Optional, () => new EventuallyTaskScheduler() }, 
                { PseudoCriteria.Routine, () => new TuesdayTaskScheduler() }, 
                { PseudoCriteria.Urgent, () => new ImmediatelyTaskScheduler() }
            };

        public static ITaskScheduler Create(UnscheduledTask unscheduledTask) =>
            taskSchedulers[unscheduledTask.Criteria]();
    }
}
