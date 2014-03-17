using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public abstract class MultimediaDocument : BinaryDocument
    {
        public MultimediaDocument(string name,string content=null,int size=0,int length=0)
            :base(name,content,size)
        {
            this.Length = length;
        }
        public int Length { get; private set; }
    }
}
