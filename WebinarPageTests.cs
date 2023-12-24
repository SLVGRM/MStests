using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using FluentAssertions;

namespace MStests
{
    [TestClass]
    public class WebinarPageTests(IWebDriver driver) : WebinarPage(driver)
    {
        readonly IWebDriver driver;

        [TestMethod]
        public void MainTheme_ShouldBeVisible_OnMainPage()
        {
            driver.Navigate().GoToUrl(webinarPageUrl);
            driver.Url.Should().Be("https://normativ.kontur.ru/webinars");
            driver.Quit();
        }
    }
}