using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace EGIndiaSpecFlowProject.StepDefinitions
{
    [Binding]
    public class TestFeatureParaBankStepDefinitions1
    {
        private IWebDriver _driver;

        [Given(@"User is on the Login Page")]
        public void GivenUserIsOnTheLoginPage()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            _driver = new FirefoxDriver();
            _driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/register.html");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"User Clicks on Register Link")]
        public void WhenUserClicksOnRegisterLink()
        {
            IWebElement Register = _driver.FindElement(By.XPath("//a[contains(text(),'Register')]"));
            Register.Click();
        }

        [When(@"User enters ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserEntersAndAndAndAndAndAndAndAndAndAnd(string firstname, string lastname, string address, string city, string state, string zipcode, string phone, string SSN, string username, string password, string confirmpassword)
        {
            //Console.WriteLine(firstname + ".........." + lastname + "...." + address + "........" + city + ".........." + state + "......" + zipcode + "...." + phone + "...." + SSN + "...." + username + "...." + password + "...." + confirmpassword);
            IWebElement Fname = _driver.FindElement(By.XPath("//input[@id='customer.firstName']"));
            Fname.SendKeys(firstname);
            IWebElement Lname = _driver.FindElement(By.XPath("//input[@id='customer.lastName']"));
            Lname.SendKeys(lastname);
            IWebElement Add = _driver.FindElement(By.XPath("//input[@id='customer.address.street']"));
            Add.SendKeys(address);
            IWebElement City = _driver.FindElement(By.XPath("//input[@id='customer.address.city']"));
            City.SendKeys(city);
            IWebElement State = _driver.FindElement(By.XPath("//input[@id='customer.address.state']"));
            State.SendKeys(state);
            IWebElement Zipcode = _driver.FindElement(By.XPath("//input[@id='customer.address.zipCode']"));
            Zipcode.SendKeys(zipcode);
            IWebElement Phone = _driver.FindElement(By.XPath("//input[@id='customer.phoneNumber']"));
            Phone.SendKeys(phone);
            IWebElement Socialsecuritynumber = _driver.FindElement(By.XPath("//input[@id='customer.ssn']"));
            Socialsecuritynumber.SendKeys(SSN);

            IWebElement Username = _driver.FindElement(By.XPath("//input[@id='customer.username']"));
            Username.SendKeys(username);
            IWebElement Pwd = _driver.FindElement(By.XPath("//input[@id='customer.password']"));
            Pwd.SendKeys(password);
            IWebElement Confirmpwd = _driver.FindElement(By.XPath("//input[@id='repeatedPassword']"));
            Confirmpwd.SendKeys(confirmpassword);
        }

        [When(@"clicks on Register button")]
        public void WhenClicksOnRegisterButton()
        {
            IWebElement RegisterButton = _driver.FindElement(By.XPath("//input[@value='Register']"));
            RegisterButton.Click();
        }

        [Then(@"User is navigated to a page which displays Account created succesful")]
        public void ThenUserIsNavigatedToAPageWhichDisplaysAccountCreatedSuccesful()
        {

            IWebElement Success = _driver.FindElement(By.XPath("//p[contains(text(),'Your account was created successfully. You are now')]"));
            string successtext = Success.Text;
            _driver.Close();
        }



        [When(@"User enters ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserEntersAnd(string username, string password)
        {

            IWebElement Username = _driver.FindElement(By.XPath("//input[@name='username']"));
            Username.SendKeys(username);

            IWebElement Password = _driver.FindElement(By.XPath("//input[@name='password']"));
            Password.SendKeys(password);

            // IWebElement RegisterLink = _driver.FindElement(By.XPath("//input[@name='password']"));
            // RegisterLink.SendKeys(passwd);
        }

        [Then(@"User displayed with an error message saying Invalid")]
        public void ThenUserDisplayedWithAnErrorMessageSayingInvalid()
        {
            IWebElement Errmsg = _driver.FindElement(By.XPath("//p[@class='error']"));
            string errtxt = Errmsg.Text;
            _driver.Close();
        }
    }
}
