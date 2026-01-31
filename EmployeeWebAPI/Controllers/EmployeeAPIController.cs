using EmployeeWebAPI.DBContext;
using EmployeeWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeAPIController : ControllerBase
    {
        private readonly AppDBContext _dbContext;
        public EmployeeAPIController(AppDBContext db)
        {
            _dbContext = db;
        }

        [HttpGet("GetAllEmp")]
        public IActionResult GetAllEmployee()
        {
            List<EmployeeAPI> data = _dbContext.EmployeeAPI.ToList();
            if (data is null)
            {
                return Ok("Employee Not Found");
            }
            return Ok(data);
        }

        [HttpPost]
        public IActionResult AddEmployee(EmployeeAPI emp)
        {
            _dbContext.EmployeeAPI.Add(emp);
            _dbContext.SaveChanges();
            return Ok("Employee Added Successfully");
        }
    }
}
