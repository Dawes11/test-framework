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
        public void GoToSpecificPage(Pages page)
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
            loginPage.Login(TestDataGenerator.GetTestData(Constants.Admin));
        }

        [Then(@"I see main page")]
        public void MainPageIsVisible()
        {
            loginPage.PageHeader("Task to be automated").IsDisplayedAfterWait().Should().BeTrue();
        }

        [Given(@"I am on main page after logging in")]
        public void MainPageIsVisibleAfterLoggingIn()
        {
            EnterValidLoginCredentials();
            MainPageIsVisible();
        }

        [When(@"I try to get to main page without login")]
        public void TryToGetToMainPageWithoutLogin()
        {
            Browser.GoTo(Pages.MainPage);         
        }

        [Then(@"I can see error message with text '(.+)'")]
        public void ErrorMessageIsShown(string errorMessage)
        {
            //check the error message is displayed
            loginPage.ErrorMessage.IsDisplayedAfterWait().Should().BeTrue();

            var uiErrorText = loginPage.ErrorMessage.Text();
            //check correct error message, there is escaping and 'x' at the end -> Contains not Equals, we need to know the message specified is visible
            uiErrorText.Should().Contain(errorMessage, $"Expected {errorMessage}, but shown {uiErrorText}.");
        }

        [When(@"I login with '(.*)' username and '(.*)' password")]
        public void LoginWithUsernameAndPassword(string username, string password)
        {
            loginPage.Login(username, password);
        }
    }
}