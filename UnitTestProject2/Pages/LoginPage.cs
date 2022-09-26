using EAEmployeeTest.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using UnitTestProject2.Pages;
//using OpenQA.Selenium.Support.PageObjects;//deprecated

namespace UnitTestProject2.Pages
{
    public class LoginPage
    {
        //private IWebDriver _driver;

        /* public LoginPage(RemoteWebDriver driver)
         {
             _driver = driver;
         }*/
        //public LoginPage(IWebDriver driver) => _driver = driver;

       public IWebElement lnklogin => DriverContent.Driver.FindElement(By.LinkText("Login"));
        IWebElement usernameField => DriverContent.Driver.FindElement(By.Name("UserName"));
        IWebElement passwordField => DriverContent.Driver.FindElement(By.Name("Password"));
        IWebElement btnlogin => DriverContent.Driver.FindElement(By.CssSelector("input.btn"));
        IWebElement empListLinkPage => DriverContent.Driver.FindElement(By.LinkText("Employee List"));
        public void ClickLoginlnk()
        {
            lnklogin.Click();
        }
        public void EnterUserCredentials(string username, string password)
    {
            usernameField.SendKeys(username);
            passwordField.SendKeys(password);
    }
        public void ClickLoginBtn()
        {
            btnlogin.Click();
        }
        public void login(string username, string password)
        {
            EnterUserCredentials(username, password);
            ClickLoginBtn();
        }
       
    }
}
