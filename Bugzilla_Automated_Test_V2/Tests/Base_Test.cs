using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Bugzilla_Test_Scripts.Tests
{
    public class Base_Test
    {
        protected IWebDriver bugzilla_driver;

        [SetUp]
        public void Setup()
        {
            // Initialize the WebDriver
            bugzilla_driver = new ChromeDriver();
            bugzilla_driver.Manage().Window.Maximize();

        }

        [TearDown]
        public void Teardown()
        {
            // Quit the WebDriver
            bugzilla_driver.Quit();
        }
    }
}
