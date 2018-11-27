using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace OutsideProject2
{
    [Binding]
    [Parallelizable]
 
    public class LoginTrisusSteps : Hooks
    {
        
        public LoginTrisusSteps() : base(BrowserType.Chrome)
        {

        }
        [Given(@"I navigate to Trisus")]
        public void GivenINavigateToTrisus()
        {

        }

        [When(@"I correct credentials")]
        public void WhenICorrectCredentials()
        {
            PageObjects Login = new PageObjects();
            Login.LoginWithCredentials("BAkintunde", "Pa$$word2");
            Thread.Sleep(3000);
        }

        [Then(@"I am logged into Trisus")]
        public void ThenIAmLoggedIntoTrisus()
        {
           // PageObjects Login = new PageObjects(driver);
           // Login.ClickLogin();
            //Login.Logout();

            
            // PropertiesCollection.Driver.Close();
        }
    }
    
}
