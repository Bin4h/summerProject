using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data_Base.Entities;

public class Album : BaseEntity
{
    public ICollection<Track>? Tracks { get; set; }
    public int SingerId { get; set; }
    public Singer? Singer { get; set; }
    [MaxLength(300)]
    public string? Title { get; set; }
    public int Date {  get; set; }
    [Column(TypeName = "text")]
    public string? Description { get; set; }
}
