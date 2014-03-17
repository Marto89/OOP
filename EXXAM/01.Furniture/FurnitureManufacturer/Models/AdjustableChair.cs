namespace FurnitureManufacturer.Models
{
    using System;

    using FurnitureManufacturer.Interfaces;
    public class AdjustableChair : Chair, IAdjustableChair
    {
         public AdjustableChair(string initialModel, string initialMaterialType, decimal initialPrice, decimal initialHeight, int initialNumberOfLegs)
            : base(initialModel, initialMaterialType, initialPrice, initialHeight,initialNumberOfLegs) 
         { 
         }

        public void SetHeight(decimal height)
        {
            if (height <= 0M)
            {
                throw new ArgumentNullException("Height cannot be less or equal to 0.00 m!");
            }
            this.Height = height;
        }
        //TODO check for ToString();
    }
}
