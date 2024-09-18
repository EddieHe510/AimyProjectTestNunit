using AimyNunitProject.Drivers;
using AimyOneLoginTest.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AimyNunitProject.Components.HomePageCompo
{
    public class HomePage: MainDriver
    {
        private IWebElement visitWebsiteButton => driver.FindElement(By.XPath("//*[contains(text(), \"Visit Website\")]"));
        private IWebElement wvpBookNowButton => driver.FindElement(By.XPath("//div[1]/div/div/div[2]/button[2]/span[contains(text(), \"Book Now\")]"));
        private IWebElement abcBookNowButton => driver.FindElement(By.XPath("//div[2]/div/div/div[2]/button[2]/span[contains(text(), \"Book Now\")]"));
   
        public void goToWVPBookingPage()
        {
            Wait.WaitToBeClickable("XPath", 5, "//div[1]/div/div/div[2]/button[2]/span[contains(text(), \"Book Now\")]");
            wvpBookNowButton.Click();
        }

        public void goToABCBookingPage()
        {
            Wait.WaitToBeClickable("XPath", 5, "//div[2]/div/div/div[2]/button[2]/span[contains(text(), \"Book Now\")]");
            abcBookNowButton.Click();
        }
    
    }
}