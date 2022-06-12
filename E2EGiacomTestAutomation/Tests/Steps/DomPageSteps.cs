using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using E2EGiacomTestAutomation.Pages.DomPage;


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
    public class DomPageSteps
    {
        private DomPage domPage = new DomPage();

        [Then(@"I can see correct values in rows")]
        public void CorrectValuesAreInRows(Table table)
        {
            foreach (var row in table.Rows)
            {
                var column = domPage.GetColumnIndexByName(row[0]);

                //When column is not found, -1 value is assigned
                column.Should().BeGreaterThan(-1, $"Column with name {row[0]} was not found.");
                
                //Column value counts from zero, column value in table from 1 -> +1 added
                column++;

                var value = domPage.GetValueFromTable(column.ToString(), row[1]);
                value.Should().BeEquivalentTo(row[2], $"Expected value on coordinates row: {row[1]}, column: {column.ToString()} was: {row[2]}, but found {value}");
            }
        }

    }
}
