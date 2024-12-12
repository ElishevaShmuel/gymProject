
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
    public class teacherService: IteacherService
    {
        private readonly IteacherRepository _repository;

        public teacherService(IteacherRepository repository)
        {
            _repository = repository;
        }
        public List<teacher> Getteacher()
        {
            return _repository.Getteacher();
        }
        public teacher GetById(string id)
        {
            return _repository.GetById(id);
        }
        public bool set(teacher c)
        {
            return _repository.set(c);
        }
        public bool putName(string id, string name)
        {
            return _repository.putName(id, name);
        }
        public bool deleteteacher(string id)
        {
            return (_repository.deleteteacher(id));
        }
    }
}
