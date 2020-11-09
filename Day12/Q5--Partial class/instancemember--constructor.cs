using System;
public delegate int wd(int x);
namespace ConsoleApplication9
{
    public partial class Employee
    {
       private int id;
        private string name;
        private double salary;
        public Employee(string name,double sal) {
            this.name = name;
            this.salary = sal;
        }
      
    }
}