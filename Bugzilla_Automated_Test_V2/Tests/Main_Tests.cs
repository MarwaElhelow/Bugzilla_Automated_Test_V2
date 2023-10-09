using Bugzilla_Test_Scripts.pages;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bugzilla_Test_Scripts.Tests
{
    internal class Main_Tests : Base_Test
    {
        private Main_Page homePage;


        [SetUp]
        public void NavigateToHomePage()
        {
            bugzilla_driver.Navigate().GoToUrl("https://bugs.documentfoundation.org/");
            homePage = new Main_Page(bugzilla_driver);
        }

        [Test]
        public void ClickOnFileABug_ToNavigateToLoginPage()
        {
            homePage.ClickOn_FileABug();

            Assert.AreEqual("Bugzilla – Log in to Bugzilla", homePage.GetPAgeTitle());

        }

        [Test]
        public void ClickOnSearchBtn_ToNavigateToBugsList()
        {

            homePage.QuickSearch_Input("Test");
            homePage.ClickOn_Search();

            Assert.AreEqual("Bugzilla – Bug List", homePage.GetPAgeTitle());
        }

        [Test]
        public void ClickToCreateNewAccount()
        {
            homePage.ClickOn_OpenANewAccount();

            Assert.AreEqual("Bugzilla – Create a new Bugzilla account", homePage.GetPAgeTitle());

        }

        [Test]
        public void NavigateToSearchPage()
        {
            homePage.Click_SearchBtn();

            Assert.AreEqual("Bugzilla – Simple Search", homePage.GetPAgeTitle());

        }
    }
}
