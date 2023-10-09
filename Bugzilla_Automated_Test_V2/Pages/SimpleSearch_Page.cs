using Bugzilla_Test_Scripts.pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace Automated_Bugzilla_Test.Pages_To_Be_Tested
{
    public class SimpleSearch_Page : Base_page
    {
        private readonly IWebDriver driver;

        public SimpleSearch_Page(IWebDriver driver) : base(driver)
        {

        }

        //Elements on Simple search page
        private By Status_DDL = By.Id("bug_status");
        private By Product_DDL = By.Id("product");
        private By WordField = By.Id("content");
        private By search_Button = By.Id("search");



        //Methods performed on simple search page
        public void SelectStatus(int statusIndex)
        {
            // Implement the logic to select from dropdown option

            SelectElement statusDropdown = new SelectElement(FindMyElement(Status_DDL));
            statusDropdown.SelectByIndex(statusIndex);

        }

        public void SelectProduct(int productIndex)
        {
            SelectElement productDropdown = new SelectElement(FindMyElement(Product_DDL));
            productDropdown.SelectByIndex(productIndex);
        }

        public void InsertWords(string words)
        {
            IWebElement wordsField = FindMyElement(WordField);
            InsertText(WordField, words);

        }

        public void ClickSearchButton()
        {
            IWebElement searchButton = FindMyElement(search_Button);
            ClickOn(search_Button);
        }

        public IReadOnlyCollection<IWebElement> GetStatusCells()
        {
            // Wait for the status cells to be present on the page
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(0.5));
            wait.Until(Bugzilla_driver => Bugzilla_driver.FindElements(By.XPath("//td[@class='bz_bug_status_column']")).Count > 0);


            // Find all the cells in the status column
            return Bugzilla_driver.FindElements(By.XPath("//td[@class='bz_bug_status_column']"));
        }
    }
}