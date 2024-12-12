
using gym.CoreNew.Entities;
using gym.CoreNew.Repositories;
using Microsoft.EntityFrameworkCore;


namespace gym.DataNew.Repositories
{
    public class teacherRepository : IteacherRepository
    {
        private readonly DataContext _context;
        public teacherRepository(DataContext context)
        {
            _context = context;
        }
        public List<teacher> Getteacher()
        {
            return _context.teachers.Include(m => m.Courses).ToList();
        }
        public teacher GetById(string id)
        {
            return _context.teachers.Find(id);

        }
        public bool set(teacher t)
        {
            _context.teachers.Add(t);
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
        public bool deleteteacher(string id)
        {
            var current = GetById(id);
            if (current != null)
            {
                _context.teachers.Remove(current);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

     

    }
}
