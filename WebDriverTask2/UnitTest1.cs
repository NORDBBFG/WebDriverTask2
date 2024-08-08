using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverTask2.POM;
using WebDriverTask2.POM.GestPage;

namespace WebDriverTask2
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-fullscreen");
            driver = new ChromeDriver(options);
        }

        [Test]
        public void Test1()
        {
            //Arrange
            string code;
            string expectedCode;
            string syntaxHighlighting;
            string expirationOption;
            string pasteNameTitle;
            string expectedNameTitle;

            //Act

            code = "git config†--global†user.name††\"New Sheriff in Town\"\n git reset†$(git commit-tree†HEAD^{tree}†-m†\"Legacy code\")\ngit push†origin master†--force\n";
            expectedCode = "git config --global user.name  \"New Sheriff in Town\"\r\n git reset $(git commit-tree HEAD^{tree} -m \"Legacy code\")\r\ngit push origin master --force\r\n ";
            syntaxHighlighting = "Bash";
            expirationOption = "10 Minutes";
            pasteNameTitle = "how to gain dominance among developers";
            expectedNameTitle = "how to gain dominance among developers - Pastebin.com";

            //Assert
            driver.Navigate().GoToUrl("https://pastebin.com/");
            var newPastaCOntext = new NewPastePageContext(driver);
            Thread.Sleep(3000);
            newPastaCOntext
                .EnterTextIntoTestField(code)
                .SelectSyntaxHighlightingByText(syntaxHighlighting)
                .SelectExpirationOptionByText(expirationOption)
                .EnterTextIntoPasteNameTitleInput(pasteNameTitle)
                .ClickButtonCreateNewPaste()
                .VerifyPageTitle<GuestPageContext>(expectedNameTitle)
                .VerifyPostStyle(syntaxHighlighting)
                .VerifyPost—ontent(expectedCode);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Dispose();
        }
    }
}