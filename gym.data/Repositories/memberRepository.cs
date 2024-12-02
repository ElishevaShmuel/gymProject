using gym.core.@interface;
using gym.core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym.data.Repositories
{
    public class memberRepository: ImemberRepository
    {
        private readonly IDataContext _context;
        public memberRepository(IDataContext context)
        {
            _context = context;
        }
    }
}
