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
    public class ABCBookingPage: MainDriver
    {
        private IWebElement firstHolidayProgram => driver.FindElement(By.XPath("//div[4]/div/div[3]/a/div/div[2]/div[2]/div/div/div[1][contains(text(), \"Holiday Program\")]"));

        // Select Attendee Page
        private IWebElement firstAttendee => driver.FindElement(By.XPath("//div[2]/div/div/div[2]/div[1]/div[2]/div/div/div[2][@class=\"pr-1 flex items-center\"]"));
        private IWebElement secondAttendee => driver.FindElement(By.XPath("//div[2]/div[2]/div/div/div[1]/div/div[1]/span[@class=\"ant-avatar ant-avatar-circle ant-avatar-icon css-var-R4da ant-avatar-css-var css-1xwzf41\"]"));
        private IWebElement selectAttendeeSubmitButton => driver.FindElement(By.XPath("//*[contains(text(), \"Submit\")]"));
        private IWebElement selectAttendeeConfirmButton => driver.FindElement(By.XPath("//*[contains(text(), \"Confirm\")]"));
        private IWebElement shoppingCartSubmit => driver.FindElement(By.XPath("//div[2]/button/span[contains(text(), \"Submit\")]"));
        private IWebElement submitBookingButton => driver.FindElement(By.XPath("//button[2]/span[contains(text(), \"Submit\")]"));

        public void selectFirstHolidayProgram()
        {
            Wait.WaitToBeClickable("XPath", 5, "//div[4]/div/div[3]/a/div/div[2]/div[2]/div/div/div[1][contains(text(), \"Holiday Program\")]");
            firstHolidayProgram.Click();
        }

        public void SelectAttendee()
        {
            Wait.WaitToBeClickable("XPath", 5, "//div[2]/div/div/div[2]/div[1]/div[2]/div/div/div[2][@class=\"pr-1 flex items-center\"]");
            firstAttendee.Click();
            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"Submit\")]");
            selectAttendeeSubmitButton.Click();
            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"Confirm\")]");
            selectAttendeeConfirmButton.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[2]/button/span[contains(text(), \"Submit\")]");
            shoppingCartSubmit.Click();
            Wait.WaitToBeClickable("XPath", 5, "//button[2]/span[contains(text(), \"Submit\")]");
            submitBookingButton.Click();
            Thread.Sleep(3000);
        }
    }
}
