using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class06.Task3.models
{
    public class User
    {
        public string Name { get; set; }
        public long CardNumber { get; set; }
        public int Pin { get; set; }
        public int Balance { get; set; }


        public User(string name, long cardNum, int pin, int balance)
        {
            Name = name;
            CardNumber = cardNum;
            Pin = pin;
            Balance = balance;
        }
    }
}
