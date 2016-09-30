using System;
using Cooking.Contacts;
using Cooking.Models;

namespace Cooking.Models
{
    public class Chef : IChef
    {
        public Chef()
        {
        }

        public void Cook()
        {
            var potato = this.GetPotato();
            var carrot = this.GetCarrot();
            var bowl = this.GetBowl();

            this.Peel(potato);
            this.Peel(carrot);

            this.Cut(potato);
            this.Cut(carrot);

            bowl.AddVegetables(potato);
            bowl.AddVegetables(carrot);
        }

        private void Peel(IVegetable vegetable)
        {
            if (vegetable == null)
            {
                throw new ArgumentException("Please, provide a vegetable to be peeled. Null cannot be peeled.");
            }

            vegetable.IsPeeled = true;
        }

        private void Cut(IVegetable vegetable)
        {
            if (vegetable == null)
            {
                throw new ArgumentException("Please, provide a vegetable to be cut. Null cannot be cut.");
            }

            vegetable.IsCut = true;
        }

        private IBowl GetBowl()
        {
            return new Bowl();
        }

        private IVegetable GetCarrot()
        {
            return new Carrot();
        }

        private IVegetable GetPotato()
        {
            return new Potato();
        }
    }
}
