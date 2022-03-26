using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class08.InheritanceApp
{
    public class UserService : BaseService
    {
        public void Login()
        {
            validateInt(10);
        }

        public void Register()
        {
            validateString("asd");
        }
    }
}
