using Automated_Bugzilla_Test.Pages_To_Be_Tested;
using Bugzilla_Test_Scripts.Tests;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace Automated_Bugzilla_Test
{
    public class SimpleSearch_Tests : Base_Test
    {
        private SimpleSearch_Page searchPage;

        [SetUp]
        public void SearchSetUp()
        {
            searchPage = new SimpleSearch_Page(bugzilla_driver);
            bugzilla_driver.Navigate().GoToUrl("https://bugs.documentfoundation.org/query.cgi");

        }

        [Test]
        public void SearchClosedAllProductsNoWords()
        {
            searchPage.SelectStatus(1);
            searchPage.SelectProduct(0);
            searchPage.ClickSearchButton();

            IReadOnlyCollection<IWebElement> statusCells = searchPage.GetStatusCells();

            // Assert that all statuses are either "Closed," "Resolved," or "Verified"
            foreach (IWebElement cell in statusCells)
            {
                string status = cell.Text.Trim();
                Assert.IsTrue(status == "Closed" || status == "Resolved" || status == "Verified",
                    $"Unexpected status found: {status}");
            }
        }

        [Test]
        public void SearchOpenAllProductsNoWords()
        {
            searchPage.SelectStatus(0);
            searchPage.SelectProduct(0);
            searchPage.ClickSearchButton();

            IReadOnlyCollection<IWebElement> statusCells = searchPage.GetStatusCells();

            // Assert that all statuses are either "Unconfirmed, New, Assigned, Reopened, NeedInfo"
            foreach (IWebElement cell in statusCells)
            {
                string status = cell.Text.Trim();
                Assert.IsTrue(status == "UNCONFIRMED" || status == "NEW" || status == "ASSIGNED" || status == "REOPENED" || status == "NEEDINFO",
                    $"Unexpected status found: {status}");
            }
        }
    }
}