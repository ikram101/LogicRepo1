using System;
using System.Collections.Generic;
using System.Text;

namespace Logical
{

    public abstract class Employee
    {
        public int EmployeeID { get; set; }
        public string EmpName { get; set; }

        public abstract DateTime DOB { get; set; }
        public abstract void DoWork(int i);


        public void GetAge(int i)
        {

        }
        public virtual void GetAge2(int i)
        {

        }

    }

    public class ContractEmployee : Employee
    {

        public override DateTime DOB { get; set; }

        public override void DoWork(int i)
        {
            
        }

        public new void  GetAge(int i)
        {

        }

    }

    public class FullTimeEmployee : Employee
    {
        public override DateTime DOB { get; set; }


        public override void DoWork(int i)
        {

        }
        public int ContractID { get; set; }
    }


     

    public class Test1
    {

        public void hello()
        {
            FullTimeEmployee fe = new FullTimeEmployee();
            


         }

    }

}
