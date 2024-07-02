using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Base.Entities;

public class Singer
{
    [Key]
    public int Id {  get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Link { get; set; } //Ссылка на офф. страницу
}
