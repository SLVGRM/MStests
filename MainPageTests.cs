using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using FluentAssertions;
using OpenQA.Selenium.Chrome;

namespace MStests
{
    [TestClass]
    public class MainPageTests
    {
        private readonly IWebDriver _driver;
        private readonly MainPage _mainPage;

        public MainPageTests()
        {
            _driver = new ChromeDriver();
            _mainPage = new MainPage(_driver);
        }

        [TestMethod]
        public void QueryParameters_ShouldBeCorrect_OnSearchPage()
        {
            _driver.Navigate().GoToUrl(_mainPage.mainPageUrl);
            var searchInput = _driver.FindElement(By.CssSelector("[data-tid='SearchInput']"));
            string query = "223";
            searchInput.Click();
            searchInput.SendKeys(query);
            _driver.FindElement(By.CssSelector("[data-tid='SearchSubmitButton']")).Click();
            var url = _driver.Url.ToString();
            var expectedPath = $"?query={query}&searching=true&sortby=1&searchquerysource=2&from=Main";
            var actualPath = new Uri(url).PathAndQuery;
            actualPath.Should().Contain(expectedPath);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _driver.Close();
            _driver.Quit();
        }
    }
}