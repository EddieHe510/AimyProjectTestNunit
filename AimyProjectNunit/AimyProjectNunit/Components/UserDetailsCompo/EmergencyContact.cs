using AimyNunitProject.Drivers;
using AimyOneLoginTest.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Xml.Linq;
using static MongoDB.Bson.Serialization.Serializers.SerializerHelper;

namespace AimyNunitProject.Components.UserDetailsCompo
{
    public class EmergencyContact : MainDriver
    {
        // Emergency Contacts
        private IWebElement addNewEC => driver.FindElement(By.XPath("//div[4]/div/div/div[1]/div/div[2]/button/span[2][contains(text(), \"Add\")]"));
        private IWebElement newContactButton => driver.FindElement(By.XPath("//div[2]/div[2]/div/button/span[2][contains(text(), \"New Contact\")]"));
        private IWebElement contactsButton => driver.FindElement(By.XPath("//*[contains(text(), \"Contacts\")]"));
        
        private IWebElement ecFirstName => driver.FindElement(By.XPath("//div[5]/div/div[2]/div/div/input[@id=\"firstName\"]"));
        private IWebElement ecLastName => driver.FindElement(By.XPath("//div[7]/div/div[2]/div/div/input[@id=\"lastName\"]"));

        private IWebElement ecContactEmail => driver.FindElement(By.XPath("//div[8]/div/div[2]/div/div/div/input[@id=\"email\"]"));
        private IWebElement ecGenderFemaleOption => driver.FindElement(By.XPath("//div[9]/div/div[2]/div/div/div/label[1]/span[2][contains(text(), \"Female\")]"));
        private IWebElement ecMobilePhoneCode => driver.FindElement(By.XPath("//div[10]/div/div[2]/div/div/div/div/div/span[1]/input[@id=\"mobilePhoneNum_countryCode\"]"));
        private IWebElement nzOption => driver.FindElement(By.XPath("//*[contains(text(), \"NZ\")]"));
        private IWebElement ecMobilePhoneNum => driver.FindElement(By.XPath("//div[10]/div/div[2]/div/div/div/input[@id=\"mobilePhoneNum_localPhoneNum\"]"));
        
        // Emergency Contact Billing Address
        private IWebElement ecBillingAddressButton => driver.FindElement(By.XPath("//*[contains(text(), \"Select Address\")]"));
        private IWebElement ecStreetAddress => driver.FindElement(By.XPath("//div[2]/div/div/input[@Id=\"address2_streetAddress\"]"));
        private IWebElement ecSuburb => driver.FindElement(By.XPath("//div[2]/div/div/input[@Id=\"address2_suburb\"]"));
        private IWebElement ecCity => driver.FindElement(By.XPath("//div[2]/div/div/input[@Id=\"address2_city\"]"));
        private IWebElement ecRegion => driver.FindElement(By.XPath("//div[2]/div/div/input[@Id=\"address2_region\"]"));
        private IWebElement ecCountry => driver.FindElement(By.XPath("//div[2]/div/div/input[@Id=\"address2_country\"]"));
        private IWebElement ecPostcode => driver.FindElement(By.XPath("//div[2]/div/div/input[@Id=\"address2_postcode\"]"));
        private IWebElement ecAddressSaveButton => driver.FindElement(By.XPath("//div[3]/button[2]/span[contains(text(), \"Save\")]"));
        private IWebElement ecInfoSaveButton => driver.FindElement(By.XPath("//div[3]/div/div[3]/div/button/span[contains(text(), \"Save\")]"));
        private IWebElement ecOKbutton => driver.FindElement(By.XPath("//div[3]/div/button/span[contains(text(), \"OK\")]"));

        // Emergency Contact Switch
        private IWebElement firstECRelationship => driver.FindElement(By.XPath("//div[1]/div/div[2]/div/div[1]/div[4]/div/div[2]/div[@class=\"ant-form-item-control-input\"]"));
        private IWebElement parentOption => driver.FindElement(By.XPath("//div[2]/div/div/div/div[1]/div[contains(text(), \"Parent\")]"));
        private IWebElement firstSaveButton => driver.FindElement(By.XPath("//div[1]/div/div[2]/div/div[2]/button/span[contains(text(), \"Save\")]"));
        private IWebElement secondECswitch => driver.FindElement(By.XPath("//div[2]/div/div[1]/div/div[2][@class=\"ant-card-extra\"]"));
        private IWebElement secondECType => driver.FindElement(By.XPath("//div[2]/div/div[2]/div/div[1]/div[3]/div/div[2]/div[@class=\"ant-form-item-control-input\"]"));
        private IWebElement ecOption => driver.FindElement(By.XPath("//div[2]/div/div/div/div[2]/div[contains(text(), \"Emergency Contact\")]"));
        private IWebElement secondECRelationship => driver.FindElement(By.XPath("//div[2]/div/div[2]/div/div[1]/div[4]/div/div[2]/div[@class=\"ant-form-item-control-input\"]"));
        private IWebElement secondECsaveButton => driver.FindElement(By.XPath("//div/div[1]/div/div[2]/div/div[2]/button/span[contains(text(), \"Save\")]"));
        private IWebElement okButton => driver.FindElement(By.XPath("//div[3]/div/button/span[contains(text(), \"OK\")]"));


        public void AddNewEmergencyContacts(string ECfirstname, string EClastname, string ECemail, string ECmobilephoneCode, string ECmobilephoneNum, string ECstreet, string ECsuburb, string ECcity, string ECregion, string ECcountry, string ECpostcode)
        {
            Wait.WaitToBeClickable("XPath", 5, "//div[4]/div/div/div[1]/div/div[2]/button/span[2][contains(text(), \"Add\")]");
            addNewEC.Click();

            Wait.WaitToBeVisible("XPath", 5, "//div[5]/div/div[2]/div/div/input[@id=\"firstName\"]");
            ecFirstName.SendKeys(ECfirstname);
            Wait.WaitToBeVisible("XPath", 5, "//div[7]/div/div[2]/div/div/input[@id=\"lastName\"]");
            ecLastName.SendKeys(EClastname);
            Wait.WaitToBeVisible("XPath", 5, "//div[8]/div/div[2]/div/div/div/input[@id=\"email\"]");
            ecContactEmail.SendKeys(ECemail);

            Wait.WaitToBeClickable("XPath", 5, "//div[9]/div/div[2]/div/div/div/label[1]/span[2][contains(text(), \"Female\")]");
            ecGenderFemaleOption.Click();

            Wait.WaitToBeVisible("XPath", 5, "//div[10]/div/div[2]/div/div/div/div/div/span[1]/input[@id=\"mobilePhoneNum_countryCode\"]");
            ecMobilePhoneCode.SendKeys(ECmobilephoneCode);
            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"NZ\")]");
            nzOption.Click();
            Wait.WaitToBeVisible("XPath", 5, "//div[10]/div/div[2]/div/div/div/input[@id=\"mobilePhoneNum_localPhoneNum\"]");
            ecMobilePhoneNum.SendKeys(ECmobilephoneNum);

            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"Select Address\")]");
            ecBillingAddressButton.Click();
            ecStreetAddress.SendKeys(ECstreet);
            ecSuburb.SendKeys(ECsuburb);
            ecCity.SendKeys(ECcity);
            ecRegion.SendKeys(ECregion);
            ecCountry.SendKeys(ECcountry);
            ecPostcode.SendKeys(ECpostcode);
            Wait.WaitToBeClickable("XPath", 5, "//div[3]/button[2]/span[contains(text(), \"Save\")]");
            ecAddressSaveButton.Click();

            Wait.WaitToBeClickable("XPath", 5, "//div[3]/div/div[3]/div/button/span[contains(text(), \"Save\")]");
            ecInfoSaveButton.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[3]/div/button/span[contains(text(), \"OK\")]");
            ecOKbutton.Click();
            Thread.Sleep(3000);
        }

        public void AddNewEmergencyContactForNewAttendeee(string ECfirstname, string EClastname, string ECemail, string ECmobilephoneCode, string ECmobilephoneNum, string ECstreet, string ECsuburb, string ECcity, string ECregion, string ECcountry, string ECpostcode)
        {
            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"Contacts\")]");
            contactsButton.Click();

            Wait.WaitToBeClickable("XPath", 5, "//div[2]/div[2]/div/button/span[2][contains(text(), \"New Contact\")]");
            newContactButton.Click();

            Wait.WaitToBeVisible("XPath", 5, "//div[5]/div/div[2]/div/div/input[@id=\"firstName\"]");
            ecFirstName.SendKeys(ECfirstname);
            Wait.WaitToBeVisible("XPath", 5, "//div[7]/div/div[2]/div/div/input[@id=\"lastName\"]");
            ecLastName.SendKeys(EClastname);
            Wait.WaitToBeVisible("XPath", 5, "//div[8]/div/div[2]/div/div/div/input[@id=\"email\"]");
            ecContactEmail.SendKeys(ECemail);

            Wait.WaitToBeClickable("XPath", 5, "//div[9]/div/div[2]/div/div/div/label[1]/span[2][contains(text(), \"Female\")]");
            ecGenderFemaleOption.Click();

            Wait.WaitToBeVisible("XPath", 5, "//div[10]/div/div[2]/div/div/div/div/div/span[1]/input[@id=\"mobilePhoneNum_countryCode\"]");
            ecMobilePhoneCode.SendKeys(ECmobilephoneCode);
            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"NZ\")]");
            nzOption.Click();
            Wait.WaitToBeVisible("XPath", 5, "//div[10]/div/div[2]/div/div/div/input[@id=\"mobilePhoneNum_localPhoneNum\"]");
            ecMobilePhoneNum.SendKeys(ECmobilephoneNum);

            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"Select Address\")]");
            ecBillingAddressButton.Click();
            ecStreetAddress.SendKeys(ECstreet);
            ecSuburb.SendKeys(ECsuburb);
            ecCity.SendKeys(ECcity);
            ecRegion.SendKeys(ECregion);
            ecCountry.SendKeys(ECcountry);
            ecPostcode.SendKeys(ECpostcode);
            Wait.WaitToBeClickable("XPath", 5, "//div[3]/button[2]/span[contains(text(), \"Save\")]");
            ecAddressSaveButton.Click();

            Wait.WaitToBeClickable("XPath", 5, "//div[3]/div/div[3]/div/button/span[contains(text(), \"Save\")]");
            ecInfoSaveButton.Click();

            Thread.Sleep(3000);
            Wait.WaitToBeClickable("XPath", 5, "//div[3]/div/button/span[contains(text(), \"OK\")]");
            ecOKbutton.Click();
            Thread.Sleep(2000);
        }

        public void CompleteTheECRequest()
        {
            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"Contacts\")]");
            contactsButton.Click();

            Wait.WaitToBeClickable("XPath", 5, "//div[1]/div/div[2]/div/div[1]/div[4]/div/div[2]/div[@class=\"ant-form-item-control-input\"]");
            firstECRelationship.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[2]/div/div/div/div[1]/div[contains(text(), \"Parent\")]");
            parentOption.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[1]/div/div[2]/div/div[2]/button/span[contains(text(), \"Save\")]");
            firstSaveButton.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[2]/div/div[1]/div/div[2][@class=\"ant-card-extra\"]");
            secondECswitch.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[2]/div/div[2]/div/div[1]/div[3]/div/div[2]/div[@class=\"ant-form-item-control-input\"]");
            secondECType.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[2]/div/div/div/div[2]/div[contains(text(), \"Emergency Contact\")]");
            ecOption.Click();

            Wait.WaitToBeClickable("XPath", 5, "//div[2]/div/div[2]/div/div[1]/div[4]/div/div[2]/div[@class=\"ant-form-item-control-input\"]");
            secondECRelationship.Click();

            // Select the Non-parent guadian option
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Build().Perform();
            Thread.Sleep(3000);
            Wait.WaitToBeClickable("XPath", 5, "//div/div[1]/div/div[2]/div/div[2]/button/span[contains(text(), \"Save\")]");
            secondECsaveButton.Click();
            Thread.Sleep(5000);
            Wait.WaitToBeClickable("XPath", 5, "//div[3]/div/button/span[contains(text(), \"OK\")]");
            okButton.Click();
            Thread.Sleep(3000);
        }
    }
}