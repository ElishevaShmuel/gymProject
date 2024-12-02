using gym.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym.core.Repositories
{
    public interface IcoursRepository
    {
        public List<cours> GetCours();
    }
}
