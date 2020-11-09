using System;

namespace ConsoleApplication25
{
    static class gen {
        public static void swap<T>(ref T a,ref T b) {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
    class Employee
    {
        private int Accid;
        static int id;
        public string name { set; get; }
        public double salary { set; get; }

        public Employee(String nm, double sal)
        {
            Accid = ++id;
            name = nm;
            salary = sal;
        }
        public void Disp(){
        Console.WriteLine("name={0} salary={1}",name,salary);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            int a=10, b=20;
            Console.WriteLine("Before swapping a={0} b={1}", a, b);
            gen.swap<int>(ref a,ref b);
            Console.WriteLine("After swapping a={0} b={1}",a,b);

            string s1 = "kailas",s2="prathamesh";
            Console.WriteLine("Before swapping s1={0} s2={1}", s1, s2);
            gen.swap<string>(ref s1, ref s2);
            Console.WriteLine("After swapping s1={0} s2={1}", s1, s2);

            Employee e1 = new Employee("kailas",50000);
            Employee e2 = new Employee("prath",60000);
            Console.WriteLine("\n before swapping object e1 and e2 respectively");
            e1.Disp(); e2.Disp();
            gen.swap<Employee>(ref e1,ref e2);
            Console.WriteLine("\n After swapping object e1 and e2 respectively");
            e1.Disp(); e2.Disp();


            Console.ReadKey();


        }
    }
}
