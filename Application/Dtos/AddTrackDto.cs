using System.ComponentModel.DataAnnotations;

namespace Application.Dtos;

public class AddTrackDto
{
    [MinLength(1), MaxLength(300)]
    public string Title { get; set; }
    [MinLength(1)]
    public int Duration { get; set; }
    [MinLength(1)]
    public int ReleaseYear { get; set; }
}
