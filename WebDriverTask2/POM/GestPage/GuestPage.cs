using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverTask2.POM.AbstractEntity;

namespace WebDriverTask2.POM.GestPage
{
    internal class GuestPage : AbstractPage
    {
        public GuestPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement MasagePostCreatSuccessfully => driver.FindElement(By.XPath("//div[@class='notice -success -post-view']"));
        public IWebElement OlMasageText => driver.FindElement(By.XPath("//ol"));
        public IWebElement LinkStyleType => driver.FindElement(By.XPath("//a[@class='btn -small h_800']"));
    }
}
