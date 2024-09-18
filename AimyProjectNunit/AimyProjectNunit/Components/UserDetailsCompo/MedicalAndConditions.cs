using AimyNunitProject.Drivers;
using AimyOneLoginTest.Drivers;
using OpenQA.Selenium;

namespace AimyNunitProject.Components.UserDetailsCompo
{
    public class MedicalAndConditions : MainDriver
    {
        private IWebElement mcButton => driver.FindElement(By.XPath("//span[contains(text(), \"Medical & Conditions\")]"));

        private IWebElement doctorName => driver.FindElement(By.XPath("//*[@id=\"doctorName\"]"));
        private IWebElement medicalServiceName => driver.FindElement(By.XPath("//*[@id=\"medicalServiceName\"]"));

        // Doctor Contact Number
        private IWebElement numberCode => driver.FindElement(By.XPath("//*[@id=\"doctorContactNum_countryCode\"]"));
        private IWebElement nzOption => driver.FindElement(By.XPath("//*[contains(text(), \"NZ\")]"));
        private IWebElement numberAreaCode => driver.FindElement(By.XPath("//*[@id=\"doctorContactNum_areaCode\"]"));
        private IWebElement numberLocalNum => driver.FindElement(By.XPath("//*[@id=\"doctorContactNum_localPhoneNum\"]"));
        private IWebElement numberExt => driver.FindElement(By.XPath("//*[@id=\"doctorContactNum_extension\"]"));

        private IWebElement insurancePolicyNumber => driver.FindElement(By.XPath("//*[@id=\"insurancePolicyNum\"]"));
        private IWebElement immunisationYesOption => driver.FindElement(By.XPath("//div[2]/div/div/div[1]/div/div[2]/div/div/div/label[1]/span[2][contains(text(), \"Yes\")]"));

        // Dietary
        private IWebElement dairyFreeYes => driver.FindElement(By.XPath("//div[4]/div[3]/div/div[2]/div[1]/div[1]/div/div[2]/div/div/div/label[1]/span[2][contains(text(), \"Yes\")]"));
        private IWebElement nutsFreeNo => driver.FindElement(By.XPath("//div[3]/div/div[2]/div[1]/div[2]/div/div[2]/div/div/div/label[2]/span[2][contains(text(), \"No\")]"));
        private IWebElement wheatFreeNo => driver.FindElement(By.XPath("//div[3]/div/div[2]/div[1]/div[3]/div/div[2]/div/div/div/label[2]/span[2][contains(text(), \"No\")]"));
        private IWebElement soyFreeNo => driver.FindElement(By.XPath("//div[3]/div/div[2]/div[1]/div[4]/div/div[2]/div/div/div/label[2]/span[2][contains(text(), \"No\")]"));
        private IWebElement glutenFreeNo => driver.FindElement(By.XPath("//div[3]/div/div[2]/div[1]/div[5]/div/div[2]/div/div/div/label[2]/span[2][contains(text(), \"No\")]"));
        private IWebElement vegetarianNo => driver.FindElement(By.XPath("//div[3]/div/div[2]/div[1]/div[6]/div/div[2]/div/div/div/label[2]/span[2][contains(text(), \"No\")]"));
        private IWebElement veganNo => driver.FindElement(By.XPath("//div[3]/div/div[2]/div[1]/div[7]/div/div[2]/div/div/div/label[2]/span[2][contains(text(), \"No\")]"));

        // Learning
        private IWebElement adhdYes => driver.FindElement(By.XPath("//div[4]/div/div[2]/div[1]/div[1]/div/div[2]/div/div/div/label[1]/span[2][contains(text(), \"Yes\")]"));
        private IWebElement autismNo => driver.FindElement(By.XPath("//div[4]/div/div[2]/div[1]/div[2]/div/div[2]/div/div/div/label[2]/span[2][contains(text(), \"No\")]"));
        private IWebElement dyslexiaNo => driver.FindElement(By.XPath("//div[4]/div/div[2]/div[1]/div[3]/div/div[2]/div/div/div/label[2]/span[2][contains(text(), \"No\")]"));
        private IWebElement downSyndromeNo => driver.FindElement(By.XPath("//div[4]/div/div[2]/div[1]/div[4]/div/div[2]/div/div/div/label[2]/span[2][contains(text(), \"No\")]"));

        private IWebElement saveButton => driver.FindElement(By.XPath("//div[3]/div/div[3]/div/button/span[contains(text(), \"Save\")]"));

        public void MedicalAndCondition(string DoctorName, string MedicalServiceName, string NumberCode, string NumberAreaCode, string NumberLocalNum, string NumberExt, string InsurancePolicyNumber)
        {
            Wait.WaitToBeClickable("XPath", 10, "//span[contains(text(), \"Medical & Conditions\")]");
            mcButton.Click();
            Thread.Sleep(2000);
            Wait.WaitToBeVisible("XPath", 5, "//*[@id=\"doctorName\"]");
            doctorName.SendKeys(DoctorName);

            Wait.WaitToBeVisible("XPath", 5, "//*[@id=\"medicalServiceName\"]");
            medicalServiceName.SendKeys(MedicalServiceName);

            Wait.WaitToBeVisible("XPath", 5, "//*[@id=\"doctorContactNum_countryCode\"]");
            numberCode.SendKeys(NumberCode);

            Wait.WaitToBeClickable("XPath", 5, "//*[contains(text(), \"NZ\")]");
            nzOption.Click();

            Wait.WaitToBeVisible("XPath", 5, "//*[@id=\"doctorContactNum_areaCode\"]");
            numberAreaCode.SendKeys(NumberAreaCode);

            Wait.WaitToBeVisible("XPath", 5, "//*[@id=\"doctorContactNum_localPhoneNum\"]");
            numberLocalNum.SendKeys(NumberLocalNum);

            Wait.WaitToBeVisible("XPath", 5, "//*[@id=\"doctorContactNum_extension\"]");
            numberExt.SendKeys(NumberExt);

            Wait.WaitToBeVisible("XPath", 5, "//*[@id=\"insurancePolicyNum\"]");
            insurancePolicyNumber.SendKeys(InsurancePolicyNumber);

            Wait.WaitToBeClickable("XPath", 5, "//div[2]/div/div/div[1]/div/div[2]/div/div/div/label[1]/span[2][contains(text(), \"Yes\")]");
            immunisationYesOption.Click();

            Wait.WaitToBeClickable("XPath", 5, "//div[4]/div[3]/div/div[2]/div[1]/div[1]/div/div[2]/div/div/div/label[1]/span[2][contains(text(), \"Yes\")]");
            dairyFreeYes.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[3]/div/div[2]/div[1]/div[2]/div/div[2]/div/div/div/label[2]/span[2][contains(text(), \"No\")]");
            nutsFreeNo.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[3]/div/div[2]/div[1]/div[3]/div/div[2]/div/div/div/label[2]/span[2][contains(text(), \"No\")]");
            wheatFreeNo.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[3]/div/div[2]/div[1]/div[4]/div/div[2]/div/div/div/label[2]/span[2][contains(text(), \"No\")]");
            soyFreeNo.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[3]/div/div[2]/div[1]/div[5]/div/div[2]/div/div/div/label[2]/span[2][contains(text(), \"No\")]");
            glutenFreeNo.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[3]/div/div[2]/div[1]/div[6]/div/div[2]/div/div/div/label[2]/span[2][contains(text(), \"No\")]");
            vegetarianNo.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[3]/div/div[2]/div[1]/div[7]/div/div[2]/div/div/div/label[2]/span[2][contains(text(), \"No\")]");
            veganNo.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[4]/div/div[2]/div[1]/div[1]/div/div[2]/div/div/div/label[1]/span[2][contains(text(), \"Yes\")]");
            adhdYes.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[4]/div/div[2]/div[1]/div[2]/div/div[2]/div/div/div/label[2]/span[2][contains(text(), \"No\")]");
            autismNo.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[4]/div/div[2]/div[1]/div[3]/div/div[2]/div/div/div/label[2]/span[2][contains(text(), \"No\")]");
            dyslexiaNo.Click();
            Wait.WaitToBeClickable("XPath", 5, "//div[4]/div/div[2]/div[1]/div[4]/div/div[2]/div/div/div/label[2]/span[2][contains(text(), \"No\")]");
            downSyndromeNo.Click();

            Wait.WaitToBeClickable("XPath", 5, "//div[3]/div/div[3]/div/button/span[contains(text(), \"Save\")]");
            saveButton.Click();
            Thread.Sleep(5000);
        }
    }
}
