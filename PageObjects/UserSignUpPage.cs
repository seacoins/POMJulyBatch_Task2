namespace POMJulyBatch_Task.PageObjects
{
    public class UserSignUpPage : Hooks
    {
        CustomMethods customMethods;

        public UserSignUpPage(IWebDriver _driver) : base(_driver)
        {
            customMethods = new CustomMethods();
        }

        private IWebElement Mr => driver.FindElement(By.Id("id_gender1"));
        private IWebElement Password => driver.FindElement(By.CssSelector("#password"));
        private IWebElement Days => driver.FindElement(By.Id("days"));
        private IWebElement Months => driver.FindElement(By.CssSelector("#months"));
        private IWebElement Year => driver.FindElement(By.CssSelector("#years"));
        private IWebElement FirstName => driver.FindElement(By.XPath("//input[@id='first_name']"));
        private IWebElement LastName => driver.FindElement(By.XPath("//input[@id='last_name']"));
        private IWebElement Company => driver.FindElement(By.CssSelector("#company"));
        private IWebElement Address => driver.FindElement(By.CssSelector("#address1"));
        private IWebElement Address2 => driver.FindElement(By.CssSelector("#address2"));
        private IWebElement Country => driver.FindElement(By.Id("country"));
        private IWebElement State => driver.FindElement(By.CssSelector("#state"));
        private IWebElement City => driver.FindElement(By.XPath("//input[@id='city']"));
        private IWebElement ZipCode => driver.FindElement(By.XPath("//input[@id='zipcode']"));
        private IWebElement Mobile => driver.FindElement(By.XPath("//input[@id='mobile_number']"));
        private IWebElement CreateAccount => driver.FindElement(By.XPath("(//button[@type='submit'])[1]"));


        public void FillUserAccountInformation(string _password, string _days, string month, string year, string _firstName,
           string _lastName, string _company, string _address, string _address2, string _country, string _state,
           string _city, string _zipCode, string _mobile)
        {
            Mr.Click();
            Password.SendKeys(_password);
            customMethods.SelectFromDropDownByText(Days, _days);
            customMethods.SelectFromDropDownByText(Months, month);
            customMethods.SelectFromDropDownByText(Year, year);
            FirstName.SendKeys(_firstName);
            LastName.SendKeys(_lastName);
            Company.SendKeys(_company);
            Address.SendKeys(_address);
            Address2.SendKeys(_address2);
            customMethods.SelectFromDropDownByText(Country, _country);
            State.SendKeys(_state);
            City.SendKeys(_city);
            ZipCode.SendKeys(_zipCode);
            Mobile.SendKeys(_mobile);
            customMethods.ScrollIntoViewViaJs(driver,0, 250);
            CreateAccount.Click();
            CreateAccount.ScrollIntoViewAndClickViaJs(driver);
        }
    }
}