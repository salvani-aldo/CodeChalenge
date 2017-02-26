using CodeChalenge.Interface;
using CodeChalenge.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChalenge.library
{
    public class DeliveryBuilder : IBuilder
    {
        private List<IBase> delivery;
        private readonly productModel _model;
        public DeliveryBuilder(productModel model)
        {
            _model = model;
            delivery = new List<IBase>();
        }
        /// <summary>
        /// Heavy (priority 2)
        /// </summary>
        /// <returns></returns>
        public IBuilder SetHeavy()
        {
            delivery.Add(new Heavy(_model.Weight));
            return this;
        }
        /// <summary>
        /// Large (priority 5)
        /// </summary>
        /// <returns></returns>
        public IBuilder SetLarge()
        {
            delivery.Add(new Large(_model));
            return this;
        }

        /// <summary>
        /// Medium (priority 4)
        /// </summary>
        /// <returns></returns>
        public IBuilder SetMedium()
        {
            delivery.Add(new Medium(_model));
            return this;
        }

        /// <summary>
        /// Reject (priority 1)
        /// </summary>
        /// <returns></returns>
        public IBuilder SetReject()
        {
            delivery.Add(new Reject(_model.Weight));
            return this;
        }

        /// <summary>
        /// Small (priority 3)
        /// </summary>
        /// <returns></returns>
        public IBuilder SetSmall()
        {
            delivery.Add(new Small(_model));
            return this;
        }

        public List<IBase> Build()
        {
            return delivery;
        }
    }
}
