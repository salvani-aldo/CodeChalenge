
using CodeChalenge.productVariables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChalenge.library
{
    public class Reject : BaseDelivery
    {
        public Reject(double weight): base(weight)
        { }

        public override bool Processed()
        {
            if (_weight > (double)Product.CategoryValue.Reject)
            {
                Category = "Reject";
                Cost = 0;

                return true;
            }

            return false;
        }
    }
}
