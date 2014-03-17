namespace FurnitureManufacturer.Models
{
    using System;
    using System.Text;

    using FurnitureManufacturer.Interfaces;
    public class Chair : Furniture, FurnitureManufacturer.Interfaces.IChair
    {
        private int numberOfLegs;

        public Chair(string initialModel, string initialMaterialType, decimal initialPrice, decimal initialHeight, int initialNumberOfLegs)
            :base(initialModel,initialMaterialType,initialPrice,initialHeight)
        {
            this.NumberOfLegs = initialNumberOfLegs;
        }
        public int NumberOfLegs
        {
            get 
            {
                return this.numberOfLegs;
            }
            private set
            {
                if(value<=0)
                {
                    throw new ArgumentNullException("The number of legs cannot be negative or zero!");
                }
                this.numberOfLegs = value;
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}", this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.NumberOfLegs);
            return sb.ToString();
        }
    }
}
