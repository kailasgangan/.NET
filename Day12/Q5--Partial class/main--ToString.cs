using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  ConsoleApplication9
{
    public partial class Employee
    {
        public override string ToString()
        {
            return ("id=" + this.id + " name=" + this.name + " salary=" + this.salary);
        }
        public static void Main()
        {
            var e1 = new Employee("prath", 50000);
            object e2 = new Employee("kailas", 50000);
            dynamic e3 = new Employee("kailas", 50000);
            e3 = "ajay";         //allowed  can be re-assign with any data type
            //  e1 = "ajay";          //not allowed-----strongly coupled with data type once assign cant re-assign
            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.WriteLine(e3);

            Console.ReadLine();
        }
    }
}
