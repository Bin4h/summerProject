using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Base.Entities;

public class Genre
{
    [Key]
    public int Id { get; set; }
    public string? Title { get; set; }
}
