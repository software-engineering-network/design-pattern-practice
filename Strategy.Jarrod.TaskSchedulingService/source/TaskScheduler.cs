namespace Strategy.Jarrod
{
    public class TodayTaskScheduler
    {
        public ScheduledTask Schedule(UnscheduledTask unscheduledTask)
        {
            return new ScheduledTask()
            {
                ScheduledDate = PseudoDate.Today
            };
        }
    }
}
