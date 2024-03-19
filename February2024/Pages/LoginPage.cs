using February2024.Utilities;
using OpenQA.Selenium;

namespace February2024.Pages
{
    public class LoginPage : CommonDriver
    {
        private readonly By usernameTextboxLocator = By.Id("UserName");
        IWebElement usernameTextbox;
        private readonly By passwordTextboxLocator = By.Id("Password");
        IWebElement passwordTextbox;
        private readonly By LoginButtonLocator = By.XPath("//*[@id='loginForm']/form/div[3]/input[1]");
        IWebElement loginButton;
        public void LoginActions(IWebDriver driver,string username,string password)
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(5);

            //Launch the Turnup Portal and navigate to login page
            //string baseURL= "http://horse.industryconnect.io/";
            driver.Navigate().GoToUrl(baseURL);

            //Identify username textbox and enter valid username
            usernameTextbox = driver.FindElement(usernameTextboxLocator);
            usernameTextbox.SendKeys(username);

            //Identify password textbox and enter valid password
            passwordTextbox = driver.FindElement(passwordTextboxLocator);
            passwordTextbox.SendKeys(password);

            //Identify Login button & Click on Login button
            loginButton = driver.FindElement(LoginButtonLocator);
            loginButton.Click();
            Thread.Sleep(1000);
        }
    }
}
