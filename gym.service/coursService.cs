using gym.core.Entities;
using gym.core.Repositories;
using gym.core.services;
using gym.data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym.service
{
    public class coursService: IcoursService
    {
        private readonly IcoursRepository _repository;

        public coursService(coursRepository repository)
        {
            _repository = repository;
        }
        public List<cours> GetCours()
        {
            return _repository.GetCours();
        }
    }
}
