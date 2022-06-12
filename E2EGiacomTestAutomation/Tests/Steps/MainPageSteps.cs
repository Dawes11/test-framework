using E2EGiacomTestAutomation.Pages.MainPage;
using TechTalk.SpecFlow;

namespace E2EGiacomTestAutomation.Tests.Steps
{
    [Binding]
    public class MainPageSteps
    {
        private readonly MainPage mainPage = new MainPage();

        [When(@"I log out")]
        public void LogOut()
        {
            mainPage.LogOut();
        }

        //more items can be added to regex
        [When(@"I click on link '(Challenging DOM)'")]
        public void ClickOnLink(string link)
        {
            mainPage.ChallengeDom();
        }

    }
}
