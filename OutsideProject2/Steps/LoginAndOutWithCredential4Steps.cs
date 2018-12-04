using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace OutsideProject2
{
    [Binding]
    [Parallelizable]
    public class LoginAndOutWithCredential4Steps
    {
        private readonly IWebDriver _Driver;
        public LoginAndOutWithCredential4Steps(IWebDriver Driver)
        {
            _Driver = Driver;
        }

        [Given(@"I navigate to the Trisus")]
        public void GivenINavigatetoTheTrisus()
        {
            _Driver.Navigate().GoToUrl("https://qa-ui-shell-sgmky.azurewebsites.net/account/login");
            _Driver.Manage().Window.Maximize();
        }
        
        [When(@"Logged Into Trisus")]
        public void WhenLoggedIntoTrisus()
        {
            PageObjects Login = new PageObjects(_Driver);
            Login.LoginWithCredentials("BAkintunde", "Pa$$word2");
         
        }
        
        [When(@"Log Out")]
        public void WhenLogOut()
        {
            PageObjects Logout = new PageObjects(_Driver);
            Logout.ClickLogout();
        }
        
        [Then(@"I am returned to the Login Page")]
        public void ThenIAmReturnedToTheLoginPage()
        {
            PageObjects Login = new PageObjects(_Driver);
            var usernamefield = Login.txtUserName;
            Thread.Sleep(4000);
            Assert.IsTrue(usernamefield.Displayed);

        }
    }
}
