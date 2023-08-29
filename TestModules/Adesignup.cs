namespace POMJulyBatch_Task.TestModules
{
    public class Adesignup : BasePage
    {
        HomePage vicHomePg;
        LoginPage lPage;
        UserSignUpPage userSignUpPage;
        ReadJsonData jsonData;
        public Adesignup()
        {
            vicHomePg = new HomePage(Initializedriver());
            lPage = new LoginPage(Initializedriver());
            userSignUpPage = new UserSignUpPage(Initializedriver());
            jsonData = new ReadJsonData();
        }

        [Test]
        public void AdeSignupTest()
        {
            browser.Navigate().GoToUrl(jsonData.GetData("UserInfo:url"));

            vicHomePg.ClickSigUpLkn();

            lPage.LoginInformation("Vanessa".AddRandomDigits(), UtilExtension.AddRandomDigits2("ade@", ".com"));

            userSignUpPage.FillUserAccountInformation(jsonData.GetData("UserInfo:password"), jsonData.GetData("UserInfo:days"),
                jsonData.GetData("UserInfo:month"), jsonData.GetData("UserInfo:year"), jsonData.GetData("UserInfo:firstName"),
                jsonData.GetData("UserInfo:lastName"), jsonData.GetData("UserInfo:company"), jsonData.GetData("UserInfo:address"),
                jsonData.GetData("UserInfo:address2"), jsonData.GetData("UserInfo:country"), jsonData.GetData("UserInfo:state"),
                jsonData.GetData("UserInfo:city"), jsonData.GetData("UserInfo:zipCode"), jsonData.GetData("UserInfo:mobile"));
        }
    }
}