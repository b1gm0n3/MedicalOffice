using System.ComponentModel.DataAnnotations;

namespace MedicalOffice.Core.Common
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}