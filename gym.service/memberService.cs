
using gym.CoreNew.Repositories;
using gym.CoreNew.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gym.CoreNew.Entities;

namespace gym.Service
{
    public class memberService: ImemberService
    {
        private readonly ImemberRepository _repository;

        public memberService(ImemberRepository repository)
        {
            _repository = repository;
        }
        public List<member> Getmember()
        {
            return _repository.Getmember();
        }
        public member GetById(string id)
        {
            return _repository.GetById(id);
        }
        public bool set(member c)
        {
            return _repository.set(c);
        }
        public bool putName(string id, string name)
        {
            return _repository.putName(id, name);
        }
        public bool deletemember(string id)
        {
            return (_repository.deletemember(id));
        }
    }
}
