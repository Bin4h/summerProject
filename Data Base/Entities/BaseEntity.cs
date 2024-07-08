using Data_Base.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Data_Base.Entities
{
    public class BaseEntity : IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        public System.DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
