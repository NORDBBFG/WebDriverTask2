using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverTask2.POM.AbstractEntity;
using WebDriverTask2.POM.GestPage;

namespace WebDriverTask2.POM
{
    internal class NewPastePageContext : AbstractPageContext
    {
        private NewPastePage newPastePage;

        public NewPastePageContext(IWebDriver driver)
        {
            this.driver = driver;
            this.newPastePage = new NewPastePage(driver);
        }

        public NewPastePageContext EnterTextIntoTestField(string text)
        {
            newPastePage.TestFieldNewPatste.SendKeys(text);
            return this;
        }
        public NewPastePageContext SelectExpirationOptionByText(string optionText)
        {
            newPastePage.DropDownMenuPasteExpiration.Click();
            newPastePage.DropDownMenuPasteExpirationElementByText(optionText).Click();
            return this;
        }

        public NewPastePageContext SelectSyntaxHighlightingByText(string optionText)
        {
            newPastePage.DropDownMenuSyntaxHighlighting.Click();
            newPastePage.DropDownMenuSyntaxHighlightingByText(optionText).Click();
            return this;
        }

        public NewPastePageContext EnterTextIntoPasteNameTitleInput(string text)
        {
            newPastePage.PasteNameTitleInput.SendKeys(text);
            return this;
        }

        public GuestPageContext ClickButtonCreateNewPaste()
        {
            newPastePage.ButtonCreateNewPaste.Click();
            return new GuestPageContext(driver);
        }
    }
}
