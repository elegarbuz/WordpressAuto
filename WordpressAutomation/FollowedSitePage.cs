using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordpressAutomation
{
    public class FollowedSitePage
    {
        public static bool IsAt()
        {
            var followedSite = Driver.Instance.FindElement(By.XPath("//span[text()='Followed Sites']"));
            if (followedSite != null)
            {
                return true;

            }
            else return false;
        }
    }
}
