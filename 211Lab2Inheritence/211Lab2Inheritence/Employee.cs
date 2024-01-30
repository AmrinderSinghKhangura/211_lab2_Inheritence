using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211Lab2Inheritence
{
    public class Employee
    {
        protected string id {  get; set; }
        protected string name { get; set; }
        protected string address { get; set; }
        protected string phone { get; set; }
        protected long sin { get; set; }
        protected string dob { get; set; }
        protected string dept { get; set; }

        public Employee(string id, string name, string address, string phone, long sin, string dob, string dept) 
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
            this.dob = dob;
            this.dept = dept;
        }

        public string GetName()
        {
            return this.name;
        }
        public virtual double GetPay()
        {
            return 6;
        }
        public override string ToString()
        {
            return $"base to string from emplyee class";
        }
    }
}
