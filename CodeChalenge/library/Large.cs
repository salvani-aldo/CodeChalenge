using CodeChalenge.model;
using CodeChalenge.productVariables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChalenge.library
{
    public class Large: BaseDelivery
    {
        public Large(productModel model) : base(model)
        { }

        public override bool Processed()
        {
            double volume = ComputeVolume();
            if (volume < (double)Product.CategoryValue.LargeParcel)
            {
                Category = "Large Parcel";
                Cost = Product.LargeParcelMultiplier * volume;

                return true;
            }

            return false;
        }
    }
}
