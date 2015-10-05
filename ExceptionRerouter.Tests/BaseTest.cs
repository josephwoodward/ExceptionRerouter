using Moq;
using NUnit.Framework;

namespace ExceptionRerouter.Tests
{
    [TestFixture]
    public class BaseTest
    {
        protected Mock<TestRegistry> TestRegistration { get; set; }

        [SetUp]
        public void TestSetup()
        {
            TestRegistration = new Mock<TestRegistry>();
        }

        public void TestTearDown()
        {
        }
    }
}