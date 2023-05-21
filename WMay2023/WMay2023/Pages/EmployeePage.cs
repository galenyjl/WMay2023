using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMay2023.Pages
{
    public  class EmployeePage
    {
        public void CreateEmployee(IWebDriver driver)
        {
            // Create an employee

            // Click on Add New Button
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[2]/div/div/div[1]/div[1]/div[2]/div/div/span/button"));
            addNewButton.Click();

            // Input First Name
            IWebElement firstNameTextbox = driver.FindElement(By.Id("firstName"));
            firstNameTextbox.SendKeys("Test");

            // Input Last Name
            IWebElement lastNameTextbox = driver.FindElement(By.Id("lastName"));
            lastNameTextbox.SendKeys("User");

            // Input Username
            IWebElement employeeUsernameTextbox = driver.FindElement(By.Id("userName"));
            employeeUsernameTextbox.SendKeys("TestUser");

            // Input Password
            IWebElement employeePasswordTextbox = driver.FindElement(By.Id("password"));
            employeePasswordTextbox.SendKeys("123123");

            // Click on Save button
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[2]/td[5]/div/button[1]"));
            saveButton.Click();
            Thread.Sleep(3000);

            // Scroll down to the bottom
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            Thread.Sleep(1000);

            // Check if record created is present in the table and has expected value
            IWebElement actualUsername = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[last()]/td[1]/div/div[3]"));

            if (actualUsername.Text == "Username: TestUser")
            {
                Console.WriteLine("Employee created successfully, test passed");
            }
            else
            {
                Console.WriteLine("Test failed");
            }
        }

        public void EditEmployee(IWebDriver driver)
        {

        }

        public void DeleteEmployee(IWebDriver driver)
        {

        }

    }
}
