using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChalenge.model
{
    public class productModel
    {
        public productModel()
        { }

        public productModel(double weight, double height, double width, double depth)
        {
            Weight = weight;
            Height = height;
            Width = width;
            Depth = depth;
        }

        public double Weight { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
    }
}
