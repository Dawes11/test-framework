﻿using E2EGiacomTestAutomation.Pages.MainPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace E2EGiacomTestAutomation.Tests.Steps
{
    [Binding]
    class MainPageSteps
    {
        private readonly MainPage mainPage = new MainPage();

        [When(@"I log out")]
        public void LogOut()
        {
            this.mainPage.LogOut();
        }
    }
}