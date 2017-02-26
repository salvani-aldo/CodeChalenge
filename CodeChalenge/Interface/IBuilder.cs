using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChalenge.Interface
{
    public interface IBuilder
    {
        IBuilder SetReject();
        IBuilder SetHeavy();
        IBuilder SetLarge();
        IBuilder SetMedium();
        IBuilder SetSmall();
        List<IBase> Build();
    }
}
