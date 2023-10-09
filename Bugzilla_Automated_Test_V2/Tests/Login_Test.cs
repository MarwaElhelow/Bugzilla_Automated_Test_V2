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
    [TestFixture]
    internal class Login_Test : Base_Test
    {
        private Login_Page Userlogin;

        [SetUp]
        public void NavigateToLoginPage()
        {
            Userlogin = new Login_Page(bugzilla_driver);
            bugzilla_driver.Navigate().GoToUrl("https://bugs.documentfoundation.org/enter_bug.cgi");
        }

        [Test]
        public void LoginWithInValidCredentials()
        {


            Userlogin.Insert_LgnEmail("Marwa.Yahia.Elhelow@gmail.com");
            Userlogin.Insert_Password("Test123");
            Userlogin.Click_Login();


            Assert.AreEqual("The login or password you entered is not valid.", Userlogin.GetInvalidCredentialsError());
        }

        [Test]
        public void LoginWithValidCredentials()
        {


            Userlogin.Insert_LgnEmail("Marwa.Elhelow@gmail.com");
            Userlogin.Insert_Password("Test1234");
            Userlogin.Click_Login();

            Assert.AreEqual("Bugzilla – Enter Bug", Userlogin.GetCreateBugPage());
        }
    }
}
