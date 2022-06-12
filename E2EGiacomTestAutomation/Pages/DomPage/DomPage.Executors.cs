namespace E2EGiacomTestAutomation.Pages.DomPage
{
    using Pages.CommonPage;

    public partial class DomPage : CommonPage
    {
        public int GetColumnIndexByName(string tableHeaderName)
        {
            return TableHeaderElements.FindIndex(elm => elm.Text.Equals(tableHeaderName));
        }

        public string GetValueFromTable(string column, string row)
        {
            return TableValue(column, row);
        }

    }
}
