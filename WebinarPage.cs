using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MStests
{
    public class WebinarPage : BasePage
    {
        public WebinarPage(IWebDriver driver) : base(driver)
        {
        }

        public string webinarPageUrl = "https://normativ.kontur.ru/webinars";
    }
}
