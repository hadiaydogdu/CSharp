using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MultiModel.Models
{
    public class Person
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public int PhoneCodeID { get; set; }
        public string Phone { get; set; }

        [NotMapped]
        public string PhoneCodeStr { get; set; }
    }
}