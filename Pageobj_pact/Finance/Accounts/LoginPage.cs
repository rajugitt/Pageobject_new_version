using Microsoft.Office.Interop.Excel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Threading;
using ExcelApp = Microsoft.Office.Interop.Excel.Application;
using System.Runtime.InteropServices;
public class LoginPage
{
    private IWebDriver _driver;
    private WebDriverWait _wait;

    public LoginPage(IWebDriver driver, WebDriverWait wait)
    {
        _driver = driver;
        _wait = wait;
    }

    public void Login(string username, string password)
    {
        _wait.Until(ExpectedConditions.ElementIsVisible(Locators.LoginPage.UsernameField)).SendKeys(username);
        _wait.Until(ExpectedConditions.ElementIsVisible(Locators.LoginPage.PasswordField)).SendKeys(password);
        Thread.Sleep(5000);
        _wait.Until(ExpectedConditions.ElementIsVisible(Locators.LoginPage.SubmitButton)).Click();
 

        _driver.FindElement(Locators.LoginPage.Index_of_the_org).Click();
        _driver.FindElement(Locators.LoginPage.Selection_submit).Click();
        _driver.FindElement(Locators.LoginPage.Compact_info_btn).Click();
        _driver.FindElement(Locators.LoginPage.selectall_btn).Click();
        Thread.Sleep(5000);
    }
}
