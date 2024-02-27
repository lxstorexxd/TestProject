﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public DateTime BirthDate { get; set; }
        public string AvatarPath { get; set; }

        public User()
        {
            AvatarPath = "/Assets/default-avatar.png";
        }
    }
}
