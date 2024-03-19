using February2024.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace February2024.Pages
{
    public class HomePage
    {
        public void NavigateToTMPage(IWebDriver driver)
        {
            try
            {
                //Navigate to Time & Material module(Click on Administration dropdown)
                IWebElement adminstrationDropdown = driver.FindElement(By.XPath("//a[@class='dropdown-toggle'][1]"));
                adminstrationDropdown.Click();
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")));


                WaitUtils.WaitToBeVisible(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 5);
                IWebElement timeAndMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
                timeAndMaterialOption.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Turnup Portal is not clickable");
            }

        }
        public void NavigateToEMPage(IWebDriver driver)
        {
            try
            {
                //Navigate to Time & Material module(Click on Administration dropdown)
                IWebElement adminstrationDropdown = driver.FindElement(By.XPath("//a[@class='dropdown-toggle'][1]"));
                adminstrationDropdown.Click();
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")));


                WaitUtils.WaitToBeVisible(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a", 5);
                IWebElement employeeOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
                employeeOption.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Turnup Portal is not clickable");
            }

        }
        public void VerifyLoggedInUser(IWebDriver driver)
        {
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
        }
    }
}
