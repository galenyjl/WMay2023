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
