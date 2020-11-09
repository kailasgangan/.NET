using System;
using System.Collections;

namespace ConsoleApplication14
{
    class location{
    public string loc{set;get;}
    public location()
        {
            loc = "No-name";
            
        }
    }
    class employee { 
    public string name{set;get;}
    public double salary { set; get; }
    public location l = new location();
    public employee(string nm,double sal,string location) {
        name = nm;
        salary = sal;
        l.loc = location;
    }
    public override string ToString()
    {
        return string.Format("name={0} salary={1} location={2}",name,salary,l.loc);
    }

    public object Clone()
    {
        // First get a shallow copy.
        employee emp = (employee)this.MemberwiseClone();
        // Then fill in the gaps.
        location location = new location();
        location.loc = this.l.loc;
        emp.l = location;
        return emp;

    }

    }
    class school {
        static void Main() {
            employee e1 = new employee("kailas",50000,"mumbai");
            Console.WriteLine(e1);
            employee e2 = (employee)e1.Clone();
            Console.WriteLine(e2);
            e1.l.loc = "khargar";
            e2.l.loc = "navi mumbai";
            Console.WriteLine(e1);
            Console.WriteLine(e2);

                Console.ReadKey();
            }
        }
    }

