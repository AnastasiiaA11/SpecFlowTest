namespace SpecFlowTest.StepDefinitions
{
    [Binding]
    public class AuthStepDefinitions
    {
        private IWebDriver _driver;

        [Given(@"Open site http://u920152e.beget.tech/#")]
        public void GivenGiven()
        {
            var driver = SingleWebDriver.GetInstance();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(Urls.Host);
        }

        [Given(@"Enter email ""([^""]*)""")]
        public void GivenEnterEmail(string email)
        {
            Thread.Sleep(5);
            var textBoxEmail=_driver.FindElement(By.XPath($"//*[@type='email']"));
            textBoxEmail.SendKeys(email);
        }

        [When(@"Enter password ""([^""]*)""")]
        public void WhenEnterPassword(string password)
        {
            Thread.Sleep(5);
            var textBoxPassword = _driver.FindElement(By.XPath($"//*[@type='password']"));
            textBoxPassword.SendKeys(password);
        }

        [Then(@"Click button Enter")]
        public void ThenWhenClickButtonEnter()
        {
            var buttonClick= _driver.FindElement(By.XPath("//*[@class='form_auth_button']"));
            buttonClick.Click();
        }
    }
}
