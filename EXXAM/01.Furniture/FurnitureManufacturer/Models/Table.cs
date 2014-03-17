namespace FurnitureManufacturer.Models
{
    using System;
    using System.Text;

    using FurnitureManufacturer.Interfaces;
    public class Table : Furniture, ITable
    {
        private decimal length;
        private decimal width;

        public Table(string initialModel, string initialMaterialType, decimal initialPrice, decimal initialHeight, decimal initialLength, decimal initialWidth)
            :base(initialModel,initialMaterialType,initialPrice,initialHeight)
        {
            this.Length = initialLength;
            this.Width = initialWidth;
        }
        public decimal Length
        {
            get 
            {
                return this.length; 
            }
            private set
            {
                if(value==decimal.Zero)
                {
                    throw new ArgumentNullException("The length of the table cannot be zero!");
                }
                this.length = value;
            }
        }

        public decimal Width
        {
            get 
            {
                return this.width; 
            }
            private set
            {
                if (value == decimal.Zero)
                {
                    throw new ArgumentNullException("The width of the table cannot be zero!");
                }
                this.width = value;
            }
        }

        public decimal Area
        {
            get 
            {
                return this.Length * this.Width; 
            }
            //TODO set if must!
        }
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendFormat("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Length: {5}, Width: {6}, Area: {7}", this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.Length, this.Width, this.Area);

            return sb.ToString();
        }
    }
}
