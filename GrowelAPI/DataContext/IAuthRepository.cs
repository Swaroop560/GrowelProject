using System.Collections.Generic;
using System.Threading.Tasks;
using GMSAPI.Model;

namespace GMSAPI.DataContext
{
    public interface IAuthRepository
    {
          Task<MasterEmployee> Login(string username, string password);

          Task<MasterEmployee> Register(MasterEmployee employeeroot , string password);

        //  Task<bool> DeptExists(string deptname);

        //  Task<Department> AddDepartments(Department depts);

          Task<bool> UserExists(string username);
         
        //  Task<IEnumerable<EmployeeRoot>> getAllEmps();

        //  Task<EmployeeRoot> GetEmployeeByID(int Id);

    }
}


