using System;


namespace DocumentSystem
{
    public class TextDocument : Documents, IEditable
    {

        public TextDocument(string name,string content=null,string charSet=null)
            :base(name,content)
        {
            this.CharSet = charSet;
        }
        public string CharSet { get; private set; }

        public override string Content
        {
            get
            {
                return base.Content;
            }
            protected set
            {
                this.Content=value;
            }
        }
        public void ChangeContent(string newContent)
        {
            base.Content = newContent;
        }
    }
}
