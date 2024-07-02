using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Base.Entities;

public class Tracks
{
    [Key]
    public int Id {  get; set; }
    public int SingerId { get; set; }
    public Singer? Singer { get; set; }
    public int AlbumId { get; set; }
    public Album? Album { get; set; }
    public int GenreId { get; set; }
    public Genre? Genre { get; set; }
    string? Title { get; set; }
    public int Duration { get; set; }
    public int Date {  get; set; }
}
