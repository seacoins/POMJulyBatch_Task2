namespace POMJulyBatch_Task.TestModules
{
    public class VictorsTest : BasePage
    {
        HomePage vicHomePg;
        ContactUsPage contactUsPg;
        GetInTouchPage getInTouchPage;
        LoginPage lPage;
        UserSignUpPage userSignUpPage;
        ReadJsonData jsonData;
        public VictorsTest()
        {
            vicHomePg = new HomePage(Initializedriver());
            contactUsPg = new ContactUsPage(Initializedriver());
            getInTouchPage = new GetInTouchPage(Initializedriver()); 
            lPage = new LoginPage(Initializedriver());
            userSignUpPage = new UserSignUpPage(Initializedriver());  
            jsonData = new ReadJsonData();
        }

        [Test, Ignore("true")]
        public void POMGroupAssignment()
        {
            browser.Navigate().GoToUrl(jsonData.GetData("UserInfo:url"));    
            
            vicHomePg.ClickContactUs();

            contactUsPg.FillContactForm("Brabdy","brandy@123.com","Photography basics","My message sent");
            Assert.True(getInTouchPage.IsSuccessMsgVisible());
        }

        [Test]
        public void AutomationExerciseTest()
        {
            browser.Navigate().GoToUrl(jsonData.GetData("UserInfo:url2"));
            lPage.LoginInformation("Brain".AddRandomDigits(), UtilExtension.AddRandomDigits2("Brain@", ".com"));
            userSignUpPage.FillUserAccountInformation(jsonData.GetData("UserInfo:password"), jsonData.GetData("UserInfo:days"), 
            jsonData.GetData("UserInfo:month"),jsonData.GetData("UserInfo:year"), jsonData.GetData("UserInfo:firstName"), 
            jsonData.GetData("UserInfo:lastName"),jsonData.GetData("UserInfo:company"), jsonData.GetData("UserInfo:address"), 
            jsonData.GetData("UserInfo:address2"), jsonData.GetData("UserInfo:country"),jsonData.GetData("UserInfo:state"), 
            jsonData.GetData("UserInfo:city"), jsonData.GetData("UserInfo:zipCode"), jsonData.GetData("UserInfo:mobile"));
        }
    }
}