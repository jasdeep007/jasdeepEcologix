using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.models;

namespace VogCodeChallenge.API.interfaces
{
    public interface IEmployeeInfo
    {
        IEnumerable<Employee> GetAll();
        IList<Employee> ListAll();
    }
}
