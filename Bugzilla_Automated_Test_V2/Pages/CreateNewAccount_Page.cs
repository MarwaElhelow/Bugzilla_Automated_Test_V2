using Bugzilla_Test_Scripts.pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Bugzilla_Test_Scripts.pages
{
    public class CreateNewAccount_Page : Base_page
    {
        public CreateNewAccount_Page(IWebDriver driver) : base(driver)
        {

        }

        //Elements Located on New Account page
        private By Email_TextBox = By.CssSelector("#login");
        private By Send_btn = By.Id("send");



        //Methods performed on New Account Page
        public void Enter_Valid_Email(string email)
        {
            FindMyElement(Email_TextBox);
            InsertText(Email_TextBox, email);

        }
        public void Click_Send()
        {
            FindMyElement(Send_btn);
            ClickOn(Send_btn);
        }


        public bool IsNewAccountDisplayed()
        {
            // Custom wait using a combination of ExpectedConditions and WebDriverWait loop
            bool isNewAccDisplayed = false;
            DateTime startTime = DateTime.Now;
            TimeSpan timeout = TimeSpan.FromSeconds(30);

            while (!isNewAccDisplayed && DateTime.Now - startTime < timeout)
            {
                try
                {
                    // Check if the element is present on the destination page
                    IWebElement destinationElement = Bugzilla_driver.FindElement(By.XPath("//*[@id=\"title\"]"));

                    if (destinationElement.Displayed)
                    {
                        isNewAccDisplayed = true;
                    }

                }
                catch (NoSuchElementException)
                {
                    // Element not found, continue waiting
                }
            }

            return isNewAccDisplayed;

        }

    }
}
