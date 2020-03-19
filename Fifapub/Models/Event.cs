using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Fifapub.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string EventCity { get; set; }
        public string EventVenue { get; set; }
        public DateTime date { get; set; }
    }
}