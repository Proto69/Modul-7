using _01._07._04.Entities;
using _01._07._04.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07._04.Controllers
{
    public class Controller
    {
        private Passwords _passwords;
        private View _view;

        public Controller()
        {
            _view= new View();
            _passwords = new(_view.ReadN(), _view.ReadL());

            _view.DisplayResult(_passwords.GeneratePasswords());
        }
    }
}
