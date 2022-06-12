namespace E2EGiacomTestAutomation.Pages.LoginPage
{
    using Utilities.Extensions;
    using PGSWebsite.Configuration.TestDataSection;
    using Pages.CommonPage;

    public partial class LoginPage : CommonPage
    {
        public void Login(TestData user)
        {
            this.EnterUsername(user.Username);
            this.EnterPassword(user.Password);
            this.ClickLoginButton();
        }

        public void Login(string username, string password)
        {
            EnterUsername(username);
            EnterPassword(password);
            ClickLoginButton();
        }

        public void EnterUsername(string email)
        {
            this.UsernameInput.SendKeys(email);
        }

        public void EnterPassword(string email)
        {
            this.PasswordInput.SendKeys(email);
        }

        public void ClickLoginButton()
        {
            this.LoginButton.ClickWithWait();
        }
    }
}
