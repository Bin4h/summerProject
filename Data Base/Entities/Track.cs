using System.ComponentModel.DataAnnotations;

namespace Data_Base.Entities;

public class Track : BaseEntity
{
    public int SingerId { get; set; }
    public Singer? Singer { get; set; }
    public int AlbumId { get; set; }
    public Album? Album { get; set; }
    public int GenreId { get; set; }
    public Genre? Genre { get; set; }
    [MaxLength(300)]
    public string? Title { get; set; }
    public int Duration { get; set; }
    public int ReleaseYear { get; set; }
}
