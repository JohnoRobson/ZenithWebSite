using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenithDataLib.Models {
    public class Event {
        [Key]
        public int EventId;
        public DateTime EventFromDate;
        public DateTime EventToDate;
        public string EnteredByUsername;
        public int Activity;
        public DateTime CreationDate;
        public bool IsActive;
    }
}
