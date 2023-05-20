using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// Open chrome browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

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
Thread.Sleep(5000);

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

// Create an employee

// Go to employee page
IWebElement threeDotButton = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[1]/div/div/div[2]/ul/li[8]/div"));
threeDotButton.Click();
Thread.Sleep(1000);

IWebElement settingsButton = driver.FindElement(By.XPath("/html/body/div[4]/div/div"));
settingsButton.Click();
Thread.Sleep(1000);

IWebElement employeeManagementMenu = driver.FindElement(By.XPath("/html/body/div[5]/div/div/ul/li[1]"));
employeeManagementMenu.Click();
Thread.Sleep(2000);

// Click on Add New Button
IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/div[2]/div/div/div[1]/div[1]/div[2]/div/div/span/button"));
addNewButton.Click();

// Input First Name

// Input Last Name

// Input Username

// Input Password

// Click on Save button

