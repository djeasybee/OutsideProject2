using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace OutsideProject2
{
    
    public enum BrowserType
    {
        Chrome,
        Firefox,
        IE
    }
    [Binding]
    public class Hooks 
    {
        private readonly IObjectContainer _objectContainer;


        //private BrowserType _browserType;
        //public Hooks(BrowserType browser)
        //{
        //    _browserType = browser;
        //}



        private IWebDriver _driver;
        
         public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

   

        private void ChooseDriverInstance(BrowserType browserType)
        {
            if (browserType == BrowserType.Chrome)
            _driver = new ChromeDriver();

            else if (browserType == BrowserType.Firefox)
                _driver = new FirefoxDriver();
        }

  
        [BeforeScenario]
        public void InitializeTest()
        {

            // ChooseDriverInstance(_browserType);
           //_driver = new ChromeDriver();
            var options = new ChromeOptions(); options.AddArguments("incognito", "testFileNameTemplate", "myID_{browser}_{testStatus}");
            _driver = new RemoteWebDriver(
               new Uri("http://localhost:4444/wd/hub"), options);

            _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
                      
        }

        [AfterScenario]

        public void CleanUp()
        {
            _driver.Quit();
        }
          

    }
}
