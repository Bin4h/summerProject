using System.ComponentModel.DataAnnotations;

namespace Data_Base.Entities;

public class Album : BaseEntity
{
    public ICollection<Track>? Tracks { get; set; }
    public int SingerId { get; set; }
    public Singer? Singer { get; set; }
    [MaxLength(300)]
    public string? Title { get; set; }
    public int ReleaseYear {  get; set; }
    [MaxLength(3000)]
    public string? Description { get; set; }
}
