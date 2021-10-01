#nullable enable
using System.Linq;
using NUnit.Framework;

namespace Test
{
    public class Tests
    {
        [Test]
        public void EnsureItemsCanBeAddedToLinklist()
        {
            var linkList = new LinkList<int>();
            
            linkList.AddRange(new []{1,1,2,3,5,8,13});

            CollectionAssert.AreEqual(new []{1,1,2,3,5,8,13}, linkList);
        }
        
        [TestCase(1,1,2,3,5,8,13)]
        [TestCase(1)]
        [TestCase]
        public void EnsureLinklistCanBeReversed(params int[] items)
        {
            var linkList = new LinkList<int>();
            
            linkList.AddRange(items);

            linkList.Reverse();
            
            CollectionAssert.AreEqual(items.Reverse(), linkList);
        }
    }
}