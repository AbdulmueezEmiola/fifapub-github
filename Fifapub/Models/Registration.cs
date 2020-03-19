using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fifapub.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Fifapub.Models
{
    public class Registration
    {
        [Key]
        public int RegistrationId { get; set; }
        [Required(ErrorMessage="Please enter your name")]        
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        public long Telephone { get; set; }
        [Required(ErrorMessage = "Please enter your email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your home city")]
        public string CITY { get; set; }
        public bool PUBG { get; set; }
        public bool FIFA { get; set; }
        [ForeignKey("Event")]
        public  int EventId {
            get;
            set;
        }
        public virtual Event Event{ get;set; }
    }
}