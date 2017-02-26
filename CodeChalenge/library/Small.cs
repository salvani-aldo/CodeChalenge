using CodeChalenge.model;
using CodeChalenge.productVariables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChalenge.library
{
    public class Small : BaseDelivery
    {
        public Small(productModel model) : base(model)
        { }

        public override bool Processed()
        {
            double volume = ComputeVolume();
            if (volume < (double)Product.CategoryValue.SmallParcel)
            {
                Category = "Small Parcel";
                Cost = Product.SmallParcelMultiplier * volume;

                return true;
            }

            return false;
        }
    }
}
