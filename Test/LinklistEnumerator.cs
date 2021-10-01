#nullable enable
using System.Collections;
using System.Collections.Generic;

namespace Test
{
    // Don't change anything in this file
    public class LinklistEnumerator<T>: IEnumerator<T>
    {
        private readonly LinkList<T>.Node? _first;
        private LinkList<T>.Node? _current;
            
        internal LinklistEnumerator(LinkList<T>.Node? first)
        {
            _first = first;
        }
            
        public bool MoveNext()
        {
            if (_first == null) return false;

            _current = _current == null ? _first : _current.Next;
                
            return _current != null;
        }

        public void Reset()
        {
            _current = _first;
        }

        public T Current => _current.Value;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}