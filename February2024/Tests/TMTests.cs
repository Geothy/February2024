using February2024.Pages;
using February2024.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace February2024.Tests
{
    [TestFixture]
    public class TMTests : CommonDriver
    {
        [SetUp]
        public void SetUpTM()
        {
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver, "hari", "123123");
            HomePage homePageObj = new HomePage();
            homePageObj.VerifyLoggedInUser(driver);
            homePageObj.NavigateToTMPage(driver);
        }

        [Test, Order(1), Description("This  test creates new time material record with valid details")]
        public void TestCreateTimeMaterialRecord()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTimeMaterialRecord(driver);

        }
        [Test, Order(2), Description("This  test edits time material record")]
        public void TestEditTimeMaterialRecord()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTimeMaterialRecord(driver);
        }
        [Test, Order(3), Description("This  test deletes time material record")]
        public void TestDeleteTimeMaterialRecord()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTimeMaterialRecord(driver);
        }
        [TearDown]

        public void CloseTestRun()
        {
            driver.Quit();
        }







    }
}
