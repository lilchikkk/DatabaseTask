using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Cell
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Block))]
        public int BlockId { get; set; }
        public Block Block { get; set; } = null!;

        [Required]
        [MaxLength(10)]
        public string CellNumber { get; set; } = string.Empty;

        public int Floor { get; set; }

        public int MaxCapacity { get; set; }

        public ICollection<Prisoner> Prisoners { get; set; } = new List<Prisoner>();
    }
}
