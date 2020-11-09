using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Employee2classLibrary
{
    public class Employee
    {
       private int  Id;
       static int genId=0;
        private string name;
        private double salary;
        private double netsalary;
        const int TDS = 10;
        static int maxemp=0;
        const int maxsal = 50000;
        public Employee(string nm,double sal) {
            if (maxemp < 3)
            {
                maxemp++;
                if (sal <= 50000)
                {
                    this.Id = ++genId;
                    this.name = nm;
                    this.salary = sal;
                }
                else {
                    Console.WriteLine("enter salary below 50000");
                }
            }
            else {
                Console.WriteLine("you cant able to create object of Employee");
            }
        
        }
        public double calculate_netsalary() {
            netsalary = salary - (10 * salary) / 100;
            return netsalary;
        }
        public void display() {
            Console.WriteLine("Id={0}, name={1}, salary={2}, netsalary={3} ",this.Id,this.name,this.salary,this.netsalary);
        }

    }
}
