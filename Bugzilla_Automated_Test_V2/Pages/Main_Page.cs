using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bugzilla_Test_Scripts.pages
{
    public class Main_Page : Base_page
    {
        public Main_Page(IWebDriver driver) : base(driver)
        {
        }
        //Elements on Main Page
        private By FileABug = By.LinkText("File a Bug");
        private By QuickSearch_TxtBox = By.Id("quicksearch_main");
        private By QuickSearch_btn = By.Id("find");
        private By Open_AnewAccount = By.LinkText("Open a New Account");
        private By Search_Icon = By.Id("query");
        private By FileABug_title = By.CssSelector("#title");



        //Methods to interact with the elements


        public void ClickOn_FileABug()
        {
            FindMyElement(FileABug);
            ClickOn(FileABug);
        }

        public void QuickSearch_Input(string input)
        {
            FindMyElement(QuickSearch_TxtBox);
            InsertText(QuickSearch_TxtBox, input);

        }

        public void ClickOn_Search()
        {
            FindMyElement(QuickSearch_btn);
            ClickOn(QuickSearch_btn);
        }

        public void ClickOn_OpenANewAccount()
        {
            FindMyElement(Open_AnewAccount);
            ClickOn(Open_AnewAccount);
        }

        public void Click_SearchBtn()
        {
            FindMyElement(Search_Icon);
            ClickOn(Search_Icon);
        }

        public string GetPAgeTitle()
        {
            WebDriverWait wait = new WebDriverWait(Bugzilla_driver, TimeSpan.FromSeconds(20));
            string txt = FindMyElement(page_Title).Text;
            return txt;

        }

    }
}
