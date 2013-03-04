using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NSubstitute;

namespace sd_final_tests
{

    [TestFixture]
    public class Class1
    {
        //private DynamicMock
        [Test]
        public void Test1()
        {
            var dsuser = (from q in sd_final.DB_Context.context.sd_users where q.priv == 2 select q);
            CollectionAssert.AllItemsAreUnique(dsuser);
        }

        [Test]
        public void Test2()
        {
            ICalculator calculator = Substitute.For<ICalculator>();
            calculator.Add(1, 2).Returns(3);
            Assert.That(calculator.Add(1, 2), Is.EqualTo(3));
            calculator.Received().Add(1, 2);
            //calculator.Received().Add(1, 3);
        }
    }

    public interface ICalculator
    {
        int Add(int a, int b);
        string Mode { get; set; }
        event EventHandler PoweringUp;
    }

 
  
}
