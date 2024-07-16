using System.ComponentModel.DataAnnotations;

namespace Data.Dtos;

public class SingerPageDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Link { get; set; }
    public List<AlbumDto> Albums { get; set; }
}
