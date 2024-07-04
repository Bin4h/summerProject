using System.ComponentModel.DataAnnotations;

namespace Application.Dtos;

public class AddSingerDto
{
    [MinLength(1), MaxLength(200)]
    public string Name { get; set; }
    [MinLength(1), MaxLength(3000)]
    public string Description { get; set; }
    [MinLength(1), MaxLength(400)]
    public string Link { get; set; }
}
