using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartsShopGit
{
    class Car
    {
        private string brand;
        private string model;
        private string productionYear;

        public Car(string brand, string model, string productionYear)
        {
            this.brand = brand;
            this.model = model;
            this.productionYear = productionYear;
        }
        public override string ToString()
        {
            return "<" + this.brand + "," + this.model + "," + this.productionYear + ">";
        }
        public override int GetHashCode()
        {

            const int prime = 31;
            int result = 1;
            result = prime * result + ((this.brand == null) ? 0 :
            this.brand.GetHashCode());
            result = prime * result + ((this.model == null) ? 0 :
            this.model.GetHashCode());
            result = prime * result + ((this.productionYear == null) ? 0 :
            this.productionYear.GetHashCode());
            return result;
        }
        public override bool Equals(Object obj)
        {
            if (this == obj)
            {
                return true;
            }

            if (obj == null)
            {
                return false;
            }

            if (this.GetType() != obj.GetType())
            {
                return false;
            }

            Car other = (Car)obj;
            if (this.brand == null)
            {
                if (other.brand != null)
                {
                    return false;
                }
            }
            else if (!this.brand.Equals(other.brand))
            {
                return false;
            }

            if (this.model == null)
            {
                if (other.model != null)
                {
                    return false;
                }
            }
            else if (!this.model.Equals(other.model))
            {
                return false;
            }

            if (this.productionYear == null)
            {
                if (other.productionYear != null)
                {
                    return false;
                }
            }
            else if (!this.productionYear.Equals(other.productionYear))
            {
                return false;
            }

            return true;
        }
    }
}
