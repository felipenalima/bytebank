using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBankAdmin.InternalSystem;
using ByteBankAdmin.Utils;

namespace ByteBankAdmin.Employees
{
    public class AccountManager : EmployeeAuthenticable, IBonificationManager
    {
        public AccountManager(string cpf) : base(cpf, 4000)
        {
            
        }

        public override double GetBonification()
        {
            return Salary * 0.25;
        }

        public override void SalaryIncrease()
        {
            Salary *= 1.05;
        }        
    }
}