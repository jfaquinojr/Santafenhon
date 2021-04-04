using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Santafenhon.Web.Data.Events
{
    [Table("EventLogs")]
    public class EventLog
    {
        public int Id { get; set; }
        [Required]
        public int StreamId { get; set; }
        [Required]
        public string EventType { get; set; }
        [Required]
        public DateTime LogDateTime { get; set; }
        public string PayLoad { get; set; }

    }
}
