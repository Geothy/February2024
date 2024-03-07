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
Thread.Sleep(1000);

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
//Create Time Record
//Navigate ti Time & Material module(Click on Administration dropdown)

IWebElement adminstrationDropdown = driver.FindElement(By.XPath("//a[@class='dropdown-toggle'][1]"));
adminstrationDropdown.Click();

IWebElement timeAndMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
timeAndMaterialOption.Click();

//Click on create new 
IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createNewButton.Click();

//Select time from dropdown
IWebElement typeCodeMainDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
typeCodeMainDropdown.Click();
 //Thread.Sleep(1000);

IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
typeCodeDropdown.Click();

//Enter Code
IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
codeTextbox.SendKeys("M121");

//Enter Description
IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
descriptionTextbox.SendKeys("Mouse");

//Enter price
IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
priceTextbox.SendKeys("5");

//Select save
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();
Thread.Sleep(3000);

//Check if new time record is created successfully
IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
goToLastPageButton.Click();

IWebElement newRecordCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
if (newRecordCode.Text == "M121")
{
    Console.WriteLine("User has created new record successfully");
}
else
{
    Console.WriteLine("User has not created new record");
}

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

//Edit price//*//*[@id="TimeMaterialEditForm"]/div/div[4]/div/span[1]/span/input[1]
IWebElement editPriceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
//editPriceTextbox.Click();
//editPriceTextbox.Clear();
editPriceTextbox.SendKeys("50");

//Select save after editing
IWebElement editSaveButton = driver.FindElement(By.Id("SaveButton"));
editSaveButton.Click();
Thread.Sleep(3000);

//Check if time record is edited successfully
IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
lastPageButton.Click();
Thread.Sleep(3000);

IWebElement editRecordCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
if (editRecordCode.Text == "M121Edited")
{
    Console.WriteLine("User has edited new record successfully");
}
else
{
    Console.WriteLine("User has not edited new record");
}

//Delete Time record

IWebElement deleteRecordButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
deleteRecordButton.Click();
IAlert alertDelete= driver.SwitchTo().Alert();
alertDelete.Accept();
Thread.Sleep(3000);

IWebElement checkLastPgButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
checkLastPgButton.Click();


