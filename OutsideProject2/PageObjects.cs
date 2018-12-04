using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace OutsideProject2
{
    class PageObjects 
    {
        private readonly IWebDriver _Driver;
        public PageObjects(IWebDriver Driver)
        {
            _Driver = Driver;
            PageFactory.InitElements(Driver, this);
        }

 

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement Submit { get; set; }


        [FindsBy(How = How.XPath, Using = "//li[@class='dropdown']//a[@class='dropdown-toggle admin-toggle']")]
        private IWebElement UserMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[@class='dropdown open']//li[@class='ng-isolate-scope']/a")]
        private IWebElement LogoutButton { get; set; }

        public void LoginWithCredentials(string username, string password)
        {

            txtUserName.SendKeys(username);
            txtPassword.SendKeys(password);
            ClickLogin();
            //WaitForLoginButton();
            //return new PageObjects();
        }

        public void ClickLogin()
        {
            Submit.Click();
        }

        public void ClickLogout()
        {

            WebDriverWait wait = new WebDriverWait(_Driver, TimeSpan.FromSeconds(5));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[@class='dropdown']//a[@class='dropdown-toggle admin-toggle']")));
            UserMenu.Click();
            LogoutButton.Click();
        }

        public void Waitfor()
        {

            WebDriverWait wait = new WebDriverWait(_Driver, TimeSpan.FromSeconds(5));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("username")));

            UserMenu.Click();
            LogoutButton.Click();
        }
    }
}
