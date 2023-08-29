namespace POMJulyBatch_Task.TestModules
{
    public class MarthaSignUp : BasePage
    {
        HomePage mHomePage;
        LoginPage mLoginPage;
        UserSignUpPage mUserSignUpPage;
        ReadJsonData mReadJsonData;

        public MarthaSignUp()
        {
            mHomePage = new HomePage(Initializedriver());
            mLoginPage = new LoginPage(Initializedriver());
            mUserSignUpPage = new UserSignUpPage(Initializedriver());
            mReadJsonData = new ReadJsonData();
        }

        [Test]
        public void MarthaSignUpTest()
        {
            browser.Navigate().GoToUrl(mReadJsonData.GetData("UserInfo:url"));

            mHomePage.ClickSigUpLkn();
            mLoginPage.LoginInformation("MartTester", "marttester".AddRandomDigits3() + "abc.com");

            mUserSignUpPage.FillUserAccountInformation(mReadJsonData.GetData("UserInfo:password"), mReadJsonData.GetData("UserInfo:days"),
            mReadJsonData.GetData("UserInfo:month"), mReadJsonData.GetData("UserInfo:year"), mReadJsonData.GetData("UserInfo:firstName"),
            mReadJsonData.GetData("UserInfo:lastName"), mReadJsonData.GetData("UserInfo:company"), mReadJsonData.GetData("UserInfo:address"),
            mReadJsonData.GetData("UserInfo:address2"), mReadJsonData.GetData("UserInfo:country"), mReadJsonData.GetData("UserInfo:state"),
            mReadJsonData.GetData("UserInfo:city"), mReadJsonData.GetData("UserInfo:zipCode"), mReadJsonData.GetData("UserInfo:mobile"));

            mHomePage.ClickSigUpLkn();

            mHomePage.AssertUserNameText("MartTester");
        }
    }
}
