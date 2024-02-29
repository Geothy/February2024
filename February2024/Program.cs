using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//Open Chrome Browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();


//Launch the Turnup Portal and navigate to login page
driver.Navigate().GoToUrl("http://horse.industryconnect.io/");

//Identify username textbox and enter valid username
IWebElement usernameTextbox= driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

//Identify password textbox and enter valid password

IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

//Identify Login button & Click on Login button
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
loginButton.Click();

//Check if the user has logged in successfully
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
if (helloHari.Text == "Hello hari!")
{
    Console.WriteLine("User has logged in successfully");
}
else
{
    Console.WriteLine("User has not logged in successfully");
}
