using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowGoogleTestProject.StepDefinitions
{
    [Binding]
    public sealed class DataTableDataDrivenTestinStepDefenitions

    {
        private IWebDriver driver;

        public DataTableDataDrivenTestinStepDefenitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Then(@"Enter search keyword in Google")]
        public void ThenEnterSearchKeywordInGoogle(Table table)
        {
          var searchCriteria =  table.CreateSet<SearchKeyTestData>();

            foreach (var keyword in searchCriteria)
            {
                driver.FindElement(By.XPath("//*[@name = 'q']")).Clear();
                driver.FindElement(By.XPath("//*[@name = 'q']")).SendKeys(keyword.searchKey);
                driver.FindElement(By.XPath("//*[@name = 'q']")).SendKeys(Keys.Enter);
                Thread.Sleep(5000);

            }
        }




    }

    public class SearchKeyTestData
        {
            public string searchKey { get; set; }
        }
}