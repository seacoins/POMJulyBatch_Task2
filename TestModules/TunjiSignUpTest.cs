namespace POMJulyBatch_Task.TestModules
{
    public class TunjiSignUpTest : BasePage
    {
        HomePage _homePage;
        ContactUsPage _contactUsPage;
        GetInTouchPage _getInTouchPage;
        LoginPage _loginPage;
        UserSignUpPage _userSignUpPage;
        ReadJsonData jsonData;
       public TunjiSignUpTest()
       {
          _homePage = new HomePage(Initializedriver());
          _contactUsPage = new ContactUsPage(Initializedriver());
          _getInTouchPage = new GetInTouchPage(Initializedriver());
          _loginPage = new LoginPage(Initializedriver());
          _userSignUpPage = new UserSignUpPage(Initializedriver());
          jsonData = new ReadJsonData();
       }

       [Test, Ignore("true")]
       public void TunjiPOMTask()
       {
            browser.Navigate().GoToUrl(jsonData.GetData("UserInfo:url"));

            _homePage.ClickContactUs();

            _contactUsPage.FillContactForm("Tunji", "OlaTunji@123.com", "Photography basics", "My message sent");
             Assert.True(_getInTouchPage.IsSuccessMsgVisible());
       }

       [Test]
       public void TunjiSignUpForm()
       {
            browser.Navigate().GoToUrl(jsonData.GetData("UserInfo:url2"));

            _loginPage.LoginInformation("OlaTunji".AddRandomDigits(), UtilExtension.AddRandomDigits2("OlaTunji@", ".com"));

            _userSignUpPage.FillUserAccountInformation(jsonData.GetData("UserInfo:password"), jsonData.GetData("UserInfo:days"),
               jsonData.GetData("UserInfo:month"), jsonData.GetData("UserInfo:year"), jsonData.GetData("UserInfo:firstName"),
               jsonData.GetData("UserInfo:lastName"), jsonData.GetData("UserInfo:company"), jsonData.GetData("UserInfo:address"),
               jsonData.GetData("UserInfo:address2"), jsonData.GetData("UserInfo:country"), jsonData.GetData("UserInfo:state"),
               jsonData.GetData("UserInfo:city"), jsonData.GetData("UserInfo:zipCode"), jsonData.GetData("UserInfo:mobile"));
        }
    }
}
