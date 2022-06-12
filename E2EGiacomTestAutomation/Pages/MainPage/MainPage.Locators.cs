using OpenQA.Selenium;

namespace E2EGiacomTestAutomation.Pages.MainPage
{
    using Pages.CommonPage;
    
    public partial class MainPage : CommonPage
    {
        public By LogoutButton => By.LinkText("Logout");

        public By ChallengingDom => By.LinkText("Challenging DOM");
    }
}
