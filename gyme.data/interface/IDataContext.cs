using gym.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym.core.@interface
{
    public interface IDataContext
    {
        public List<cours> Courses { get; set; }
        public List<teather> Teathers { get; set; }
        public List<member> Members { get; set; }
        public secretary Secretary { get; set; }
    }
}
