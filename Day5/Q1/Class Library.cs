using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Employee
{
    public class Employee
    {
        private string Firstname;
        private string Lastname;
        private string Middlename;
        public Employee(string Firstname, string Middlename, string Lastname)
        {
            this.Firstname = Firstname;
            this.Middlename = Middlename;
            this.Lastname =  Lastname;
            Display1();
            
        }
        public Employee(string fst,string lst) {
            this.Firstname = fst;
            this.Lastname = lst;
            Display2();
        }
        public void Display1() {
            Console.WriteLine("Firstname={0} \n middlename={1} \n lastname={2}", Firstname,Middlename, Lastname);
        }
        public void Display2()
        {
            Console.WriteLine("Firstname={0} \n lastname={1}", Firstname, Lastname);
        }
    }
}
