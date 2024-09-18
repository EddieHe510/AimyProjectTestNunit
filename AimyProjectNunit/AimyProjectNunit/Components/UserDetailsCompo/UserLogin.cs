using AimyNunitProject.Drivers;
using AimyOneLoginTest.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AimyNunitProject.Components.LoginConpo
{
    public class UserLogin: MainDriver
    {
        private IWebElement userLoginButton => driver.FindElement(By.XPath("//*[contains(text(), \"Login\")]"));
        private IWebElement username => driver.FindElement(By.Id("Username"));
        private IWebElement password => driver.FindElement(By.Id("Password"));
        private IWebElement loginButton => driver.FindElement(By.XPath("//button[1][contains(text(), \"Login\")]"));

        public void login(string loginUsername, string loginPassword)
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
        }
    }
}
