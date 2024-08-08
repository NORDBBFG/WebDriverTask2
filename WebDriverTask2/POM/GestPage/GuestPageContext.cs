using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverTask2.POM.AbstractEntity;

namespace WebDriverTask2.POM.GestPage
{
    internal class GuestPageContext : AbstractPageContext
    {
        private GuestPage newGuestPage;

        public GuestPageContext(IWebDriver driver)
        {
            this.driver = driver;
            this.newGuestPage = new GuestPage(driver);
        }

        public GuestPageContext VerifyMasagePostCreatSuccessfullyApears()
        {
            Thread.Sleep(1000);
            bool actual = newGuestPage.MasagePostCreatSuccessfully.Enabled;
            Assert.IsTrue(actual);
            return this;
        }

        public GuestPageContext VerifyPostStyle(string expectedStyle)
        {
            string actualStyle = newGuestPage.LinkStyleType.Text;
            Assert.That(actualStyle, Is.EqualTo(expectedStyle));
            return this;
        }

        public GuestPageContext VerifyPostСontent(string expectedContent)
        {
            string actualContent = newGuestPage.OlMasageText.Text;
            Assert.That(actualContent, Is.EqualTo(expectedContent));
            return this;
        }
    }
}
