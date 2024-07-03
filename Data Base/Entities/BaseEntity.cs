using System.ComponentModel.DataAnnotations;

namespace Data_Base.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public System.DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
