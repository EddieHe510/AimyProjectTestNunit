using AimyNunitProject.Drivers;
using AimyOneLoginTest.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AimyNunitProject.Components.WVPBookingPageCompo
{
    public class WVPBookingPage: MainDriver
    {
        // Programs List
        private IWebElement programsList => driver.FindElement(By.XPath("//div[1]/div[1]/div/div[@class=\"ant-select-selection-overflow\"]"));
        private IWebElement beforeSchoolOption => driver.FindElement(By.XPath("//*[contains(text(), \"Before School Program\")]"));
        private IWebElement afterSchoolOption => driver.FindElement(By.XPath("//*[contains(text(), \"After School Program\")]"));
        
        // Day of Week List
        private IWebElement dayOfWeekList => driver.FindElement(By.XPath("//div[1]/div[2]/div/div[@class=\"ant-select-selection-overflow\"]"));
        private IWebElement monOption => driver.FindElement(By.XPath("//div[1]/div[contains(text(), \"Mon\")]"));
        private IWebElement tueOption => driver.FindElement(By.XPath("//*[contains(text(), \"Tue\")]"));
        private IWebElement wedOption => driver.FindElement(By.XPath("//*[contains(text(), \"Wed\")]"));
        private IWebElement ThuOption => driver.FindElement(By.XPath("//*[contains(text(), \"Thu\")]"));
        private IWebElement FriOption => driver.FindElement(By.XPath("//*[contains(text(), \"Fri\")]"));

        // Programs
        private IWebElement termOneProgram => driver.FindElement(By.XPath("//*[contains(text(), \"Term 1 2024\")]"));


        // Select Attendee Page
        private IWebElement firstAttendee => driver.FindElement(By.XPath("//div[1]/div[2]/div/div/div[1]/div/div[1]/span[@class=\"ant-avatar ant-avatar-circle ant-avatar-icon css-var-R4da ant-avatar-css-var css-1xwzf41\"]"));
        private IWebElement secondAttendee => driver.FindElement(By.XPath("//div[2]/div[2]/div/div/div[1]/div/div[1]/span[@class=\"ant-avatar ant-avatar-circle ant-avatar-icon css-var-R4da ant-avatar-css-var css-1xwzf41\"]"));
        private IWebElement selectAttendeeSubmitButton => driver.FindElement(By.XPath("//*[contains(text(), \"Submit\")]"));
        private IWebElement selectAttendeeConfirmButton => driver.FindElement(By.XPath("//*[contains(text(), \"Confirm\")]"));

        public void SelectTermOneProgram()
        {
            Wait.WaitToBeClickable("XPath", 5, "//div[1]/div[1]/div/div[@class=\"ant-select-selection-overflow\"]");
            programsList.Click();
            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"Before School Program\")]");
            beforeSchoolOption.Click();

            Wait.WaitToBeClickable("XPath", 5, "//div[1]/div[2]/div/div[@class=\"ant-select-selection-overflow\"]");
            dayOfWeekList.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[1]/div[contains(text(), \"Mon\")]");
            monOption.Click();

            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"Term 1 2024\")]");
            termOneProgram.Click();
        }


        public void SelectAttendee()
        {
            Wait.WaitToBeClickable("XPath", 5, "//div[1]/div[2]/div/div/div[1]/div/div[1]/span[@class=\"ant-avatar ant-avatar-circle ant-avatar-icon css-var-R4da ant-avatar-css-var css-1xwzf41\"]");
            firstAttendee.Click();
            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"Submit\")]");
            selectAttendeeSubmitButton.Click();
            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"Confirm\")]");
            selectAttendeeConfirmButton.Click();
        }
    }
}