namespace POMJulyBatch_Task.PageObjects
{
    public class ContactUsPage : Hooks
    {
        CustomMethods customMethods;

        public ContactUsPage(IWebDriver _driver) : base(_driver)
        {
            customMethods = new CustomMethods();
        }

        IWebElement name => driver.FindElement(By.XPath("//input[@name='name']"));
        IWebElement email => driver.FindElement(By.XPath("//input[@name='email']"));
        IWebElement subject => driver.FindElement(By.XPath("//input[@name='subject']"));
        IWebElement message => driver.FindElement(By.CssSelector("#message"));
        IWebElement submitbtn => driver.FindElement(By.XPath("//input[@name='submit']"));

        public GetInTouchPage FillContactForm(string _name, string _email, string _subject, string _message)
        {
            name.SendKeys(_name);
            email.SendKeys(_email);
            subject.SendKeys(_subject);
            message.SendKeys(_message);
            customMethods.ScrollIntoViewAndClickViaJs(submitbtn, driver);
            driver.SwitchTo().Alert().Accept();
            return new GetInTouchPage(driver);
        }
    }
}