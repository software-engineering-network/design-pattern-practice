namespace Strategy.Jarrod
{
    public class TaskSchedulerFactory
    {
        public static ITaskScheduler Create(PseudoCriteria pseudoCriteria)
        {
            switch (pseudoCriteria)
            {
                case PseudoCriteria.Urgent:
                    return new ImmediatelyTaskScheduler();
                case PseudoCriteria.Routine:
                default:
                    return new TuesdayTaskScheduler();
            }
        }
    }
}
