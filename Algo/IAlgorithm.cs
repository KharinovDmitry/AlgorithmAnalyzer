using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public interface IAlgorithm<T>
    {
        public void Execute(T input);
    }
}
