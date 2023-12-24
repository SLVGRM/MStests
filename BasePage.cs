using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MStests
{
    public class BasePage
    {
        protected IWebDriver driver = new ChromeDriver();

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
