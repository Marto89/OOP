namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using FurnitureManufacturer.Interfaces;
    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;
        private int tryParseChecker;

        public Company(string initialName, string initialRegistrationNumber)
        {
            this.Name = initialName;
            this.RegistrationNumber = initialRegistrationNumber;
            this.furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) && value.Length < 5)
                {
                    throw new ArgumentNullException("Name cannot be empty, null or with less than 5 symbols.");
                }
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }
            private set
            {

                if (!(int.TryParse(value, out tryParseChecker)) && value.Length < 10)
                {
                    throw new ArgumentException("Registration number must be exactly 10 symbols and must contain only digits.");
                }
                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return new List<IFurniture>(this.furnitures);
            }
        }

        public void Add(IFurniture furniture)
        {
            if (furniture == null)
            {
                throw new ArgumentNullException("Furniture wich do you want to add cannot be null!");
            }
            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            if (furniture != null && this.furnitures.Contains(furniture))
            {
                this.furnitures.Remove(furniture);
            }
        }

        public IFurniture Find(string model)
        {
            foreach (var furniture in this.furnitures)
            {
                if (furniture.Model.ToLower() == model.ToLower())
                {
                    return furniture;
                }
            }
            return null;
        }

        public string Catalog()
        {
            var orderedFurnitures = this.furnitures.OrderBy((p) => p.Price).ThenBy((m) => m.Model);
            var sb = new StringBuilder();
            sb.AppendFormat("{0} - {1} - {2} {3}",
                            this.Name,
                            this.RegistrationNumber,
                            this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                            this.Furnitures.Count != 1 ? "furnitures" : "furniture");
            if(this.Furnitures.Count>0)
            {
                sb.AppendLine();
                foreach (var furniture in orderedFurnitures)
                {
                    sb.AppendLine(furniture.ToString());
                }
            }          
            return sb.ToString().Trim();
        }
    }
}
