using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace OutsideProject2
{
    [Binding]
    [Parallelizable]
    public class LoginTrisusSteps
    {


        private readonly IWebDriver _Driver;
        public LoginTrisusSteps(IWebDriver Driver)
        {
            _Driver = Driver;
        }


        [Given(@"I navigate to Trisus")]
        public void GivenINavigateToTrisus()
        {
            _Driver.Navigate().GoToUrl("https://qa-ui-shell-sgmky.azurewebsites.net/account/login");
            _Driver.Manage().Window.Maximize();
        }


        [When(@"I enter correct credentials")]
        public void WhenIEnterCorrectCredentials()
        {
           
            PageObjects Login = new PageObjects(_Driver);
            Login.LoginWithCredentials("BAkintunde", "Pa$$word13");
            Thread.Sleep(3000);
        }
        
        [Then(@"I am logged into Trisus")]
        public void ThenIAmLoggedIntoTrisus()
        {
            PageObjects Logout = new PageObjects(_Driver);
            Logout.ClickLogout();
        }
    }
}


