using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

public class WaitHelper
{
    private readonly IWebDriver _driver;
    private readonly TimeSpan _defaultTimeout;

    // Constructor initializing WebDriver and default timeout
    public WaitHelper(IWebDriver driver, TimeSpan defaultTimeout)
    {
        _driver = driver;
        _defaultTimeout = defaultTimeout;
    }

    public void WaitUntilVisible(By locator)
    {
        WaitUntilVisible(locator, _defaultTimeout);
    }

    public void WaitUntilClickable(By locator)
    {
        WaitUntilClickable(locator, _defaultTimeout);
    }

    public void WaitUntilVisible(By locator, TimeSpan timeout)
    {
        WebDriverWait wait = new WebDriverWait(_driver, timeout);
        wait.Until(ExpectedConditions.ElementIsVisible(locator));
    }

    public void WaitUntilClickable(By locator, TimeSpan timeout)
    {
        WebDriverWait wait = new WebDriverWait(_driver, timeout);
        wait.Until(ExpectedConditions.ElementToBeClickable(locator));
    }
}
