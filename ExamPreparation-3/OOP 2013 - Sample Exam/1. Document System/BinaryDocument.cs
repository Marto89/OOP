using System;


namespace DocumentSystem
{
    public abstract class BinaryDocument : Documents
    {
        public BinaryDocument(string name,string content=null,int size=0)
            :base(name,content)
        {
            this.Size = size;
        }
        public int Size{get;private set;}
    }
}
