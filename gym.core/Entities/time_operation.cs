namespace gym.core.Entities
{
    public class time_operation
    {
        public TimeOnly TimeStart { get; set; }
        public TimeOnly TimeEnd { get; set; }

        public time_operation() { }

        public time_operation(TimeOnly timeStart, TimeOnly timeEnd)
        {
            TimeStart = timeStart;
            TimeEnd = timeEnd;
        }
    }
}
