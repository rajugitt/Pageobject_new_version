using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;  // For WebDriverWait without using SeleniumExtras.WaitHelpers
using SeleniumExtras.WaitHelpers;
using System;

public class AccountPage
{
    private IWebDriver _driver;
    private WebDriverWait _wait;

    // Constructor initializing WebDriverWait with passed wait time
    public AccountPage(IWebDriver driver, WebDriverWait wait)
    {
        _driver = driver;
        _wait = wait;
    }

    // Method to create a new account
    public void CreateAccount(string accountCode, string accountName)
    {
        // Send keys to the account code and name fields
        _driver.FindElement(Locators.AccountPage.AccountCodeField).SendKeys(accountCode);
        _driver.FindElement(Locators.AccountPage.AccountNameField).SendKeys(accountName);
        _driver.FindElement(Locators.AccountPage.SaveButton).Click();

        // Wait until the close button is clickable and then click it
        _wait.Until(ExpectedConditions.ElementToBeClickable(Locators.AccountPage.CloseButton)).Click();
    }

    // Method to search for an account by code
    public void SearchAccount(string accountCode)
    {
        // Wait until the search field is visible, clear it, and then send the account code
        _wait.Until(ExpectedConditions.ElementIsVisible(Locators.AccountPage.SearchField)).Clear();
        _driver.FindElement(Locators.AccountPage.SearchField).SendKeys(accountCode);

        // Simulate pressing the Enter key to submit the search
        _driver.FindElement(Locators.AccountPage.SearchField).SendKeys(Keys.Enter);
    }
    public void EditAccount(string accountcode, string accountName)
    {
        _wait.Until(ExpectedConditions.ElementIsVisible(Locators.Editaccount.Editoption)).Click();
        _wait.Until(ExpectedConditions.ElementIsVisible(Locators.Editaccount.Ed_accountcode)).SendKeys(accountcode);
        _wait.Until(ExpectedConditions.ElementIsVisible(Locators.Editaccount.Ed_accountname)).SendKeys(accountName);
        _driver.FindElement(Locators.Editaccount.Ed_savebutton).Click();
        _wait.Until(ExpectedConditions.ElementIsVisible(Locators.Editaccount.Ed_Closetab)).Click();
    }
}
