using System;
using System.Collections;

namespace ConsoleApplication14
{
    class student { 
    public int rollnumber;
    static int genROLL=0;
        private string _name;
        private double _marks;

        public student(string name, double marks)
        {
            this.rollnumber = ++genROLL;
            Name = name;
            Marks = marks;
        }
        public string Name {
            set {
                this._name = value;
            }
            get {
                return _name;
            }
        }
        public double Marks
        {
            set
            {
                this._marks = value;
            }
            get
            {
                return _marks;
            }
        }
    }
    class school {
        static void Main() {
            student[] s = new student[3];
            s[0] = new student("kailas",80);
            s[1] = new student("prathmesh", 90);
            s[2] = new student("Ajay", 85);

              foreach (student s1 in s)
                Console.WriteLine("RollNo={0} name={1} marks={2}",s1.rollnumber,s1.Name,s1.Marks);
               

                Console.ReadKey();
            }
        }
    }

