using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.BLL.Interfaces
{
    public interface IDepartmentReposotory
    {
        IEnumerable<Department> GetAll();
        Department? Get(int id);
        int Add(Department model);
        int Update(Department model);

        int Delete(Department model);

    }
}
