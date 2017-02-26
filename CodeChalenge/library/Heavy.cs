using CodeChalenge.productVariables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChalenge.library
{
    public class Heavy: BaseDelivery
    {
        public Heavy(double weight) : base(weight)
        {
        }

        public override bool Processed()
        {
            if (_weight > (double)Product.CategoryValue.HeavyParcel)
            {
                Category = "Heavy Parcel";
                Cost = _weight * Product.HeavyParcelMultiplier;

                return true;
            }

            return false;
        }
    }
}
