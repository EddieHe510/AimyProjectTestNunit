using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AimyNunitProject.Drivers
{
    public class Broswer: MainDriver
    {
        private IWebDriver driver;

        public Broswer(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string BroswerGetScreenShot()
        {
            Thread.Sleep(200);
            var file = ((ITakesScreenshot)driver).GetScreenshot();
            var img = file.AsBase64EncodedString;

            return img;
        }
    }
}
