
using gym.core.Entities;
using gym.core.@interface;
using gym.core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym.data.Repositories
{
    public class coursRepository: IcoursRepository
    {
        private readonly IDataContext _context;
        public coursRepository(IDataContext context) 
        {
            _context=context;
        }
        public List<cours> GetCours()
        {
            return _context.Courses;
        }
    }
}
