namespace POMJulyBatch_Task.PageObjects
{
    public class HomePage : Hooks
    {
        CustomMethods CustomMethods;
        public HomePage(IWebDriver _driver) : base(_driver)
        {
            CustomMethods = new CustomMethods();
        }

        IWebElement contactUs => driver.FindElement(By.LinkText("Contact us"));
        IWebElement signupLkn => driver.FindElement(By.LinkText("Signup / Login"));
        IWebElement userNameDisplayText => driver.FindElement(By.XPath("//b"));


        public ContactUsPage ClickContactUs()
        {
            contactUs.Click();
            return new ContactUsPage(driver);
        }

        public void ClickSigUpLkn() => signupLkn.Click();

        public void AssertUserNameText(string text)
        {
            CustomMethods.WaitForElementTextBy(driver, By.XPath("//b"), text);
            string isUserNameDisplayed = userNameDisplayText.Text;
            Assert.True(isUserNameDisplayed.Contains($"{text}"));
        }
    }
}