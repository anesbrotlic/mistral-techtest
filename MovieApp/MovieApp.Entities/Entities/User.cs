﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Entities.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
    }
}
