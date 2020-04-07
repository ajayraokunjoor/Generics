using System;
using System.Collections.Generic;

namespace Generics
{
    public class GenericList<T>
    {
        public void Add(T Value)
        {

        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
