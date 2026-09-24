using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Shift
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Guard))]
        public int GuardId { get; set; }
        public Guard Guard { get; set; } = null!;

        public DateTime ShiftDate { get; set; }

        public TimeSpan StartTime { get; set; }

        public TimeSpan? EndTime { get; set; }
    }
}
