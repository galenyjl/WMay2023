using OpenQA.Selenium;
using WMay2023.Utilities;

namespace WMay2023.Pages
{
    public class HomePage
    {
        public void GoToEmployeePage(IWebDriver driver)
        {
            // Go to employee page
            IWebElement threeDotButton = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[1]/div/div/div[2]/ul/li[8]/div"));
            threeDotButton.Click();
            Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[4]/div/div", 2);

            IWebElement settingsButton = driver.FindElement(By.XPath("/html/body/div[4]/div/div"));
            settingsButton.Click();
            Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[5]/div/div/ul/li[1]", 2);

            IWebElement employeeManagementMenu = driver.FindElement(By.XPath("/html/body/div[5]/div/div/ul/li[1]"));
            employeeManagementMenu.Click();
            Thread.Sleep(2000);
        }
    }
}
