using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Base.Entities;

public class Album
{
    [Key]
    public int Id { get; set; }
    public int SingerId { get; set; }
    public Singer? Singer { get; set; }
    public string? Title { get; set; }
    public int Date {  get; set; }
    public string? Description { get; set; }
}
