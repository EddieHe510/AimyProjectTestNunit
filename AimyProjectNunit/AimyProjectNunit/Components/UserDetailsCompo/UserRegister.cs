using AimyNunitProject.Drivers;
using AimyOneLoginTest.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AimyNunitProject.Components.UserDetailsCompo
{
    public class UserRegister: MainDriver
    {
        private IWebElement userLoginButton => driver.FindElement(By.XPath("//*[contains(text(), \"Login\")]"));
        private IWebElement registerButton => driver.FindElement(By.XPath("//*[contains(text(), \"Register\")]"));
        private IWebElement registerEmail => driver.FindElement(By.Id("Email"));
        private IWebElement registerPassword => driver.FindElement(By.Id("Password"));
        private IWebElement registerConfirmPassword => driver.FindElement(By.Id("ConfirmPassword"));
        private IWebElement acceptThePolicy => driver.FindElement(By.Id("AcceptPolicy"));
        private IWebElement registerButtonTwo => driver.FindElement(By.Name("register"));


        public void Register(string RegisterEmail, string RegisterPassword, string RegisterConfirmPassword)
        {
            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"Login\")]");
            userLoginButton.Click();

            // Switch to Login frame
            var handles = driver.WindowHandles;
            driver.SwitchTo().Window(handles.Last());

            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"Register\")]");
            registerButton.Click();

            registerEmail.SendKeys(RegisterEmail);
            registerPassword.SendKeys(RegisterPassword);
            registerConfirmPassword.SendKeys(RegisterConfirmPassword);
            acceptThePolicy.Click();

            Wait.WaitToBeClickable("Name", 5, "register");
            registerButtonTwo.Click();
        }
    }
}
