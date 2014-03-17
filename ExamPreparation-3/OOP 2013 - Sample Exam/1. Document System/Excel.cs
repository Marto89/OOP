using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public class ExcelDocument : OfficeDocument, IEncryptable
    {
        private bool isEncrypted;
        public ExcelDocument(string name, string content = null, int size = 0,string version=null, int numberOfRows = 0, int numberOfCols = 0)
            : base(name, content, size,version)
        {
            this.NumberOfRows = numberOfRows;
            this.NumberOfCols = numberOfCols;
        }

        public int NumberOfRows { get; private set; }
        public int NumberOfCols { get; private set; }

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
    }
}
