using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fifapub.Models
{
    public class Winner
    {
        [Key]
        public int WinnerId { get; set; }
        [Required(ErrorMessage ="Don't forget to add the name")]
        public string Name { get; set; }
        public bool pubg { get; set; }
        public bool fifa { get; set; }
        public string Image { get; set; }
        [ForeignKey("Event")]
        public int EventId
        {
            get;
            set;
        }
        public virtual Event Event { get; set; }
    }
}