using Gym.CoreNew.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.CoreNew.Repositories
{
    public interface IcoursRepository
    {
        public List<cours> GetCours();
    }
}
