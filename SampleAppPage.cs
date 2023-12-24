
using OpenQA.Selenium;

namespace MStests
{
    internal class SampleAppPage
    {
        private IWebDriver Driver { get; set; }

        public SampleAppPage (IWebDriver driver)
        {
            Driver = driver;    
        }

        public bool IsLoaded { get; internal set; }
        public bool IsVisible { get; internal set; }


        internal object FillOutFormAndSubmit(string v)
        {
            throw new NotImplementedException();
        }

        internal void GoTo()
        {
            Driver.Navigate().GoToUrl("https://normativ.kontur.ru/");
        }
    }
}