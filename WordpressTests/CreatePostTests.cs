using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordpressAutomation;

namespace WordpressTests
{
    [TestClass]
    public class CreatePostTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void CreateNewPost()
        {
            var loginPage = new LoginPage();

            loginPage.GoTo();
            loginPage.Login("gae@ciklum.com", "Temp1234%");
            MySitePage.GoTo();
            MySitePage.CreateNewPost("QA Test");
                     
           /// Assert.AreEqual(PostPage.Title, "This is the test post title", "Title didn't match new post");
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
