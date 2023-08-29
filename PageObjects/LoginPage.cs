namespace POMJulyBatch_Task.PageObjects
{
    public class LoginPage : Hooks
    {
        public LoginPage(IWebDriver _driver) : base(_driver)
        {
        }

        IWebElement signUpName => driver.FindElement(By.XPath("//input[@name='name']"));
        IWebElement signUpEmail => driver.FindElement(By.XPath("//input[@data-qa='signup-email']"));
        IWebElement submitButton => driver.FindElement(By.CssSelector("button[data-qa='signup-button']"));
        
        public void LoginInformation(string _name, string _email)
        {
            signUpName.SendKeys(_name);
            signUpEmail.SendKeys(_email);
            submitButton.Click();
        }
    }
}