using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data_Base.Entities;

public class Singer : BaseEntity
{
    [MaxLength(200)]
    public string? Name { get; set; }
    [Column(TypeName = "text")]
    public string? Description { get; set; }
    [MaxLength(400)]
    public string? Link { get; set; } //Ссылка на офф. страницу
    public ICollection<Album>? Albums { get; set; } 
}
