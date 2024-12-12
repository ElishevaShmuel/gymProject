
using gym.DataNew.@interface;
using gym.CoreNew.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym.DataNew
{
    public class FakeData 
    {
        public List<cours> Courses { get; set; }
        public List<teacher> teachers { get; set; }
        public List<member> Members { get; set; }

        public FakeData()
        {
            Courses = new List<cours>();
            teachers = new List<teacher>();
            Members = new List<member>();
        }


    }
}
