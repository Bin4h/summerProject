using System.ComponentModel.DataAnnotations;

namespace Application.Dtos;

public class AddAlbumDto
{
    [MinLength(1), MaxLength(300)]
    public string? Title { get; set; }
    [MinLength(1)]
    public int ReleaseYear { get; set; }
    [MinLength(1), MaxLength(3000)]
    public string? Description { get; set; }
}
