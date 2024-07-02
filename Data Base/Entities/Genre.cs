using System.ComponentModel.DataAnnotations;

namespace Data_Base.Entities;

public class Genre : BaseEntity
{
    [MaxLength(200)]
    public string? Title { get; set; }
}
