﻿using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class User
    {
        [Key]
        public string UserName { get; set; }
        public int SecurityLevel { get; set; }
        public string Password { get; set; }
    }
}