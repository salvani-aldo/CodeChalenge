using CodeChalenge.model;
using CodeChalenge.productVariables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChalenge.library
{
    public class Medium : BaseDelivery
    {
        public Medium(productModel model) : base(model)
        { }

        public override bool Processed()
        {
            double volume = ComputeVolume();
            if (volume < (double)Product.CategoryValue.MediumParcel)
            {
                Category = "Medium Parcel";
                Cost = Product.MediumParcelMultiplier * volume;

                return true;
            }

            return false;
        }
    }
}
