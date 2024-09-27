using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace EGIndiaSpecFlowProject.StepDefinitions
{
    [Binding]
    public class OrangeHRMStepDefinitions
    {
        private IWebDriver _driver;

        [Given(@"User is on the orange hrm login page")]
        public void GivenUserIsOnTheOrangeHrmLoginPage()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            _driver = new FirefoxDriver();
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

        }

        [When(@"User enters ""([^""]*)"" and ""([^""]*)"" in  the text fields")]
        public void WhenUserEntersAndInTheTextFields(string usrname, string passwd)
        {
            IWebElement username = _driver.FindElement(By.XPath("//input[@name='username']"));
            username.SendKeys(usrname);
            IWebElement password = _driver.FindElement(By.XPath("//input[@name='password']"));
            password.SendKeys(passwd);
        }

        [When(@"User clicks on submit button")]
        public void WhenUserClicksOnSubmitButton()
        {
            IWebElement login = _driver.FindElement(By.XPath("//button[@type=\"submit\"]"));
            login.Click();
            Thread.Sleep(1000);
        }

        [Then(@"User is navigated home page")]
        public void ThenUserIsNavigatedHomePage()
        {
            IWebElement Admin = _driver.FindElement(By.XPath("(//a[@class = 'oxd-main-menu-item'])[1]"));
            Admin.Click();
            _driver.Close();
        }

        [When(@"User enters wrong ""([^""]*)"" and ""([^""]*)"" in  the text fields")]
        public void WhenUserEntersWrongAndInTheTextFields(string usrname, string passwd)
        {
            IWebElement username = _driver.FindElement(By.XPath("//input[@name='username']"));
            username.SendKeys(usrname);
            IWebElement password = _driver.FindElement(By.XPath("//input[@name='password']"));
            password.SendKeys(passwd);
        }

        [Then(@"User gets displayed an error message")]
        public void ThenUserGetsDisplayedAnErrorMessage()
        {

            IWebElement Errmsg = _driver.FindElement(By.XPath("//div[@class='oxd-alert-content oxd-alert-content--error']"));
            string text = Errmsg.Text;
            _driver.Close();
            Console.WriteLine(text);
        }

    }
}
