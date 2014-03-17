namespace FurnitureManufacturer.Models
{
    using System;
    using System.Text;

    using FurnitureManufacturer.Interfaces;

    public abstract class Furniture : IFurniture
    {
        private string model;
        private string material;
        private decimal price;
        private decimal height;

        public Furniture(string initialModel, string initialMaterialType, decimal initialPrice, decimal initialHeight)
        {
            this.Model = initialModel;
            this.Material = initialMaterialType;
            this.Price = initialPrice;
            this.Height = initialHeight;
        }

        public string Model
        {
            get 
            {
                return this.model; 
            }
            private set
            {
                if(string.IsNullOrWhiteSpace(value) && value.Length<3)
                {
                    throw new ArgumentNullException("Model cannot be empty, null or with less than 3 symbols!");
                }
                this.model = value;
            }
        }

        public string Material
        {
            get 
            {
                return this.material;
            }
            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Material cannot be null,empty or white space!");
                }
                value = value[0].ToString().ToUpper() + value.Substring(1);
                this.material = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
               if(value<=0)
               {
                   throw new ArgumentNullException("Price cannot be less or equal to $0.00!");
               }
               this.price = value;
            }
        }

        public decimal Height
        {
            get 
            {
                return this.height;
            }
            protected set
            {
                if(value<=0)
                {
                    throw new ArgumentNullException("Height cannot be less or equal to 0.00 m!");
                }
                this.height=value;
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendFormat("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, ", this.GetType().Name, this.Model, this.Material, this.Price, this.Height);
            return sb.ToString();
        }
    }
}
