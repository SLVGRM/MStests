using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace MStests
{
    public class BasePage
    {
        protected IWebDriver Driver;

        public BasePage(IWebDriver driver)
        {
            this.Driver = driver;
        }
    }
}
