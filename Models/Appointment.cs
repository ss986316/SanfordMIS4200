using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SanfordMIS4200.Models
{
    public class Appointment
    {
        [Key]
        public int appointmentID { get; set; }
        public DateTime appointmentTime { get; set; }
        public int petID { get; set; }
        public int ownerID { get; set; }
        public virtual Pet  Pet { get; set; }
        public virtual Owner Owner  { get; set; }
    }
}