using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalOffice.Core.Common
{
    public abstract class AuditableEntity : BaseEntity
    {
        public DateTime CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? DeletedBy { get; set; }

        [NotMapped]
        public bool IsDeleted => DeletedAt.HasValue;
    }
}
