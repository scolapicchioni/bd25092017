using H07_OO02.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace H07_002.Logic.Tests
{
    [TestClass]
    public class CollectionTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Collection<int> list = new Collection<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);

            Collection<int> evenNumbers = list.Filter(Mario);

            Collection<int> oddNumbers = list.Filter(number => number % 2 != 0);
            
        }
        private bool Elizabeth(int number) {
            return number > 3;
        }

        private bool Mario(int item) {
            return item % 2 == 0;
        }


    }
}
