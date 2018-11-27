using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace OutsideProject2
{
    [Binding]
    [Parallelizable]
    public class Credentials2Steps 
    {
        private readonly IWebDriver _Driver;
        public Credentials2Steps(IWebDriver Driver)
        {
            _Driver = Driver;
        }
        [Given(@"I navigate to Tris")]
        public void GivenINavigateToTris()
        {
            _Driver.Navigate().GoToUrl("https://qa-ui-shell-sgmky.azurewebsites.net/account/login");
            _Driver.Manage().Window.Maximize();
        }
        
        [When(@"I correct cred")]
        public void WhenICorrectCred()
        {
            PageObjects Login = new PageObjects(_Driver);
            Login.LoginWithCredentials("BAkintunde", "Pa$$word2");
            Thread.Sleep(3000);


            //PageObjects Login = new PageObjects();
            //Login.LoginWithCredentials("BAkintundes", "Pa$$word2");
            //Thread.Sleep(3000);
        }
        
        [Then(@"I am logged in")]
        public void ThenIAmLoggedIn()
        {

            PageObjects Logout = new PageObjects(_Driver);
            Logout.ClickLogout();
        }
    }
}
