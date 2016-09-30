using System;
using Cooking.Contacts;

namespace Cooking.Models
{
    public class Vegetable : IVegetable
    {
        private bool isCut = false;
        private bool isPeeled = false;
        private bool isRotten = false;

        public Vegetable()
        {
            this.IsCut = isCut;
            this.IsPeeled = isPeeled;
            this.IsRotten = isRotten;
        }

        public bool IsCut
        {
            get
            {
                return this.isCut;
            }

            set
            {
                this.isCut = value;
            }
        }

        public bool IsPeeled
        {
            get
            {
                return this.isPeeled;
            }

            set
            {
                this.isPeeled = value;
            }
        }

        public bool IsRotten
        {
            get
            {
                return this.isRotten;
            }

            set
            {
                this.isRotten = value;
            }
        }
    }
}
