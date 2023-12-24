using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace MStests
{
    public class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
