using BlazorCrud.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Gateway
{
 
    public class GatewayManager
    {
        
        ApplicationDbContext _db = new ApplicationDbContext();

        public bool Add(Student student)
        {
            _db.student.Add(student);
            int rowEffected = _db.SaveChanges();
            if (rowEffected>0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public List<Student> ViewAll()
        {
            return _db.student.ToList();
        }
        public Student Edit(int id)
        {
          return _db.student.FirstOrDefault(c => c.id == id);
        }
        public bool Update(Student student)
        {
            _db.student.Update(student);
            int rowEffected = _db.SaveChanges();
            if (rowEffected>0)
            {
                return true;
            }
            else
                return false;
        }

        public bool Delete(int id)
        {
            var student = _db.student.FirstOrDefault(c => c.id == id);
            _db.student.Remove(student);
            int rowEffect = _db.SaveChanges();
            if (rowEffect > 0)
            {
                return true;
            }
            else return false;

        }
    }
}
