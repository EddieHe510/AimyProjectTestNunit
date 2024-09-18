using AimyNunitProject.Drivers;
using AimyOneLoginTest.Drivers;
using Microsoft.VisualBasic.FileIO;
using OpenQA.Selenium;

namespace AimyNunitProject.Components.UserDetailsCompo
{
    public class UserProfile : MainDriver
    {
        private IWebElement accountSettingList => driver.FindElement(By.XPath("//*[@class=\"anticon anticon-user\"]"));
        private IWebElement accountOption => driver.FindElement(By.XPath("//*[contains(text(), \"Account\")]"));
        private IWebElement completeProfileButton => driver.FindElement(By.XPath("//*[contains(text(), \"Complete Profile\")]"));
        // Account Holders
        private IWebElement addNewAHButton => driver.FindElement(By.XPath("//div[2]/div/div/div[1]/div/div[2]/button/span[2][contains(text(), \"Add\")]"));
        private IWebElement aHFirstName => driver.FindElement(By.Id("firstName"));
        private IWebElement aHLastName => driver.FindElement(By.Id("lastName"));
        private IWebElement aHContactEmail => driver.FindElement(By.Id("email"));
        private IWebElement aHGenderMaleOption => driver.FindElement(By.XPath("//*[contains(text(), \"Male\")]"));
        private IWebElement aHMobilePhoneCode => driver.FindElement(By.Id("mobilePhoneNum_countryCode"));
        private IWebElement nzOption => driver.FindElement(By.XPath("//*[contains(text(), \"NZ\")]"));
        private IWebElement aHMobilePhoneNum => driver.FindElement(By.Id("mobilePhoneNum_localPhoneNum"));
        private IWebElement aHBillingAddressButton => driver.FindElement(By.XPath("//*[contains(text(), \"Select Address\")]"));

        // Account Holder Billing Address
        private IWebElement streetAddress => driver.FindElement(By.XPath("//div[2]/div/div/input[@Id=\"address2_streetAddress\"]"));
        private IWebElement suburb => driver.FindElement(By.XPath("//div[2]/div/div/input[@Id=\"address2_suburb\"]"));
        private IWebElement city => driver.FindElement(By.XPath("//div[2]/div/div/input[@Id=\"address2_city\"]"));
        private IWebElement region => driver.FindElement(By.XPath("//div[2]/div/div/input[@Id=\"address2_region\"]"));
        private IWebElement country => driver.FindElement(By.XPath("//div[2]/div/div/input[@Id=\"address2_country\"]"));
        private IWebElement postcode => driver.FindElement(By.XPath("//div[2]/div/div/input[@Id=\"address2_postcode\"]"));
        private IWebElement addressSaveButton => driver.FindElement(By.XPath("//div[3]/button[2]/span[contains(text(), \"Save\")]"));

        private IWebElement contactSaveButton => driver.FindElement(By.XPath("//div[3]/div/button/span[contains(text(), \"Save\")]"));

        public void GoToAccountProfilePage()
        {
            accountSettingList.Click();
            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"Account\")]");
            accountOption.Click();
        }

        public void AddNewAccountHolders(string AHfirstname, string AHlastname, string AHemail, string AHmobilephoneCode, string AHmobilephoneNum, string AHstreet, string AHsuburb, string AHcity, string AHregion, string AHcountry, string AHpostcode)
        {
            //Wait.WaitToBeClickable("XPath", 5, "//div[2]/div/div/div[1]/div/div[2]/button/span[2][contains(text(), \"Add\")]");
            //addNewAHButton.Click();
            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"Complete Profile\")]");
            completeProfileButton.Click();

            Wait.WaitToBeVisible("Id", 5, "firstName");
            aHFirstName.SendKeys(AHfirstname);
            Wait.WaitToBeVisible("Id", 5, "lastName");
            aHLastName.SendKeys(AHlastname);
            Wait.WaitToBeVisible("Id", 5, "email");
            aHContactEmail.SendKeys(AHemail);
            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"Male\")]");
            aHGenderMaleOption.Click();
            Wait.WaitToBeVisible("Id", 5, "mobilePhoneNum_countryCode");
            aHMobilePhoneCode.SendKeys(AHmobilephoneCode);
            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"NZ\")]");
            nzOption.Click();
            Wait.WaitToBeVisible("Id", 5, "mobilePhoneNum_localPhoneNum");
            aHMobilePhoneNum.SendKeys(AHmobilephoneNum);

            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"Select Address\")]");
            aHBillingAddressButton.Click();
            Wait.WaitToBeVisible("XPath", 5, "//div[2]/div/div/input[@Id=\"address2_streetAddress\"]");
            streetAddress.SendKeys(AHstreet);
            suburb.SendKeys(AHsuburb);
            city.SendKeys(AHcity);
            region.SendKeys(AHregion);
            country.SendKeys(AHcountry);
            postcode.SendKeys(AHpostcode);
            Wait.WaitToBeClickable("XPath", 5, "//div[3]/button[2]/span[contains(text(), \"Save\")]");
            addressSaveButton.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[3]/div/button/span[contains(text(), \"Save\")]");
            contactSaveButton.Click();
        }
    }
}
