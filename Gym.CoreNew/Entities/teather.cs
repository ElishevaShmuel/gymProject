namespace gym.CoreNew.Entities
{
    public class teacher
    {
        public enum Geners
        {
            Baila, Hiphop, Erobi, Pilatis
        }
        public string Name { get; set; }

        public string Id { get; set; }

        public string Phone { get; set; }
        public List<cours> Courses { get; set; }
        public Geners MyExpiriens { get; set; }

        public teacher(string name, string id, string phone, List<cours> courses, Geners myExpiriens)
        {
            Name = name;
            Id = id;
            Phone = phone;
            Courses = courses;
            MyExpiriens = myExpiriens;
        }
        public teacher() { }
    }
}
