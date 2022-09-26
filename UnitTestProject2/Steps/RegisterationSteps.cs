using EAEmployeeTest.Base;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using UnitTestProject2.Pages;

namespace UnitTestProject2.Steps
{

    
    [Binding]
    public sealed class RegistrationSteps
    {
        string url = "http://eaapp.somee.com/";
        string username = "Norhan";
        string password = "N@rhan01*";
        string email = "NorhanMmedhat@gmail.com";
       // string key = "john";
      /*  [Given(@"I had navigated to home page2")]
        public void GivenIHadNavigatedToHomePage2()
        {
            DriverContent.Driver = new ChromeDriver();
            DriverContent.Driver.Navigate().GoToUrl(url);
            //DriverContent.Browser.GoToUrl(url);
            //ScenarioContext.Current.Pending();
        }

        [Given(@"I see the application opened2")]
        public void GivenISeeTheApplicationOpened2()
        {
            Homepage home = new Homepage();
            home.CheckSuccessfulLogin();
        }*/

        [Then(@"I clicked the Register link")]
        public void ThenIClickedTheRegisterLink()
        {
            Homepage home = new Homepage();
            home.navigatetoRegisterPage();
        }

        [When(@"I enetred the username and password and confirm password and email")]
        public void WhenIEnetredTheUsernameAndPassword(Table table)
        {
            RegistrationPage register = new RegistrationPage();
            register.EnterUserInfo(username,password,email);
            /* dynamic data = table.CreateDynamicInstance();
             data.username, data.password*/
        }

        [Then(@"I clicked register")]
        public void ThenIClickedLogin()
        {
            RegistrationPage register = new RegistrationPage();
            register.ClickRegisterBtn();
        }

      /*  [Then(@"I should see my name with hello2")]
        public void ThenIShouldSeeMyNameWithHello2()
        {
            //Homepage home = new Homepage();
            //home.checkHelloUsername();
        }*/

    }
}
