using Microsoft.Office.Interop.Excel;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System.Runtime.InteropServices;
using System;
using ExcelApp = Microsoft.Office.Interop.Excel.Application;
using System.Threading;

public class ChartAccountsTest
{
    static Random random = new Random();
    static string Newaccount = null;
    static string lastedited = null;

    static IWebDriver driver = null;
    static ExcelApp excelApp = null;
    static Workbook workbook = null;
    static Worksheet worksheet = null;

    // Initialize Excel and WebDriver
    public static void InitializeExcelAndWebDriver()
    {
        excelApp = new ExcelApp();
        excelApp.Visible = false;
        string excelFilePath = @"C:\Users\Administrator\Desktop\cred2.xlsx";
        workbook = excelApp.Workbooks.Open(excelFilePath);
        worksheet = (Worksheet)workbook.Sheets[1];

        driver = new ChromeDriver();
    }

    // Perform login
    public static void PerformLogin()
    {
        string url = worksheet.Cells[2, 1].Text;
        string username = worksheet.Cells[2, 4].Text;
        string password = worksheet.Cells[2, 5].Text;

        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(200)); // Create the wait instance
        LoginPage loginPage = new LoginPage(driver, wait); // Pass the wait instance to the LoginPage constructor

        driver.Navigate().GoToUrl(url);
        Thread.Sleep(5000); // Consider replacing this with a wait for a specific element

        loginPage.Login(username, password);
    }

    // Navigate to Chart of Accounts and create an account
    public static void NavigateToChartOfAccountsAndCreateAccount()
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(200));
        Thread.Sleep(5000);
        HomePage homePage = new HomePage(driver, wait);
        homePage.GoToChartOfAccountsPage();
        homePage.ClickAddButton();

        string randomAccountCode = GenerateRandomAccountCode();
        string randomAccountName = GenerateRandomAccountName();
        AccountPage accountPage = new AccountPage(driver, wait);
        accountPage.CreateAccount(randomAccountCode, randomAccountName);
        Thread.Sleep(5000);
        Newaccount = randomAccountCode;
 // Save the last edited account for future operations
    }

    // Search for an account
    public static void SearchForAccount()
    {
        AccountPage accountPage = new AccountPage(driver, new WebDriverWait(driver, TimeSpan.FromSeconds(200)));
        Thread.Sleep(5000);
        accountPage.SearchAccount(Newaccount);
    }
    public static void editaccount()
    {

        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(200));
        HomePage editacc = new HomePage(driver, wait);
        editacc.Clickeditbutton();
        Thread.Sleep(5000);
        string randomAccountCode = GenerateRandomAccountCode();
        string randomAccountName = GenerateRandomAccountName();
        AccountPage editaccount = new AccountPage(driver, wait);
        editaccount.EditAccount(randomAccountCode, randomAccountName);
        Thread.Sleep(5000);
        lastedited = randomAccountCode;

    }
    // Save changes to Excel
    public static void SaveChangesToExcel()
    {
        workbook.Save();
    }

    // Cleanup
    public static void Cleanup()
    {
        if (worksheet != null) Marshal.ReleaseComObject(worksheet);
        if (workbook != null)
        {
            workbook.Close(false);
            Marshal.ReleaseComObject(workbook);
        }
        if (excelApp != null)
        {
            excelApp.Quit();
            Marshal.ReleaseComObject(excelApp);
        }
        driver?.Quit();
    }

    // Random data generation methods
    public static string GenerateRandomAccountCode() => "AC" + random.Next(1000, 9999);
    public static string GenerateRandomAccountName() => "Account_" + random.Next(1, 1000);
}
