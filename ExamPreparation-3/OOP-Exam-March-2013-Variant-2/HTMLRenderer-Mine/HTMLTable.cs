using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderer
{
    public class HTMLTable : HTMLElement, ITable
    {
        readonly int rows;
        readonly int cols;
        private IElement[,] matrix;

        public HTMLTable(int rows, int cols)
            : base("table", null)
        {
            this.rows = rows;
            this.cols = cols;
            this.matrix = new IElement[this.Rows, this.Cols];
        }
        public int Rows
        {
            get
            {
                return this.rows;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
        }

        public IElement this[int row, int col]
        {
            get
            {

                return matrix[row,col];
            }
            set
            {
                this.matrix[row, col] = value;
            }
        }
        public override void Render(StringBuilder output)
        {
            output.Append(string.Format("<{0}>",this.Name));
            for (int row = 0; row < this.Rows; row++)
            {
                output.Append("<tr>");
                for (int col = 0; col < this.Cols; col++)
                {
                    output.Append("<td>");
                    output.Append(this[row, col].ToString());
                    output.Append("</td>");
                }
                output.Append("</tr>");
            }
            output.Append(string.Format("</{0}>", this.Name));
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            this.Render(sb);
            return sb.ToString();
        }

    }
}
