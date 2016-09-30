using System;
using System.Collections.Generic;
using Cooking.Contacts;

namespace Cooking.Models
{
    public class Bowl : IBowl
    {
        private ICollection<IVegetable> vegetables;

        public Bowl()
        {
            this.vegetables = new List<IVegetable>();
        }

        public ICollection<IVegetable> Vegetables
        {
            get
            {
                return this.vegetables;
            }

            set
            {
                this.vegetables = value;
            }
        }

        public void AddVegetables(IVegetable vegetable)
        {
            if (vegetable == null)
            {
                throw new ArgumentException("Please, pass a vegetable. You cannot add null to the bowl.");
            }

            this.Vegetables.Add(vegetable);
        }
    }
}
