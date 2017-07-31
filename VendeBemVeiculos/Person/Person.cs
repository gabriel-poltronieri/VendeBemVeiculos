using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    public class Person : IComparable
    {
        public Person(string firstName, string lastName, string cpf)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.CPF = cpf;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string CPF { get; private set; }

        public override int GetHashCode()
        {
            return (int)(Convert.ToUInt64(CPF) / 20051);
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}     CPF:{this.CPF}";
        }
        public int CompareTo(object obj)
        {
            var person = (Person)obj;
            return string.Compare(this.CPF, person.CPF);
        }

        public override bool Equals(object obj)
        {
            if (IsPerson(obj))
            {
                var comparedPerson = (Person)obj;
                return this.CPF == comparedPerson.CPF;
            }
            return false;
        }
        private bool IsPerson(object obj)
        {
            return obj is Person;
        }        
    }
}