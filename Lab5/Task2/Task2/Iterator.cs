using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();
        
        public abstract object Current();
        public abstract bool MoveNext();
        public abstract void Reset();
    }
}
