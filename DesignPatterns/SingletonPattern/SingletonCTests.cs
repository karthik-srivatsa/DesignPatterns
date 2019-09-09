using NUnit.Framework;
using SingletonImplementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    [TestFixture]
    class SingletonCTests
    {
        [Test]
        public void IsSingletonTest()
        {
            var db1 = DatabaseReader.Instance;
            var db2 = DatabaseReader.Instance;
            Assert.That(db1, Is.SameAs(db2));
        }
    }
}
