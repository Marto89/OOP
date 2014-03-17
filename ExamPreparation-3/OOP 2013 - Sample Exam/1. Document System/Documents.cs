using System;
using System.Collections.Generic;

using DocumentSystem;

namespace DocumentSystem
{
    public abstract class Documents : IDocument
    {
        private string name;
        private string content;

        public Documents(string name, string content = null)
        {
            this.Name = name;
            this.Content = content;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("You must enter a name of ducument!");
                }
                this.name = value;
            }
        }
        public virtual string Content
        {
            get
            {
                return this.content;
            }
            protected set
            {
                this.content = value;
            }
        }

        public virtual void LoadProperty(string key, string value)
        {
            SaveAllProperties(IList<KeyValuePair<string, object>> output);
        }

        public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output = new List<KeyValuePair<string, object>>();
            output<"name"> = "afasdasd";
        }
    }
}
