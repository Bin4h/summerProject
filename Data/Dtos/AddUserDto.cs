﻿using System.ComponentModel.DataAnnotations;

namespace Data.Dtos;

public class AddUserDto
{
    [MaxLength(400)]
    public string Login { get; set; }
    [MaxLength(400)]
    public string Password { get; set; }
    [MaxLength(40)]
    public string Role { get; set; }
}
