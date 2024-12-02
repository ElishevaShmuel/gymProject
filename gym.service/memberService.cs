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
    public class memberService: ImemberService
    {
        private readonly IcoursRepository _repository;

        public memberService(coursRepository repository)
        {
            _repository = repository;
        }
    }
}
