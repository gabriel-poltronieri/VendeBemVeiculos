using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    public class Client : Person
    {
        public Client(string firstName, string lastName, string cpf)
            : base(firstName, lastName, cpf) { }
    }
}
