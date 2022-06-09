namespace E2EGiacomTestAutomation.Tests.Steps
{
    using FluentAssertions;
    using Pages.LoginPage;
    using E2EGiacomTestAutomation.Utilities.Extensions;
    using TechTalk.SpecFlow;
    using Utilities;
    using Utilities.Helpers.TestDataGenerator;
    using Utilities.Enums;

    [Binding]
    public class LoginPageSteps
    {
        private readonly LoginPage loginPage = new LoginPage();

        
        [When(@"I go to '(.+)' page")]
        public void IgoToSpecificPage(Pages page)
        {
            Browser.GoTo(page);
        }

        [Given(@"I open The Internet page")]
        public void OpenLoginPage()
        {
            Browser.GoTo(Pages.LoginPage);
        }

        [When(@"I enter valid login credentials")]
        public void EnterValidLoginCredentials()
        {
            this.loginPage.Login(TestDataGenerator.GetTestData(Constants.Admin));
        }

        [Then(@"I see landing page")]
        public void LandingPageIsVisible()
        {
            this.loginPage.PageHeader("Task to be automated").IsDisplayedAfterWait().Should().BeTrue();
        }

        [Given(@"I am on landing page after logging in")]
        public void LandingPageIsVisibleAfterLoggingIn()
        {
            EnterValidLoginCredentials();
            LandingPageIsVisible();
        }

    }
}