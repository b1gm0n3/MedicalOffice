using MedicalOffice.Core.Common;
using System.ComponentModel.DataAnnotations;

namespace MedicalOffice.Core.Entities
{
    public class Patient : AuditableEntity
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        public DateTime? Birthday { get; set; }
    }
}
