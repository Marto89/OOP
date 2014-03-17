using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public abstract class OfficeDocument : BinaryDocument
    {
        public OfficeDocument(string name,string content=null,int size=0,string version=null)
            :base(name,content,size)
        {
            this.Version = version;
        }

        public string Version { get; private set; }
    }
}
