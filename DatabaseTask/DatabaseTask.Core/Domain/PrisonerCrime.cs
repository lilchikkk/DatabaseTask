using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class PrisonerCrime
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Prisoner))]
        public int PrisonerId { get; set; }
        public Prisoner Prisoner { get; set; } = null!;

        [ForeignKey(nameof(Crime))]
        public int CrimeId { get; set; }
        public Crime Crime { get; set; } = null!;
    }
}
