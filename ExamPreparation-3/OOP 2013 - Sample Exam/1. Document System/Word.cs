using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public class WordDocument : OfficeDocument, IEncryptable, IEditable
    {
        private bool isEncrypted;
        public WordDocument(string name,string content=null,int size=0,string version=null,int numberOfCharacters=0)
            :base(name,content,size,version)
        {
            this.NumberOfCharacters = numberOfCharacters;
        }
        public int NumberOfCharacters { get; private set; }

        public override string Content
        {
            get
            {
                return base.Content;
            }
            protected set
            {
                this.ChangeContent(value);
            }
        }
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
            if (this.IsEncrypted)
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

        public void ChangeContent(string newContent)
        {
            base.Content = newContent;
        }
    }
}
