using System;
using System.Collections;

namespace ConsoleApplication14
{
    class school {
        static void Main() {
            var v = new[] { new { name = "kailas", salary = 50000 }, new { name = "prath", salary = 55000 }, new { name = "Ajay", salary = 60000 } };
            foreach (var c in v)
            {
                Console.WriteLine("name={0} salary={1}",c.name,c.salary);

            }

               

                Console.ReadKey();
            }
        }
    }

