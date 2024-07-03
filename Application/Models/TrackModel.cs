namespace Application.Models;

public class TrackModel
{
    public int SingerId { get; set; }
    public int AlbumId { get; set; }
    public int GenreId { get; set; }
    public string Title { get; set; }
    public int Duration { get; set; }
    public int ReleaseYear { get; set; }
}
