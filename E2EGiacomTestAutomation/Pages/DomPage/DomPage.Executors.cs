using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace E2EGiacomTestAutomation.Pages.DomPage
{
    using Pages.CommonPage;
    using Utilities.Extensions;

    public partial class DomPage : CommonPage
    {
        public int FindColumn(string tableHeaderName)
        {
            return TableHeaderElements.FindIndex(elm => elm.Text.Equals(tableHeaderName));
        }

        public string GetValueFromTable(string column, string row)
        {
            return TableValue(column, row);
        }

    }
}
