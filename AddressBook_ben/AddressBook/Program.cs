using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new AddressBook();
            IEnumerable<Contact>  contacts = db.Contacts;


            foreach(var c in contacts)
            {
                Console.WriteLine(string.Format("Name: {0}", c));
            }

            Console.ReadLine();
            
        }
    }
}
