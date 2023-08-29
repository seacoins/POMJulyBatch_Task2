namespace POMJulyBatch_Task.BaseHooks
{
    public class Hooks
    {
        public IWebDriver driver;
        public Hooks(IWebDriver _driver)
        {
            driver = _driver;
        }
    }
}