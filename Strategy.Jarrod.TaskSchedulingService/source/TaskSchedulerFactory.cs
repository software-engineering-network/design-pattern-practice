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
                    return new TuesdayTaskScheduler();
                case PseudoCriteria.Optional:
                default:
                    return new EventuallyTaskScheduler();
            }
        }
    }
}
