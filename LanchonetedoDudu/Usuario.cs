using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchonetedoDudu
{
    public class Usuario
    {
        private int _id;
        private string _name;
        private string _cpf;
        private string _password;
        private string _email;

        public Usuario(string name, string cpf, string password, string email)
        {
            _name = name;
            _cpf = cpf;
            _password = password;
            _email = email;         
        }
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        public string Name
        {
            set { Name = value; }
            get { return _name; }
        }
        public string CPF
        {
            set { CPF = value; }
            get { return _cpf; }
        }
        public string Password
        {
            set { Password = value; }
            get { return _password; }
        }
        public string Email
        {
            set { Email = value;}
            get { return _email;}
        } 
    }
}

