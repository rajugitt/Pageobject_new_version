using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Pageobj_pact.Finance.Accounts;
using System.Threading;

public class HomePage
{
    private IWebDriver _driver;
    private WebDriverWait _wait;

    public HomePage(IWebDriver driver, WebDriverWait wait)
    {
        _driver = driver;
        _wait = wait;
    }

    public void GoToChartOfAccountsPage()
    {
       
        _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Locators.HomePage.FinanceMenu)).Click();

        _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Locators.HomePage.ChartOfAccountsMenu)).Click();
    }

    public void ClickAddButton()
    {
       
        _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Financelocators.AccountPage.AddButton)).Click();
    }
    public void Clickeditbutton()
    {
        _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Financelocators.Editaccount.Editoption)).Click();
    }
    public void Clickdeletebutton()
    {
        _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Financelocators.DeleteAccount.deleteoption)).Click();
    }
}
