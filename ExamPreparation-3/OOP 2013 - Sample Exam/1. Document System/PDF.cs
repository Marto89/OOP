using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public class PDFDocument : BinaryDocument, IEncryptable
    {
        private bool isEncrypted;
        public PDFDocument(string name,string content=null,int size=0,int numberOfPages=0)
            :base(name,content,size)
        {
            this.NumberOfPages = numberOfPages;
        }
        public int NumberOfPages { get; private set; }

        public bool IsEncrypted
        {
            get
            {
                return this.isEncrypted;
            }
            private set
            {
                this.isEncrypted = value;
            }
        }

        public void Encrypt()
        {
            if(this.IsEncrypted)
            {
                throw new ArgumentException("Is already encrypted!");
            }
            else
            {
                this.IsEncrypted = !this.IsEncrypted;
            }
        }

        public void Decrypt()
        {
            if (this.IsEncrypted)
            {
                this.IsEncrypted = !this.IsEncrypted;
            }
            else
            {
                throw new ArgumentException("Is already encrypted!");                
            }
        }
    }
}
