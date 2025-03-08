using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.BLL.Interfaces;
using Company.DAL.Data.Contexts;

namespace Company.BLL.Reposetories
{
    public class DepartmentReposotery : IDepartmentReposotory 
    {

        private CompanyDbcontext _context;

        public DepartmentReposotery()
        {
            _context = new CompanyDbcontext();
        }

        public IEnumerable<Department> GetAll()
        {
            
            return (IEnumerable<Department>)_context.Departments.ToList();
        }

        public Department? Get(int id)
        {
            
            return _context.Departments.Find(id);
        }

        public int Add(Department model)
        {
            
            _context.Departments.Add(model);
            return _context.SaveChanges();


        }

        public int Update(Department model)
        {
            
            _context.Departments.Update(model);
            return _context.SaveChanges();
        }

        public int Delete(Department model)
        {
            
            _context.Departments.Remove(model);
            return _context.SaveChanges();
        }

        

        

        
    }
}
