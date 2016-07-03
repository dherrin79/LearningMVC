namespace AddressBook
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    

    public partial class AddressBook : DbContext
    {
        public AddressBook()
            : base("name=AddressBookContext")
        {
        }

        public  DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
