using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowGoogleTestProject.StepDefinitions
{
    [Binding]
    public sealed class Feuture1StepDefinitions
    {
        private IWebDriver driver;
        public Feuture1StepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
         // driver = new ChromeDriver();
            
         
        }

        [When(@"Enter URL")]
        public void WhenEnterURL()
        {
            driver.Url = "https://www.google.com/";
            Thread.Sleep(3000);
            driver.FindElement(By.Id("L2AGLb")).Click();
         
           // driver.Manage().Window.Maximize();
        }

        [Then(@"Search for Love you baby song")]
        public void ThenSearchForLoveYouBabySong()
        {
            driver.FindElement(By.XPath("//*[@name = 'q']")).SendKeys("Love you baby song");
            driver.FindElement(By.XPath("//*[@name = 'q']")).SendKeys(Keys.Enter);

            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@class = 'LC20lb MBeuO DKV0Md']")).Click();
            Thread.Sleep(10000);

            driver.Quit();
        }



    }
}