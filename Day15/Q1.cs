using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    class Student 
    {
        private int rollno;
        private string name;
        private int maths;
        private int sci;
        private int total;
        public Student(string nm, int mth, int science) {
            this.name = nm;
            this.maths = mth;
            this.sci = science;
            this.total = this.maths + this.sci;
        }
        public string disp() {
            return string.Format("name={0} maths={1} science={2} Total={3}",this.name,this.maths,this.sci,this.total);
        }
        static void Main(string[] args)
        {
            Student s1 = new Student("kailas",80,75);
            Student s2 = new Student("prath", 60, 85);
            Student s3 = new Student("Ajay", 90, 65);
            SortedList<string, string> sl =new SortedList<string, string>();
            sl.Add(s1.name,s1.disp());
            sl.Add(s2.name, s2.disp());
            sl.Add(s3.name, s3.disp());
           
            foreach (KeyValuePair<string, string> x in sl)
            Console.WriteLine(x);
   
            Console.ReadKey();


            }
        }
    }

