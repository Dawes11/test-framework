using E2EGiacomTestAutomation.Utilities.Extensions;

namespace E2EGiacomTestAutomation.Pages.MainPage
{
    using Pages.CommonPage;

    public partial class MainPage : CommonPage
    {
        public void LogOut()
        {
            LogoutButton.ClickWithWait();
        }

        public void ChallengeDom()
        {
            ChallengingDom.ClickWithWait();
        }
    }
}
