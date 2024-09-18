using AimyNunitProject.Drivers;
using AimyOneLoginTest.Drivers;
using OpenQA.Selenium;

namespace AimyNunitProject.Components.WVPBookingPageCompo
{
    public class TermOnePrograms : MainDriver
    {
        private IWebElement regularBookingOption => driver.FindElement(By.XPath("//*[contains(text(), \"Regular Booking\")]"));
        private IWebElement casualBookingOption => driver.FindElement(By.XPath("//*[contains(text(), \"Casual Booking\")]"));

        // Booking Range
        // Start Date
        private IWebElement startDate => driver.FindElement(By.XPath("//*[@placeholder=\"Start Date\"]"));
        private IWebElement thirdtyOption => driver.FindElement(By.XPath("//tr[5]/td[3]/div[contains(text(), \"30\")]"));
        // End Date
        private IWebElement endDate => driver.FindElement(By.XPath("//*[@placeholder=\"End Date\"]"));
        private IWebElement threeOption => driver.FindElement(By.XPath("//div[3]/div/div/div/div/div[1]/div/div[2]/table/tbody/tr[1]/td[4]/div[contains(text(), \"3\")]"));
        // Time table
        private IWebElement SevenToNineAMWed => driver.FindElement(By.XPath("//tr[1]/td[4]/div/label/span[@class=\"ant-checkbox ant-wave-target css-1xwzf41\"]"));
        private IWebElement agreementButton => driver.FindElement(By.XPath("//div[3]/div[2]/div[2]/div/div[1]/label/span[1][@class=\"ant-checkbox ant-wave-target css-1xwzf41\"]"));
        private IWebElement bookingNextButton => driver.FindElement(By.XPath("//*[contains(text(), \"Next\")]"));

        public void RegularBooking()
        {
            Wait.WaitToBeClickable("XPath", 5, "//*[@placeholder=\"Start Date\"]");
            startDate.Click();
            Wait.WaitToBeClickable("XPath", 5, "//tr[5]/td[3]/div[contains(text(), \"30\")]");
            thirdtyOption.Click();
            Wait.WaitToBeClickable("XPath", 5, "//*[@placeholder=\"End Date\"]");
            endDate.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[3]/div/div/div/div/div[1]/div/div[2]/table/tbody/tr[1]/td[4]/div[contains(text(), \"3\")]");
            threeOption.Click();
            Wait.WaitToBeClickable("XPath", 5, "//tr[1]/td[4]/div/label/span[@class=\"ant-checkbox ant-wave-target css-1xwzf41\"]");
            SevenToNineAMWed.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[3]/div[2]/div[2]/div/div[1]/label/span[1][@class=\"ant-checkbox ant-wave-target css-1xwzf41\"]");
            agreementButton.Click();
            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"Next\")]");
            bookingNextButton.Click();
        }

        public void CasualBokking()
        {
            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"Casual Booking\")]");
            casualBookingOption.Click();
            Wait.WaitToBeClickable("XPath", 5, "//*[@placeholder=\"Start Date\"]");
            startDate.Click();
            Wait.WaitToBeClickable("XPath", 5, "//tr[5]/td[3]/div[contains(text(), \"30\")]");
            thirdtyOption.Click();
            Wait.WaitToBeClickable("XPath", 5, "//*[@placeholder=\"End Date\"]");
            endDate.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[3]/div/div/div/div/div[1]/div/div[2]/table/tbody/tr[1]/td[4]/div[contains(text(), \"3\")]");
            threeOption.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[1]/table/tbody/tr[1]/td[4]/div/label/span/input[@type=\"checkbox\"]");
            SevenToNineAMWed.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[2]/div/div[1]/label/span[1]/input[@type=\"checkbox\"]");
            agreementButton.Click();
            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"Next\")]");
            bookingNextButton.Click();
        }
    }
}
