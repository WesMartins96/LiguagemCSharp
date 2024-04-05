using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHashCode_Equals.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }


        //verificar se um cliente é igual a outro, neste caso por email.
        public override bool Equals(object obj)
        {
            if (!(obj is Client))
            {
                return false;
            }
            Client other = obj as Client;
            return Email.Equals(other.Email);
        }

        //Gerar hashcode do cliente
        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
