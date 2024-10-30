using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pageobj_pact.Finance.Accounts
{
    internal class Financelocators
    {
        // Account Page Locators
        public static class AccountPage
        {
            
            public static readonly By AddButton = By.XPath("//*[@id=\"maincontainer\"]/div/div[1]/div[2]/span[2]");
            public static readonly By AccountCodeField = By.XPath("//*[@id=\"AccountCode\"]");
            public static readonly By AccountNameField = By.XPath("//*[@id=\"AccountName\"]");
            public static readonly By SaveButton = By.XPath("//*[@id=\"revwebbody\"]/modal-container/div/div/app-model-dialog/div/div[2]/form/app-quick-account/div/div[2]/div/button[1]/i");
            public static readonly By SearchField = By.Id("undefined");
            public static readonly By CloseButton = By.CssSelector(".quickview__close");
        }
        public static class Editaccount
        {
            public static readonly By Editoption = By.XPath("//*[@id=\"maincontainer\"]/div/div[1]/div[2]/span[4]");
            public static readonly By Ed_accountcode = By.XPath("//*[@id=\"AccountCode\"]");
            public static readonly By Ed_accountname = By.XPath("//*[@id=\"AccountName\"]");

            public static readonly By Ed_savebutton = By.XPath("//*[@id=\"revwebbody\"]/modal-container/div/div/app-model-dialog/div/div[2]/form/app-quick-account/div/div[2]/div/button[1]");
            public static readonly By Ed_Closetab = By.XPath("//*[@id=\"revwebbody\"]/modal-container/div/div/app-model-dialog/div/div[1]/button/i");
        }
        public static class DeleteAccount
        {
            public static readonly By deleteoption = By.XPath("//*[@id=\"maincontainer\"]/div/div[1]/div[2]/span[5]/i");
            public static readonly By deleteit = By.XPath("//*[@id=\"revwebbody\"]/modal-container/div/div/app-model-dialog/div/div[2]/form/app-deletecostcenter/div/div[2]/div/button[1]");
            public static readonly By closeit = By.XPath("//*[@id=\"revwebbody\"]/modal-container/div/div/app-model-dialog/div/div[1]/button/i");
        }
    }
}
