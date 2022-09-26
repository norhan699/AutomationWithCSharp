using EAEmployeeTest.Base;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using UnitTestProject2.Pages;

namespace UnitTestProject2.Steps
{

    
    [Binding]
    public sealed class LoginSteps
    {
        string url = "http://eaapp.somee.com/";
        string username = "Norhan";
        string password = "N@rhan01*";
        [Given(@"I had navigated to home page")]
        public void GivenIHadNavigatedToHomePage()
        {
          //  DriverContent.Driver = new ChromeDriver();//in hooks
            DriverContent.Driver.Navigate().GoToUrl(url);
        }

        [Given(@"I see the application opened")]
        public void GivenISeeTheApplicationOpened()
        {
            Homepage home = new Homepage();
            home.CheckSuccessfulLogin();
        }

        [When(@"I clicked the (.*) link")]
        public void ThenIClickedTheLink(string lnkNmane)//ThenIClickedTheLoginLink
        {
            Homepage home = new Homepage();
            if (lnkNmane == "Login")
            {
                home.navigatetoLoginPage();
            }
            else if (lnkNmane == "Register")
            {
                home.navigatetoRegisterPage();
            }
            else if (lnkNmane == "EmpList")
            {
                home.navigatetoEmpListPage();
            }
        }

        [When(@"I enetred the username and password")]
        public void WhenIEnetredTheUsernameAndPassword(Table table)
        {
            LoginPage login = new LoginPage();
            login.EnterUserCredentials(username,password);
        }

        [Then(@"I clicked login")]
        public void ThenIClickedLogin()
        {
            LoginPage login = new LoginPage();
            login.ClickLoginBtn();
        }

        [Then(@"I should see my name with hello")]
        public void ThenIShouldSeeMyNameWithHello()
        {
            Homepage home = new Homepage();
            //home.checkHelloUsername();
        }
     

        [Then(@"I should be navigated to a list with all employees")]
        public void ThenIShouldBeNavigatedToAListWithAllEmployees()
        {
            EmployeeListPage list = new EmployeeListPage();
            DriverContent.Driver.Title.Contains("Employee");
        }


    }
}
