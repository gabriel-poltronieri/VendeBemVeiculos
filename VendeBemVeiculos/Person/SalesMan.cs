using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    public class Salesman : Person
    {
        public Salesman(string firstName, string lastName, string cpf) 
            : base(firstName, lastName, cpf) { }
    }
}