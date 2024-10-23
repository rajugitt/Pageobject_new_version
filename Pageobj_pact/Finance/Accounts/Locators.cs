using OpenQA.Selenium;  // Ensure this using directive is added

public static class Locators
{
    // Login Page Locators
    public static class LoginPage
    {
        public static readonly By UsernameField = By.CssSelector("#txtUserName");
        public static readonly By PasswordField = By.CssSelector("#txtPassword");
        public static readonly By SubmitButton = By.CssSelector("#btnLogn");
        public static readonly By Index_of_the_org = By.CssSelector("#cList_9");
        public static readonly By Selection_submit = By.XPath("//*[@id=\"btnLogn\"]");
        public static readonly By Compact_info_btn = By.XPath("//*[@id=\"revwebbody\"]/modal-container/div/div/app-model-dialog/div/div[2]/form/app-message-dialog-view-model/div/div[2]/div/button/i");
        public static readonly By selectall_btn = By.XPath("//*[@id=\"loginId\"]/div/div[3]/div/button[2]");
    }

    // Home Page Locators
    public static class HomePage
    {
        public static readonly By FinanceMenu = By.XPath("//*[@id=\"revwebbody\"]/app-root/app-home/form/div/app-sidemenu/div/ul/li[2]/span");
        public static readonly By ChartOfAccountsMenu = By.XPath("//*[@id=\"sidebar_menu\"]/app-submenu[2]/div/div[2]/ul/li[1]/ul/li/a");
        public static readonly By AddButton = By.XPath("//*[@id=\"maincontainer\"]/div/div[1]/div[2]/span[2]");
    }

    // Account Page Locators
    public static class AccountPage
    {
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
}
