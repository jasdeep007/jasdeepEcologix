using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.interfaces;
using VogCodeChallenge.API.models;

namespace VogCodeChallenge.API.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class employeesController : ControllerBase
    {
        private readonly IEmployeeInfo _emp;
        public employeesController(IEmployeeInfo employeeInfo)
        {
            this._emp = employeeInfo;
        }
        [Route("")]
        [HttpGet]
        public async Task<IEnumerable<Employee>> getEmployees()
        {
            var result = Task.Run(() => _emp.GetAll());
            await Task.WhenAll(result);
            return result.Result;
        }

        [Route("department/{departmentId}")]
        [HttpGet]
        public async Task<IEnumerable<Employee>> department(int departmentId)
        {
            var result = Task.Run(() => _emp.GetAll().Where(x => x.Department.DepartmentId == departmentId));
            await Task.WhenAll(result);
            return result.Result;
        }
    }
}
