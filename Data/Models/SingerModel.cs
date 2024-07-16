using Data.Dtos;

namespace Application.Models;

public class SingerModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Link { get; set; }
    public List<AlbumModel> Albums { get; set; }
}
