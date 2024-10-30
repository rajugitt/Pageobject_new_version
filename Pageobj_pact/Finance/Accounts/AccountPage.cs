using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;  // For WebDriverWait without using SeleniumExtras.WaitHelpers
using Pageobj_pact.Finance.Accounts;
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
        //_wait.Until(ExpectedConditions.ElementToBeClickable(Financelocators.AccountPage.AddButton)).Click(); 
        _wait.Until(ExpectedConditions.ElementIsVisible(Financelocators.AccountPage.AccountCodeField)).SendKeys(accountCode);
        _wait.Until(ExpectedConditions.ElementIsVisible(Financelocators.AccountPage.AccountNameField)).SendKeys(accountName);
        _wait.Until(ExpectedConditions.ElementToBeClickable(Financelocators.AccountPage.SaveButton)).Click();
        // Wait until the close button is clickable and then click it
        _wait.Until(ExpectedConditions.ElementToBeClickable(Financelocators.AccountPage.CloseButton)).Click();
    }

    // Method to search for an account by code
    public void SearchAccount(string accountCode)
    {
        _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Locators.HomePage.ChartOfAccountsMenu)).Click();
        // Wait until the search field is visible, clear it, and then send the account code
        _wait.Until(ExpectedConditions.ElementIsVisible(Financelocators.AccountPage.SearchField)).Clear();
        _wait.Until(ExpectedConditions.ElementIsVisible(Financelocators.AccountPage.SearchField)).SendKeys(accountCode);
        
        // Simulate pressing the Enter key to submit the search
        _driver.FindElement(Financelocators.AccountPage.SearchField).SendKeys(Keys.Enter);
    }
    public void EditAccount(string accountcode, string accountName)
    {
        //_wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Financelocators.Editaccount.Editoption)).Click();
        _wait.Until(ExpectedConditions.ElementIsVisible(Financelocators.Editaccount.Ed_accountname)).SendKeys(accountcode);
        _wait.Until(ExpectedConditions.ElementIsVisible(Financelocators.Editaccount.Ed_accountname)).SendKeys(accountName);
        _wait.Until(ExpectedConditions.ElementToBeClickable(Financelocators.Editaccount.Ed_savebutton)).Click();
        _wait.Until(ExpectedConditions.ElementToBeClickable(Financelocators.Editaccount.Ed_Closetab)).Click();
    }
    public void Deleteaccount()
    {
        _wait.Until(ExpectedConditions.ElementToBeClickable(Financelocators.DeleteAccount.deleteit)).Click();
        _wait.Until(ExpectedConditions.ElementToBeClickable(Financelocators.DeleteAccount.closeit)).Click();
    }
}
