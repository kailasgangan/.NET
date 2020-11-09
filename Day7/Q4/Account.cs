using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Account
{
          [Serializable]
    public class Account
    {
        private int GeneratedId = 0;
        static int id = 0;
        private string name = null;
        private double balance = 0;
        const int obj = 3;
        static int objcnt = 0;
        public Account(string name, double bl)
        {
            if (bl >= 1000)
            {

                ++objcnt;
                if (objcnt <= obj)
                {
                    this.GeneratedId = ++id;
                    this.name = name;
                    this.balance = bl;
                }
                else
                {
                    Console.WriteLine("object is not created were name is {0}", name);
                }
            }
            else
            {
                Console.WriteLine("min bal amount should be 1000");
            }
        }
        public void deposit(double dp)
        {
            this.balance += dp;
            Console.WriteLine("{0} amount is deposited", dp);
        }
        public void withdraw(double w)
        {
            this.balance -= w;
            Console.WriteLine("{0} amount is withdraw ", w);
        }
        public void display()
        {
            Console.WriteLine("Id={0} ,name={1} and balance={2}", this.GeneratedId, this.name, this.balance);
        }
        static void SaveAsSoapFormat(object objGraph, string fileName)  //Serialisation
        {
            // Save object to a file named CarData.soap in SOAP format.
            SoapFormatter soapFormat = new SoapFormatter();

            using (Stream fStream = new FileStream(fileName,
              FileMode.Create, FileAccess.Write))
            {
                soapFormat.Serialize(fStream, objGraph);
            }
            Console.WriteLine("=> Saved car in SOAP format!");
        }
        static void LoadFromFile(string fn)
        {

            // read object to a file named CarData.soap in SOAP format.
            SoapFormatter soapFormat = new SoapFormatter();
            using (Stream fStream = new FileStream(fn, FileMode.Open))
            {
                employee[] obj = (employee[])soapFormat.Deserialize(fStream);

                foreach (employee e in obj)
                    Console.WriteLine("{0}  {1}", e.Name, e.Salary);
            }

        }


    }
    class demo
    {
        static void Main()
        {
            Account[] myEmp = new Account[2];
            myEmp[0] = new Account("raj", 7000);
            myEmp[1] = new Account("geeta", 9000);



            // Save as SOAP.
            SaveAsSoapFormat(myEmp, "AccountData.soap");
            string fn = "AccountData.soap";
            LoadFromFile(fn);


            Console.ReadLine();

        }
    }
}
