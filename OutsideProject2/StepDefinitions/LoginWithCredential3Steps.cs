using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace OutsideProject2
{
    [Binding]
    [Parallelizable]
    public class LoginWithCredential3Steps
    {
        private readonly IWebDriver _Driver;
        public LoginWithCredential3Steps(IWebDriver Driver)
        {
            _Driver = Driver;
        }

        [Given(@"I am on Trisus Website")]
        public void GivenIAmOnTrisusWebsite()
        {
            _Driver.Navigate().GoToUrl("https://qa-ui-shell-sgmky.azurewebsites.net/account/login");
            _Driver.Manage().Window.Maximize();
        }
    
        
        [When(@"I enter my credential")]
        public void WhenIEnterMyCredential()
        {
            PageObjects Login = new PageObjects(_Driver);
            Login.LoginWithCredentials("BAkintunde", "Pa$$word13");
         }
        
        [Then(@"I am logged into trisus")]
        public void ThenIAmLoggedIntoTrisus()
        {

            PageObjects Logout = new PageObjects(_Driver);
            Logout.ClickLogout();
           
        }
    }
}
