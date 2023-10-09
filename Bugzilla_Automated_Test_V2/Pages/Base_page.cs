using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bugzilla_Test_Scripts.pages
{
    public class Base_page
    {
        //Declare pages Driver
        protected IWebDriver Bugzilla_driver;


        //initialize the driver with this Constructor
        public Base_page(IWebDriver bugZilla_driver)
        {
            this.Bugzilla_driver = bugZilla_driver;
        }

        //Common elements
        protected By page_Title = By.Id("title");






        //Common and custom functions that are being used across all pages
        public IWebElement FindMyElement(By myElement)
        {
            IWebElement myWebElement = Bugzilla_driver.FindElement(myElement);
            return myWebElement;
        }

        public void ClickOn(By ClickableElement)
        {
            Bugzilla_driver.FindElement(ClickableElement).Click();
        }

        public void InsertText(By Text_Element, string text)
        {
            Bugzilla_driver.FindElement(Text_Element).SendKeys(text);
        }


        public void WaitElementToBeDisplayed(By WaitElement, int time)
        {
            WebDriverWait wait = new WebDriverWait(Bugzilla_driver, TimeSpan.FromSeconds(10));

        }

        public string GetPAgeTitle()
        {
            WebDriverWait wait = new WebDriverWait(Bugzilla_driver, TimeSpan.FromSeconds(20));
            string txt = FindMyElement(page_Title).Text;
            return txt;

        }


    }
}
