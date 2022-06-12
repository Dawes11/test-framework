using E2EGiacomTestAutomation.Utilities.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
