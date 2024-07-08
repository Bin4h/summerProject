﻿using System.ComponentModel.DataAnnotations;

namespace Application.Dtos;

public class AddTrackDto
{
    public int SingerId { get; set; }
    public int AlbumId { get; set; }
    public int GenreId { get; set; }
    [MinLength(1), MaxLength(300)]
    public string Title { get; set; }
    [Range(0, int.MaxValue)]
    public int Duration { get; set; }
    [Range(1000, 2024)]
    public int ReleaseYear { get; set; }
}
