using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class06.Task2.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string[] Messages { get; set; }

        public User(int id, string username, string password, string[] messages)
        {
            Id = id;
            UserName = username;
            Password = password;
            Messages = messages;
        }
    }
}
