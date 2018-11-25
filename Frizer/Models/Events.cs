using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Frizer.Models
{
    public class Events
    {
        public Events(DateTime start, DateTime end, int id, string clientId, string serviceId)
        {
            this.start = start;
            this.end = end;
            this.clientId = clientId; 
            this.Id = id;
            this.serviceId = serviceId;
        }

        public Events()
        {

        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime start { get; set; }

        public DateTime end { get; set; }

        public string clientId { get; set; }

        public string serviceId { get; set; }
    }
}