using gym.CoreNew.Entities;


namespace gym.CoreNew.services
{
    public interface IteacherService
    {
        public List<teacher> Getteacher();
        public teacher GetById(string id);
        public bool set(teacher c);
        public bool putName(string id, string name);
        public bool deleteteacher(string id);
    }
}
