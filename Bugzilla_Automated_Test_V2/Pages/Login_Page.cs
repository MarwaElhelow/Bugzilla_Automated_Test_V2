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
    public class Login_Page : Base_page
    {

        public Login_Page(IWebDriver driver) : base(driver)
        {
        }

        //Elements located on Login page
        //private IWebElement Lgn_btn => Bugzilla_driver.FindElement(By.Name("GoAheadAndLogIn"));

        private By Lgn_Email_Box = By.Id("Bugzilla_login");
        private By Lgn_Password_box => By.Id("Bugzilla_password");

        private By Lgn_btn = By.Name("GoAheadAndLogIn");
        private By Invalid_Credentials_message = By.Id("error_msg");



        //Actions can be performed on Login page


        public void Insert_LgnEmail(string Lgn_email)
        {
            FindMyElement(Lgn_Email_Box);
            InsertText(Lgn_Email_Box, Lgn_email);

        }

        public void Insert_Password(string Lgn_Password)
        {
            FindMyElement(Lgn_Password_box);
            InsertText(Lgn_Password_box, Lgn_Password);
        }

        public void Click_Login()
        {
            FindMyElement(Lgn_btn);
            ClickOn(Lgn_btn);

        }

        public string GetInvalidCredentialsError()
        {
            WebDriverWait wait = new WebDriverWait(Bugzilla_driver, TimeSpan.FromSeconds(20));
            string txt = FindMyElement(Invalid_Credentials_message).Text;
            return txt;
        }

        public string GetCreateBugPage()
        {
            WebDriverWait wait = new WebDriverWait(Bugzilla_driver, TimeSpan.FromSeconds(20));
            string txt = FindMyElement(page_Title).Text;
            return txt;
        }
    }
}
