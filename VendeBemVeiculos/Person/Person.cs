using ExtensionsMethods;
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

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}     CPF:{this.CPF}";
        }

        public int CompareTo(object obj)
        {
            if (obj.IsPerson())
            {
                var person = (Person)obj;
                return string.Compare(this.CPF, person.CPF);
            }
            throw new ArgumentException();
        }
        public override bool Equals(object obj)
        {
            if (obj.IsPerson())
            {
                var comparedPerson = (Person)obj;
                return this.CPF == comparedPerson.CPF;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Convert.ToInt32(this.CPF) / 100;
        }
    }
}