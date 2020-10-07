﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SanfordMIS4200.Models
{
    public class Owner
    {
        public int ownerID { get; set; }
        public  string firstName { get; set; }
        public string lastName { get; set; }
        public string  email { get; set; }
        public string phonenumber { get; set; }
        public ICollection<Pet> Pet { get; set; }

    }
}
