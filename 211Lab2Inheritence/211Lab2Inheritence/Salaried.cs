using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _211Lab2Inheritence
{
    public class Salaried : Employee
    {  
        protected double salary {  get; set; }
        public Salaried( string id, string name, string address, string phone, long sin, string dob, string dept, double salary ):base(id, name, address, phone, sin, dob, dept)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
            this.dob = dob;
            this.dept = dept;
            this.salary = salary;
        }
        public override double  GetPay()
        {
            return this.salary / 52;
        }
        public override string ToString()
        {
            return "ToString for Salaried class";
        }
    }
}
