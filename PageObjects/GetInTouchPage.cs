namespace POMJulyBatch_Task.PageObjects
{
    public class GetInTouchPage : Hooks
    {
        public GetInTouchPage(IWebDriver _driver) : base(_driver)
        {
        }

        IWebElement successMessage => driver.FindElement(By.CssSelector(".status"));

        public bool IsSuccessMsgVisible() => successMessage.Displayed;
        public string IsSuccessMsgtextVisible() => successMessage.Text;
    }
}