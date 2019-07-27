namespace Strategy.Jarrod
{
    public class ScheduledTask
    {
        public PseudoDate ScheduledDate { get; set; }
    }

    public class UnscheduledTask
    {
        public PseudoCriteria Criteria { get; set; }
    }
}
