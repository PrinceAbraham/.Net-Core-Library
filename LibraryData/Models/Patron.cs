﻿using System;

namespace LibraryData.Models
{
    public class Patron
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth{ get; set; }
        public string TelephoneNumber { get; set; }

        //Virtual lazy loads a collection from db the first time is is accesed
        public virtual LibraryCard LibraryCard { get; set; }
        public virtual LibraryBranch HomeLibraryBranch { get; set; }

    }
}
