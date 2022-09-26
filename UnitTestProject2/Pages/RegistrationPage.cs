using EAEmployeeTest.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject2.Pages
{
    public class RegistrationPage
    {
        IWebElement lnkregister => DriverContent.Driver.FindElement(By.Id("registerLink"));
        IWebElement usernameField => DriverContent.Driver.FindElement(By.Name("UserName"));
        IWebElement passwordField => DriverContent.Driver.FindElement(By.Name("Password"));
        IWebElement emailField => DriverContent.Driver.FindElement(By.Name("Email"));
        IWebElement confirmPasswordField => DriverContent.Driver.FindElement(By.Name("ConfirmPassword"));
        IWebElement btnregist => DriverContent.Driver.FindElement(By.CssSelector("input.btn"));


        public void Clickregisterlnk()
        {
            lnkregister.Click();
        }
        public void EnterUserInfo(string username, string password, string email)
        {
            usernameField.SendKeys(username);
            passwordField.SendKeys(password);
            confirmPasswordField.SendKeys(password);
            emailField.SendKeys(email);
        }
        public void ClickRegisterBtn()
        {
            btnregist.Click();
        }
        public void login(string username, string password,string email)
        {
            EnterUserInfo(username, password,email);
            ClickRegisterBtn();
        }
    }
}
