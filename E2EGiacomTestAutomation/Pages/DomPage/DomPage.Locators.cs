using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace E2EGiacomTestAutomation.Pages.DomPage
{
    using Pages.CommonPage;
    using E2EGiacomTestAutomation.Utilities;
    using Utilities.Extensions;

    public partial class DomPage : CommonPage
    {
        public List<IWebElement> TableHeaderElements = SeleniumExecutor.Driver.FindElements(By.XPath("//thead//th")).ToList<IWebElement>();


        public string TableValue (string column, string row) => By.XPath($"//table/tbody/tr[{row}]/td[{column}]").Text().ToString();
    }
}
