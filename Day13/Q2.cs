using System;
using System.IO;
namespace Day5Account
{
    public class student
    {
        private int id;
        private string name;
        private int marks;
        public student(string name, int mks)
        {
            this.name = name;
            this.marks = mks;

        }
        public void give_gracemarks(int mks)
        {
            if (mks >=5)
            {
                throw new myexception(name, marks, "gracemarks should be less than 5");
            }
            else
            {
                this.marks = mks;
            }

        }
        public void filestore(){
            FileStream fout = new FileStream("tt.txt", FileMode.Create, FileAccess.Write);
            StreamWriter fstr_out = new StreamWriter(fout);
            fstr_out.WriteLine(name);
            fstr_out.Write(marks);
            fout.Close();
        }
    }
    class myexception : ApplicationException
    {
        public readonly int mks;
        public readonly string name;
        public string sms;
        public myexception(string name, int mks, string smg)
        {
            this.name = name;
            this.mks = mks;
            this.sms = smg;
        }
    }
    class demo
    {
        static void Main()
        {
            try
            {
                student e1 = new student("raj", 80);
                student e2 = new student("geet", 70);


                e1.give_gracemarks(4);
                e1.filestore();

            }
            catch (myexception e)
            {
                Console.WriteLine("marks={0} name={1} {2}", e.mks, e.name, e.sms);
            }
           

            Console.ReadLine();

        }
    }
}
