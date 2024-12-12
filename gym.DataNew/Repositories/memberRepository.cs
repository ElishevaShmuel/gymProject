
using gym.DataNew.@interface;
using gym.CoreNew.Repositories;

using gym.CoreNew.Entities;
using Microsoft.EntityFrameworkCore;

namespace gym.DataNew.Repositories
{
    public class memberRepository : ImemberRepository
    {
        private readonly DataContext _context;
        public memberRepository(DataContext context)
        {
            _context = context;
        }
        public List<member> Getmember()
        {
            return _context.Members.Include(m=>m.MyCourses).ToList();
        }
        public member GetById(string id)
        {
            return _context.Members.Find(id);

        }
        public bool set(member m)
        {
            _context.Members.Add(m);
            _context.SaveChanges();
            return true;
        }
        public bool putName(string id, string name)
        {

            var current = GetById(id);
            if (current != null)
            {
                current.Name = name;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool deletemember(string id)
        {
            var current = GetById(id);
            if (current != null)
            {
                _context.Members.Remove(current);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
