
namespace ManualTestingProjectPLUS.code.Tests
{
    [TestFixture]
    public class TestBase
    {
        [SetUp]
        public void OpenBrowser()
        {
            Session.Session.Instance().GetBrowser().Navigate().GoToUrl("http://todo.ly/");
        }

        [TearDown]
        public void CloseBrowser()
        {
            Session.Session.Instance().CloseBrowser();
        }
    }
}
