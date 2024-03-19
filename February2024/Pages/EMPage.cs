using February2024.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace February2024.Pages
{
    public class EMPage
    {
        public void CreateEmployeeRecord(IWebDriver driver)
        {
            Console.WriteLine("Employee Record Created");
        }
        public void EditEmployeeRecord(IWebDriver driver)
        {
            Console.WriteLine("Employee Record Edited");
        }
        public void DeleteEmployeeRecord(IWebDriver driver)
        {
            Console.WriteLine("Employee Record Deleted");
        }
    }
}
