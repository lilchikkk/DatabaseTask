using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Prisoner
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Cell))]
        public int? CellId { get; set; }
        public Cell? Cell { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; } = string.Empty;

        public DateTime BirthDate { get; set; }

        [MaxLength(20)]
        public string? PersonalCode { get; set; }

        public DateTime ArrivalDate { get; set; }

        [Required]
        [MaxLength(50)]
        public string Status { get; set; } = string.Empty;

        public ICollection<Sentence> Sentences { get; set; } = new List<Sentence>();
        public ICollection<PrisonerCrime> PrisonerCrimes { get; set; } = new List<PrisonerCrime>();
        public ICollection<Visit> Visits { get; set; } = new List<Visit>();
    }
}
