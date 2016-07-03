using AddressBook_ben.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AddressBook_ben.DataContext
{
    public class AddressBookContext : DbContext
    {
        public AddressBookContext() : base("AddressBook")
        {
        }
        public DbSet<Contacts> Contacts { get; set; } 
        
    }
}