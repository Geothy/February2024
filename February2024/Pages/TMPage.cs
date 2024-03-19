using February2024.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace February2024.Pages
{
    public class TMPage
    {
        public void CreateTimeMaterialRecord(IWebDriver driver)
        {
            //Create Time Record


            //Click on create new 
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();

            //Select time from dropdown
            IWebElement typeCodeMainDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeMainDropdown.Click();
            
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            typeCodeDropdown.Click();

            //Enter Code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("M121");

            //Enter Description
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("Mouse");

            //Enter price
            WaitUtils.WaitToBeClickable(driver, "XPath", "//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]", 2);
            IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTextbox.SendKeys("5");

            //Select save
            WaitUtils.WaitToBeVisible(driver, "Id", "SaveButton", 2);
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(3000);

            //Check if new time record is created successfully
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(3000);

            IWebElement newRecordCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
           /* if (newRecordCode.Text == "M121")
            {
                Console.WriteLine("User has created new record successfully");
            }
            else
            {
                Console.WriteLine("User has not created new record");
            }*/

            Assert.That((newRecordCode.Text == "M121"),"User has not created new record");
        }
        public void EditTimeMaterialRecord(IWebDriver driver)
        {
            //Edit Time Record

            IWebElement editNewRecordButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editNewRecordButton.Click();

            //Edit Code
            IWebElement editCodeTextbox = driver.FindElement(By.Id("Code"));
            editCodeTextbox.Click();
            editCodeTextbox.Clear();
            editCodeTextbox.SendKeys("M121Edited");

            //Edit Description
            IWebElement editDescriptionTextbox = driver.FindElement(By.Id("Description"));
            editDescriptionTextbox.Click();
            editDescriptionTextbox.Clear();
            editDescriptionTextbox.SendKeys("MouseEdited");

            //Thread.Sleep(5000);

            //Edit price//*[@id="TimeMaterialEditForm"]/div/div[4]/div/span[1]/span/input[1]
            WaitUtils.WaitToBeVisible(driver, "XPath", "//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]", 2);
            IWebElement editPriceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            editPriceTextbox.SendKeys("50");

            //Select save after editing
            IWebElement editSaveButton = driver.FindElement(By.Id("SaveButton"));
            editSaveButton.Click();
            Thread.Sleep(3000);

            //Check if time record is edited successfully
            //WaitUtils.WaitToBeVisible(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 2);
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPageButton.Click();
            Thread.Sleep(5000);
            
            IWebElement editRecordCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            /*if (editRecordCode.Text == "M121Edited")
            {
                Console.WriteLine("User has edited new record successfully");
            }
            else
            {
                Console.WriteLine("User has not edited new record");
            }*/
            Assert.That((editRecordCode.Text != "M121Edited"), "User has not edited new record");
        }
        public void DeleteTimeMaterialRecord(IWebDriver driver)
        {
            //Delete Time record
            IWebElement checkLastPgButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            checkLastPgButton.Click();
            Thread.Sleep(3000);

            IWebElement deleteRecordButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteRecordButton.Click();
            IAlert alertDelete = driver.SwitchTo().Alert();
            alertDelete.Accept();
            Thread.Sleep(3000);

            
            IWebElement deleteRecordCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            /*if (deleteRecordCode.Text != "M121Edited")
            {
                Console.WriteLine("User has deleted new record successfully");
            }
            else
            {
                Console.WriteLine("User has not deleted new record");
            }*/
            Assert.That((deleteRecordCode.Text != "M121Edited"), "User has not deleted record successfully");
        }
    }
}
