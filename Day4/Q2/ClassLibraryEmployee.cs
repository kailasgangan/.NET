using System;


namespace ClassLibraryEmployee
{
    public class Employee
    {
        private int id;
        private string name;
        private int salary;
        private int netsal;
        const int TDS = 10;
        //---------------------constructor------------------------
        public Employee(int id,string name,int sal) {
            this.id = id;
            this.name = name;
            this.salary = sal;
        }
        //-----------netsalary----------------------
        public int netsalary() {
            netsal = salary - ((10 * salary) / 100);
            return netsal;
        }
        //------------Display------------------------
        public void display(){
            Console.WriteLine("name={0} and Netsalary={1}",this.name,this.netsal);
        }
    }
    }

