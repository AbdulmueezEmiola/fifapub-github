using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Fifapub.Models
{
    public class New
    {
        [Key]
        public int NewsID { get; set; }
        [Required(ErrorMessage ="Please enter your header")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter your info")]
        public string Info { get; set; }
        public DateTime Date { get; set; }
        public string Image { get; set; }
    }
}