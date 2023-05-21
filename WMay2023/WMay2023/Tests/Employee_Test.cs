using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WMay2023.Pages;

// Open chrome browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

// Login page object initialization and definition
LoginPage loginPageObject = new LoginPage();
loginPageObject.LoginSteps(driver);

// Home page object initialization and definition
HomePage homePageObject = new HomePage();
homePageObject.GoToEmployeePage(driver);

// Employee page object initialization and definition
EmployeePage employeePageObject = new EmployeePage();
employeePageObject.CreateEmployee(driver);

// Edit employee
employeePageObject.EditEmployee(driver);

// Delete employee
employeePageObject.DeleteEmployee(driver);

