using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eManager.Domain
{
    public class ActivityEmployee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public int EmployeeId { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual Employee Employee { get; set; }

    }
}
