using gym.core.Entities;
using gym.core.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdataContext
{
    public class FakeData: IDataContext
    {
        public List<cours> Courses { get; set; }
        public List<teather> Teathers { get; set; }
        public List<member> Members { get; set; }
        public secretary Secretary { get; set; }

        public FakeData()
        {
            Courses = new List<cours>();
            Teathers = new List<teather>();
            Members = new List<member>();
            Secretary = new secretary();
        }

    
    }
}
