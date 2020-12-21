using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TrCrexDeneme.Core.Entity;

namespace TrCrexDeneme.Model.Entities
{
    [Serializable]
    [Flags]
    public enum Role
    {
        None=0,
        Admin=1,
        User=2,
        Moderator=3,
        Editor=4
    }
    public class User:CoreEntity
    {
         
        [MaxLength(25)]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Role? Role { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Order> Orders { get; set; }

    }
}
