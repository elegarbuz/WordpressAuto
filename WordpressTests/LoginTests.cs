using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordpressAutomation;

namespace WordpressTests
{
    [TestClass]
    public class LoginTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void LogInToAccount()
        {
            var loginPage = new LoginPage();

            loginPage.GoTo();
            loginPage.Login("gae@ciklum.com", "Temp1234%");
            Assert.IsTrue(FollowedSitePage.IsAt(), "Failed to login(incorrect tab is opened)");
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
