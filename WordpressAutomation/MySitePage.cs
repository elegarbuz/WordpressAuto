using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordpressAutomation
{
    public class MySitePage
    {
        public static void GoTo()
        {
            Driver.Instance.FindElement(By.XPath("//a[1]/span[text()='My Site']")).Click();
            Driver.Instance.FindElement(By.XPath("//li[1]/a[1]/span[text()='Site Pages']")).Click();
        }

        public static void CreateNewPost(string postName)
        {

            Driver.Instance.FindElement(By.XPath("//li[1][@data-tip-target='side-menu-page']/a[2]")).Click();
            Driver.Instance.FindElement(By.XPath("//div[1]/textarea[@placeholder='Title']")).SendKeys(postName);
            Driver.Instance.FindElement(By.XPath("//div[4]/div/button[text()='Publish…']")).Click();
            Driver.Instance.FindElement(By.XPath("//div[2]/button[text()='Publish!']")).Click();
            Driver.Instance.FindElement(By.XPath("//div[1][@class='web-preview__toolbar']/button[text()='Close']")).Click();


        }
    }
}
