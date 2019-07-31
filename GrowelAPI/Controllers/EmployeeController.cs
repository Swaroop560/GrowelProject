using System.Threading.Tasks;
using GMSAPI.DataContext;
using GMSAPI.DTO;
using GMSAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GrowelAPI.Controllers
{
    public class EmployeeController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        private readonly IConfiguration _config;
        public EmployeeController(IAuthRepository repo, IConfiguration config)
        {
            this._config = config;
            this._repo = repo;
        }

        [HttpPost("registeremployee")]
        public async Task<IActionResult> Register(EmployeeForRegisterDTO employeeForRegisterDTO)
        {
            // validate the request

            employeeForRegisterDTO.UserName = employeeForRegisterDTO.UserName.ToLower();

            if (await _repo.UserExists(employeeForRegisterDTO.UserName))
                return BadRequest("User Name Taken");

            var empToCreate = new MasterEmployee
            {
                    // EmpName = employeeForRegisterDTO.EmpName,
                    // Lname = employeeForRegisterDTO.Lname,
                    // Gender = employeeForRegisterDTO.Gender,
                    // DoJ = employeeForRegisterDTO.DoJ,
                    // Email = employeeForRegisterDTO.Email,
                    // IsAdmin = employeeForRegisterDTO.IsAdmin,
                    // deptID = employeeForRegisterDTO.deptID,
                     UserName = employeeForRegisterDTO.UserName

            };

            var createdEmployee = await _repo.Register(empToCreate, employeeForRegisterDTO.Password);
            // return CreatedAtRoute();
            return StatusCode(201);


        }
    }
}