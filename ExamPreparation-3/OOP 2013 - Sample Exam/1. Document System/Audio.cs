using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public class AudioDocument : MultimediaDocument
    {
        public AudioDocument(string name,string content=null,int size=0,int length=0,int sampleRate=0)
            :base(name,content,size,length)
        {
            this.SampleRate = sampleRate;
        }

        public int SampleRate { get; private set; }
    }
}
