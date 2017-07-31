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

        public PersonRegister(string archiveName)
            : base(archiveName) { }

        protected override ICollection<T> DataGroup { get; } = new SortedSet<T>();

        public override void AddItemToRegister(T item)
        {
            if (this.DataGroup.Contains(item))
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
                        Load(line);                        
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
            var activatedPerson = (T)Activator.CreateInstance(typeof(T), firstName, lastName, cpf);
            this.DataGroup.Add(activatedPerson);
        }

        protected override void LoadItemsString()
        {
            foreach (T p in this.DataGroup)
            {
                CreateStringLine(p);
            }
        }
        private void CreateStringLine(T person)
        {
            if (person != null)
            {
                this.allData += $"{person.FirstName}%{person.LastName}%{person.CPF}\r\n";
            }
        }

        public T[] FilterByFirstName(string firstName)
        {
            return this.Items.Where(v => v.FirstName == firstName).ToArray();
        }
        public T[] FilterByLastName(string lastName)
        {
            return this.Items.Where(v => v.LastName == lastName).ToArray();
        }
        public T[] FilterByCPF(string cpf)
        {
            return this.Items.Where(v => v.CPF == cpf).ToArray();
        }
    }
}