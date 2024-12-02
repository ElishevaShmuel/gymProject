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
    public class secretaryService: IsecretaryService
    {
        private readonly IcoursRepository _repository;

        public secretaryService(coursRepository repository)
        {
            _repository = repository;
        }
    }
}
