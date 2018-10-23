using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordpressAutomation
{
    public class LoginPage
    {
        /// private readonly IWebDriver Driver;

        /// public LoginPage(IWebDriver driver)
        /// {
        /// this.Driver = driver;
        /// }

        /// private IWebElement EmailAddress => this.Driver.FindElement(By.Id("usernameOrEmail"));

        public void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://wordpress.com/log-in");
        }

        public void Login(string email, string password)
        {
            Driver.Instance.FindElement(By.Id("usernameOrEmail")).SendKeys(email);
            Driver.Instance.FindElement(By.XPath(".//form//button[text()='Continue']")).Click();
            Driver.Instance.FindElement(By.Id("password")).SendKeys(password);
            Driver.Instance.FindElement(By.XPath(".//form//button[text()='Log In']")).Click();
        }
    }  
}
