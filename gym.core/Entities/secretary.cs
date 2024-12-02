namespace gym.core.Entities
{
    public class secretary
    {
        public string Name { get; set; }

        public string Id { get; set; }

        public string Phone { get; set; }

        public time_operation timeOperation { get; set; }

        public secretary()
        {

        }

        public secretary(string name, string id, string phone, time_operation timeOperation)
        {
            Name = name;
            Id = id;
            Phone = phone;
            this.timeOperation = timeOperation;
        }
    }
}
