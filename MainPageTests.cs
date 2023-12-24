using OpenQA.Selenium;
using FluentAssertions;
using OpenQA.Selenium.Chrome;

namespace MStests
{
    [TestClass]
    public class MainPageTests : MainPage
    //public class MainPageTests(IWebDriver driver) : MainPage(driver)
    {
        [TestMethod]
        public void QueryParameters_ShouldBeCorrect_OnSearchPage()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(mainPageUrl);
            var searchInput = driver.FindElement(By.ClassName("[data-tid='SimpleSearchWrap']"));
            searchInput.Click();
            searchInput.SendKeys("налог");
            driver.FindElement(By.CssSelector("[data-tid='SearchSubmitButton']")).Click();
            var url = driver.Url.ToString();
            var expectedPath = "?query=налог&searching=true&sortby=1&searchquerysource=2&from=Main";
            var actualPath = new Uri(url).PathAndQuery;
            actualPath.Should().Contain(expectedPath);
            driver.Quit();
        }
    }
}