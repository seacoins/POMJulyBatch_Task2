using POMJulyBatch_Task.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMJulyBatch_Task.TestModules
{
    public class SeacoinsSignUp : BasePage
    {
        HomePage SeaHomePage;
        LoginPage SeaLoginPage;
        UserSignUpPage SeaUserSignUpPage;
        ReadJsonData SeaReadJsonData;

        public SeacoinsSignUp()
        {
            SeaHomePage = new HomePage(Initializedriver());
            SeaLoginPage = new LoginPage(Initializedriver());
            SeaUserSignUpPage = new UserSignUpPage(Initializedriver());
            SeaReadJsonData = new ReadJsonData();
        }

        [Test]
        public void SeacoinsSignUpTest()
        {
            browser.Navigate().GoToUrl(SeaReadJsonData.GetData("UserInfo:url"));

            SeaHomePage.ClickSigUpLkn();
            SeaLoginPage.LoginInformation("Testerson", "Doe Testerson".AddRandomDigits3() + "abc.com");

            SeaUserSignUpPage.FillUserAccountInformation(SeaReadJsonData.GetData("UserInfo:password"), SeaReadJsonData.GetData("UserInfo:days"),
            SeaReadJsonData.GetData("UserInfo:month"), SeaReadJsonData.GetData("UserInfo:year"), SeaReadJsonData.GetData("UserInfo:firstName"),
            SeaReadJsonData.GetData("UserInfo:lastName"), SeaReadJsonData.GetData("UserInfo:company"), SeaReadJsonData.GetData("UserInfo:address"),
            SeaReadJsonData.GetData("UserInfo:address2"), SeaReadJsonData.GetData("UserInfo:country"), SeaReadJsonData.GetData("UserInfo:state"),
            SeaReadJsonData.GetData("UserInfo:city"), SeaReadJsonData.GetData("UserInfo:zipCode"), SeaReadJsonData.GetData("UserInfo:mobile"));

            SeaHomePage.ClickSigUpLkn();

            SeaHomePage.AssertUserNameText("Testerson");
        }
    }
}




