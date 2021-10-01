#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/* Requirement 1.1) Implement the Add method to add items to the linked list
 * Requirement 1.2) The time complexity of the Add must be O(1)
 * 
 * Requirement 2.1) Implement the Reverse method to reverse the contents of the linked list
 * Requirement 2.2) The time complexity of the the reversal has to be O(n)
 * Requirement 2.3) The space complexity of the reversal has to be O(1)
 */

namespace Test
{
    public class LinkList<T>: IEnumerable<T>
    {
        internal class Node
        {
            public readonly T Value;
            public Node? Next;
            public Node(T value) => Value = value;
        }

        private Node? _first;
        public void Add(T value)
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<T> items) => items.ToList().ForEach(Add);
        public IEnumerator<T> GetEnumerator() => new LinklistEnumerator<T>(_first);
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}