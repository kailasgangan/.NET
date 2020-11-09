using System;
public delegate int wd(int x);
namespace ConsoleApplication9
{
    public class Employee
    {
        private int id;
        private string name;
        private double salary;
        public Employee(string name, double sal)
        {
            this.name = name;
            this.salary = sal;
        }
        public override string ToString()
        {
            return ("id=" + this.id + " name=" + this.name + " salary=" + this.salary);
        }
        public static void Main()
        {
            Employee[] emp=new Employee[100000];
            for (int i = 0; i < 100000; i++)
            {
                emp[i] = new Employee("kailas",10000);
                Console.WriteLine("Generation of emp is: {0}", GC.GetGeneration(emp));
            }

            GC.Collect(0, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();

            Console.WriteLine("Generation of refToMyCar is: {0}",
  GC.GetGeneration(emp));

            // See if tonsOfObjects[9000] is still alive.
            if (emp[0] != null)
            {
                Console.WriteLine("Generation of tonsOfObjects[0] is: {0}",
                    GC.GetGeneration(emp[0]));
            }
            else
                Console.WriteLine("tonsOfObjects[0] is no longer alive.");

            // Print out how many times a generation has been swept.

            Console.WriteLine("\nGen 0 has been swept {0} times",
                                         GC.CollectionCount(0));

            Console.WriteLine("Gen 1 has been swept {0} times",
                                       GC.CollectionCount(1));

            Console.WriteLine("Gen 2 has been swept {0} times",
                                 GC.CollectionCount(2));
            Console.ReadLine();


            Console.ReadLine();
        }
    }
}