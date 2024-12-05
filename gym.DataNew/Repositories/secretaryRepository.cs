using gym.core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym.DataNew.Repositories
{
    public class secretaryRepository : IsecretaryRepository
    {
        private readonly IDataContext _context;
        public secretaryRepository(IDataContext context)
        {
            _context = context;
        }
    }
}
