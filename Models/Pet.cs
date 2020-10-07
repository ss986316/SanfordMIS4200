using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SanfordMIS4200.Models
{
    public class Pet
    {
        public int petID { get; set; }
        public string petType { get; set; }
        public int ownerID { get; set; }
        public  virtual Owner Owner { get; set; }
        public ICollection<Appointment> Appointment { get; set; }

    }
}