namespace FurnitureManufacturer.Models
{
    using System;
    using System.Text;

    using FurnitureManufacturer.Interfaces;

    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private const decimal ConvertedChairHeight = 0.10m;

        private readonly decimal realHeight;

        private bool isConverted;
        public ConvertibleChair(string initialModel, string initialMaterialType, decimal initialPrice, decimal initialHeight, int initialNumberOfLegs)
            : base(initialModel, initialMaterialType, initialPrice, initialHeight, initialNumberOfLegs)
        {
            this.IsConverted = false;
            this.realHeight = this.Height;
        }

        public bool IsConverted
        {
            get
            {
                return this.isConverted;
            }
            private set
            {
                this.isConverted = value;
            }
        }

        public void Convert()
        {
            this.IsConverted = !this.IsConverted;
            if (this.IsConverted)
            {
                this.Height = ConvertedChairHeight;
            }
            else
            {
                this.Height = realHeight;
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendFormat("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}, State: {6}", this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.NumberOfLegs, this.IsConverted ? "Converted" : "Normal");

            return sb.ToString();
        }
    }
}
