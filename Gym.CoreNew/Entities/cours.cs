using static gym.CoreNew.Entities.teacher;

namespace gym.CoreNew.Entities
{
    public class cours
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Geners Gener { get; set; }
        public time_operation OperationTime { get; set; }
        

        public cours() { }

        public cours(string name, int id, Geners gener, time_operation operationTime)
        {
            Name = name;
            Id = id;
            Gener = gener;
            OperationTime = operationTime;
        }
    }
}
