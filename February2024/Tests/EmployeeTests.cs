using February2024.Pages;
using February2024.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace February2024.Tests
{
    [Parallelizable]
    [TestFixture]
    public class EmployeeTests : CommonDriver
    {
        [SetUp]
        public void SetUpEmp()
        {
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver, "hari", "123123");
            HomePage homePageObj = new HomePage();
            homePageObj.VerifyLoggedInUser(driver);
            homePageObj.NavigateToEMPage(driver);
        }

        [Test, Order(1), Description("This  test creates new Employee record with valid details")]
        public void TestCreateEmployeeRecord()
        {
            EMPage emPageObj = new EMPage();
            emPageObj.CreateEmployeeRecord(driver);

        }
        [Test, Order(2), Description("This  test edits Employee record")]
        public void TestEditEmployeeRecord()
        {
            EMPage emPageObj = new EMPage();
            emPageObj.EditEmployeeRecord(driver);
        }
        [Test, Order(3), Description("This  test deletes Employee record")]
        public void TestDeleteEmployeeRecord()
        {
            EMPage emPageObj = new EMPage();
            emPageObj.DeleteEmployeeRecord(driver);
        }
        [TearDown]

        public void CloseTestRun()
        {
            driver.Quit();
        }







    }
}
