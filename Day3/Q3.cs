using System;


namespace ConsoleApplication5
{
    struct emp {
        private string name;
        private int salary;
        public emp(string name,int salary) {
            this.name = name;
            this.salary = salary;

        }
        public void dsp(){
            Console.WriteLine("name="+name+"  salary="+salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            emp e=new emp("kailas",50000);
            emp e1 = new emp("prathamesh", 60000);
            e.dsp();
            e1.dsp();
            Console.ReadLine();

        }
    }
}
