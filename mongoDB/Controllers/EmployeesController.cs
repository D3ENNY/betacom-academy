using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using mongoDB.BLogic;
using mongoDB.Models;
using MongoDB.Driver;

namespace mongoDB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        //private readonly IMongoCollection<Employee> _employees;
        private EmployeeService _employees;

        //public EmployeesController(IOptions<EmployeesDbConfig> opt) 
        public EmployeesController(EmployeeService service)
        {
            _employees = service;
        }

        [HttpGet]
        public Task<IEnumerable<Employee>> Get() => _employees.GetEmployee();

    }
}