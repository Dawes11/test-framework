using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using E2EGiacomTestAutomation.Pages.DomPage;


namespace E2EGiacomTestAutomation.Tests.Steps
{
    [Binding]
    public class DomPageSteps
    {
        private DomPage domPage = new DomPage();

        [Then(@"I can see correct values in rows")]
        public void CorrectValuesAreInRows(Table table)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
