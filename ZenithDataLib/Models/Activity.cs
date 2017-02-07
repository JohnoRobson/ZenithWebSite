using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZenithDataLib.Models {
    public class Activity {
        [Key]
        public int ActivityId;
        public string ActivityDescription;
        public DateTime CreationDate;
    }
}
