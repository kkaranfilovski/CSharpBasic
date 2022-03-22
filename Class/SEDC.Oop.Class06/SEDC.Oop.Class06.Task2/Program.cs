using SEDC.Oop.Class06.Task2.Models;
using SEDC.Oop.Class06.Task2.Services;
using System;

namespace SEDC.Oop.Class06.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            User kristijan = new User(1, "kristijan95", "kiko7", new string[] { "message1", "message2" });
            User petko = new User(2, "petko", "123", new string[] { "hello", "sedc" });
            User stanko = new User(3, "stanko", "stanko33", new string[] { "sedc", "trainer" });
            User[] users = { kristijan, petko, stanko };
            UserServices userServices = new UserServices();

            userServices.Main(users, userServices);
        }
    }
}


