using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    public class PersonRegister<T> : Register<T> where T : Person
    {
        private const int FIRST_NAME = 0;
        private const int LAST_NAME = 1;
        private const int CPF = 2;

        public PersonRegister(string fileName)
            : base(fileName) { }

        protected override ICollection<T> Data { get; } = new SortedSet<T>();

        public override void AddItemToRegister(T item)
        {
            if (this.Data.Contains(item))
            {
                throw new AlreadyCreatedException();
            }
            else
            {
                base.AddItemToRegister(item);
            }
        }

        protected override void LoadData()
        {
            if (File.Exists(this.FileName))
            {
                using (var personStream = File.Open(this.FileName, FileMode.Open))
                using (var reader = new StreamReader(personStream))
                {
                    string line = reader.ReadLine();
                    while (string.IsNullOrEmpty(line) == false)
                    {                        
                        this.Load(line);                        
                        line = reader.ReadLine();
                    }
                }
            }
        }
        private void Load(string line)
        {
            string[] data = line.Split('%');
            var firstName = data[FIRST_NAME];
            var lastName = data[LAST_NAME];
            var cpf = data[CPF];
            var loadedPerson = (T)Activator.CreateInstance(typeof(T), firstName, lastName, cpf);
            this.Data.Add(loadedPerson);
        }

        protected override string GetFileContent()
        {
            var content = string.Empty;
            foreach (T person in this.Data)
            {
                content += $"{person.FirstName}%{person.LastName}%{person.CPF}\r\n";
            }
            return content;
        }

        public T[] FilterByFirstName(string firstName)
        {
            return this.Items.Where(p => p.FirstName == firstName).ToArray();
        }
        public T[] FilterByLastName(string lastName)
        {
            return this.Items.Where(p => p.LastName == lastName).ToArray();
        }
        public T[] FilterByCPF(string cpf)
        {
            return this.Items.Where(p => p.CPF == cpf).ToArray();
        }
    }
}