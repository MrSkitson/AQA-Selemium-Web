using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowGoogleTestProject.StepDefinitions
{
    [Binding]
    public sealed class DataDrivenTestinStepDefenitions

    {
        private IWebDriver driver;
        
        public DataDrivenTestinStepDefenitions (IWebDriver driver)
        {
            this.driver = driver;
        }

        [Then(@"Search for '([^']*)'")]
        public void ThenSearchFor(string searchKey)
        {
            driver.FindElement(By.XPath("//*[@name = 'q']")).SendKeys(searchKey);
            driver.FindElement(By.XPath("//*[@name = 'q']")).SendKeys(Keys.Enter);

            Thread.Sleep(3000);
           
        }



    }
}