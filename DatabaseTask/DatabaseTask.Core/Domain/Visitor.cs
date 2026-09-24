using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Visitor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(20)]
        public string? PersonalCode { get; set; }

        [MaxLength(50)]
        public string? RelationToPrisoner { get; set; }

        public ICollection<Visit> Visits { get; set; } = new List<Visit>();
    }
}
