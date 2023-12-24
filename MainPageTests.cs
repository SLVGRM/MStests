using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using FluentAssertions;
using OpenQA.Selenium.Chrome;

namespace MStests
{
    [TestClass]
    public class MainPageTests
    {
        private IWebDriver driver;
        private MainPage mainPage;

        public MainPageTests()
        {
            driver = new ChromeDriver();
            mainPage = new MainPage(driver);
        }

        [TestMethod]
        public void QueryParameters_ShouldBeCorrect_OnSearchPage()
        {
            driver.Navigate().GoToUrl(mainPage.mainPageUrl);
            var searchInput = driver.FindElement(By.CssSelector("[data-tid='SearchInput']"));
            string query = "налог";
            searchInput.Click();
            searchInput.SendKeys(query);
            driver.FindElement(By.CssSelector("[data-tid='SearchSubmitButton']")).Click();
            var url = driver.Url.ToString();
            var expectedPath = $"searching=true&sortby=1&searchquerysource=2&from=Main";
            var actualPath = new Uri(url).PathAndQuery;
            actualPath.Should().Contain(expectedPath);
        }

        [TestCleanup]
        public void Cleanup()
        {
            driver.Close();
            driver.Quit();
        }
    }
}