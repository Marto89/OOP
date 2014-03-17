namespace HTMLRenderer
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class HTMLElement : IElement
    {
        private IList<IElement> childElements;


        public HTMLElement(string name, string textContent = null)
        {
            this.Name = name;
            this.TextContent = textContent;
            this.childElements = new List<IElement>();
        }
        public string Name { get; protected set; }

        public string TextContent { get; set; }
        public IEnumerable<IElement> ChildElements
        {
            get
            {
                return new List<IElement>(this.childElements);
            }
        }

        public void AddElement(IElement element)
        {
            if (element != null && this.GetType().Name!="HTMLTable")
            {
                this.childElements.Add(element);
            }

        }
        public virtual void Render(StringBuilder output)
        {
            var isNameNullFirst = this.Name == null ? "" : string.Format("<{0}>", this.Name);
            output.Append(isNameNullFirst);
            if (this.TextContent != null)
            {
                foreach (var item in this.TextContent)
                {
                    if (item == '<')
                    {
                        output.Append("&lt;");
                    }
                    else if (item == '>')
                    {
                        output.Append("&gt;");
                    }
                    else if (item == '&')
                    {
                        output.Append("&amp;");
                    }
                    else
                    {
                        output.Append(item);
                    }
                }
            }
            if (this.childElements.Count != 0)
            {
                foreach (var child in this.ChildElements)
                {
                    output.Append(child.ToString());
                }
            }
            var isNameNullLast = this.Name == null ? "" : string.Format("</{0}>", this.Name);
            output.Append(isNameNullLast);
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            this.Render(sb);
            return sb.ToString();
        }
    }
}