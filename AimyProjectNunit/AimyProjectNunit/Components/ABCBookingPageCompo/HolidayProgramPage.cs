using AimyNunitProject.Drivers;
using AimyOneLoginTest.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AimyProjectNunit.Components.ABCBookingPageCompo
{
    public class HolidayProgramPage: MainDriver
    {
        private IWebElement canvasPainting => driver.FindElement(By.XPath("//div[1]/div[2]/div/div/div[2]/div[3]/div/div/div/div[1]/div[1][contains(text(), \"School Day\")]"));
        private IWebElement forrestHike => driver.FindElement(By.XPath("//div[2]/div[2]/div/div/div[2]/div[2]/div/div/div/div[1]/div[1][contains(text(), \"Early Drop Off\")]"));
        private IWebElement pizzaParty => driver.FindElement(By.XPath("//div[3]/div[2]/div/div/div[2]/div[4]/div/div/div/div[1]/div[1][contains(text(), \"Late Pick Up\")]"));
        private IWebElement bullseye => driver.FindElement(By.XPath("//div[4]/div[2]/div/div/div[2]/div[2]/div/div/div/div[1]/div[1][contains(text(), \"Early Drop Off\")]"));
        private IWebElement wheelsDay => driver.FindElement(By.XPath("//div[5]/div[2]/div/div/div[2]/div[3]/div/div/div/div[1]/div[1][contains(text(), \"School Day\")]"));
        private IWebElement busTripToTheZoo => driver.FindElement(By.XPath("//div[6]/div[2]/div/div/div[2]/div[2]/div/div/div/div[1]/div[1][contains(text(), \"Early Drop Off\")]"));
        private IWebElement beachDay => driver.FindElement(By.XPath("//div[7]/div[2]/div/div/div[2]/div[2]/div/div/div/div[1]/div[1][contains(text(), \"Early Drop Off\")]"));
        private IWebElement saveTheEgg => driver.FindElement(By.XPath("//div[8]/div[2]/div/div/div[2]/div[3]/div/div/div/div[1]/div[1][contains(text(), \"School Day\")]"));
        private IWebElement monopolyChamps => driver.FindElement(By.XPath("//div[9]/div[2]/div/div/div[2]/div[3]/div/div/div/div[1]/div[1][contains(text(), \"School Day\")]"));
        private IWebElement superheroDay => driver.FindElement(By.XPath("//div[10]/div[2]/div/div/div[2]/div[2]/div/div/div/div[1]/div[1][contains(text(), \"School Day\")]"));
        private IWebElement agreementCheckBox => driver.FindElement(By.XPath("//*[@class=\"ant-checkbox ant-wave-target css-1xwzf41\"]"));
        private IWebElement nextButton => driver.FindElement(By.XPath("//div[2]/div[2]/div/div[2]/button[@class=\"ant-btn css-1xwzf41 css-var-r3 ant-btn-primary\"]"));
        private IWebElement userLoginButton => driver.FindElement(By.XPath("//*[contains(text(), \"Login\")]"));
        private IWebElement username => driver.FindElement(By.Id("Username"));
        private IWebElement password => driver.FindElement(By.Id("Password"));
        private IWebElement loginButton => driver.FindElement(By.XPath("//button[1][contains(text(), \"Login\")]"));

        public void ABClogin(string loginUsername, string loginPassword)
        {
            // Save the original window
            string originalWindow = driver.CurrentWindowHandle;

            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"Login\")]");
            userLoginButton.Click();

            // Switch to Login frame
            var handles = driver.WindowHandles;
            driver.SwitchTo().Window(handles.Last());

            Wait.WaitToBeVisible("Id", 5, "Username");
            username.SendKeys(loginUsername);
            Wait.WaitToBeVisible("Id", 5, "Password");
            password.SendKeys(loginPassword);
            Wait.WaitToBeClickable("XPath", 5, "//button[1][contains(text(), \"Login\")]");
            loginButton.Click();
            driver.SwitchTo().Window(originalWindow);
            Wait.WaitToBeClickable("XPath", 5, "//div[2]/div[2]/div/div[2]/button[@class=\"ant-btn css-1xwzf41 css-var-r3 ant-btn-primary\"]");
            nextButton.Click();
        }

        public void SelectPrograms()
        {
            Thread.Sleep(1000);
            Wait.WaitToBeClickable("XPath", 5, "//div[1]/div[2]/div/div/div[2]/div[3]/div/div/div/div[1]/div[1][contains(text(), \"School Day\")]");
            canvasPainting.Click();
            Thread.Sleep(1000);
            Wait.WaitToBeClickable("XPath", 5, "//div[2]/div[2]/div/div/div[2]/div[2]/div/div/div/div[1]/div[1][contains(text(), \"Early Drop Off\")]");
            forrestHike.Click();
            Thread.Sleep(1000);
            Wait.WaitToBeClickable("XPath", 5, "//div[3]/div[2]/div/div/div[2]/div[4]/div/div/div/div[1]/div[1][contains(text(), \"Late Pick Up\")]");
            pizzaParty.Click();
            Thread.Sleep(1000);
            Wait.WaitToBeClickable("XPath", 5, "//div[4]/div[2]/div/div/div[2]/div[2]/div/div/div/div[1]/div[1][contains(text(), \"Early Drop Off\")]");
            bullseye.Click();
            Thread.Sleep(1000);
            Wait.WaitToBeClickable("XPath", 5, "//div[5]/div[2]/div/div/div[2]/div[3]/div/div/div/div[1]/div[1][contains(text(), \"School Day\")]");
            wheelsDay.Click();
            Thread.Sleep(1000);
            Wait.WaitToBeClickable("XPath", 5, "//div[6]/div[2]/div/div/div[2]/div[2]/div/div/div/div[1]/div[1][contains(text(), \"Early Drop Off\")]");
            busTripToTheZoo.Click();
            Thread.Sleep(1000);
            Wait.WaitToBeClickable("XPath", 5, "//div[7]/div[2]/div/div/div[2]/div[2]/div/div/div/div[1]/div[1][contains(text(), \"Early Drop Off\")]");
            beachDay.Click();
            Thread.Sleep(1000);
            Wait.WaitToBeClickable("XPath", 5, "//div[8]/div[2]/div/div/div[2]/div[3]/div/div/div/div[1]/div[1][contains(text(), \"School Day\")]");
            saveTheEgg.Click();
            Thread.Sleep(1000);
            Wait.WaitToBeClickable("XPath", 5, "//div[9]/div[2]/div/div/div[2]/div[3]/div/div/div/div[1]/div[1][contains(text(), \"School Day\")]");
            monopolyChamps.Click();
            Thread.Sleep(1000);
            Wait.WaitToBeClickable("XPath", 5, "//div[10]/div[2]/div/div/div[2]/div[2]/div/div/div/div[1]/div[1][contains(text(), \"School Day\")]");
            superheroDay.Click();
            Thread.Sleep(1000);
            Wait.WaitToBeClickable("XPath", 5, "//*[@class=\"ant-checkbox ant-wave-target css-1xwzf41\"]");
            agreementCheckBox.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[2]/div[2]/div/div[2]/button[@class=\"ant-btn css-1xwzf41 css-var-r3 ant-btn-primary\"]");
            nextButton.Click();
        }
    }
}
