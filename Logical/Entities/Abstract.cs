using System;
using System.Collections.Generic;
using System.Text;

namespace Logical
{

    public abstract class Employee
    {
        public int EmployeeID { get; set; }
        public string EmpName { get; set; }
    }

    public class ContractEmployee : Employee
    {

    }

    public class FullTimeEmployee : Employee
    {

    }


    public class Test
    {
        ContractEmployee cEmp = new ContractEmployee();
        cEmp.
        
    }

}
