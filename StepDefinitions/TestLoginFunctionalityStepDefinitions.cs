using TechTalk.SpecFlow;

namespace EGIndiaSpecFlowProject.StepDefinitions
{
    [Binding]
    public class TestLoginFunctionalityStepDefinitions
    {
        [Given(@"User is on login page")]
        public void GivenUserIsOnLoginPage()
        {
            Console.WriteLine("Test user is on the login Page");
        }

        [When(@"User enters the username and password")]
        public void WhenUserEntersTheUsernameAndPassword()
        {
            Console.WriteLine("Test user enters the username and password");
        }

        [When(@"User Clicks on login button")]
        public void WhenUserClicksOnLoginButton()
        {
            Console.WriteLine("Test user clicks on Login button");
        }

        [Then(@"User is navigated to home page")]
        public void ThenUserIsNavigatedToHomePage()
        {
            Console.WriteLine("Test user is navigated to Home Page");
        }
    }
}
