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
      }
}
