using AimyNunitProject.Drivers;
using AimyOneLoginTest.Drivers;
using OpenQA.Selenium;

namespace AimyNunitProject.Components.UserDetailsCompo
{
    public class AttendeesProfile : MainDriver
    {
        private IWebElement addNewAttendees => driver.FindElement(By.XPath("//*[contains(text(), \"New Attendee\")]"));
        private IWebElement attendeeFirstName => driver.FindElement(By.Id("firstName"));
        private IWebElement attendeeLastName => driver.FindElement(By.Id("lastName"));
        private IWebElement attendeeKnownAs => driver.FindElement(By.Id("knownName"));
        private IWebElement attendeeEthnicity => driver.FindElement(By.XPath("//div[7]/div/div[2]/div/div/div/div/div[@class=\"ant-select-selection-overflow\"]"));
        private IWebElement chineseOption => driver.FindElement(By.XPath("//div[2]/div[1]/div/div/div[5]/div[contains(text(), \"Chinese\")]"));
        // Primary Language
        private IWebElement attendeePrimaryLanguage => driver.FindElement(By.XPath("//div[8]/div/div[2]/div/div/div/div/div[@class=\"ant-select-selection-overflow\"]"));
        private IWebElement armenianOption => driver.FindElement(By.XPath("//div[1]/div/div/div[7]/div[contains(text(), \"Armenian\")]"));
        // Swimming comertency
        private IWebElement attendeeSwimmingCompetency => driver.FindElement(By.XPath("//div[2]/div/div/div/div/span[1][@class=\"ant-select-selection-search\"]"));
        private IWebElement learnerOption => driver.FindElement(By.XPath("//*[contains(text(), \"Learner\")]"));
        private IWebElement attendeeRoomNumber => driver.FindElement(By.Id("roomNum"));
        private IWebElement attendeeGenderMaleOption => driver.FindElement(By.XPath("//*[contains(text(), \"Male\")]"));
        // Date of Birth
        private IWebElement dateOfBirth => driver.FindElement(By.XPath("//div[2]/div/div/div/div[@class=\"ant-picker-input\"]"));
        private IWebElement dateOfBirthYearSelect => driver.FindElement(By.XPath("//*[@class=\"ant-picker-year-btn\"]"));
        private IWebElement lastDecadeArrow => driver.FindElement(By.XPath("//*[@class=\"ant-picker-super-prev-icon\"]"));
        private IWebElement oneEightOption => driver.FindElement(By.XPath("//tr[4]/td[1]/div[contains(text(), \"2018\")]"));
        private IWebElement MayOption => driver.FindElement(By.XPath("//tr[2]/td[2]/div[contains(text(), \"May\")]"));
        private IWebElement tenOption => driver.FindElement(By.XPath("//div[2]/table/tbody/tr[2]/td[5]/div[contains(text(), \"10\")]"));

        private IWebElement attendeeSchoolYear => driver.FindElement(By.Id("schoolYear"));
        private IWebElement attendeeInfoSaveButton => driver.FindElement(By.XPath("//div[3]/div/button/span[contains(text(), \"Save\")]"));

        // Connection with emergency
        private IWebElement firstAttendee => driver.FindElement(By.XPath("//div[3]/div/div/div[2]/div/div[1]/div/ul/li[1]/span/span[@class=\"anticon anticon-edit\"]"));
        private IWebElement switchSecondEmergencyContactOn => driver.FindElement(By.XPath("//div[2]/div/form/div/div[2]/div/div[1]/div/div[2]/button/span[@class=\"ant-switch-inner\"]"));
        private IWebElement typeList => driver.FindElement(By.XPath("//div[1]/div/div[2]/div/div[2]/div/div[2]/div/form/div/div[2]/div/div[2]/div/div[1]/div[3]/div/div[2]/div/div/div/div/span[1]/input[@class=\"ant-select-selection-search-input\"]"));
        private IWebElement parentOption => driver.FindElement(By.XPath("//*[contains(text(), \"Parent/Guardian\")]"));
        private IWebElement relationshipList => driver.FindElement(By.XPath("//div[3]/div/div[2]/div/div[1]/div[4]/div/div[2]/div/div/div/div/div/span[1]/input[@class=\"ant-select-selection-search-input\"]"));
        private IWebElement familyOption => driver.FindElement(By.XPath("//div[5]/div/div/div[2]/div/div/div/div[3]/div[contains(text(), \"Family Member\")]"));

        // Select attendee after edit profile
        private IWebElement selectFirstAttendee => driver.FindElement(By.XPath("//*[contains(text(), \"OPPO He\")]"));
        private IWebElement submitTheOrder => driver.FindElement(By.XPath("//*[contains(text(), \"Submit\")]"));
        private IWebElement confirmOrder => driver.FindElement(By.XPath("//*[contains(text(), \"Confirm\")]"));
        private IWebElement shoppingCartSubmit => driver.FindElement(By.XPath("//div[2]/button/span[contains(text(), \"Submit\")]"));
        private IWebElement submitBookingButton => driver.FindElement(By.XPath("//button[2]/span[contains(text(), \"Submit\")]"));

        public void AddNewAttendees(string AttendeeFirstName, string AttendeeLastName, string AttendeeKnownAs, string AttendeeRoomNumber, string AttendeeSchoolYear)
        {
            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"New Attendee\")]");
            addNewAttendees.Click();

            Wait.WaitToBeClickable("XPath", 5, "//div[7]/div/div[2]/div/div/div/div/div[@class=\"ant-select-selection-overflow\"]");
            attendeeEthnicity.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[2]/div[1]/div/div/div[5]/div[contains(text(), \"Chinese\")]");
            chineseOption.Click();

            Wait.WaitToBeVisible("Id", 5, "firstName");
            attendeeFirstName.SendKeys(AttendeeFirstName);

            Wait.WaitToBeClickable("XPath", 5, "//div[8]/div/div[2]/div/div/div/div/div[@class=\"ant-select-selection-overflow\"]");
            attendeePrimaryLanguage.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[1]/div/div/div[7]/div[contains(text(), \"Armenian\")]");
            armenianOption.Click();

            Wait.WaitToBeVisible("Id", 5, "lastName");
            attendeeLastName.SendKeys(AttendeeLastName);
            Wait.WaitToBeClickable("XPath", 5, "//div[2]/div/div/div/div/span[1][@class=\"ant-select-selection-search\"]");
            attendeeSwimmingCompetency.Click();
            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"Learner\")]");
            learnerOption.Click();

            Wait.WaitToBeVisible("Id", 5, "knownName");
            attendeeKnownAs.SendKeys(AttendeeKnownAs);

            attendeeRoomNumber.SendKeys(AttendeeRoomNumber);
            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"Male\")]");
            attendeeGenderMaleOption.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[2]/div/div/div/div[@class=\"ant-picker-input\"]");
            dateOfBirth.Click();
            Wait.WaitToBeClickable("XPath", 5, "//*[@class=\"ant-picker-year-btn\"]");
            dateOfBirthYearSelect.Click();
            Wait.WaitToBeClickable("XPath", 5, "//*[@class=\"ant-picker-super-prev-icon\"]");
            lastDecadeArrow.Click();
            Wait.WaitToBeClickable("XPath", 5, "//tr[4]/td[1]/div[contains(text(), \"2018\")]");
            oneEightOption.Click();
            Wait.WaitToBeClickable("XPath", 5, "//tr[2]/td[2]/div[contains(text(), \"May\")]");
            MayOption.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[2]/table/tbody/tr[2]/td[5]/div[contains(text(), \"10\")]");
            tenOption.Click();

            Wait.WaitToBeVisible("Id", 5, "schoolYear");
            attendeeSchoolYear.SendKeys(AttendeeSchoolYear);

            Wait.WaitToBeClickable("XPath", 5, "//div[3]/div/button/span[contains(text(), \"Save\")]");
            attendeeInfoSaveButton.Click();
        }

        public void SelectEmergencyContact()
        {
            Wait.WaitToBeClickable("XPath", 5, "//div[3]/div/div/div[2]/div/div[1]/div/ul/li[1]/span/span[@class=\"anticon anticon-edit\"]");
            firstAttendee.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[2]/div/form/div/div[2]/div/div[1]/div/div[2]/button/span[@class=\"ant-switch-inner\"]");
            switchSecondEmergencyContactOn.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[1]/div/div[2]/div/div[2]/div/div[2]/div/form/div/div[2]/div/div[2]/div/div[1]/div[3]/div/div[2]/div/div/div/div/span[1]/input[@class=\"ant-select-selection-search-input\"]");
            typeList.Click();
            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"Parent/Guardian\")]");
            parentOption.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[2]/div/div/div/div/span[1]/input[@class=\"ant-select-selection-search-input\"]");
            relationshipList.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[5]/div/div/div[2]/div/div/div/div[3]/div[contains(text(), \"Family Member\")]");
            familyOption.Click();
        }

        public void SelectFirstAttendee()
        {
            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"OPPO He\")]");
            selectFirstAttendee.Click();
            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"Submit\")]");
            submitTheOrder.Click();
            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"Confirm\")]");
            confirmOrder.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[2]/button/span[contains(text(), \"Submit\")]");
            shoppingCartSubmit.Click();
            Wait.WaitToBeClickable("XPath", 5, "//button[2]/span[contains(text(), \"Submit\")]");
            submitBookingButton.Click();
            Thread.Sleep(3000);
        }
    }
}
