using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.interfaces;
using VogCodeChallenge.API.models;

namespace VogCodeChallenge.API.businesslogics
{
    public class EmployeeInfoFromLocal : IEmployeeInfo
    {
        public IEnumerable<Employee> GetAll()
        {
            List<Employee> result = new List<Employee>()
            {
                new Employee()
                {
                    EmployeeId = 1,
                    FirstName ="First from local",
                    LastName="Last",
                    JobTitle="Software Developer",
                    Address="Winnipeg,Canada",
                    Department= getAllDepartments().Where(x=>x.DepartmentId==1).FirstOrDefault()
                }, new Employee()
                {
                    EmployeeId = 2,
                    FirstName ="Second from Database",
                    LastName="Last",
                    JobTitle="Tester",
                    Address="BC,Canada",
                    Department= getAllDepartments().Where(x=>x.DepartmentId==1).FirstOrDefault()
                }
            };
            return result;
        }

        public IList<Employee> ListAll()
        {
            List<Employee> result = new List<Employee>()
            {
                new Employee()
                {
                    EmployeeId = 1,
                    FirstName ="First from local",
                    LastName="Last",
                    JobTitle="Software Developer",
                    Address="Winnipeg,Canada",
                    Department= getAllDepartments().Where(x=>x.DepartmentId==1).FirstOrDefault()
                }, new Employee()
                {
                    EmployeeId = 2,
                    FirstName ="Second from Database",
                    LastName="Last",
                    JobTitle="Tester",
                    Address="BC,Canada",
                    Department= getAllDepartments().Where(x=>x.DepartmentId==1).FirstOrDefault()
                }
            };
            return result;
        }

        public List<Department> getAllDepartments()
        {
            return new List<Department>()
            {
                new Department(){DepartmentId=1,Name="Technical",UniqueAddress="TECH" },
                new Department(){DepartmentId=1,Name="Human Resource",UniqueAddress="HR" }
            };
        }
    }
}
