using FlowerShop;
using NSubstitute;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // ARRANGE

            IClient c = Substitute.For<IClient>();
            IOrderDAO od = Substitute.For<IOrderDAO>();
            List<Flower> f = new List<Flower>();
            IOrder o = new Order(od, c, false);

            //ACT

            o.Deliver();

            //ASSERT

            od.Received().SetDelivered(Arg.Any<IOrder>());
            
        }
    }
}