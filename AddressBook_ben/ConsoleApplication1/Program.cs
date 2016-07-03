using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new AddressBook();
            var contacts = db.Contacts;

            foreach(var c in contacts)
            {
                Console.WriteLine(string.Format("Name: {0}", c.FirstName));
            }
            Console.ReadLine();
        }
    }
}
