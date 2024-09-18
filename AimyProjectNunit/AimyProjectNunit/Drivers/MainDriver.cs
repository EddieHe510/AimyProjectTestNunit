using AimyOneLoginTest.Drivers;
using AventStack.ExtentReports.Model;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AimyNunitProject.Drivers
{
    [TestFixture]
    public class MainDriver
    {
        public static IWebDriver driver;
        protected Broswer broswer;

        [SetUp]
        public void LaunchTheBrowser()
        {
            Reporter.ReportingCreateTest(TestContext.CurrentContext.Test.MethodName);

            // Headless browser mode
            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--headless");
            //driver = new ChromeDriver(options);


            string testBrowser = GetBrowserFromConfig();
            switch (testBrowser.ToLower())
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                case "firefox":
                    driver = new FirefoxDriver();
                    break;
                case "edge":
                    driver = new EdgeDriver();
                    break;
                default:
                    break;
            }

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://sandbox-me.aimyone.com/ireland-demo");

            broswer = new Broswer(driver);
        }

        [TearDown]
        public void CloseTheBroswer()
        {
            DriverEndTest();
            Reporter.ReportingEndRepoting();
            driver.Quit();

        }

        private string GetBrowserFromConfig()
        {
            return "chrome";
        }

        private void DriverEndTest()
        {
            var testStatus = TestContext.CurrentContext.Result.Outcome.Status;
            var message = TestContext.CurrentContext.Result.Message;

            switch (testStatus)
            {
                case TestStatus.Failed:
                    Reporter.ReportingLogFail($"Test has failed {message}");
                    break;

                case TestStatus.Skipped:
                    Reporter.ReportingLogInfo($"Test skipped {message}");
                    break;

                default:
                    break;
            }

            Reporter.ReportingLogScreenShot("Ending test", broswer.GetBrowserFromConfig());
        }
    }
}
