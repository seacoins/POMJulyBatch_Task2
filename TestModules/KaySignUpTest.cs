namespace POMJulyBatch_Task.TestModules
{
    public class KaySignUpTest : BasePage
    {
        HomePage homePg;
        LoginPage lPage;
        UserSignUpPage userSignUpPage;
        ReadJsonData jsonData;
        string userName, email;
        public KaySignUpTest()
        {
            homePg = new HomePage(Initializedriver());
            lPage = new LoginPage(Initializedriver());
            userSignUpPage = new UserSignUpPage(Initializedriver());
            jsonData = new ReadJsonData();
        }

        [Test]
        public void KaySignUp_Test()
        {
            browser.Navigate().GoToUrl(jsonData.GetData("UserInfo:url"));

            homePg.ClickSigUpLkn();

            userName = "QaUser".AddRandomDigits();
            email = "abc".AddRandomDigits3();
            lPage.LoginInformation(userName, email);

            userSignUpPage.FillUserAccountInformation(jsonData.GetData("UserInfo:password"), jsonData.GetData("UserInfo:days"),
                jsonData.GetData("UserInfo:month"), jsonData.GetData("UserInfo:year"), jsonData.GetData("UserInfo:firstName"),
                jsonData.GetData("UserInfo:lastName"), jsonData.GetData("UserInfo:company"), jsonData.GetData("UserInfo:address"),
                jsonData.GetData("UserInfo:address2"), jsonData.GetData("UserInfo:country"), jsonData.GetData("UserInfo:state"),
                jsonData.GetData("UserInfo:city"), jsonData.GetData("UserInfo:zipCode"), jsonData.GetData("UserInfo:mobile"));

            homePg.ClickSigUpLkn();

            Assert.That(userName, Is.Not.Empty);
        }
    }
}