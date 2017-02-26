using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChalenge.productVariables
{
    public class Product
    {
        public enum CategoryValue
        {
            Reject = 50,
            HeavyParcel = 10,
            SmallParcel = 1500,
            MediumParcel = 2500,
            LargeParcel = 3500
        }

        public const double RejectMultiplier = 0.0;
        public const double HeavyParcelMultiplier = 15;
        public const double SmallParcelMultiplier = 0.05;
        public const double MediumParcelMultiplier = 0.04;
        public const double LargeParcelMultiplier = 0.03;
    }
}
