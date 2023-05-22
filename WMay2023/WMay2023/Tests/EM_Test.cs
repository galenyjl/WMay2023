﻿using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WMay2023.Pages;
using WMay2023.Utilities;

namespace WMay2023.Tests
{
    [TestFixture]
    public class EM_Test : CommonDriver
    {
        [SetUp]
        public void LoginFunction()
        {
            // Open chrome browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Login page object initialization and definition
            LoginPage loginPageObject = new LoginPage();
            loginPageObject.LoginSteps(driver);
        }

        [Test, Order(1)]
        public void CreateEmployee_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObject = new HomePage();
            homePageObject.GoToEmployeePage(driver);

            // Employee page object initialization and definition
            EmployeePage employeePageObject = new EmployeePage();
            employeePageObject.CreateEmployee(driver);
        }

        [Test, Order(2)]
        public void EditEmployee_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObject = new HomePage();
            homePageObject.GoToEmployeePage(driver);

            // Edit employee
            EmployeePage employeePageObject = new EmployeePage();
            employeePageObject.EditEmployee(driver);
        }

        [Test, Order(3)]
        public void DeleteEmployee_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObject = new HomePage();
            homePageObject.GoToEmployeePage(driver);

            // Delete employee
            EmployeePage employeePageObject = new EmployeePage();
            employeePageObject.DeleteEmployee(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Close();
        }
    }
}
