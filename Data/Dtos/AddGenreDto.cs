using System.ComponentModel.DataAnnotations;

namespace Application.Dtos;

public class AddGenreDto
{
    [MinLength(1), MaxLength(200)]
    public string Title { get; set; }
}
