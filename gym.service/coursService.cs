

using gym.CoreNew.Entities;
using gym.CoreNew.Repositories;
using gym.CoreNew.services;

namespace gym.Service
{
    public class coursService : IcoursService
    {
        private readonly IcoursRepository _repository;

        public coursService(IcoursRepository repository)
        {
            _repository = repository;
        }
        public List<cours> GetCours()
        {
            return _repository.GetCours();
        }
        public cours GetById(int id)
        {
            return _repository.GetById(id);
        }
        public bool set(cours c)
        {
            return _repository.set(c);
        }
            public bool putTimeOption(int id, time_operation t)
        {
            return _repository.putTimeOption(id, t);
        }
        public bool deletecours(int id)
        {
            return (_repository.deletecours(id));
        }
    }
}
