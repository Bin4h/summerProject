using System.ComponentModel.DataAnnotations;

namespace Data_Base.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public System.DateTime CreatedAt { set { _ = DateTime.Now; } }
    }
}
