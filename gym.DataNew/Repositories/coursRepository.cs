using gym.core.Entities;
using gym.core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym.DataNew.Repositories
{
    public class coursRepository : IcoursRepository
    {
        private readonly IDataContext _context;
        public coursRepository(IDataContext context)
        {
            _context = context;
        }
        public List<cours> GetCours()
        {
            return _context.Courses;
        }
    }
}
