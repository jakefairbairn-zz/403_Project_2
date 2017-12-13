using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project2.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name ="Email Address")]
        public string UserEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string UserPassword { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string UserFirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string UserLastName { get; set; }
    }
}