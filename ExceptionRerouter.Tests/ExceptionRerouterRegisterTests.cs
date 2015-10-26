using System;
using System.Linq;
using ExceptionRerouter.Core.Store;
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
            Core.ExceptionRerouter.Register(new EmptyTestRegistry());
            var res = Core.ExceptionRerouter.Routes;

            res.Count().ShouldBe(1);
        }

        [Test]
        public void ShouldNotRegisterDuplicates()
        {
            Core.ExceptionRerouter.Reset();

            Core.ExceptionRerouter.Register(new EmptyTestRegistry());
            Core.ExceptionRerouter.Register(new EmptyTestRegistry());

            Core.ExceptionRerouter.Routes.Count().ShouldBe(1);
        }

        [Test]
        public void ShouldCreateExceptionRoutes()
        {
            Core.ExceptionRerouter.Register(new FullTestRegistry());
            ExceptionTypes.Exceptions.ShouldNotBeEmpty();
        }

        [Test]
        public void ShouldClearExistingRoutes()
        {
            Core.ExceptionRerouter.Register(new FullTestRegistry());
            Core.ExceptionRerouter.Reset();
        }
    }
}
