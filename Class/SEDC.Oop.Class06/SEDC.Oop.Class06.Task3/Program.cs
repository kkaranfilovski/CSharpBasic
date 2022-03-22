using SEDC.Oop.Class06.Task3.models;
using System;

namespace SEDC.Oop.Class06.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[] {
                new User("kristijan", "1111", 1234, 1000),
                new User("ilija", "2222", 5555, 500),
                new User("petko", "3333", 6666, 200)
            };

            ATM atm = new ATM(users);
            atm.Main();
        }
    }
}
