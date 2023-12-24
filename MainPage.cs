using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MStests
{

    public class MainPage : BasePage
    {
        public string mainPageUrl = "https://normativ.kontur.ru";

        public MainPage(IWebDriver driver) : base(driver)
        {
        }
    }
}