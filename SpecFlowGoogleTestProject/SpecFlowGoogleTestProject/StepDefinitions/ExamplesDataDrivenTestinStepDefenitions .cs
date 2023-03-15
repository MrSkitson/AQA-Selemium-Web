using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowGoogleTestProject.StepDefinitions
{
    [Binding]
    public sealed class ExamplesDataDrivenTestinStepDefenitions

    {
        private IWebDriver driver;
        
        public ExamplesDataDrivenTestinStepDefenitions(IWebDriver driver)
        {
            this.driver = driver;
        }


        [Then(@"Search with (.*)")]
        public void ThenSearchWithSongByLoveYouBaby(string searchKey)
        {
            driver.FindElement(By.XPath("//*[@name = 'q']")).SendKeys(searchKey);
            driver.FindElement(By.XPath("//*[@name = 'q']")).SendKeys(Keys.Enter);

            Thread.Sleep(3000);
        }




    }
}