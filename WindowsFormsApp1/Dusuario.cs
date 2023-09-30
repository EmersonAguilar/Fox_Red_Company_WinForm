using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Dusuario
    {
        public string _usuario;
        public string _password;

        public String get_usuario()
        {
            return _usuario;
        }

        public String get_password()
        {
            return _password;
        } 

        public void set_usuario(String value)
        {
            this._usuario = value;
        }

        public void set_password(String value)
        {
            this._password = value;
        }
    }
}
