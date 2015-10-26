using Moq;
using NUnit.Framework;

namespace ExceptionRerouter.Tests
{
    [TestFixture]
    public class BaseTest
    {
        protected Mock<EmptyTestRegistry> TestRegistration { get; set; }

        [SetUp]
        public void TestSetup()
        {
            Core.ExceptionRerouter.ClearRoutes();
            TestRegistration = new Mock<EmptyTestRegistry>();
        }

        public void TestTearDown()
        {
        }
    }
}