using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Deja_sList.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set;}
        public string Zipcode { get; set; }
        public string Email { get; set; }

        [ForeignKey("Jobs")]
        public string JobId { get; set; }
        public Jobs Jobs { get; set; }
    
    }
}