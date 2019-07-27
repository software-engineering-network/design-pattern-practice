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
                new UnscheduledTask { Criteria = PseudoCriteria.Urgent },
                new UnscheduledTask { Criteria = PseudoCriteria.Optional },
                new UnscheduledTask { Criteria = PseudoCriteria.Optional },
                new UnscheduledTask { Criteria = PseudoCriteria.Optional },
            };
        }

        [Fact]
        public void WhenSchedulingTasks_ThatAreRoutine_ItSchedulesTasksForTuesday()
        {
            var tuesdayTasks = taskSchedulingService.ScheduleTasks(unscheduledTasks)
                .Where(x => x.ScheduledDate == PseudoDate.Tuesday);

            tuesdayTasks.Should().HaveSameCount(unscheduledTasks.Where(x => x.Criteria == PseudoCriteria.Routine));
            tuesdayTasks.Should().OnlyContain(x => x.ScheduledDate == PseudoDate.Tuesday);
        }

        [Fact]
        public void WhenSchedulingTasks_ThatAreUrgent_ItSchedulesTasksForImmediateExecution()
        {
            var immediateTasks = taskSchedulingService.ScheduleTasks(unscheduledTasks)
                .Where(x => x.ScheduledDate == PseudoDate.Immediately);

            immediateTasks.Should().HaveSameCount(unscheduledTasks.Where(x => x.Criteria == PseudoCriteria.Urgent));
            immediateTasks.Should().OnlyContain(x => x.ScheduledDate == PseudoDate.Immediately);
        }

        [Fact]
        public void WhenSchedulingTasks_ThatAreOptional_ItSchedulesTasksForEventualExecution()
        {
            var eventualTasks = taskSchedulingService.ScheduleTasks(unscheduledTasks)
                .Where(x => x.ScheduledDate == PseudoDate.Eventually);

            eventualTasks.Should().HaveSameCount(unscheduledTasks.Where(x => x.Criteria == PseudoCriteria.Optional));
            eventualTasks.Should().OnlyContain(x => x.ScheduledDate == PseudoDate.Eventually);
        }
    }
}
