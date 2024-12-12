using gym.CoreNew.Entities;



namespace gym.CoreNew.services
{
    public interface ImemberService
    {
        public List<member> Getmember();
        public member GetById(string id);
        public bool set(member c);
        public bool putName(string id, string name);
        public bool deletemember(string id);
    }
}
