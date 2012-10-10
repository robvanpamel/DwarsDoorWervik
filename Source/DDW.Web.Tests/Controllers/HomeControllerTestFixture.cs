using System.Web.Mvc;
using DDW.Web.Controllers;
using NUnit.Framework;

namespace DDW.Web.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTestFixture
    {
        [Test]
        [SetUICulture("nl-BE")]
        public void WhenUICultureNlWebsiteIsShownInNl()
        {
            var controller = new HomeController();
            var result = controller.Index();

            Assert.That(result, Is.TypeOf<ViewResult>());
        }
    }
}