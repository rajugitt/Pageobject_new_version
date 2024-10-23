using OpenQA.Selenium;
using System.Threading;

public class LoginPage
{
    private IWebDriver _driver;

    public LoginPage(IWebDriver driver)
    {
        _driver = driver;
    }

    public void Login(string username, string password)
    {
        _driver.FindElement(Locators.LoginPage.UsernameField).SendKeys(username);
        _driver.FindElement(Locators.LoginPage.PasswordField).SendKeys(password);
        _driver.FindElement(Locators.LoginPage.SubmitButton).Click();
        _driver.FindElement(Locators.LoginPage.Index_of_the_org).Click();
        _driver.FindElement(Locators.LoginPage.Selection_submit).Click();
        _driver.FindElement(Locators.LoginPage.Compact_info_btn).Click();
        _driver.FindElement(Locators.LoginPage.selectall_btn).Click();
        Thread.Sleep(5000);
    }
}
