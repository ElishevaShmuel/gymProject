using gym.core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym.DataNew.Repositories
{
    public class teacherRepository : IteacherRepository
    {
        private readonly IDataContext _context;
        public teacherRepository(IDataContext context)
        {
            _context = context;
        }
    }
}
