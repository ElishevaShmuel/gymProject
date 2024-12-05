namespace Gym.CoreNew.Entities
{
    public class member
    {
        public string Name { get; set; }

        public string Id { get; set; }

        public string Phone { get; set; }
        public List<cours> MyCourses { get; set; }

        public member()
        {
        }

        public member(string name, string id, string phone, List<cours> myCourses)
        {
            Name = name;
            Id = id;
            Phone = phone;
            MyCourses = myCourses;
        }
    }
}
