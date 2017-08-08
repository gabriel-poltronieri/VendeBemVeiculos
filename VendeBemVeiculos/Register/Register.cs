using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    public abstract class Register<T> 
    {
        public Register(string fileName)
        {
            this.FileName = fileName;
            if (File.Exists(FileName))
            {
                LoadData();
            }
            else
            {
                File.Create(this.FileName);
            }
        }

        public string FileName { get; protected set; }
        public T[] Items { get { return this.Data.ToArray(); } }
        protected abstract ICollection<T> Data { get; }

        public virtual void AddItemToRegister(T item)
        {
            this.Data.Add(item);
            this.UpdateFile();
        }
        public void DeleteItemFromRegister(T item)
        {
            this.Data.Remove(item);
            this.UpdateFile();
        }
        public void UpdateFile()
        {
            using (var dataStream = File.Open(this.FileName, FileMode.Create))
            using (var dataWriter = new StreamWriter(dataStream))
            {
                var fileContent = this.GetFileContent();
                dataWriter.Write(fileContent);
            }
        }
        
        protected abstract void LoadData();
        protected abstract string GetFileContent();
    }
}