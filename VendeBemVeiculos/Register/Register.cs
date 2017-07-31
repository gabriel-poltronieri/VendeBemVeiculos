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
        protected string allData;

        public Register(string archiveName)
        {
            this.FileName = archiveName;
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

        public T[] Items { get { return this.DataGroup.ToArray(); } }
        protected abstract ICollection<T> DataGroup { get; }

        public virtual void AddItemToRegister(T item)
        {
            this.DataGroup.Add(item);
            UpdateArchive();
        }
        public void DeleteItemFromRegister(T item)
        {
            this.DataGroup.Remove(item);
            UpdateArchive();
        }
        public void UpdateArchive()
        {
            using (var dataStream = File.Open(this.FileName, FileMode.Create))
            using (var dataWriter = new StreamWriter(dataStream))
            {
                LoadItemsString();
                dataWriter.Write(allData);
            }
            DeleteString();
        }
        private void DeleteString()
        {
            this.allData = "";
        }
        
        protected abstract void LoadData();
        protected abstract void LoadItemsString();
    }
}