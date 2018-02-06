using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._02_OpenClosed
{
    public abstract class EmployeeBase
    {
        public EmployeeBase(int id, string name, string type)
        {
            this.ID = id;
            this.Name = name;
            this.EmployeeType = type;
        }
        public int ID { get; set; }
        public string EmployeeType { get; set; }
        public string Name { get; set; }

        public virtual decimal GetBonus()
        {
            return .1M;
        }
    }

    public class EmployeePermanent : EmployeeBase
    {
        public EmployeePermanent(int id, string name, string type) : base(id, name, type) { }

    }

    public class EmployeeTemp : EmployeeBase
    {
        public EmployeeTemp(int id, string name, string type) : base(id, name, type) { }
        public override decimal GetBonus()
        {
            return .05M;
        }
    }

    public class Bonus
    {
        public decimal Calculate(decimal salary, EmployeeBase employee)
        {
            return salary * employee.GetBonus();
        }
    }
}
