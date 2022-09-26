using EAEmployeeTest.Base;
using OpenQA.Selenium;

namespace UnitTestProject2.Pages
{ 
   public class Homepage
    {
        IWebElement lnklogin => 
            DriverContent.Driver.FindElement(By.LinkText("Login")); 
         IWebElement hello_username =>
            DriverContent.Driver.FindElement(By.XPath("//a[@href=' / Manage']"));
        IWebElement empListLinkPage => 
            DriverContent.Driver.FindElement(By.LinkText("Employee List"));
        IWebElement lnkRegister =>
            DriverContent.Driver.FindElement(By.LinkText("Register"));



        public LoginPage navigatetoLoginPage()
        {
            lnklogin.Click();
            return new LoginPage();
        }
        public bool CheckSuccessfulLogin()
        {
            return lnklogin.Displayed;
        }
         public bool checkHelloUsername()
        {
            return hello_username.Displayed;
        }
        public RegistrationPage navigatetoRegisterPage()
        {
            lnkRegister.Click();
            return new RegistrationPage();
        }
        public EmployeeListPage navigatetoEmpListPage()
        {
            empListLinkPage.Click();
            return new EmployeeListPage();
        }
    }
}
