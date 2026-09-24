using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Block
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Prison))]
        public int PrisonId { get; set; }
        public Prison Prison { get; set; } = null!;

        [Required]
        [MaxLength(20)]
        public string BlockNumber { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string SecurityLevel { get; set; } = string.Empty;

        public ICollection<Cell> Cells { get; set; } = new List<Cell>();
    }
}
