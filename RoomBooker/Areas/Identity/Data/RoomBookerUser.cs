﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace RoomBooker.Areas.Identity.Data;

// Add profile data for application users by adding properties to the RoomBookerUser class
public class RoomBookerUser : IdentityUser
{
    [Required]
    public new required string Email {  get; set; }
    [Required]
    public string? Password { get; set; }
}

