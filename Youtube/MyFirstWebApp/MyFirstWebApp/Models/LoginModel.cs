﻿using System.ComponentModel.DataAnnotations;

namespace MyFirstWebApp.Models
{
    public class LoginModel
    {
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(250)]
        public string Password { get; set; }
    }
}
