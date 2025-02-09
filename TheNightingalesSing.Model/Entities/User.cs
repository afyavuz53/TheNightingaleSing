﻿using System;
using System.Collections.Generic;
using System.Text;
using TheNightingalesSing.Core.Entity;
using TheNightingalesSing.Model.Enums;

namespace TheNightingalesSing.Model.Entities
{
    public class User:BaseEntity
    {
        public User()
        {
            Role = UserRole.Standart;
            IsActive = false;
        }
        public string UserName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public UserRole Role { get; set; }
        public Guid ActivationCode { get; set; }
        public ICollection<Order> Order { get; set; }
    }
}
