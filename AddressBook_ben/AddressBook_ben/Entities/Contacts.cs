using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AddressBook_ben.Entities
{
    public class Contacts
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        //public Contacts()
        //{
        //    //set
        //    this.Id = 10;
        //    //get
        //    var _id = this.Id;
        //}

    }
}