using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WMay2023.Pages;
using WMay2023.Utilities;

namespace WMay2023.StepDeifinitions
{
    [Binding]
    public class EmployeeStepDefinitions : CommonDriver
    {
        [Given(@"I logged into warehouse portal successfully")]
        public void GivenILoggedIntoWarehousePortalSuccessfully()
        {
            // Open chrome browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Login page object initialization and definition
            LoginPage loginPageObject = new LoginPage();
            loginPageObject.LoginSteps(driver);
        }

        [When(@"I navigate to employee page")]
        public void WhenINavigateToEmployeePage()
        {
            // Home page object initialization and definition
            HomePage homePageObject = new HomePage();
            homePageObject.GoToEmployeePage(driver);
        }

        [When(@"I create a new employee record")]
        public void WhenICreateANewEmployeeRecord()
        {
            // Employee page object initialization and definition
            EmployeePage employeePageObject = new EmployeePage();
            employeePageObject.CreateEmployee(driver);
        }

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            EmployeePage employeePageObject = new EmployeePage();

            string newFirstName = employeePageObject.GetFirstName(driver);
            string newLastName = employeePageObject.GetLastName(driver);
            string newUsername = employeePageObject.GetUsername(driver);

            Assert.AreEqual("First Name: Test" == newFirstName, "Actual first name and expected first name do not match");
            Assert.AreEqual("Last Name: User" == newLastName, "Actual last name and expected last name do not match");
            Assert.AreEqual("Username: TestUser" == newUsername, "Actual username and expected username do not match");
        }
    }
}
