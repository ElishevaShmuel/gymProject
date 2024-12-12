
using gym.CoreNew.Entities;
using gym.CoreNew.Repositories;


namespace gym.DataNew.Repositories
{
    public class coursRepository : IcoursRepository
    {
        private readonly DataContext _context;
        public coursRepository(DataContext context)
        {
            _context = context;
        }
        public List<cours> GetCours()
        {
            return _context.Courses.ToList();
        }
        public cours GetById(int id)
        {
            return _context.Courses.Find(id);
        }
        public bool set(cours c)
        {
            _context.Courses.Add(c);
            _context.SaveChanges();
            return true;
        }
        public bool putTimeOption(int id, time_operation t)
        {
            var current= GetById(id);
            if (current != null)
            {
                current.OperationTime = t;
                _context.SaveChanges();
                return true;
                
            }
            return false;

        }
        public bool deletecours(int id)
        {
            var current = GetById(id);
            if (current != null)
            {
               _context.Courses.Remove(current);
                _context.SaveChanges();
                return true;
            }
            return false;

        }
    }
}
