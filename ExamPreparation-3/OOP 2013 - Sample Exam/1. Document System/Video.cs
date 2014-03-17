using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public class VideoDocument : MultimediaDocument
    {
        public VideoDocument(string name,string content=null,int size=0,int length=0,int frameRate=0)
            :base(name,content,size,length)
        {
            this.FrameRate = frameRate;
        }
        public int FrameRate { get; private set; }
    }
}
