using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fifapub.Models
{
    public class Gallery
    {
        [Key]
        public int GalleryId { get; set; }
        public string image { get; set; }
        [ForeignKey("Event")]
        public int EventId
        {
            get;
            set;
        }
        public virtual Event Event { get; set; }
    }
}