using NUnit.Framework;
using OpenQA.Selenium;

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


        }

        public string GetFirstName(IWebDriver driver)
        {
            IWebElement actualFirstName = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[last()]/td[1]/div/div[1]"));
            return actualFirstName.Text;
        }

        public string GetLastName(IWebDriver driver)
        {
            IWebElement actualLastName = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[last()]/td[1]/div/div[2]"));
            return actualLastName.Text;
        }

        public string GetUsername(IWebDriver driver)
        {
            IWebElement actualUsername = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[last()]/td[1]/div/div[3]"));
            return actualUsername.Text;
        }

        public void EditEmployee(IWebDriver driver)
        {
            // Scroll down to the bottom
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            Thread.Sleep(1000);

            IWebElement newUsername = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[last()]/td[1]/div/div[3]"));
            if (newUsername.Text == "Username: TestUser")
            {
                IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[last()]/td[5]/div/button[2]"));
                editButton.Click();
            }
            else
            {
                Assert.Fail("Record recently created hasn't been found");
            }

            // Edit first name into code textbox
            IWebElement editFirstNameTextbox = driver.FindElement(By.Id("firstName"));
            IWebElement clearFirstNameButton = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[25]/td[1]/div/form/div[1]/div/div[2]/div/div/span/span"));
            clearFirstNameButton.Click();
            editFirstNameTextbox.SendKeys("editedTest");

            // Edit last name into code textbox
            IWebElement editLastNameTextbox = driver.FindElement(By.Id("lastName"));
            IWebElement clearLastNameButton = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[25]/td[1]/div/form/div[2]/div/div[2]/div/div/span/span"));
            clearLastNameButton.Click();
            editLastNameTextbox.SendKeys("editedUser");

            // Edit last name into code textbox
            IWebElement editUsernameTextbox = driver.FindElement(By.Id("userName"));
            IWebElement clearUsernameButton = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[25]/td[1]/div/form/div[3]/div/div[2]/div/div/span/span"));
            clearUsernameButton.Click();
            editUsernameTextbox.SendKeys("editedTestUser");

            // Click on Save button
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[last()]/td[5]/div/button[1]"));
            saveButton.Click();
            Thread.Sleep(3000);

            // Check if record created is present in the table and has expected value
            IWebElement editedFirstName = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[last()]/td[1]/div/div[1]"));
            IWebElement editedLastName = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[last()]/td[1]/div/div[2]"));
            IWebElement editedUsername = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[last()]/td[1]/div/div[3]"));

            Assert.AreEqual(editedFirstName.Text, "First Name: editedTest", "Actual first name and expected first name do not match");
            Assert.AreEqual(editedLastName.Text, "Last Name: editedUser", "Actual last name and expected last name do not match");
            Assert.AreEqual(editedUsername.Text, "Username: editedTestUser", "Actual username and expected username do not match");
        }

        public void DeleteEmployee(IWebDriver driver)
        {
            // Scroll down to the bottom
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            Thread.Sleep(1000);

            IWebElement editedUsername = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[last()]/td[1]/div/div[3]"));

            if (editedUsername.Text == "Username: editedTestUser")
            {
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[last()]/td[5]/div/button[3]"));
                deleteButton.Click();
            }
            else
            {
                Assert.Fail("Record recently edited hasn't been found");
            }

            // Click on Save button
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[last()]/td[2]/div/button[1]"));
            saveButton.Click();

            Thread.Sleep(2000);
            //check the record deleted successfully
            IWebElement deleteUsername = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[last()]/td[1]/div/div[3]"));
            Assert.That(deleteUsername.Text != "Username: editedTestUser", "Record hasn't been deleted");
        }

    }
}
