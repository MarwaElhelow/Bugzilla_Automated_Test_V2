using Bugzilla_Test_Scripts.pages;
using Bugzilla_Test_Scripts.Tests;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bugzilla_Test_Scripts.Tests
{
    public class CreateNewAccount_Tests : Base_Test
    {
        private CreateNewAccount_Page NewAccount;


        [SetUp]
        public void NewAccount_setUp()
        {
            NewAccount = new CreateNewAccount_Page(bugzilla_driver);
            bugzilla_driver.Navigate().GoToUrl("https://bugs.documentfoundation.org/createaccount.cgi");
        }

        [Test]
        public void CreateNewAccount_Test()
        {
            NewAccount.Enter_Valid_Email("Marwa.yahia.Hassan@gmail.com");
            NewAccount.Click_Send();

            bool isNewAccDisplayed = NewAccount.IsNewAccountDisplayed();

            Assert.IsTrue(isNewAccDisplayed);
        }
    }
}
