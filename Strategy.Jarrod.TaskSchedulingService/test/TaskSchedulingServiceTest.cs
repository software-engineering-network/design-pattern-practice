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
        [Fact]
        public void WhenSchedulingTasks_ForToday_ItCreatesScheduledTasksForToday()
        {
            var unscheduledTasks = new List<UnscheduledTask>()
            {
                new UnscheduledTask { DesiredDate = PseudoDate.Today },
                new UnscheduledTask { DesiredDate = PseudoDate.Today }
            };

            var taskSchedulingService = new TaskSchedulingService();

            var todayTasks = taskSchedulingService.ScheduleTasks(unscheduledTasks).Where(x => x.ScheduledDate == PseudoDate.Today);

            todayTasks.Should().HaveSameCount(unscheduledTasks.Where(x => x.DesiredDate == PseudoDate.Today));
            todayTasks.Should().OnlyContain(x => x.ScheduledDate == PseudoDate.Today);
        }
    }
}
