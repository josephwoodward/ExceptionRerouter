using System;
using System.Linq;
using Shouldly;
using NUnit.Framework;

namespace ExceptionRerouter.Tests
{
    public class ExceptionRerouterRegisterTests : BaseTest
    {
        [Test]
        public void ShouldThrowExceptionIfRegistryIsNull()
        {
            Should.Throw<NullReferenceException>(() => Core.ExceptionRerouter.Register(null));
        }

        [Test]
        public void ShouldRegisterRoute()
        {
            Core.ExceptionRerouter.Register(new TestRegistry());
            var res = Core.ExceptionRerouter.Routes;
        }

        [Test]
        public void ShouldNotRegisterDuplicates()
        {
            Core.ExceptionRerouter.Register(new TestRegistry());
            Core.ExceptionRerouter.Register(new TestRegistry());

            Core.ExceptionRerouter.Routes.ToList().Count.ShouldBe(1);
        }

    }
}
