using System;

namespace ConsoleApplication15
{
    class person
    {
        public virtual string dojob()
        {
            return "doing job";
        }
    }
    class programmer : person
    {
        public override string dojob()
        {
            return "doing coding";
        }
        public void testing()
        {
            Console.WriteLine(" I am testing code also");
        }
    }
    class dancer : person
    {

    }
    class singer : person
    {
        public override string dojob()
        {
            return "singing";
        }
    }
    class Program
    {
        static void perform(person p)
        {
            string s=p.dojob();
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            person[] p = new person[3];
            p[0] = new programmer();
            p[1] = new singer();
            p[2] = new dancer();
          
            for (int i = 0; i < p.Length; i++) {
                 perform(p[i]);
             }


            Console.ReadLine();

        }
    }
}
