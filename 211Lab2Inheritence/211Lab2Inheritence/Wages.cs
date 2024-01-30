﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211Lab2Inheritence
{
    internal class Wages : Employee
    {
        protected double rate;
        protected double hours;
        public Wages(string id, string name, string address, string phone, long sin, string dob, string dept, double rate, double hours) : base(id, name, address, phone, sin, dob, dept)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
            this.dob = dob;
            this.dept = dept;
            this.rate = rate;
            this.hours = hours;
        }
        public override double GetPay()
        {
            if (this.hours > 40)
            {
                double overtimeHours = this.hours - 40;
                return this.rate * 40 + this.rate * 1.5 * overtimeHours;
            }
            else
            {
                return this.rate * this.hours;
            }
        }
        public override string ToString()
        {
            return "ToString for Wages class";
        }
    }
}
