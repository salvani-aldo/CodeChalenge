using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChalenge.Interface
{
    public interface IBase
    {
        double GetCost();
        string GetCategory();
        bool Processed();
    }
}
