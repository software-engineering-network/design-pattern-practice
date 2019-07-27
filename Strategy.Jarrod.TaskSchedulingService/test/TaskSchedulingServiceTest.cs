using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Strategy.Jarrod;
using Xunit;

namespace Strategy.Jarrod.Test
{
    public class TaskSchedulingServiceTest
    {
        private TaskSchedulingService taskSchedulingService;
        private ICollection<UnscheduledTask> unscheduledTasks;

        public TaskSchedulingServiceTest()
        {
            taskSchedulingService = new TaskSchedulingService();
            unscheduledTasks = new List<UnscheduledTask>()
            {
                new UnscheduledTask { Criteria = PseudoCriteria.Routine },
                new UnscheduledTask { Criteria = PseudoCriteria.Urgent },
                new UnscheduledTask { Criteria = PseudoCriteria.Urgent }
            };
        }

        [Fact]
        public void WhenSchedulingTasks_ThatAreRoutine_ItSchedulesTasksForTuesday()
        {
            var tomorrowTasks = taskSchedulingService.ScheduleTasks(unscheduledTasks)
                .Where(x => x.ScheduledDate == PseudoDate.Tuesday);

            tomorrowTasks.Should().HaveSameCount(unscheduledTasks.Where(x => x.Criteria == PseudoCriteria.Routine));
            tomorrowTasks.Should().OnlyContain(x => x.ScheduledDate == PseudoDate.Tuesday);
        }

        [Fact]
        public void WhenSchedulingTasks_ThatAreUrgent_ItSchedulesTasksForImmediateExecution()
        {
            var nowTasks = taskSchedulingService.ScheduleTasks(unscheduledTasks)
                .Where(x => x.ScheduledDate == PseudoDate.Immediately);

            nowTasks.Should().HaveSameCount(unscheduledTasks.Where(x => x.Criteria == PseudoCriteria.Urgent));
            nowTasks.Should().OnlyContain(x => x.ScheduledDate == PseudoDate.Immediately);
        }
    }
}
