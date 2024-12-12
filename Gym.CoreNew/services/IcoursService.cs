using gym.CoreNew.Entities;


namespace gym.CoreNew.services
{
    public interface IcoursService
    {
        public List<cours> GetCours();
        public cours GetById(int id);
        public bool set(cours c);
        public bool putTimeOption(int id, time_operation t);
        public bool deletecours(int id);

    }
}
