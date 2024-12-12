namespace gym.CoreNew.Entities
{
    public class time_operation
    {
        public int id { get; set; }
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
