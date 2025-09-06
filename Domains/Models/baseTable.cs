using System.ComponentModel.DataAnnotations;

namespace Domains.Models
{
    public abstract class baseTable
    {
        public Guid Id { get; set; }
        public int CurrentState { get; set; }
        public Guid ?CreatedBy { get; set; }
        public DateTime ?CreatedDate { get; set; }
        public Guid? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

    }
}