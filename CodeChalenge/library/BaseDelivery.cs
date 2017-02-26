using CodeChalenge.Interface;
using CodeChalenge.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChalenge.library
{
    public abstract class BaseDelivery : IBase
    {
        public string Category { get; set; }
        public double Cost { get; set; }

        internal readonly double _weight;
        internal readonly productModel _model;

        public BaseDelivery(double weight)
        {
            _weight = weight;
        }

        public BaseDelivery(productModel model)
        {
            _model = model;
        }

        public virtual double GetCost()
        {
            return Cost;
        }

        public abstract bool Processed();

        public string GetCategory()
        {
            return Category;
        }

        internal double ComputeVolume()
        {
            return _model.Height * _model.Width * _model.Depth;
        }
    }
}
