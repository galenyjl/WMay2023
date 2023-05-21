using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMay2023.Pages
{
    public class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            // Launch warehouse
            driver.Navigate().GoToUrl("https://desktop.gradspace.monster/");

            // Identify username textbox and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("normal_login_username"));
            usernameTextbox.SendKeys("superadmin");

            // Identify password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Id("normal_login_password"));
            passwordTextbox.SendKeys("string2");

            // Identify login button and click on login button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"normal_login\"]/div[3]/div/div/div/div/button"));
            loginButton.Click();
            Thread.Sleep(6000);

            // Check if user is logged in successfully
            IWebElement ReportMenu = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[1]/div/div/div[2]/ul/li[6]/div/span[2]"));

            if (ReportMenu.Text == "Report")
            {
                Console.WriteLine("Logged in successfully, test passed");
            }
            else
            {
                Console.WriteLine("Login failed, test failed");
            }
        }
    }
}
