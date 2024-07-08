using System.ComponentModel.DataAnnotations;

namespace Application.Dtos;

public class AddAlbumDto
{
    public int SingerId { get; set; }

    [MinLength(1), MaxLength(300)]
    public string? Title { get; set; }
    [Range(0, int.MaxValue)]
    public int ReleaseYear { get; set; }
    [MinLength(1), MaxLength(3000)]
    public string? Description { get; set; }
}
