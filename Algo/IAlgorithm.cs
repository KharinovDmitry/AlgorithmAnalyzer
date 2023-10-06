using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public interface IAlgorithm<TResult, TInput>
    {
        public int Min { get; }
        public int Max { get; }
        public int Step { get; }

        public TResult Execute(TInput input);
    }
}
